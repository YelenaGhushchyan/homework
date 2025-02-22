public class FlightTicket
{
    public string passengerName;
    public int flightNumber;
    public int seatNumber;

    public FlightTicket(string name, int flight, int seat)
    {
        passengerName = name;
        flightNumber = flight;
        seatNumber = seat;
    }

    public void ShowTicketInfo()
    {
        Console.WriteLine("Passenger: " + passengerName);
        Console.WriteLine("Flight Number: " + flightNumber);
        Console.WriteLine("Seat Number: " + seatNumber);
    }
}

class Program
{
    static void Main(string[] args)
    {
        FlightTicket ticket1 = new FlightTicket("Anna", 10, 15);
        FlightTicket ticket2 = new FlightTicket("Ani", 15, 70);
        ticket1.ShowTicketInfo();
        ticket2.ShowTicketInfo();
    }
}
