using FlightScheduler.Core.Interfaces;

namespace FlightScheduler.Core.Services
{
    public class FileReaderService : IFileReaderService
    {
        public Task<string> ReadFileAsync(string path)
        {
            try
            {
                return Task.FromResult(File.ReadAllText(path));

            }
            catch (Exception)
            {
                Console.WriteLine("An error occured reading order file");
                throw;
            }
        }
    }
}
