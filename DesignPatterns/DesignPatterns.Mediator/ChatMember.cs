namespace DesignPatterns.Mediator;

public abstract class ChatMember 
{
    protected string Name { get; set; }
    private readonly ChatRoom _chatRoom;
    private readonly Stack<string> _messageHistory = new();
    public int NumberOfReceivedMessages => _messageHistory.Count;

    protected ChatMember(ChatRoom chatRoom, string name)
    {
        Name = name;
        _chatRoom = chatRoom;
        _chatRoom.AddMember(this);
    }

    public string ReceiveMessage(string message)
    {
        _messageHistory.Push(message);
        return $"received {message}";
    }

    public void SendMessage(string message)
    {
        _chatRoom.SendMessage(this, message);
    }

    public string LastMessage => _messageHistory.Peek();
}

public class ChatRoomMember : ChatMember
{
    public ChatRoomMember(ChatRoom chatRoom, string name) : base(chatRoom, name)
    {
    }
}

