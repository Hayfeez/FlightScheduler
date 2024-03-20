namespace FlightScheduler.Data.Entities
{
    public class Flight
    {
        public int Number { get; set; }
        public int Day { get; set; }
        public Airplane Airplane { get; set; }
        public Airport DepartureAirport { get; set; } = SeedData.MontrealAirport;
        public Airport ArrivalAirport { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
