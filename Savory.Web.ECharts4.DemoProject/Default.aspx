<%@ Page Language="C#" AutoEventWireup="true" %>


<!DOCTYPE html>

<html>
<head>
    <meta charset="utf-8" />
    <title>度假优惠券平台系统日报</title>
    <link href="https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" rel="stylesheet">
</head>
<body>
    <header class="navbar navbar-default navbar-static-top">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand">度假优惠券平台 - 系统日报</a>
            </div>
        </div>
    </header>
    <div class="container">
        <div id="main" style="width: 1000px; height: 800px;"></div>
    </div>

    <hr />

    <footer>
        <div class="container">
            <p>度假优惠平台</p>
        </div>
    </footer>

    <script src="https://cdn.bootcss.com/jquery/1.10.2/jquery.min.js"></script>
    <script src="https://cdn.bootcss.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdn.bootcss.com/echarts/4.0.2/echarts.min.js"></script>
    <script>

        $(function () {
            $.post('/EChartsHandler.ashx', {}, function (response) {

                var myChart = echarts.init(document.getElementById('main'));

                $.post("/LegendDataHandler.ashx", {}, function (legendData) {

                    response.legend.data = legendData;

                    $.post("/SeriesDataHandler.ashx", {}, function (seriesData) {

                        response.series = [{
                            name: '访问来源',
                            type: 'pie',
                            radius: ['50%', '70%'],
                            itemStyle: { normal: { label: { show: false }, labelLine: { show: false } }, emphasis: { label: { show: true, position: 'center', textStyle: { fontSize: '30', fontWeight: 'bold' } } } },
                            data: seriesData
                        }];

                        console.log(response);
                        console.log(JSON.stringify(response, null, 2));

                        myChart.setOption(response);
                    })
                });
            });
        });

    </script>
</body>
</html>
