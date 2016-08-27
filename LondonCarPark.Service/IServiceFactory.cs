

namespace LondonCarPark.Service
{
    public interface  IServiceFactory
    {
        IService<CarParkServiceModel> GetCarParkService { get; }
    }
}
