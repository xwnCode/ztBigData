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
        document.getElementById("imageqse").src = 'data:image/png;base64,'+data[0].img;
        document.getElementById("imageqses").src = 'data:image/png;base64,'+data[1].img;
    },
    error: function (data) {
        return "";
    }
});