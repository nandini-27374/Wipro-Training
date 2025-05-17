using System;
interface IMaintenance
{
    void Service();
    void Repair();
}
class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}


class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is being repared");
    }
}

class Program3
{
    static void Main()
    {
        IMaintenance cm = new CarMaintenance();
        IMaintenance bm = new BikeMaintenance();

        cm.Service();
        cm.Repair();

        bm.Service();
        bm.Repair();
    }
}