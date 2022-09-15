namespace DesignPatterns.Bridge;

public class SonyTvSoftware : IDeviceSoftware
{
    public override string ToString()
    {
        return "Sony TV";
    }

    public string PowerOn()
    {
        return $"Powering on {this}";
    }

    public string PowerOff()
    {
        return $"Powering off {this}";
    }

    public string SwitchChannel(int channelNumber)
    {
        return $"switching to channel {channelNumber}";
    }
}