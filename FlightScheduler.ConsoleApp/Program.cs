using FlightScheduler.Core.Services;

namespace FlightScheduler.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to FLight Scheduler");
            Console.WriteLine("Enter 1 to List Flight Schedules");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var parsedInput))
            {
                ProcessInput(parsedInput);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        static void ProcessInput(int input)
        {
            try
            {
                if (input == 1)
                {
                    var flightScheduleService = new FlightScheduleService();
                    var flightSchedules = flightScheduleService.LoadFlightSchedules();

                    Console.WriteLine(
                        string.Join(Environment.NewLine,
                        flightSchedules.Select(x => $"Flight: {x.Number}, departure: {x.DepartureAirport.ShortCode}, arrival: {x.ArrivalAirport.ShortCode}, day: {x.Day}")));
                }

                else
                {
                    Console.WriteLine("Unknown input");
                }
            }
            catch
            {

                Console.WriteLine("An error occured");
            }
        }
    }
}