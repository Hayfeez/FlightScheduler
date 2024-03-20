using FlightScheduler.Core.Interfaces;
using FlightScheduler.Data;
using FlightScheduler.Data.Entities;

namespace FlightScheduler.Core.Services
{
    public class FlightScheduleService : IFlightSchedule
    {
        public IEnumerable<Flight> LoadFlightSchedules()
        {
            return new List<Flight>
            {
                new Flight
                {
                    Day = 1,
                    Number = 1,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.TorontoAirport
                },
                new Flight
                {
                    Day = 1,
                    Number = 2,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.CalgaryAirport
                },
                new Flight
                {
                    Day = 1,
                    Number = 3,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.VancouverAirport
                },
                //day2
                new Flight
                {
                    Day = 2,
                    Number = 4,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.TorontoAirport
                },
                new Flight
                {
                    Day = 2,
                    Number = 5,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.CalgaryAirport
                },
                new Flight
                {
                    Day = 2,
                    Number = 6,
                   Airplane = SeedData.Airplane,
                   ArrivalAirport = SeedData.VancouverAirport
                }
            };
        }

    }
}
