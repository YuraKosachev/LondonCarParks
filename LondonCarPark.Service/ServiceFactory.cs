
namespace LondonCarPark.Service
{
    public class ServiceFactory : IServiceFactory
    {
        public IService<CarParkServiceModel> GetCarParkService { get { return new CarParkService(); } }
         
       
    }
}
