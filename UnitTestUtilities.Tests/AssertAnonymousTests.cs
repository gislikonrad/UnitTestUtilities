using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities.Tests
{
	[TestClass]
	public class AssertAnonymousTests
	{
		[TestMethod]
		public void ShouldPass()
		{
			var expected = new { Id = 0, Name = "Name" };
			var actual = new { Id = 0, Name = "Name", Value = "some value" };
			AssertAnonymous.ContainsAll(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldFailBecauseOfMissingProperty()
		{
			var expected = new { Id = 0, Name = "Name", Value = "some value" };
			var actual = new { Id = 0, Name = "Name" };
			AssertAnonymous.ContainsAll(expected, actual);
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldFailBecauseOfPropertyValue()
		{
			var expected = new { Id = 0 };
			var actual = new { Id = 1 };
			AssertAnonymous.ContainsAll(expected, actual);
		}
	}
}
