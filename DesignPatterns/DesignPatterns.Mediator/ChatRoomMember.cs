namespace DesignPatterns.Mediator;

public class ChatRoomMember : IColleague
{
    private readonly IMediator _mediator;
    private readonly Stack<string> _messageHistory = new();
    public int NumberOfReceivedMessages => _messageHistory.Count;

    public ChatRoomMember(IMediator mediator)
    {
        _mediator = mediator;
        _mediator.AddColleague(this);
    }

    public string ReceiveMessage(string message)
    {
        _messageHistory.Push(message);
        return $"received {message}";
    }

    public void SendMessage(string message)
    {
        _mediator.SendMessage(this, message);
    }

    public string LastMessage => _messageHistory.Pop();
}

public interface IColleague
{
    string ReceiveMessage(string message);
}