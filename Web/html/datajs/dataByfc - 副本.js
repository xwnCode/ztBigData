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
        if (data[0].type==1) {
            $("#zzp").html(data[0].shootNum);
        }
        if (data[0].type == 2) {
            $("#wbp").html(data[0].shootNum);
        }
        if (data[0].type == 3) {
            $("#dxp").html(data[0].shootNum);
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
        document.getElementById("imageqse").src = data[0].img;
    },
    error: function (data) {
        return "";
    }
});