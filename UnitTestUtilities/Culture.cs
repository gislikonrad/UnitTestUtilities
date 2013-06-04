using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities
{
	/// <summary>
	/// Change the culture on the thread temporarily
	/// </summary>
    public class Culture : IDisposable
    {
		private CultureInfo _previousCulture = null;
		private CultureInfo _previousUiCulture = null;

		/// <summary>
		/// Switch to the culture corresponding to the ietf language tag until this object is disposed
		/// </summary>
		/// <param name="ietfLanguageTag">An identifier in the form of xx-XX where 'xx' is the language identifier and 'XX' is the country identifier</param>
		/// <param name="placement">Specify whether to change the CurrentCulture, the CurrentUiCulture, or both. Default is both</param>
		/// <returns>Culture disposable object</returns>
		public static IDisposable SwitchTo(string ietfLanguageTag, CulturePlacement placement = CulturePlacement.Both)
		{
			try
			{
				var culture = CultureInfo.GetCultureInfoByIetfLanguageTag(ietfLanguageTag);
				return SwitchTo(culture, placement);
			}
			catch (CultureNotFoundException)
			{
				Assert.Fail("Culture {0} is not a known culture");
				return null; // will never be hit
			}
		}

		/// <summary>
		/// Switch to the culture corresponding to the ietf language tag until this object is disposed
		/// </summary>
		/// <param name="culture">A CultureInfo object</param>
		/// <param name="placement">Specify whether to change the CurrentCulture, the CurrentUiCulture, or both. Default is both</param>
		/// <returns>Culture disposable object</returns>
		public static IDisposable SwitchTo(CultureInfo culture, CulturePlacement placement = CulturePlacement.Both)
		{
			return new Culture(culture, placement);
		}

		private Culture(CultureInfo culture, CulturePlacement placement)
		{
			if (placement.HasFlag(CulturePlacement.ThreadCulture))
			{
				_previousCulture = Thread.CurrentThread.CurrentCulture;
				Thread.CurrentThread.CurrentCulture = culture;
			} 
			if (placement.HasFlag(CulturePlacement.ThreadUiCulture))
			{
				_previousUiCulture = Thread.CurrentThread.CurrentUICulture;
				Thread.CurrentThread.CurrentUICulture = culture;
			}
		}

		/// <summary>
		/// IDisposable.Dispose()
		/// </summary>
		public void Dispose()
		{
			if (_previousCulture != null)
				Thread.CurrentThread.CurrentCulture = _previousCulture;
			if (_previousUiCulture != null)
				Thread.CurrentThread.CurrentUICulture = _previousUiCulture;
		}
	}

	[Flags]
	public enum CulturePlacement
	{
		ThreadCulture = 1,
		ThreadUiCulture = 2,
		Both = 3
	}
}
