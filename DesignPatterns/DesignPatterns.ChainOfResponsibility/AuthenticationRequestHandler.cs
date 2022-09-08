namespace DesignPatterns.ChainOfResponsibility
{
    public class AuthenticationRequestHandler : RequestHandler
    {
        public AuthenticationRequestHandler(RequestHandler? nextHandler) : base("Authentication", nextHandler)
        {
        }

        protected override bool HandleRequest(Request request)
        {
            return request.UserName == "Admin" && request.Password == "Password1";
        }
    }
}