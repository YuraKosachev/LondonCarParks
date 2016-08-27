using System.Net;
namespace LondonCarPark.Provider
{
    public interface IConnector
    {
        WebResponse GetData(string url, string requestMethod);
    }
}
