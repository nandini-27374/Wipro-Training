using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SmartDevice
    {
        public string DeviceName { get; set; }
        public bool PowerStatus { get; set; }

        public SmartDevice(string name)
        {
            DeviceName = name;
            PowerStatus = false;
        }

        public void TogglePower()
        {
            PowerStatus = !PowerStatus; 
            Console.WriteLine($"DeviceName{DeviceName} Power Status is now {(PowerStatus ? "ON":"OFF")}");
        }
        public virtual void ShowStatus()
        {
            Console.WriteLine($"DeviceName {DeviceName},Power is { (PowerStatus ? "ON":"OFF")}");
        }
    }

    class SmartLight : SmartDevice
    {
        public int Brightness { get; set; }

        public SmartLight(string name):base(name)
        {
            Brightness = 50;
        }
        public void SetBrightness (int value)
        {
            Brightness=Math.Max(0, Math.Min(100,value));
            Console.WriteLine($"Brightness set to {Brightness}%");
        }

        public override void ShowStatus()
        {
            base.ShowStatus();
            Console.WriteLine($"Brightness:{Brightness}%");
        }
    }

    class SmartThermostat : SmartDevice
    {
        public double Temperature { get; set; } 

        public SmartThermostat(string name) : base(name)
        {
            Temperature = 22.0;
        }
        public void SetTemperature(double temp)
        {
            Temperature = temp;
            Console.WriteLine($"{DeviceName} temparature set to {Temperature}");
        }
        public override void ShowStatus()
        {
            base.ShowStatus();
            Console.WriteLine($"Temperature {Temperature} C");
        }
    }
}