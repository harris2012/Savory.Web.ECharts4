var route = function ($stateProvider, $urlRouterProvider) {

    $urlRouterProvider.when('', '/welcome').when('/', '/welcome');

    $stateProvider.state('echarts', {
        url: '/',
        template: '<div class="container" ui-view></div>'
    });

    $stateProvider.state('echarts.welcome', {
        url: 'welcome',
        templateUrl: 'scripts/view/view_welcome.html?v=' + window.version,
        controller: WelcomeController
    });

    //单词详情页
    $stateProvider.state('echarts.firstexample', {
        url: 'firstexample',
        templateUrl: 'scripts/view/view_firstexample.html?v=' + window.version,
        controller: FirstExampleController
    });
}