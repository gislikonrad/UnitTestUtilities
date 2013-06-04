using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities
{
	/// <summary>
	/// Assert an action
	/// </summary>
	public static class AssertAction
	{
		/// <summary>
		/// Assert that an action throws a certain type of exception
		/// </summary>
		/// <typeparam name="TException">The base type of exception wanted</typeparam>
		/// <param name="action">The action to perform</param>
		public static void Throws<TException>(Action action)
			where TException : Exception
		{
			Throws<TException>(action, e => true);
		}

		/// <summary>
		/// Assert that an action throws a certain type of exception and that it is predicated to a condition
		/// </summary>
		/// <typeparam name="TException">The base type of the exception wanted</typeparam>
		/// <param name="action">The action to perform</param>
		/// <param name="predicate">The condition the exception has to pass</param>
		public static void Throws<TException>(Action action, Predicate<TException> predicate)
			where TException : Exception
		{
			var type = typeof(TException);
			try
			{
				action();
			}
			catch(TException ex)
			{
				Assert.IsTrue(predicate(ex), string.Format("Predicate failed for {0}", type.FullName));
				return;
			}
			catch (Exception ex)
			{
				var thrownType = ex.GetType();
				//Assert.IsTrue(type.IsAssignableFrom(
				Assert.Fail("Expected exception of type {0}, but an exception of type {1} was thrown instead.", type.FullName, thrownType.FullName);
				return;
			}

			Assert.Fail("Expected exception of type {0}, but none was thrown.", type.FullName);
		}
	}
}
