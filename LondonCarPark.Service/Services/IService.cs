using System.Collections.Generic;

namespace LondonCarPark.Service
{
    public interface IService<TServiceModel>
        where TServiceModel : class
    {
        IEnumerable<TServiceModel> GetList();
        TServiceModel GetItem(TServiceModel model);
    }
}
