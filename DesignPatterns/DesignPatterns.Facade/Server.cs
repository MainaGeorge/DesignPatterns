namespace DesignPatterns.Facade
{
    public class Server : IServer
    {
        public string ConnectToDatabase(string connectionString)
        {
            return "connected";
        }

        public string DisconnectDatabaseConnection()
        {
            return "disconnected";
        }

        public string ReadData()
        {
            return "data retrieved";
        }
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
        public bool Authenticate(string username, string password)
        {
            return username.Equals("admin") && password.Equals("password1");
        }
    }

    public interface IFacade
    {
        string ReadData(string username, string password, string connectionString);
    }
}