using System.Collections.Generic;


namespace LondonCarPark.Provider
{
    public interface IProvider<TModel>
        where TModel:class
    {
        IEnumerable<TModel> GetList();
        TModel GetItem(TModel model);
    }
}
