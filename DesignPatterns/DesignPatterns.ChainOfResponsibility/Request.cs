namespace DesignPatterns.ChainOfResponsibility
{
    public class Request
    {
        private readonly List<string> _headers = new();

        public Request(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }

        public bool ContainsHeader(string header)
        {
            return _headers.Contains(header);
        }

        public void AddHeader(string header)
        {
            _headers.Add(header);
        }
    }
}