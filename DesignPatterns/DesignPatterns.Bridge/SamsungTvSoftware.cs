namespace DesignPatterns.Bridge;

public class SamsungTvSoftware : IDeviceSoftware
{
    public override string ToString()
    {
        return "Samsung TV";
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
        return $"switching {this} to channel {channelNumber}";
    }
}