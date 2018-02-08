using Newtonsoft.Json;
using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class SerieDataCollectionConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(SerieDataCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            SerieDataCollection collection = value as SerieDataCollection;
            if (collection == null || collection.SerieDataList == null || collection.SerieDataList.Count == 0)
            {
                return;
            }

            serializer.Serialize(writer, collection.SerieDataList);
        }
    }
}
