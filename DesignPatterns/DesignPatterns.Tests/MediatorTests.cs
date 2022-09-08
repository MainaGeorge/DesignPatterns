using DesignPatterns.Mediator;

namespace DesignPatterns.Tests
{
    public  class MediatorTests
    {
        [Fact]
        public void Mediator_SetUpWorksCorrectly()
        {
            var chatRoom = new ChatRoom();
            var member1 = new ChatRoomMember(chatRoom);
            var member2 = new ChatRoomMember(chatRoom);
            var member3 = new ChatRoomMember(chatRoom);

            const string message = "hello there from member 1";
            member1.SendMessage(message);

            Assert.Equal(1, member3.NumberOfReceivedMessages);
            Assert.Equal(1, member2.NumberOfReceivedMessages);

            //objects don't send messages to themselves
            Assert.Equal(0, member1.NumberOfReceivedMessages);

            Assert.True(member3.LastMessage.Equals(message));
        }
    }
}
