namespace DesignPatterns.Bridge;

public interface IDeviceSoftware
{
    string PowerOn();
    string PowerOff();
    string SwitchChannel(int channelNumber);

}