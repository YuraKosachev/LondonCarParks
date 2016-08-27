using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LondonCarPark.Models
{
    public class CarParkViewModel
    {
        public string IdCarPark { get; set; }
        public string NameCarPark { get; set; }
        public IEnumerable<BayViewModel> Bays { get; set; }
    }
}