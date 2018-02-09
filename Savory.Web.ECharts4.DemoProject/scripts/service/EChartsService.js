function EChartsService($resource, $q) {

    var resource = $resource(null, {}, {
        getThem: {
            method: 'POST',
            url: '/EChartsHandler.ashx'
        },
        getExamples: {
            method: 'POST',
            url: '/ExamplesHandler.ashx',
            isArray: true
        },
        genData: {
            method: 'POST',
            url: '/OutputHandler.ashx'
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
        getExamples: function () {
            var d = $q.defer();
            resource.getExamples({}, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        },
        genData: function () {
            var d = $q.defer();
            resource.genData({}, null, function (result) {
                d.resolve(result);
            }, function (result) {
                d.reject(result);
            });
            return d.promise;
        }
    }
}