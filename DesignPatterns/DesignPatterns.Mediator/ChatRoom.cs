namespace DesignPatterns.Mediator
{
    public abstract class ChatRoom
    {
        protected readonly List<ChatRoomMember> _chatRoomMembers = new();

        public void AddChatRoomMember(ChatRoomMember newMember)
        {
            _chatRoomMembers.Add(newMember);
        }

        public void SendMessage(ChatRoomMember member, string message)
        {
            foreach (var m in _chatRoomMembers.Where(m => m != member))
                m.ReceiveMessage(message);
        }
    }


    public abstract class ChatRoomMember
    {
        protected readonly ChatRoom _chatRoom;
        private Stack<string> _messageHistory = new();

        public ChatRoomMember(ChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public string ReceiveMessage(string message)
        {
            return $"received {message}";
        }

        public void SendMessage(string message)
        {
            _chatRoom.SendMessage(this, message);
        }
    }
}