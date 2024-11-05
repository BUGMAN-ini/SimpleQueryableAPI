
public interface IApiDataReader
{
    Task<string> Read(string baseaddress, string requesturi);
}