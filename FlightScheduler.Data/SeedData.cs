using FlightScheduler.Data.Entities;

namespace FlightScheduler.Data
{
    public static class SeedData
    {
        public static Airplane Airplane = new Airplane { Capacity = 20 };
        public static Airport MontrealAirport = new() { Name = "Montreal", ShortCode = "YUL" };
        public static Airport TorontoAirport = new() { Name = "Toronto", ShortCode = "YYZ" };
        public static Airport CalgaryAirport = new() { Name = "Calgary", ShortCode = "YYC" };
        public static Airport VancouverAirport = new() { Name = "Vancouver", ShortCode = "YVR" };

    }
}