namespace DesignPatterns.Mediator
{
    public abstract class ChatRoom
    {
        protected string Name { get; }
        protected readonly List<ChatRoomMember> ChatRoomMembers = new();
        public void SendMessage(ChatRoomMember roomMember, string message)
        {
            foreach (var m in ChatRoomMembers.Where(m => m != roomMember))
                m.ReceiveMessage(message);
        }

        protected ChatRoom(string name)
        {
            Name = name;
        }
        public void AddMember(ChatRoomMember roomMember)
        {
            ChatRoomMembers.Add(roomMember);
        }

        public void SendMessage<T>(string message) where T : ChatRoomMember
        {
            ChatRoomMembers.OfType<T>()
                .ToList()
                .ForEach(m => m.ReceiveMessage(message));
        }
    }
}