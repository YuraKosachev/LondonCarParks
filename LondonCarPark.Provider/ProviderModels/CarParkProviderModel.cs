using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LondonCarPark.Provider
{
    [DataContract]
    public class CarParkProviderModel
    {
        [DataMember(Name = "id")]
        public string IdCarPark { get; set; }
        [DataMember(Name = "name")]
        public string NameCarPark { get; set; }
        [DataMember(Name = "bays")]
        public IEnumerable<BayProviderModel> Bays { get; set; }
    }
}
