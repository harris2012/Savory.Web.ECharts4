function ExampleController($scope, EChartsService, $state, $stateParams) {

    $scope.id = $stateParams.id;

    if ($scope.id == null || $scope.id.length == 0) {
        $state.go('echarts.welcome');
    }

    EChartsService.getThem($scope.id).then(function (option) {

        var myChart = echarts.init(document.getElementById('main'));

        myChart.setOption(option.toJSON());
    });
}