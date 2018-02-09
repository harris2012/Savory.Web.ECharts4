using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class LabelMapConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(LabelMap);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            LabelMap map = value as LabelMap;
            if (map == null || map.Labels == null || map.Labels.Count == 0)
            {
                return;
            }

            serializer.Serialize(writer, map.Labels);
        }
    }
}
