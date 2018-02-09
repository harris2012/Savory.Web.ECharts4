using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class TopConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(Top);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Top top = value as Top;
            if (top == null)
            {
                return;
            }

            if (top.EnumValue != null)
            {
                switch (top.EnumValue.Value)
                {
                    case TopEnum.Top:
                        writer.WriteValue("top");
                        break;
                    case TopEnum.Middle:
                        writer.WriteValue("middle");
                        break;
                    case TopEnum.Bottom:
                        writer.WriteValue("bottom");
                        break;
                    default:
                        break;
                }
            }
            else if (top.IntValue != null)
            {
                if (top.IsPercent)
                {
                    writer.WriteValue(top.IntValue + "%");
                }
                else
                {
                    writer.WriteValue(top.IntValue);
                }
            }
        }
    }
}
