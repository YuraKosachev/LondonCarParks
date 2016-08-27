using System.Collections.Generic;

namespace LondonCarPark.Service
{
    public class CarParkServiceModel
    {
        public string IdCarPark { get; set; }
        public string NameCarPark { get; set; }
        public IEnumerable<BayServiceModel> Bays { get; set; }
    }
}
