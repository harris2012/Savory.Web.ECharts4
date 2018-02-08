var route = function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when('', '/welcome').when('/', '/welcome');

    $stateProvider.state('echarts', {
        url: '/',
        template: '<div class="container" ui-view></div>'
    });

    //欢迎页
    $stateProvider.state('echarts.welcome', {
        url: 'welcome',
        templateUrl: 'scripts/view/view_welcome.html?v=' + window.version,
        controller: WelcomeController
    });

    //第一个示例程序
    $stateProvider.state('echarts.firstexample', {
        url: 'firstexample',
        templateUrl: 'scripts/view/view_firstexample.html?v=' + window.version,
        controller: FirstExampleController
    });

    // 1. Basic Line Chart
    // http://echarts.baidu.com/examples/editor.html?c=line-simple
    $stateProvider.state('echarts.BasicLineChart', {
        url: 'BasicLineChart',
        templateUrl: 'scripts/view/view_BasicLineChart.html?v=' + window.version,
        controller: BasicLineChartController
    });
    
}