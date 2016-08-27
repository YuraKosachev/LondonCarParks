using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LondonCarPark.Models
{
    public class BayViewModel
    {
        public int BayCount { get; set; }
        public string BayType { get; set; }
        public int Free { get; set; }
        public int Occupied { get; set; }
    }
}