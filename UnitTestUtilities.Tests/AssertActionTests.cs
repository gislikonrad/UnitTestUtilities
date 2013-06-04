using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUtilities.Tests
{
	[TestClass]
	public class AssertActionTests
	{
		[TestMethod]
		public void ShouldPass()
		{
			AssertAction.Throws<Exception>(() => { throw new Exception(); });
		}

		[TestMethod]
		public void ShouldPassWithPredicate()
		{
			var message = "message";
			AssertAction.Throws<Exception>(() => { throw new Exception(message); }, e => e.Message == message);
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldFail()
		{
			AssertAction.Throws<ArgumentException>(() => { throw new Exception(); });
		}

		[TestMethod]
		[ExpectedException(typeof(AssertFailedException))]
		public void ShouldFailByPredicate()
		{
			AssertAction.Throws<Exception>(() => { throw new Exception(); }, e => e.InnerException != null);
		}
	}
}
