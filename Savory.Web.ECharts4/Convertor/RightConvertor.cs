using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class RightConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Right);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Right right = value as Right;
            if (right == null)
            {
                return;
            }

            if (right.IntValue != null)
            {
                if (right.IsPercent)
                {
                    writer.WriteValue(right.IntValue.Value + "%");
                }
                else
                {
                    writer.WriteValue(right.IntValue.Value);
                }
            }
        }

    }
}
