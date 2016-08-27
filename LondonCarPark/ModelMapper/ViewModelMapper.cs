using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LondonCarPark.Service;
using LondonCarPark.Models;

namespace LondonCarPark.ModelMapper
{
    public static class ViewModelMapper
    {
        public static CarParkViewModel MapToCarParkViewModel(this CarParkServiceModel model)
        {
            return new CarParkViewModel
            {
                IdCarPark = model.IdCarPark,
                NameCarPark = model.NameCarPark,
                Bays = model.Bays.Select(bay => new BayViewModel
                {
                    BayCount = bay.BayCount,
                    BayType = bay.BayType,
                    Free = bay.Free,
                    Occupied = bay.Occupied
                })
            };
        }
        public static CarParkServiceModel MapToCarParkServiceModel(this CarParkViewModel model)
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