using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class XAxisCollectionConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(XAxisCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            XAxisCollection collection = value as XAxisCollection;
            if (collection == null || collection.XAxisList == null || collection.XAxisList.Count == 0)
            {
                return;
            }

            if (collection.XAxisList.Count == 1)
            {
                serializer.Serialize(writer, collection.XAxisList[0]);
            }
            else
            {
                serializer.Serialize(writer, collection.XAxisList);
            }
        }
    }
}
