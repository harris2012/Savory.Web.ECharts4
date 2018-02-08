function FirstExampleController($scope) {
    $.post('/EChartsHandler.ashx', {}, function (response) {

        var myChart = echarts.init(document.getElementById('main'));

        $.post("/LegendDataHandler.ashx", {}, function (legendData) {

            response.legend.data = legendData;

            $.post("/SeriesDataHandler.ashx", {}, function (seriesData) {

                response.series = [{
                    name: '访问来源',
                    type: 'pie',
                    radius: ['50%', '70%'],
                    itemStyle: { normal: { label: { show: false }, labelLine: { show: false } }, emphasis: { label: { show: true, position: 'center', textStyle: { fontSize: '30', fontWeight: 'bold' } } } },
                    data: seriesData
                }];

                console.log(response);
                console.log(JSON.stringify(response, null, 2));

                myChart.setOption(response);
            })
        });
    });
}