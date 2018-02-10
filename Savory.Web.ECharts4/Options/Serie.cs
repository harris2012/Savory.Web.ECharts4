using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.Web.ECharts4
{
    public class Serie
    {
        [JsonProperty("avoidLabelOverlap")]
        public bool? AvoidLabelOverlap;

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public SerieType SerieType { get; set; }

        [JsonProperty("data")]
        public SerieDataCollection Data { get; set; }

        [JsonProperty("radius")]
        public List<string> Radius { get; set; }

        [JsonProperty("itemStyle")]
        public Dictionary<string, ItemStyle> ItemStyle { get; set; }

        [JsonProperty("areaStyle")]
        public AreaStyle AreaStyle { get; set; }

        [JsonProperty("smooth")]
        public bool? Smooth { get; set; }

        [JsonProperty("stack")]
        public string Stack { get; set; }

        [JsonProperty("label")]
        public LabelMap Label { get; set; }

        [JsonProperty("animation")]
        public bool? Animation { get; set; }

        [JsonProperty("lineStyle")]
        public LineStyle LineStyle { get; set; }

        [JsonProperty("markArea")]
        public MarkArea MarkArea { get; set; }

        [JsonProperty("yAxisIndex")]
        public int? YAxisIndex { get; set; }

        [JsonProperty("xAxisIndex")]
        public int? XAxisIndex { get; set; }

        [JsonProperty("labelLine")]
        public LabelLineMap LabelLine { get; set; }
    }

    public class LineStyle
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 线的类型。可选 'solid' 'dashed' 'dotted'
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// </summary>
        [JsonProperty("shadowBlur")]
        public string ShadowBlur { get; set; }

        /// <summary>
        /// 阴影颜色。支持的格式同color。
        /// </summary>
        [JsonProperty("shadowColor")]
        public string ShadowColor { get; set; }

        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// </summary>
        [JsonProperty("shadowOffsetX")]
        public int? ShadowOffsetX { get; set; }

        /// <summary>
        /// 阴影垂直方向上的偏移距离。
        /// </summary>
        [JsonProperty("shadowOffsetY")]
        public string ShadowOffsetY { get; set; }

        /// <summary>
        /// 图形透明度。支持从 0 到 1 的数字，为 0 时不绘制该图形。
        /// </summary>
        [JsonProperty("opacity")]
        public double Opacity { get; set; }
    }

    public class MarkArea
    {
        [JsonProperty("silent")]
        public bool? Silent { get; set; }

        [JsonProperty("data")]
        public List<MarkAreaData> Data { get; set; }

        [JsonProperty("label")]
        public Label Label { get; set; }

        [JsonProperty("itemStyle")]
        public ItemStyle ItemStyle { get; set; }

        [JsonProperty("emphasis")]
        public int? Emphasis { get; set; }

        [JsonProperty("animation")]
        public bool Animation { get; set; }

        [JsonProperty("animationThreashold")]
        public int? AnimationThreashold { get; set; }

        [JsonProperty("animationDuration")]
        public int? AnimationDuration { get; set; }

        [JsonProperty("animationEasing")]
        public string AnimationEasing { get; set; }

        [JsonProperty("animationDelay")]
        public int? AnimationDelay { get; set; }

        [JsonProperty("animationDurationUpdate")]
        public int? AnimationDurationUpdate { get; set; }

        [JsonProperty("animationEasingUpdate")]
        public string AnimationEasingUpdate { get; set; }

        [JsonProperty("animationDelayUpdate")]
        public int? AnimationDelayUpdate { get; set; }

    }

    public class MarkAreaData
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("valueIndex")]
        public int? ValueIndex { get; set; }

        [JsonProperty("valueDim")]
        public int? ValueDim { get; set; }

        [JsonProperty("coord")]
        public List<int> Coord { get; set; }

        [JsonProperty("x")]
        public int? X { get; set; }

        [JsonProperty("y")]
        public int? Y { get; set; }

        [JsonProperty("value")]
        public int? Value { get; set; }

        [JsonProperty("itemStyle")]
        public ItemStyle ItemStyle { get; set; }

        [JsonProperty("label")]
        public Label Label { get; set; }

        [JsonProperty("emphasis")]
        public Emphasis Emphasis { get; set; }
    }

    public class Emphasis
    {
        [JsonProperty("itemStyle")]
        public ItemStyle ItemStyle { get; set; }

        [JsonProperty("label")]
        public Label Label { get; set; }
    }
}
