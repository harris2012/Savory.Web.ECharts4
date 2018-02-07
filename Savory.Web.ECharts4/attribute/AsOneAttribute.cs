using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 该属性只能加在List上面，当List只有一个元素的时候，支持将List退化为单个元素
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class AsOneAttribute : Attribute
    {
    }
}
