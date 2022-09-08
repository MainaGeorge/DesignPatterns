using DesignPatterns.Mediator;

namespace DesignPatterns.Tests
{
    public  class MediatorTests
    {
        [Fact]
        public void Mediator_SetUpWorksCorrectly()
        {
            var chatRoom = new FaceBookChatRoom("facebook chat");
            var james = new ChatRoomMember(chatRoom, "James");
            var john = new ChatRoomMember(chatRoom, "John");
            var joy = new ChatRoomMember(chatRoom, "Joy");

            const string message = "hello there from member 1";
            james.SendMessage(message);

            Assert.Equal(1, joy.NumberOfReceivedMessages);
            Assert.Equal(1, john.NumberOfReceivedMessages);

            //objects don't send messages to themselves
            Assert.Equal(0, james.NumberOfReceivedMessages);

            Assert.True(joy.LastMessage.Equals(message));
        }
    }
}
