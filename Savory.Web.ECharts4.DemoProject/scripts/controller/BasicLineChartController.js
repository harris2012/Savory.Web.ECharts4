function BasicLineChartController($scope, EChartsService) {

    EChartsService.getOption('BasicLineChart').then(function (option) {

        EChartsService.getData('BasicLineChart').then(function (data) {

            option.xAxis = {
                type: 'category',
                data: ['Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat', 'Sun']
            };
            option.yAxis = {
                type: 'value'
            };
           option.series = [{
               data: [820, 932, 901, 934, 1290, 1330, 1320],
               type: 'line'
           }]

            //console.log(JSON.stringify(option, null, 2));

            var myChart = echarts.init(document.getElementById('main'));

            myChart.setOption(option.toJSON());
        });
    });
}