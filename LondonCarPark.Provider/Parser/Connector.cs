using System.Net;


namespace LondonCarPark.Provider
{
    public class Connector:IConnector 
    {
        public WebResponse GetData(string url, string requestMethod)
        {
            var request = WebRequest.Create(url);
            request.Method = requestMethod;
            return request.GetResponse();
        }
    }
}
