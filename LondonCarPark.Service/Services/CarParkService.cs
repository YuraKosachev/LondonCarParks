
using System.Collections.Generic;
using System.Linq;

namespace LondonCarPark.Service
{
    public class CarParkService : Service<CarParkServiceModel>
    {
        public CarParkService():base() { }
        public override CarParkServiceModel GetItem(CarParkServiceModel model)
        {
            return _providerFactory.GetCarParkProvider.GetItem(model.MapToCarParkProviderModel()).MapToCarParkServiceModel();
        }

        public override IEnumerable<CarParkServiceModel> GetList()
        {
            return _providerFactory.GetCarParkProvider.GetList().Select(model=>model.MapToCarParkServiceModel());
        }
    }
}
