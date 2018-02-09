using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    /// <summary>
    /// 标题集合
    /// </summary>
    public class TitleCollection
    {
        /// <summary>
        /// 标题集合
        /// </summary>
        public List<Title> TitleList { get; set; }

        public static implicit operator TitleCollection(Title title)
        {
            TitleCollection collection = new TitleCollection();

            collection.TitleList = new List<Title> { title };

            return collection;
        }

        public static implicit operator TitleCollection(List<Title> titleList)
        {
            TitleCollection collection = new TitleCollection();

            collection.TitleList = titleList;

            return collection;
        }

        public void Add(Title title)
        {
            this.TitleList.Add(title);
        }
    }
}
