using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonCarPark.Provider
{
    public interface IProviderFactory
    {
        IProvider<CarParkProviderModel> GetCarParkProvider { get; }
    }
}
