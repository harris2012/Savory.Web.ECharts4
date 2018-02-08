function EChartsOptionService($resource, $q) {

    var resource = $resource("/EChartsOptionHandler.ashx");

    return {
        firstexample: function () {
            var d = $q.defer();
            resource.save({ id: 'firstexample' }, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        }
    }
}