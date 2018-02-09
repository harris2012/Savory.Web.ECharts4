using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class GridCollection
    {
        public List<Grid> GridList { get; set; }

        public GridCollection(List<Grid> gridList)
        {
            this.GridList = gridList;
        }

        public GridCollection(Grid grid)
        {
            this.GridList = new List<Grid> { grid };
        }

        public static implicit operator GridCollection(List<Grid> gridList)
        {
            return new GridCollection(gridList);
        }

        public static implicit operator GridCollection(Grid grid)
        {
            return new GridCollection(grid);
        }
    }
}
