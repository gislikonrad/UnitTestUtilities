using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities
{
	public static class AssertAction
	{
		public static void Throws<TException>(Action action)
			where TException : Exception
		{
			Throws<TException>(action, e => true);
		}

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
