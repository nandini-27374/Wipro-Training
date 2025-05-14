using System;

abstract class TicketBooking
{
    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking Tickets");
    }

    //abstract method
    public abstract void BookTicket(int seats);
}

class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} bus tickets");
    }
}

class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} flight tickets");
    }
}
class Program
{
    static void Main()
    {
        TicketBooking busbkg = new BusBooking();
        TicketBooking flightbkg = new FlightBooking();

        busbkg.ShowBookingInfo();
        busbkg.BookTicket(2);

        flightbkg.ShowBookingInfo();
        flightbkg.BookTicket(3);
    }
}
