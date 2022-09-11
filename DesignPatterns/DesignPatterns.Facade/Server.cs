namespace DesignPatterns.Facade
{
    public class Server : IServer
    {
        public string ConnectToDatabase(string connectionString) => "connected";
        public string DisconnectDatabaseConnection() => "disconnected";
        public string ReadData() => "data retrieved";
    }

    public interface IServer
    {
        string ConnectToDatabase(string connectionString);
        string DisconnectDatabaseConnection();
        string ReadData();
    
    }

    public interface IAuthenticator
    {
        bool Authenticate(string username, string password);
    }

    public class Authenticator : IAuthenticator
    {
        public bool Authenticate(string username, string password) => username.Equals("admin") && password.Equals("password1");
    }

    public interface IFacade
    {
        string ReadData(string username,string password, string connectionString);
    }
}