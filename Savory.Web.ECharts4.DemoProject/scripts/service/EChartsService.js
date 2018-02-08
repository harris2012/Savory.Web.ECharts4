function EChartsService($resource, $q) {

    var resource = $resource(null, {}, {
        getData: {
            method: 'POST',
            url: '/EChartsDataHandler.ashx'
        },
        getOption: {
            method: 'POST',
            url: '/EChartsOptionHandler.ashx'
        }
    });

    return {
        getData: function (id) {
            var d = $q.defer();
            resource.getData({ id: id }, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        },
        getOption: function (id) {
            var d = $q.defer();
            resource.getOption({ id: id }, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        },
    }
}