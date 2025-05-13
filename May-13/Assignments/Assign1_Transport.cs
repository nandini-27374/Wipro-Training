using System;
interface ITransport
{
    void Start();
    void Stop();
}
class Bus : ITransport
{
    public void Start()
    {
        Console.WriteLine("Bus is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Bus is Stopping");
    }
}


class Train : ITransport
{
    public void Start()
    {
        Console.WriteLine("Train is Starting");
    }
    public void Stop()
    {
        Console.WriteLine("Train is Stopping");
    }
}

class Program3
{
    static void Main()
    {
        ITransport bus = new Bus();
        ITransport train = new Train();

        bus.Start();
        bus.Stop();

        train.Start();
        train.Stop();
    }
}