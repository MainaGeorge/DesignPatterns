using DesignPatterns.Bridge;

namespace DesignPatterns.Tests
{
    public class BridgeTests
    {
        [Fact]
        public void Bridge_ConnectsTwo_IndependentHierarchies()
        {
            var sonyRemote = new RemoteControl(new SonyTvSoftware());
            var samsungRemote = new AdvancedRemoteControl(new SamsungTvSoftware());

            Assert.Equal("Powering on Sony TV", sonyRemote.PowerOn());
            Assert.Equal("switching Samsung TV to channel 3", samsungRemote.SwitchChannel(3));
        }
    }
}
