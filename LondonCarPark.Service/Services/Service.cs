using System.Collections.Generic;
using LondonCarPark.Provider;


namespace LondonCarPark.Service
{
    public abstract class Service<TServiceModel> : IService<TServiceModel>
        where TServiceModel : class
    {
        protected IProviderFactory _providerFactory;
        public Service() {
            _providerFactory = new ProviderFactory();
        }
        public abstract TServiceModel GetItem(TServiceModel model);
        public abstract IEnumerable<TServiceModel> GetList();
       
    }
}
