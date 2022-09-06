namespace DesignPatterns.Mediator
{
    public class ChatRoom : IMediator
    {
        protected readonly List<IColleague> ChatRoomMembers = new();
        public void SendMessage(IColleague member, string message)
        {
            foreach (var m in ChatRoomMembers.Where(m => m != member))
                m.ReceiveMessage(message);
        }

        public void AddColleague(IColleague colleague)
        {
            ChatRoomMembers.Add(colleague);
        }
    }

    public interface IMediator
    {
        void SendMessage(IColleague colleague, string message);
        void AddColleague(IColleague colleague);
    }
}