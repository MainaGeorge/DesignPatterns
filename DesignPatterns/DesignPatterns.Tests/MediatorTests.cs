using DesignPatterns.Mediator;

namespace DesignPatterns.Tests
{
    public class MediatorTests
    {
        [Fact]
        public void Mediator_SetUpWorksCorrectly()
        {
            var chatRoom = new FaceBookChatRoom("facebook chat");
            var james = new LivingRoomChatRoomMember(chatRoom, "James");
            var john = new KitchenChatRoomMember(chatRoom, "John");
            var joy = new LivingRoomChatRoomMember(chatRoom, "Joy");

            const string message = "hello there from roomMember 1";
            james.SendMessage(message);

            Assert.Equal(1, joy.NumberOfReceivedMessages);
            Assert.Equal(1, john.NumberOfReceivedMessages);

            //objects don't send messages to themselves
            Assert.Equal(0, james.NumberOfReceivedMessages);

            Assert.True(joy.LastMessage.Equals(message));
        }

        [Fact]
        public void Mediator_CanSend_RestrictedMessages()
        {
            var chatRoom = new FaceBookChatRoom("facebook chat");
            var james = new LivingRoomChatRoomMember(chatRoom, "James");
            var john = new KitchenChatRoomMember(chatRoom, "John");
            var kim = new KitchenChatRoomMember(chatRoom, "Kim");

            const string message = "hello from the kitchen";
            kim.SendMessage<LivingRoomChatRoomMember>(message);
            Assert.True(james.LastMessage.Equals(message));
            Assert.Equal(0, john.NumberOfReceivedMessages);
            Assert.Equal(1, james.NumberOfReceivedMessages);
        }
    }
}
