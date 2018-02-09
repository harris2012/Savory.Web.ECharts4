using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4.Convertor
{
    public class GridCollectionConvertor : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(GridCollection);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            GridCollection collection = value as GridCollection;
            if (collection == null || collection.GridList == null || collection.GridList.Count == 0)
            {
                return;
            }

            if (collection.GridList.Count == 1)
            {
                serializer.Serialize(writer, collection.GridList[0]);
            }
            else
            {
                serializer.Serialize(writer, collection.GridList);
            }
        }
    }
}
