var chartData = generateChartData();
var chart = AmCharts.makeChart("chartdiv", {
    "type": "serial",
    "theme": "light",
    "marginRight": 80,
    "autoMarginOffset": 20,
    "marginTop": 7,
    "dataProvider": chartData,
    "valueAxes": [{
        "axisAlpha": 0.2,
        "dashLength": 1,
        "position": "left"
    }],
    "mouseWheelZoomEnabled": true,
    "graphs": [{
        "id": "g1",
        "balloonText": "[[value]]",
        "bullet": "round",
        "bulletBorderAlpha": 1,
        "bulletColor": "#FFFFFF",
        "hideBulletsCount": 50,
        "title": "red line",
        "valueField": "visits",
        "useLineColorForBulletBorder": true,
        "balloon": {
            "drop": true
        }
    }],
    "chartScrollbar": {
        "autoGridCount": true,
        "graph": "g1",
        "scrollbarHeight": 40
    },
    "chartCursor": {
        "limitToGraph": "g1"
    },
    "categoryField": "date",
    "categoryAxis": {
        "parseDates": true,
        "axisColor": "#DADADA",
        "dashLength": 1,
        "minorGridEnabled": true
    },
    "export": {
        "enabled": true
    }
});
chart.addListener("rendered", zoomChart);
zoomChart();

function zoomChart() {
    chart.zoomToIndexes(chartData.length - 40, chartData.length - 1);
}
function generateChartData() {
    var chartData = [];
    var firstDate = new Date();
    firstDate.setDate(firstDate.getDate() - 5);
    var visits = 1200;
    for (var i = 0; i < 1000; i++) {
        var newDate = new Date(firstDate);
        newDate.setDate(newDate.getDate() + i);
        visits += Math.round((Math.random() < 0.5 ? 1 : -1) * Math.random() * 10);
        chartData.push({
            date: newDate,
            visits: visits
        });
    }
    return chartData;
}

var chart = AmCharts.makeChart("chart-revenue-day", {
    "theme": "none",
    "type": "serial",
    "startDuration": 2,
    "dataProvider": [{
        "country": "01/01/2018",
        "visits": 4025,
        "color": "#FF0F00"
    }, {
        "country": "02/01/2018",
        "visits": 1882,
        "color": "#FF6600"
    }, {
        "country": "04/01/2018",
        "visits": 1809,
        "color": "#FF9E01"
    }, {
        "country": "05/01/2018",
        "visits": 1322,
        "color": "#FCD202"
    }, {
        "country": "06/01/2018",
        "visits": 1122,
        "color": "#F8FF01"
    }, {
        "country": "07/01/2018",
        "visits": 1114,
        "color": "#B0DE09"
    }, {
        "country": "08/01/2018",
        "visits": 984,
        "color": "#04D215"
    }, {
        "country": "09/01/2018",
        "visits": 711,
        "color": "#0D8ECF"
    }, {
        "country": "10/01/2018",
        "visits": 665,
        "color": "#0D52D1"
    }, {
        "country": "11/01/2018",
        "visits": 580,
        "color": "#2A0CD0"
    }, {
        "country": "12/01/2018",
        "visits": 443,
        "color": "#8A0CCF"
    }, {
        "country": "13/01/2018",
        "visits": 441,
        "color": "#CD0D74"
    }, {
        "country": "14/01/2018",
        "visits": 395,
        "color": "#754DEB"
    }, {
        "country": "15/01/2018",
        "visits": 386,
        "color": "#DDDDDD"
    }, {
        "country": "16/01/2018",
        "visits": 328,
        "color": "#000000"
    }],
    "valueAxes": [{
        "position": "left",
        "title": "Visitors"
    }],
    "graphs": [{
        "balloonText": "[[category]]: <b>[[value]]</b>",
        "fillColorsField": "color",
        "fillAlphas": 1,
        "lineAlpha": 0.1,
        "type": "column",
        "valueField": "visits"
    }],
    "depth3D": 20,
    "angle": 30,
    "chartCursor": {
        "categoryBalloonEnabled": false,
        "cursorAlpha": 0,
        "zoomable": false
    },
    "categoryField": "country",
    "categoryAxis": {
        "gridPosition": "start",
        "labelRotation": 90
    },
    "export": {
        "enabled": true
    }

});