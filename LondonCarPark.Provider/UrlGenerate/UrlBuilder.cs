using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonCarPark.Provider.UrlGenerate
{
    public abstract class UrlBuilder<TParam>:IUrlBuilder<TParam>
    {
        protected string _urlApi;
        protected string _appId;
        protected string _appKey;
        public UrlBuilder()
        {
            _urlApi = Properties.Settings.Default.HttpAPI;
            _appId = Properties.Settings.Default.AppId;
            _appKey = Properties.Settings.Default.AppKey;
        }

        public abstract string GetUrl();
        public abstract string GetUrl(TParam data);
    }
}
