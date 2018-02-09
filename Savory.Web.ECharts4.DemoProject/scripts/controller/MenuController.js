function MenuController($scope, EChartsService) {

    EChartsService.getExamples().then(function (response) {

        $scope.examples = response;
    });
}