namespace DesignPatterns.Mediator
{
    public abstract class ChatRoom
    {
        protected string Name { get; private set; }
        protected readonly List<ChatMember> ChatRoomMembers = new();
        public void SendMessage(ChatMember member, string message)
        {
            foreach (var m in ChatRoomMembers.Where(m => m != member))
                m.ReceiveMessage(message);
        }

        protected ChatRoom(string name)
        {
            Name = name;
        }
        public void AddMember(ChatMember member)
        {
            ChatRoomMembers.Add(member);
        }
    }
}