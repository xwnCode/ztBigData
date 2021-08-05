var lc = [];
var dg = [];
var lcz = [];
var sd = [];

function Get() {


    //获取设备信息
    $.ajax({
        url: '../databyzn/GetDeviceRunInfByzn.ashx',
        async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#jrclqd").html(data[0].by1);
            $("#jrclsd").html(data[0].by2);
            $("#remainCapacity").html(data[0].by3);
            $("#remainTime").html(data[0].by4);
        },
        error: function (data) {
            return "";
        }
    });


    //获取图片数量
    $.ajax({
        url: '../databyzn/GetPictureNum.ashx',
        async: false,
        type: 'post',
        //data: { operate: 'line' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            for (var i = 0; i < data.length; i++) {
                if (data[i].type == 1) {
                    $("#zzp").html(data[i].shootNum);
                }
                if (data[i].type == 2) {
                    $("#wbp").html(data[i].shootNum);
                }
                if (data[i].type == 3) {
                    $("#dxp").html(data[i].shootNum);
                }
            }
            //        if (data[0].type == 1) {
            //            $("#zzp").html(data[0].shootNum);
            //        }
            //        if (data[0].type == 2) {
            //            $("#wbp").html(data[0].shootNum);
            //        }
            //        if (data[0].type == 3) {
            //            $("#dxp").html(data[0].shootNum);
            //        }
        },
        error: function (data) {
            return "";
        }
    });

    //获取上传图片
    $.ajax({
        url: '../databyzn/GetPictureUp.ashx',
        async: false,
        type: 'post',
        //data: { operate: 'line' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            if (data.length == 1) {
                document.getElementById("imageqse").src = 'data:image/png;base64,' + data[0].img;
            } 
            if (data.length == 2) {
                document.getElementById("imageqse").src = 'data:image/png;base64,' + data[0].img;
                document.getElementById("imageqses").src = 'data:image/png;base64,' + data[1].img;
            }
        },
        error: function (data) {
            return "";
        }
    });


    lc = [];
    dg = [];
    lcz = [];
    sd = [];
    //波形图
    $.ajax({
        url: '../databyzn/GetGeometric.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bo' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);

//            for (var i = data.length - 1; i >= 0; i--) {
//                lc.push(data[i].moveDistance);
//                dg.push(data[i].hei1);
//                lcz.push(data[i].zig1);
//                sd.push(data[i].speed);
            //            }

            for (var i = 0; i < data.length ; i++) {
                lc.push(data[i].moveDistance);
                dg.push(data[i].hei1);
                lcz.push(data[i].zig1);
                sd.push(data[i].speed);
            }
        },
        error: function (data) {
            return "";
        }
    });
}