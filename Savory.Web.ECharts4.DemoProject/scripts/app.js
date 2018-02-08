var app = angular.module('echarts', ['ngResource', 'ui.router']);

app.config(route);

app.service('EChartsService', ['$resource', '$q', EChartsService]);

app.controller(FirstExampleController);
app.controller(WelcomeController);
