using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities.Tests
{
	[TestClass]
	public class CultureTests
	{
		private static readonly string _notTheCurrentCulture = "pl-PL";

		[TestMethod]
		public void ShouldSwitchCulture()
		{
			var culture = _notTheCurrentCulture;

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);

			using (Culture.SwitchTo(culture))
			{
				Assert.AreEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
				Assert.AreEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
			}

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
		}

		[TestMethod]
		public void ShouldSwitchThreadCultureOnly()
		{
			var culture = _notTheCurrentCulture;

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);

			using (Culture.SwitchTo(culture, CulturePlacement.ThreadCulture))
			{
				Assert.AreEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
				Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
			}

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
		}

		[TestMethod]
		public void ShouldSwitchThreadUiCultureOnly()
		{
			var culture = _notTheCurrentCulture;

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);

			using (Culture.SwitchTo(culture, CulturePlacement.ThreadUiCulture))
			{
				Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
				Assert.AreEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
			}

			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentCulture.IetfLanguageTag);
			Assert.AreNotEqual(culture, Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldAssertFailOnUnavailableCulture()
		{
			var culture = "xx-XX";

			Culture.SwitchTo(culture);
		}
	}
}
