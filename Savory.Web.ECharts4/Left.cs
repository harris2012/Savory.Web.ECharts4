using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Left
    {
        public int? LeftValue { get; private set; }
        public LeftEnum? LeftEnum { get; private set; }

        public Left(int leftValue)
        {
            this.LeftValue = leftValue;
        }

        public Left(LeftEnum leftEnum)
        {
            this.LeftEnum = leftEnum;
        }

        public static implicit operator Left(LeftEnum leftEnum)
        {
            return new Left(leftEnum);
        }

        public static implicit operator Left(int leftValue)
        {
            return new Left(leftValue);
        }
    }
}
