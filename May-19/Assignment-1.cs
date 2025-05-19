using System;

abstract class SmartDevice
{ 
    public void ShowStatus()
    {
        Console.WriteLine("Device status: Active");
    }

    //abstract method
    public abstract void TurnOn();
}



interface IRemoteControl
{
    void IncreaseVolume();
    void DecreaseVolume();
}

class SmartLight : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Light turned on");
    }
    public  void IncreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("Light do not support volume control");
    }
}
class SmartSpeaker : SmartDevice, IRemoteControl
{
    public override void TurnOn()
    {
        Console.WriteLine("Smart Speaker turned on");
    }
    public void IncreaseVolume()
    {
        Console.WriteLine("Volume Increased");
    }
    public void DecreaseVolume()
    {
        Console.WriteLine("VolumeDecreased");
    }

}

class Program
{
    static void Main()
    {
        SmartDevice sl = new SmartLight();
        SmartDevice ss = new SmartSpeaker();

        Console.WriteLine("Smart Light");
        sl.ShowStatus();
        sl.TurnOn();
        ((IRemoteControl)sl).IncreaseVolume();
        ((IRemoteControl)sl).DecreaseVolume();

        Console.WriteLine("\nSmartSpeaker:");
        ss.ShowStatus();
        ss.TurnOn();
        ((IRemoteControl)ss).IncreaseVolume();
        ((IRemoteControl)ss).DecreaseVolume();

    }
}