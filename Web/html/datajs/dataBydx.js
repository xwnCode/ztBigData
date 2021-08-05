function arrayBufferToBase64(buffer) {
    var binary = '';
    var bytes = new Uint8Array(buffer);
    var len = bytes.byteLength;
    for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return window.btoa(binary);
}

//获取产品合格数量
var xdata = [];
var ydata = [];

//获取周产量统计
var xzdata = [];
var yzdata = [];
var zzdata = [];

//获取今日产量统计
var xyzdata;
var yyzdata;
var zzzdata = [];

//获取设备运行信息
var xdxdata = [];
var ydxdata = [];

function Get() {
    //获取设备信息
    $.ajax({
        url: '../databydx/GetDeviceFilesBydx.ashx',
        //async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#Devicename").html(data[0].Devicename);
            $("#Charger").html(data[0].Charger);
            $("#Phone").html(data[0].Phone);
            $("#Deviceaddress").html(data[0].Deviceaddress);

            var str12 = arrayBufferToBase64(data[0].Devicepicture); //转换字符串
            console.log(str12);
            document.getElementById("imageqse").src = 'data:image/png;base64,' + str12;
        },
        error: function (data) {
            return "";
        }
    });


    //获取产品合格数量
    //    var xdata = [];
    //    var ydata = [];
         xdata = [];
         ydata = [];
    $.ajax({
        url: '../databydx/GetDayProDetailsBydx.ashx',
        async: false,
        type: 'post',
        data: { operate: 'line' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            for (var i = 0; i < data.length; i++) {
                //xdata.push(data[i].dates + "月");
                if (data[i].total == 0) {
                    ydata.push(0)
                } else {
                    ydata.push((data[i].qualified / data[i].total * 100).toFixed(2));
                }
            }
        },
        error: function (data) {
            return "";
        }
    });

    //获取周产量统计
    //    var xzdata = [];
    //    var yzdata = [];
    //    var zzdata = [];
         xzdata = [];
         yzdata = [];
         zzdata = [];
    $.ajax({
        url: '../databydx/GetDayProDetailsBydx.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bar' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            for (var i = 0; i < data.length; i++) {
                //xzdata.push("周" + data[i].dates);
                yzdata.push(data[i].plans);
                zzdata.push(data[i].total);
            }
        },
        error: function (data) {
            return "";
        }
    });

    //获取今日产量统计
    //    var xyzdata;
    //    var yyzdata;
    //    var zzzdata = [];
         xyzdata;
         yyzdata;
         zzzdata = [];
    $.ajax({
        url: '../databydx/GetDayProDetailsBydx.ashx',
        async: false,
        type: 'post',
        data: { operate: 'pie' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            if (data.length != 0 && data[0].plans != null) {
                xyzdata = data[0].plans;
                yyzdata = data[0].total;
                zzzdata.push({ value: data[0].total });
                zzzdata.push({ value: data[0].plans - data[0].total });
                zzzdata.push({ value: data[0].plans / 3 });
            }
        },
        error: function (data) {
            return "";
        }
    });


    //获取设备运行信息
    //    var xdxdata = [];
    //    var ydxdata = [];
         xdxdata = [];
         ydxdata = [];
    $.ajax({
        url: '../databydx/GetDeviceRunInfBydx.ashx',
        async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);

//            xdxdata.push(data[0].TotalLenofcopwire - data[0].RemainLenofcopwire);
//            xdxdata.push(data[0].TotalNumofRinghop - data[0].RemainNumofRinghop);
//            xdxdata.push(data[0].TotalNumofPipehop - data[0].RemainNumofPipehop);
            //            xdxdata.push(data[0].TotalNumofNosehop - data[0].RemainNumofNosehop);

            xdxdata.push(data[0].TotalLenofcopwire);
            xdxdata.push(data[0].TotalNumofRinghop);
            xdxdata.push(data[0].TotalNumofPipehop);
            xdxdata.push(data[0].TotalNumofNosehop);

            ydxdata.push(data[0].RemainLenofcopwire);
            ydxdata.push(data[0].RemainNumofRinghop);
            ydxdata.push(data[0].RemainNumofPipehop);
            ydxdata.push(data[0].RemainNumofNosehop);
        },
        error: function (data) {
            return "";
        }
    });


    //当前生产吊玄信息
    $.ajax({
        url: '../databydx/GetCurrProDataBydx.ashx',
        async: false,
        type: 'post',
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);

            $("#CrossSecNum").html(data[0].CrossSecNum);
            $("#CurProLenofdrop").html(data[0].CurProLenofdrop);
            $("#TorqueValue").html(data[0].TorqueValue);
            $("#TwistedLineSpecs").html(data[0].TwistedLineSpecs);
            $("#PresPipeSpecs").html(data[0].PresPipeSpecs);
            $("#ThimbleSpecs").html(data[0].ThimbleSpecs);
            $("#CopNoseSpecs").html(data[0].CopNoseSpecs);
        },
        error: function (data) {
            return "";
        }
    });
}