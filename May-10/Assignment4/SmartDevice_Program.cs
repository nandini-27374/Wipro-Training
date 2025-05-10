using ConsoleApp1;

using System;
using System.Numerics;
using System.Reflection.Metadata;

class Program1
{
    static void Main()
    {
        SmartLight smart = new SmartLight("Living room light");
        smart.TogglePower();
        smart.SetBrightness(75);
        smart.ShowStatus();

        Console.WriteLine();

        SmartThermostat thermostat = new SmartThermostat("Hall Thermostat");
        thermostat.TogglePower();
        thermostat.SetTemperature(24.5);
        thermostat.ShowStatus();


    }
}