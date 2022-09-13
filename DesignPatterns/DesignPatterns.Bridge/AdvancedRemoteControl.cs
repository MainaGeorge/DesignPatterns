namespace DesignPatterns.Bridge;

public class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDeviceSoftware deviceSoftware) : base(deviceSoftware)
    {
    }
    public string SwitchChannel(int channelNumber) => DeviceSoftware.SwitchChannel(channelNumber);
}