var route = function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when('', '/welcome').when('/', '/welcome');

    $stateProvider.state('echarts', {
        url: '/',
        views: {
            'header': {
                templateUrl: 'scripts/view/view_header.html?v=' + window.releaseNo,
                controller: HeaderController
            },
            'menu': {
                templateUrl: 'scripts/view/view_menu.html?v=' + window.releaseNo,
                controller: MenuController
            },
            '': {
                template: '<div class="container" ui-view></div>'
            }
        }
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