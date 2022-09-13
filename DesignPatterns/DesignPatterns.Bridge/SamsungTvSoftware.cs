namespace DesignPatterns.Bridge;

public class SamsungTvSoftware : IDeviceSoftware
{
    public override string ToString() => "Samsung TV";
    public string PowerOn() => $"Powering on {this}";
    public string PowerOff() => $"Powering off {this}";
    public string SwitchChannel(int channelNumber) => $"switching {this} to channel {channelNumber}";

}