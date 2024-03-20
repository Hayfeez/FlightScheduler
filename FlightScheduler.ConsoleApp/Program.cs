using FlightScheduler.Core.Services;
using FlightScheduler.Data.Entities;
using System.Text.Json;

namespace FlightScheduler.ConsoleApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to Flight Scheduler");
            Console.WriteLine("Enter 1 to List Flight Schedules or 2 to list flight itenary");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var parsedInput))
            {
                await ProcessInput(parsedInput);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        static async Task ProcessInput(int input)
        {
            try
            {

                var flightScheduleService = new FlightScheduleService();
                switch (input)
                {
                    case 1:
                        {
                            var flightSchedules = flightScheduleService.LoadFlightSchedules();

                            Console.WriteLine(
                                string.Join(Environment.NewLine,
                                flightSchedules.Select(x => $"Flight: {x.Number}, departure: {x.DepartureAirport.ShortCode}, arrival: {x.ArrivalAirport.ShortCode}, day: {x.Day}")));
                        }
                        break;
                    case 2:
                        {
                            var fileReader = new FileReaderService();
                            var filePath = "StaticFiles\\coding-assigment-orders.json";
                            var destinationString = await fileReader.ReadFileAsync(filePath);
                            var orderDestinations = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(destinationString)
                                  ?.Select(x => new Order
                                  {
                                      Destination = x.Value["destination"],
                                      OrderNo = x.Key
                                  }).ToList();

                            flightScheduleService.AttachOrdersToFlights(orderDestinations);

                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Unknown input");
                            break;
                        }
                }
            }
            catch
            {

                Console.WriteLine("An error occured while processing input");
            }

        }
    }
}