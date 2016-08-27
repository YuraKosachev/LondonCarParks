using System.Collections.Generic;
using LondonCarPark.Provider.UrlGenerate;

namespace LondonCarPark.Provider
{
    public class LondonCarParkProvider: Provider<CarParkProviderModel, Connector,string>
    {
        public LondonCarParkProvider() : base()
        {
            _urlBuilder = new CarParkUrl();
            _requestMethod = "Get";
        }

        public override CarParkProviderModel GetItem(CarParkProviderModel model)
        {
            return _connector.GetData(_urlBuilder.GetUrl(model.IdCarPark), _requestMethod).GetModel<CarParkProviderModel>();
        }

        public override IEnumerable<CarParkProviderModel> GetList()
        {
            return _connector.GetData(_urlBuilder.GetUrl(), _requestMethod).GetModel<IEnumerable<CarParkProviderModel>>();
        }
    }
}
