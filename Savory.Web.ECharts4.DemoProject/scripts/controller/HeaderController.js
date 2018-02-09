function HeaderController($scope, EChartsService) {

    $scope.genData = function () {
        EChartsService.genData();
    }
}