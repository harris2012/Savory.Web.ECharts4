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
    <script src="https://cdn.bootcss.com/echarts/2.2.7/echarts-all.js"></script>
    <script>

        $(function () {
            $.post('/EChartsHandler.ashx', {}, function (response) {

                var myChart = echarts.init(document.getElementById('main'));

                function genData() {
                    var legendData = [];
                    var seriesData = [];

                    legendData.push('成功'); seriesData.push({ name: '成功', value: 10503 });
                    legendData.push('[优惠平台]优惠券已使用'); seriesData.push({ name: '[优惠平台]优惠券已使用', value: 212 });
                    legendData.push('[度假]优惠券在当前订单没有匹配的阶梯'); seriesData.push({ name: '[度假]优惠券在当前订单没有匹配的阶梯', value: 201 });
                    legendData.push('[度假]该产品不可以使用该优惠券'); seriesData.push({ name: '[度假]该产品不可以使用该优惠券', value: 170 });
                    legendData.push('[优惠平台]使用次数超过策略允许最大值'); seriesData.push({ name: '[优惠平台]使用次数超过策略允许最大值', value: 107 });
                    legendData.push('[度假]订单原始金额(orderAmount)必须是正数'); seriesData.push({ name: '[度假]订单原始金额(orderAmount)必须是正数', value: 97 });
                    legendData.push('[优惠平台]优惠券不存在'); seriesData.push({ name: '[优惠平台]优惠券不存在', value: 58 });
                    legendData.push('[优惠平台]风控屏蔽！'); seriesData.push({ name: '[优惠平台]风控屏蔽！', value: 38 });
                    legendData.push('[优惠平台]产线ID与策略不匹配'); seriesData.push({ name: '[优惠平台]产线ID与策略不匹配', value: 24 });
                    legendData.push('[度假]优惠券在当前平台(platformId)不可用'); seriesData.push({ name: '[度假]优惠券在当前平台(platformId)不可用', value: 22 });
                    legendData.push('[优惠平台]优惠券所属适用站点不匹配'); seriesData.push({ name: '[优惠平台]优惠券所属适用站点不匹配', value: 19 });
                    legendData.push('[度假]优惠券在当前渠道不可用'); seriesData.push({ name: '[度假]优惠券在当前渠道不可用', value: 17 });
                    legendData.push('[优惠平台]该限时优惠券已被其他用户收藏'); seriesData.push({ name: '[优惠平台]该限时优惠券已被其他用户收藏', value: 12 });
                    legendData.push('[优惠平台]券码不合法'); seriesData.push({ name: '[优惠平台]券码不合法', value: 5 });
                    legendData.push('[度假]用户信息(UserInfo)必传'); seriesData.push({ name: '[度假]用户信息(UserInfo)必传', value: 3 });
                    legendData.push('[度假]这张订单想要优惠的金额太多了'); seriesData.push({ name: '[度假]这张订单想要优惠的金额太多了', value: 3 });
                    legendData.push('[度假]优惠券没有被设置'); seriesData.push({ name: '[度假]优惠券没有被设置', value: 2 });
                    legendData.push('[优惠平台]优惠券已经失效'); seriesData.push({ name: '[优惠平台]优惠券已经失效', value: 1 });
                    legendData.push('[优惠平台]活动已经结束了'); seriesData.push({ name: '[优惠平台]活动已经结束了', value: 1 });

                    return { legendData: legendData, seriesData: seriesData };
                }

                var data = genData();
                response.legend.data = data.legendData;
                response.series = [
                        {
                            name: '访问来源',
                            type: 'pie',
                            radius: ['50%', '70%'],
                            itemStyle: { normal: { label: { show: false }, labelLine: { show: false } }, emphasis: { label: { show: true, position: 'center', textStyle: { fontSize: '30', fontWeight: 'bold' } } } },
                            data: data.seriesData
                        }
                ];

                myChart.setOption(response);
            });
        });

    </script>
</body>
</html>
