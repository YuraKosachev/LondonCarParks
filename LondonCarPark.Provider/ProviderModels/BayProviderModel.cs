using System.Runtime.Serialization;

namespace LondonCarPark.Provider
{
   [DataContract]
    public class BayProviderModel
    {
        
            [DataMember(Name = "bayCount")]
            public int BayCount { get; set; }
            [DataMember(Name = "bayType")]
            public string BayType { get; set; }
            [DataMember(Name = "free")]
            public int Free { get; set; }
            [DataMember(Name = "occupied")]
            public int Occupied { get; set; }
        }
    }

