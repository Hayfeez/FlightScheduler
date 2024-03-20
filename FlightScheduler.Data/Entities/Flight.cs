namespace FlightScheduler.Data.Entities
{
    public class Flight
    {
        public int Number { get; set; }
        public int Day { get; set; }
        public Airplane Airplane { get; set; }
        public Airport DepartureAirport { get; set; }
        public Airport ArrivalAirport { get; set; }
    }
}
