using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LondonCarPark.Provider.UrlGenerate
{
    public interface IUrlBuilder<TParam>
    {
        string GetUrl();
        string GetUrl(TParam data);
    }
}
