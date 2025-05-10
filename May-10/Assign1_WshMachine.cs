using System;

class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine("Appliance is a machine.");
    }
}

class WashingMachine : Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes.");
    }
}

class Program
{
    static void Main()
    {
        Appliance appliance=new Appliance();
        appliance.Operate();//calls base method

        WashingMachine wash_mac = new WashingMachine();
        wash_mac.Operate();//calls overriden method

        //Polymorphism
        Appliance appli_wash = new WashingMachine();
        appli_wash.Operate();//Calls overridden method
    }
}