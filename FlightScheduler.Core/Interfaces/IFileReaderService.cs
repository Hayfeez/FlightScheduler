namespace FlightScheduler.Core.Interfaces
{
    public interface IFileReaderService
    {
        Task<string> ReadFileAsync(string path);
    }
}
