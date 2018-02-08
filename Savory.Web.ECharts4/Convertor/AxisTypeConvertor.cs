﻿using Newtonsoft.Json;
using Savory.Web.ECharts4.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class AxisTypeConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(AxisType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            AxisType axisType = (AxisType)value;
            switch (axisType)
            {
                case AxisType.Value:
                    writer.WriteValue("value");
                    break;
                case AxisType.Category:
                    writer.WriteValue("category");
                    break;
                case AxisType.Time:
                    writer.WriteValue("time");
                    break;
                case AxisType.Log:
                    writer.WriteValue("log");
                    break;
                default:
                    break;
            }
        }
    }
}