namespace DesignPatterns.Bridge;

public class SonyTvSoftware : IDeviceSoftware
{
    public override string ToString() => "Sony TV";
    public string PowerOn() => $"Powering on {this}";
    public string PowerOff() => $"Powering off {this}";
    public string SwitchChannel(int channelNumber) => $"switching to channel {channelNumber}";

}