using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    partial class EChartsOption
    {
        #region Title 标题
        /// <summary>
        /// 为图标增加一个标题
        /// </summary>
        /// <returns></returns>
        public Title CreateTitle()
        {
            Title title = new Title();

            this.TitleCollection = title;

            return title;
        }

        /// <summary>
        /// 为图表创建一个标题
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public Title CreateTitle(string text)
        {
            Title title = new Title();
            title.Text = text;

            this.TitleCollection = title;

            return title;
        }
        #endregion

        #region Legend

        #endregion
    }
}
