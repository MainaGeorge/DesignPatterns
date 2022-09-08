using DesignPatterns.ChainOfResponsibility;

namespace DesignPatterns.Tests
{
    public class ChainOfResponsibilityTests : IDisposable
    {
        private readonly string _authenticationHandler = "Authentication";
        private readonly string _loggingHandler = "Request Logger";
        private readonly string _customHeaderHandler = "Custom Header";

        [Fact]
        public void ChainOfResponsibility_ExecutesCorrectly()
        {
            var customHeaderHandler = new EnsureCustomHeaderPresentRequestHandler(null, "homeGrown");
            var loggingHandler = new RequestLogger(customHeaderHandler);
            var authenticationHandler = new AuthenticationRequestHandler(loggingHandler);

            var request = new Request("Admin", "Password1");
            request.AddHeader("homeGrown");

            authenticationHandler.Handle(request);

            Assert.Equal(3, authenticationHandler.GetNumberOfHandlersRun);
            Assert.Contains(authenticationHandler.GetRunHandlers(), x => x.Equals(_authenticationHandler, StringComparison.Ordinal));
        }

        [Fact]
        public void ChainOfResponsibility_StopsIfReqestHandlingFails()
        {
            var customHeaderHandler = new EnsureCustomHeaderPresentRequestHandler(null, "homeGrown");
            var loggingHandler = new RequestLogger(customHeaderHandler);
            var authenticationHandler = new AuthenticationRequestHandler(loggingHandler);

            var request = new Request("Admin", "Password1");
            request.AddHeader("feathers");

            authenticationHandler.Handle(request);

            Assert.Equal(2, authenticationHandler.GetNumberOfHandlersRun);
            Assert.Contains(authenticationHandler.GetRunHandlers(), x => x.Equals(_authenticationHandler, StringComparison.CurrentCultureIgnoreCase));
            Assert.Contains(authenticationHandler.GetRunHandlers(), x => x.Equals(_loggingHandler, StringComparison.CurrentCultureIgnoreCase));
            Assert.DoesNotContain(authenticationHandler.GetRunHandlers(), x => x.Equals(_customHeaderHandler, StringComparison.CurrentCultureIgnoreCase));
        }

        [Fact]
        public void ChainOfResponsibility_DoesNotRunIfFirstHandlerFails()
        {
            var customHeaderHandler = new EnsureCustomHeaderPresentRequestHandler(null, "homeGrown");
            var loggingHandler = new RequestLogger(customHeaderHandler);
            var authenticationHandler = new AuthenticationRequestHandler(loggingHandler);

            var request = new Request("Admins", "Password1!");
            request.AddHeader("feathers");

            authenticationHandler.Handle(request);

            Assert.Equal(0, authenticationHandler.GetNumberOfHandlersRun);
        }

        [Fact]
        public void ChainOfResponsibility_DoesNotRunTheHandlersAfterOneFails()
        {
            var customHeaderHandler = new EnsureCustomHeaderPresentRequestHandler(null, "homeGrown");
            var loggingHandler = new RequestLogger(customHeaderHandler)
            {
                LogginSucceeded = false
            };

            var authenticationHandler = new AuthenticationRequestHandler(loggingHandler);

            var request = new Request("Admin", "Password1");
            request.AddHeader("feathers");

            authenticationHandler.Handle(request);

            Assert.Equal(1, authenticationHandler.GetNumberOfHandlersRun);
            Assert.Contains(authenticationHandler.GetRunHandlers(), x => x.Equals(_authenticationHandler, StringComparison.CurrentCultureIgnoreCase));
        }

        public void Dispose()
        {
            //Reset the stack after every test since we are using a single instance
            RequestTracer.Instance.ResetStackWithHistory();
        }
    }
}
