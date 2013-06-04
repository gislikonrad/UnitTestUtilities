using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities
{
	/// <summary>
	/// Assert anonymous objects
	/// </summary>
	public static class AssertAnonymous
	{
		/// <summary>
		/// Asserts that all the properties in the expected object are in the actual object and have the same values
		/// </summary>
		/// <param name="expected">An anonymous object</param>
		/// <param name="actual">An anonymous object</param>
		public static void ContainsAll(object expected, object actual)
		{
			ContainsAll(expected.ToDictionary(), actual);
		}

		/// <summary>
		/// Asserts that all the KeyValuePairs in the dictionary have a property in 'actual' corresponding to the pair's key with a value corresponding to the pair's value
		/// </summary>
		/// <param name="expected">A dictionary of string and object where the keys are the property names and the values are the property values</param>
		/// <param name="actual">An anonymous object</param>
		public static void ContainsAll(IDictionary<string, object> expected, object actual)
		{
			ContainsAll(expected, actual.ToDictionary());
		}

		private static void ContainsAll(IDictionary<string, object> expected, IDictionary<string, object> actual)
		{
			foreach (var pair in expected)
			{
				if (!actual.ContainsKey(pair.Key))
					Assert.Fail("Expected a property called {0} but found none.", pair.Key);
				Assert.AreEqual(pair.Value, actual[pair.Key]);
			}
		}
	}

	internal static class ObjectExtensions
	{
		internal static IDictionary<string, object> ToDictionary(this object obj)
		{
			if (obj == null) return new Dictionary<string, object>();
			return obj
				.GetType()
				.GetProperties()
				.ToDictionary(p => p.Name, p => p.GetValue(obj, null));
		}
	}
}
