using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class EChartsSerializer
    {
        internal string Serialize(EChartsOption option)
        {
            if (option == null)
            {
                throw new ArgumentNullException(nameof(option));
            }

            StringBuilder builder = new StringBuilder();

            Serialize(option, builder);

            return builder.ToString();
        }

        private void Serialize(object item, StringBuilder builder)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }

            builder.Append("{");

            var properties = item.GetType().GetProperties();
            foreach (var property in properties)
            {
                #region PropertyName

                if (property.IsDefined(typeof(EChartsPropertyAttribute), false))
                {
                    var propertyAttribute = (EChartsPropertyAttribute)property.GetCustomAttributes(typeof(EChartsPropertyAttribute), false)[0];
                    builder.Append(propertyAttribute.Name);
                }
                else
                {
                    builder.Append(property.Name);
                }

                #endregion

                #region PropertyValue

                var propertyType = property.PropertyType;
                if (propertyType.Name.Equals("List`1"))
                {
                    var asOneAttribute = property.GetCustomAttributes(typeof(AsOneAttribute), false);
                    if (asOneAttribute != null)
                    {

                    }
                }

                #endregion
            }

            builder.Append("}");
        }
    }
}
