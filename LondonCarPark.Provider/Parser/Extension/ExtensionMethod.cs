using System.Text;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace LondonCarPark.Provider
{
    public static class ExtensionMethod
    {
        
        public static TModel GetModel<TModel>(this WebResponse response)
            where TModel : class
        {
            TModel item;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(TModel));
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                item = (TModel)json.ReadObject(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(reader.ReadToEnd())));

            }
            return item;


        }
    }
}
