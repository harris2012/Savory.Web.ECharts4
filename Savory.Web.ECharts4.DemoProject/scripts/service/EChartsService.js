function EChartsService($resource, $q) {

    var resource = $resource(null, {}, {
        getThem: {
            method: 'POST',
            url: '/EChartsHandler.ashx'
        }
    });

    return {
        getThem: function (id) {
            var d = $q.defer();
            resource.getThem({ id: id }, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        },
    }
}