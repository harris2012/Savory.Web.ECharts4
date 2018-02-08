var app = angular.module('echarts', ['ngResource', 'ui.router']);

app.config(route);

app.service('EChartsDataService', ['$resource', '$q', EChartsDataService]);
app.service('EChartsOptionService', ['$resource', '$q', EChartsOptionService]);

app.controller(FirstExampleController);
app.controller(WelcomeController);
