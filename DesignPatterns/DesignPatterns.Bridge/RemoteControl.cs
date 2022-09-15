namespace DesignPatterns.Bridge
{
    public class RemoteControl
    {
        protected readonly IDeviceSoftware DeviceSoftware;

        public RemoteControl(IDeviceSoftware deviceSoftware)
        {
            DeviceSoftware = deviceSoftware;
        }

        public string PowerOff()
        {
            return DeviceSoftware.PowerOff();
        }

        public string PowerOn()
        {
            return DeviceSoftware.PowerOn();
        }
    }
}