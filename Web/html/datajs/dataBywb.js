function arrayBufferToBase64(buffer) {
    var binary = '';
    var bytes = new Uint8Array(buffer);
    var len = bytes.byteLength;
    for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return window.btoa(binary);
}

//获取产品不合格数量
var xdata = [];
var ydata = [];

//获取月产量统计
var xzdata = [];
var yzdata = [];
var zzdata = [];

//获取今日产量统计
//var xyzdata = [];
var xyzdata;
var yyzdata;

//获取设备运行信息
var xwbdata = [];
var ywbdata = [];

function Get() {
    //获取设备信息
    $.ajax({
        url: '../databywb/GetDeviceFilesBywb.ashx',
        //async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
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


    //获取产品不合格数量
    //var xdata = [];
    //var ydata = [];
    xdata = [];
    ydata = [];
    $.ajax({
        url: '../databywb/GetDayProDetailsBywb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'line' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            for (var i = 0; i < data.length; i++) {
                //xdata.push(data[i].dates + "月");
                ydata.push(data[i].sum);
            }
        },
        error: function (data) {
            return "";
        }
    });

    //获取月产量统计
    //var xzdata = [];
    //var yzdata = [];
    //var zzdata = [];
    xzdata = [];
    yzdata = [];
    zzdata = [];
    $.ajax({
        url: '../databywb/GetDayProDetailsBywb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bar' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            var total = 0;
            for (var i = 0; i < data.length; i++) {
                //xzdata.push(data[i].dates + "月");
                //yzdata.push(data[i].total);
                total = total + data[i].total;
                yzdata.push(total);
                zzdata.push(data[i].plans);
            }
        },
        error: function (data) {
            return "";
        }
    });

    //获取今日产量统计
    //var xyzdata = 0;
    //var yyzdata;
    //xyzdata = [];
    xyzdata = 0;
    yyzdata;
    $.ajax({
        url: '../databywb/GetDayProDetailsBywb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'pie' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
                        if (data[0].plans != null) {
                            xyzdata = data[0].plans;

                        }
                        if (data[0].total != null) {
                                            yyzdata = data[0].total;
                        }
//            if (data[0].plans != null && data[0].total != null) {
//                xyzdata = [
//                { value: data[0].plans, name: '当天' },
//                { value: data[0].total, name: '开累' }
//                ]
//            }
        },
        error: function (data) {
            return "";
        }
    });


    //    //获取当前生产数据
    //    //var xyzdata;
    //    //var yyzdata;
    //    $.ajax({
    //        url: '../databywb/GetCurrProDataBywb.ashx',
    //        async: true,
    //        type: 'post',
    //        data: { oper: 'pipe' },
    //        dataType: 'json',
    //        success: function (data) {
    //            var datas = JSON.stringify(data);
    //            //alert(datas);
    //            var html = "";
    //            for (var i = 0; i < data.length; i++) {
    //                html += "<div class='message_scroll'><div class='quarter-div blue' style='width: 30%; height: 20%; float: left; text-align: center;color: White; background-image: url(img/pushmessage_class.png); background-size: 100%, 100%;background-repeat: no-repeat;'>切割</div>"
    //+ "<div class='quarter-div green' style='width: 70%; height: 20%; float: left; text-align: right;color: White; background-image: url(img/pushmessage_class.png); background-size: 100%, 100%; background-repeat: no-repeat;'> 安装中</div>"
    //+ "<div class='quarter-div orange' style='width: 30%; height: 80%; float: left; background-image: url(img/pushmessage_class.png);background-repeat: no-repeat; background-size: 100% 100%; -moz-background-size: 100% 100%;text-align: center;'><img src='img/images/pic_ico_03.png' /></div>"
    //+ "<div class='quarter-div yellow' style='width: 70%; height: 80%; float: left; background-image: url(img/pushmessage_class.png);background-repeat: no-repeat; background-size: 100% 100%; -moz-background-size: 100% 100%;'><div style='margin-top:15px;'><span style='color: White;width:80px;display:block;text-align: center;float: left;'>编号</span><span style='color: White;width:80px;float: left;display:block;text-align: center;'>管型</span><span style='color: White;width:80px;display:block;text-align: center;float: left;'>管长</span><span style='color: White;width:80px;display:block;text-align: center;float: left;'>时间</span><br /><span style='color: White;width:80px;display:block;text-align: center;float: left;'>" + data[i].PipeCutNumber + "</span><span style='color: White;width:80px;display:block;text-align: center;float: left;'>" + data[i].PipeCutType + "</span><span style='color: White;width:80px;display:block;text-align: center;float: left;'>" + data[i].PipeCutLength + "米</span><span style='color: White;width:80px;display:block;text-align: center;float: left;'>0.5分</span></div></div>"
    //+ "</div>";
    //            }
    //            $("#divs").append(html);
    //        },
    //        error: function (data) {
    //            return "";
    //        }
    //    });

    //获取设备运行信息
    //var xwbdata = [];
    //var ywbdata = [];
    xwbdata = [];
    ywbdata = [];
    $.ajax({
        url: '../databywb/GetDeviceRunInfBywb.ashx',
        async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#CutSpeed").html(data[0].CutSpeed);
            $("#AirTotalPre").html(data[0].AirTotalPre);

            xwbdata.push(data[0].CantilBrownCor.split('/')[1]);
            xwbdata.push(data[0].FlatBrownCor.split('/')[1]);
            xwbdata.push(data[0].ArrBrownCor.split('/')[1]);

            ywbdata.push(data[0].CantilBrownCor.split('/')[0]);
            ywbdata.push(data[0].FlatBrownCor.split('/')[0]);
            ywbdata.push(data[0].ArrBrownCor.split('/')[0]);
            //切割机
            if (data[0].CutRunStatus == 0) {
                document.getElementById("qgj").src = 'img/images/red.png';
             
            }
            if (data[0].CutRunStatus == 1) {
                document.getElementById("qgj").src = 'img/images/green.png';
            
            }
            if (data[0].CutRunStatus == 2) {
                document.getElementById("qgj").src = 'img/images/yellow.png';
               
            }
            //平腕臂
            if (data[0].FlatFixRunStatus == 0) {
                document.getElementById("pwb").src = 'img/images/red.png';
            }
            if (data[0].FlatFixRunStatus == 1) {
                document.getElementById("pwb").src = 'img/images/green.png';
            }
            if (data[0].FlatFixRunStatus == 2) {
                document.getElementById("pwb").src = 'img/images/yellow.png';
            }
            // 斜腕臂
            if (data[0].CantilArmRunStatus == 0) {
                document.getElementById("xwb").src = 'img/images/red.png';
            }
            if (data[0].CantilArmRunStatus == 1) {
                document.getElementById("xwb").src = 'img/images/green.png';
            }
            if (data[0].CantilArmRunStatus == 2) {
                document.getElementById("xwb").src = 'img/images/yellow.png';
            }
            // 出料口
            if (data[0].OutRunStatus == 0) {
                document.getElementById("clk").src = 'img/images/red.png';
            }
            if (data[0].OutRunStatus == 1) {
                document.getElementById("clk").src = 'img/images/green.png';
            }
            if (data[0].OutRunStatus == 2) {
                document.getElementById("clk").src = 'img/images/yellow.png';
            }
            // 气泵
            if (data[0].AirRunStatus == 0) {
                document.getElementById("qb").src = 'img/images/red.png';
            }
            if (data[0].AirRunStatus == 1) {
                document.getElementById("qb").src = 'img/images/green.png';
            }
            if (data[0].AirRunStatus == 2) {
                document.getElementById("qb").src = 'img/images/yellow.png';
            }
            //            xwbdata = [320, 302, 301];
            //            ywbdata = [120, 132, 101];
        },
        error: function (data) {
            return "";
        }
    });

    //获取当前生产数据  切割
    $.ajax({
        url: '../databywb/GetCurrProDataBywb.ashx',
        async: false,
        type: 'post',
        data: { oper: 'pipe' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#PipeCutNumber").html(data[0].PipeCutNumber);
            $("#PipeCutType").html(data[0].PipeCutType);
            $("#PipeCutLength").html(data[0].PipeCutLength + "米");
            $("#Deviceaddress").html(data[0].Deviceaddress);
            $("#cv").html(data[0].cv + "分");
            $("#PipeCutWorkMode").html(data[0].PipeCutWorkMode);
        },
        error: function (data) {
            return "";
        }
    });

    //获取当前生产数据 平腕臂安装
    $.ajax({
        url: '../databywb/GetCurrProDataBywb.ashx',
        async: false,
        type: 'post',
        data: { oper: 'flax' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#FlatFixNumber").html(data[0].FlatFixNumber);
            $("#cvs").html(data[0].cvs + "分");
            $("#FlatFixPosition").html(data[0].FlatFixPosition);

            $("#FlatFixEars").html(data[0].FlatFixEars);
            $("#FlatFixSeat").html(data[0].FlatFixSeat);
            $("#FlatFixSupport").html(data[0].FlatFixSupport);

            $("#FlatFixWorkMode").html(data[0].FlatFixWorkMode);
        },
        error: function (data) {
            return "";
        }
    });


    //获取当前生产数据 斜腕臂安装
    $.ajax({
        url: '../databywb/GetCurrProDataBywb.ashx',
        async: false,
        type: 'post',
        data: { oper: 'arm' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#CantilArmNumber").html(data[0].CantilArmNumber);
            $("#cvk").html(data[0].cvk + "分");
            $("#CantilArmSupport").html(data[0].CantilArmSupport);

            $("#CantilArmLocatingring").html(data[0].CantilArmLocatingring);
            $("#CantildArmSite").html(data[0].CantildArmSite);

            $("#CantilArmWorkMode").html(data[0].CantilArmWorkMode);
        },
        error: function (data) {
            return "";
        }
    });
}

function fun(s, t) {
    var startTime = new Date(s); // 开始时间
    var endTime = new Date(t); // 结束时间
    //console.log(endTime - startTime); // 毫秒数
    //console.log(Math.floor((endTime - startTime) / 1000)); // 秒数
    console.log(Math.floor((endTime - startTime) / 1000 / 60)); // 分钟
    //console.log(Math.floor((endTime - startTime) / 1000 / 60 / 60)); // 小时
    //console.log(Math.floor((endTime - startTime) / 1000 / 60 / 60 / 24)); // 天数
    var cv = Math.floor((endTime - startTime) / 1000 / 60);
    return cv;
}