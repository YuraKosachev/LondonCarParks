
namespace LondonCarPark.Provider
{
    public class ProviderFactory : IProviderFactory
    {
        public IProvider<CarParkProviderModel> GetCarParkProvider
        {
            get{ return new LondonCarParkProvider();}
        }
    }
}
