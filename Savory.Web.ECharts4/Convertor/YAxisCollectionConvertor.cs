using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class YAxisCollectionConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(YAxisCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            YAxisCollection collection = value as YAxisCollection;
            if (collection == null || collection.YAxisList == null || collection.YAxisList.Count == 0)
            {
                return;
            }

            serializer.Serialize(writer, collection.YAxisList);
        }
    }
}
