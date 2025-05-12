using System;
interface IDeviceControl
{
    void TurnOn();
    void TurnOff();
}
class SmartTV : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("SmartTV is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("SmartTV is now OFF");
    }
}
class Speaker : IDeviceControl
{
    public void TurnOn()
    {
        Console.WriteLine("speaker is now ON");
    }
    public void TurnOff()
    {
        Console.WriteLine("speaker is now OFF");
    }
}

class Program4
{
    static void Main()
    {
        SmartTV stv = new SmartTV();
        stv.TurnOn();
        SmartTV stvoff = new SmartTV();
        stvoff.TurnOff();
        Speaker speaker = new Speaker();
        stv.TurnOn();
        Speaker speakeroff = new Speaker();
        speakeroff.TurnOff();
    }
}