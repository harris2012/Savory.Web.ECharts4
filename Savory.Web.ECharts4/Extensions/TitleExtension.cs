using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    partial class Title
    {
        public Title SetText(string text)
        {
            this.Text = text;

            return this;
        }

        public Title SetSubText(string subText)
        {
            this.SubText = subText;

            return this;
        }
    }
}
