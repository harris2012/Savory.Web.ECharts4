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

    //测试页面
    $stateProvider.state('echarts.example', {
        url: 'example/:id',
        templateUrl: 'scripts/view/view_example.html?v=' + window.version,
        controller: ExampleController
    });
}