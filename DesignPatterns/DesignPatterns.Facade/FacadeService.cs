namespace DesignPatterns.Facade;

public class FacadeService : IFacade
{
    private readonly IServer _server = new Server();
    private readonly IAuthenticator _authenticator = new Authenticator();

    public string ReadData(string username, string password, string connectionString)
    {
        try
        {
            var authenticated = _authenticator.Authenticate(username, password);
            if (!authenticated)
                throw new InvalidOperationException("You are not allowed to access the server");
            var databaseConnection = _server.ConnectToDatabase(connectionString);
            if (!databaseConnection.Equals("connected"))
                throw new Exception("something went wrong while connecting to the database");
        }
        finally
        {
            _server.DisconnectDatabaseConnection();
        }
        return _server.ReadData();
    }
}