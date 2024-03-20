using FlightScheduler.Data.Entities;

namespace FlightScheduler.Core.Interfaces
{
    public interface IFlightSchedule
    {
        IEnumerable<Flight> LoadFlightSchedules();
        void AttachOrdersToFlights(List<Order> orders);
    }
}
