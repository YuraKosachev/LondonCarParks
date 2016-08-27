using System.Collections.Generic;
using LondonCarPark.Provider.UrlGenerate;

namespace LondonCarPark.Provider
{
    public abstract class Provider<TModel,TConnector,TParam> : IProvider<TModel>
        where TModel : class
        where TConnector:IConnector,new()
    {
        protected IConnector _connector;
        protected string _requestMethod;
        protected IUrlBuilder<TParam> _urlBuilder;
        public Provider()
        {
            _connector = new TConnector();
        }

        public abstract TModel GetItem(TModel model);

        public abstract IEnumerable<TModel> GetList();
       
    }
}
