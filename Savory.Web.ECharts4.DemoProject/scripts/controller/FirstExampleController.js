function FirstExampleController($scope, EChartsService) {

    EChartsService.getThem('firstexample').then(function (option) {

        console.log(JSON.stringify(option, null, 2));

        var myChart = echarts.init(document.getElementById('main'));

        myChart.setOption(option.toJSON());
    });
}