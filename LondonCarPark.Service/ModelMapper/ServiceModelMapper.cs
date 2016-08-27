using System.Linq;
using LondonCarPark.Provider;

namespace LondonCarPark.Service
{
    public static class ServiceModelMapper
    {
        public static  CarParkProviderModel MapToCarParkProviderModel(this CarParkServiceModel model)
        {
            return new CarParkProviderModel {
                IdCarPark = model.IdCarPark,
                NameCarPark = model.NameCarPark,
                Bays = model.Bays.Select(bay => new BayProviderModel {
                                        BayCount=bay.BayCount,
                                        BayType = bay.BayType,
                                        Free = bay.Free,
                                        Occupied = bay.Occupied})
            };
        }
        public static  CarParkServiceModel MapToCarParkServiceModel(this CarParkProviderModel model)
        {
            return new CarParkServiceModel
            {
                IdCarPark = model.IdCarPark,
                NameCarPark = model.NameCarPark,
                Bays = model.Bays.Select(bay => new BayServiceModel
                {
                    BayCount = bay.BayCount,
                    BayType = bay.BayType,
                    Free = bay.Free,
                    Occupied = bay.Occupied
                })
            };
        }
    }
}
