using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace UnitTestUtilities
{
	public class HttpContextMock
	{
		internal HttpContextMock()
		{
			RequestMock = new Mock<HttpRequestBase>();
			ResponseMock = new Mock<HttpResponseBase>();
			SessionMock = new Mock<HttpSessionStateBase>();
			ApplicationMock = new Mock<HttpApplicationStateBase>();
			ServerMock = new Mock<HttpServerUtilityBase>();

			ContextMock = new Mock<HttpContextBase>();
			ContextMock.SetupGet(c => c.Request).Returns(() => RequestObject);
			ContextMock.SetupGet(c => c.Response).Returns(() => ResponseObject);
			ContextMock.SetupGet(c => c.Request).Returns(() => RequestObject);
			ContextMock.SetupGet(c => c.Application).Returns(() => ApplicationObject);
			ContextMock.SetupGet(c => c.Server).Returns(() => ServerObject);
		}

		public Mock<HttpRequestBase> RequestMock { get; private set; }
		public HttpRequestBase RequestObject { get { return RequestMock.Object; } }

		public Mock<HttpResponseBase> ResponseMock { get; private set; }
		public HttpResponseBase ResponseObject { get { return ResponseMock.Object; } }

		public Mock<HttpSessionStateBase> SessionMock { get; private set; }
		public HttpSessionStateBase SessionObject { get { return SessionMock.Object; } }

		public Mock<HttpApplicationStateBase> ApplicationMock { get; private set; }
		public HttpApplicationStateBase ApplicationObject { get { return ApplicationMock.Object; } }

		public Mock<HttpServerUtilityBase> ServerMock { get; private set; }
		public HttpServerUtilityBase ServerObject { get { return ServerMock.Object; } }

		public Mock<HttpContextBase> ContextMock { get; private set; }
		public HttpContextBase ContextObject { get { return ContextMock.Object; } }
	}
}
