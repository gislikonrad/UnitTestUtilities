using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

namespace UnitTestUtilities
{
	public static class HttpContextMockFactory
	{
		public static HttpContextMock Create()
		{
			var mock = new HttpContextMock();
			Initialize(mock);
			return mock;
		}

		private static void Initialize(HttpContextMock mock)
		{
			mock.ResponseMock.Setup(r => r.Redirect(It.IsAny<string>())).Throws<RedirectException>();
		}
	}
}
