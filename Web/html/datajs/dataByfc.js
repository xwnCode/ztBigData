var lc = [];
var dg = [];
var lcz = [];
var sd = [];

function Get() {
    //获取设备信息
    $.ajax({
        url: '../databyfc/GetDeviceRunInfByfc.ashx',
        async: false,
        type: 'post',
        data: {},
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            $("#jrclqd").html(data[0].by1);
            $("#jrclsd").html(data[0].by2);
            $("#dqsd").html(data[0].by3);
        },
        error: function (data) {
            return "";
        }
    });


    //获取图片数量
    $.ajax({
        url: '../databyfc/GetPictureNum.ashx',
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
        },
        error: function (data) {
            return "";
        }
    });

    //获取上传图片
    $.ajax({
        url: '../databyfc/GetPictureUp.ashx',
        async: false,
        type: 'post',
        //data: { operate: 'line' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            //alert(datas);
            for (var i = 0; i < data.length; i++) {
                if (data[i].type == 1) {
                    document.getElementById("zzop").src = data[i].img;
                }
                if (data[i].type == 2) {
                    document.getElementById("wbop").src = data[i].img;
                }
                if (data[i].type == 3) {
                    document.getElementById("dxop").src = data[i].img;
                }
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
        url: '../databyfc/GetGeometric.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bo' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
                    for (var i = 0; i < data.length; i++) {
                        lc.push(data[i].kiloMeter);
                        dg.push(data[i].hei1);
                        lcz.push(data[i].zig1);
                        sd.push(data[i].speed);
                    }
//            for (var i = data.length - 1; i >= 0; i--) {
//                lc.push(data[i].kiloMeter);
//                dg.push(data[i].hei1);
//                lcz.push(data[i].zig1);
//                sd.push(data[i].speed);
//            }
        },
        error: function (data) {
            return "";
        }
    });
}