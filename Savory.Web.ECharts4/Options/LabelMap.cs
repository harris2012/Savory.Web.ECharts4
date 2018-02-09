using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class LabelMap
    {
        public Dictionary<string, Label> Labels { get; set; }

        public LabelMap(Dictionary<string, Label> labels)
        {
            this.Labels = labels;
        }

        public LabelMap(KeyValuePair<string, Label> label)
        {
            this.Labels = new Dictionary<string, Label>();
            this.Labels.Add(label.Key, label.Value);
        }

        public static implicit operator LabelMap(Dictionary<string, Label> labels)
        {
            return new LabelMap(labels);
        }

        public static implicit operator LabelMap(KeyValuePair<string, Label> labels)
        {
            return new LabelMap(labels);
        }
    }
}
