function FirstExampleController($scope, EChartsDataService) {

    ;

    $.post('/EChartsOptionHandler.ashx', {}, function (option) {

        var myChart = echarts.init(document.getElementById('main'));

        EChartsDataService.firstexample().then(function (data) {

            option.legend.data = data.legendData;

            option.series = [{
                name: '访问来源',
                type: 'pie',
                radius: ['50%', '70%'],
                itemStyle: {
                    normal: { label: { show: false }, labelLine: { show: false } },
                    emphasis: { label: { show: true, position: 'center', textStyle: { fontSize: '30', fontWeight: 'bold' } } }
                },
                data: data.serieData
            }];

            console.log(JSON.stringify(option, null, 2));
            myChart.setOption(option);
        });
    });
}