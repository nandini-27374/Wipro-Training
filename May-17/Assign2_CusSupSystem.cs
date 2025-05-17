using System;
interface ISupportTicket
{
    void CreativeTicket(string issue);
    void ResolveTicket(int ticketid);
}
class EmailSupport : ISupportTicket
{
    public void CreativeTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email:{issue}");
    }
    public void ResolveTicket(int ticketid)
    {
        Console.WriteLine($"Resolving ticket {ticketid} via Email");
    }
}

class PhoneSupport : ISupportTicket
{
    public void CreativeTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Phone:{issue}");
    }
    public void ResolveTicket(int ticketid)
    {
        Console.WriteLine($"Resolving ticket {ticketid} via Phone");
    }
}


class Program3
{
    static void Main()
    {
        ISupportTicket es = new EmailSupport();
        ISupportTicket ps = new PhoneSupport();

        es.CreativeTicket("Cannot login to account");
        es.ResolveTicket(1234);

        ps.CreativeTicket("Internet is not working");
        ps.ResolveTicket(202);
    }
}
