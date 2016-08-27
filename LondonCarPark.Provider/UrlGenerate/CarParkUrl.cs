using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonCarPark.Provider.UrlGenerate
{
    public class CarParkUrl : UrlBuilder<string>
    {
        public CarParkUrl() : base() { }
        public override string GetUrl()
        {
            return String.Format("{0}Occupancy/CarPark?app_id={1}&app_key={2}", _urlApi, _appId, _appKey);
        }

        public override string GetUrl(string data)
        {
            return String.Format("{0}Occupancy/CarPark/{1}?app_id={2}&app_key={3}", _urlApi, data, _appId, _appKey);
        }
    }
}
