function arrayBufferToBase64(buffer) {
    var binary = '';
    var bytes = new Uint8Array(buffer);
    var len = bytes.byteLength;
    for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return window.btoa(binary);
}

//合同占比
var xdata = [];

//各类合同金额
var xxdata = [];

//各季度责任成本和实际成本对比图
var xxxdata = [];
var yyydata = [];
var zzzdata = [];

//各类费用占比
var danqidata;
var kaileidata;
var danqia;
var kailei;

//责任成本节超率
var zrcbjcl;
var zrcbjcldata;

function Get() {

    //合同金额
    var html = "";
    $.ajax({
        url: '../databycb/GetAgreementBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'sum' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0 && data[0].htje != null) {
                if (String(data[0].htje).split('.').length == 1) {
                    var data1 = String(data[0].htje).split('.')[0];
                    for (var i = 0; i < data1.length; i++) {
                        html += "<li class='data_cage' style='width: 15%'>" + data1.charAt(i) + "</li>";
                    }
                    html += "<li style='float: left; color: White; margin-top: 15%'>万元</li>";
                }
                if (String(data[0].htje).split('.').length == 2) {
                    var data1 = String(data[0].htje).split('.')[0];
                    for (var i = 0; i < data1.length; i++) {
                        html += "<li class='data_cage' style='width: 15%'>" + data1.charAt(i) + "</li>";
                    }
                    html += "<li class='data_cage' style='background-image: none;'>.</li>";
                    var data2 = String(data[0].htje).split('.')[1];
                    for (var i = 0; i < data2.length; i++) {
                        html += "<li class='data_cage' style='width: 15%'>" + data2.charAt(i) + "</li>";
                    }
                    html += "<li style='float: left; color: White; margin-top: 15%'>万元</li>";
                }
            }
            $("#htje").html(html);
        },
        error: function (data) {
            return "";
        }
    });

    //合同占比
    xdata = [];
    $.ajax({
        url: '../databycb/GetAgreementBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bar' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);

            if (data.length>0) {
                xdata.push({ value: data[0].zhtje, name: '主合同金额' });
                xdata.push({ value: data[0].bchtje, name: '补充合同金额' });
            }
        },
        error: function (data) {
            return "";
        }
    });


    //各类合同金额
    xxdata = [];
    $.ajax({
        url: '../databycb/GetAgreementBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bars' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                xxdata.push(data[0].jxzlhtje); xxdata.push(data[0].wzhtje); xxdata.push(data[0].zyfbhtje); xxdata.push(data[0].lwfbhtje);
            }
        },
        error: function (data) {
            return "";
        }
    });

    //各季度责任成本和实际成本对比图
    xxxdata = [];
    yyydata = [];
    zzzdata = [];
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'bar' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                for (var i = 0; i < data.length; i++) {
                    xxxdata.push(data[i].year + "年第" + data[i].quarter + "季度");
                    yyydata.push(data[i].zrcb);
                    zzzdata.push(data[i].sjcb);
                } 
            }
        },
        error: function (data) {
            return "";
        }
    });

    //各类费用占比
    danqidata = [];
    kaileidata = [];
    danqia;
    kailei;
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'kailei' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                kailei = data[0].zl;
                kaileidata.push({ value: data[0].xcjf, name: '现场缴费' });
                kaileidata.push({ value: data[0].zyfbf, name: '专业分包费' });
                kaileidata.push({ value: data[0].jxf, name: '机械费' });
                kaileidata.push({ value: data[0].rgf, name: '人工费' });
                kaileidata.push({ value: data[0].clf, name: '材料费' });
            }
        },
        error: function (data) {
            return "";
        }
    });
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: 'danqi' },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                danqia = data[0].zl;
                danqidata.push({ value: data[0].xcjf, name: '现场缴费' });
                danqidata.push({ value: data[0].zyfbf, name: '专业分包费' });
                danqidata.push({ value: data[0].jxf, name: '机械费' });
                danqidata.push({ value: data[0].rgf, name: '人工费' });
                danqidata.push({ value: data[0].clf, name: '材料费' });
            }
        },
        error: function (data) {
            return "";
        }
    });


    //验工计价
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: "dq" },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                $("#dqygjj").html(data[0].dq);
            }
        },
        error: function (data) {
            return "";
        }
    });
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: "kl" },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                $("#klygjj").html(data[0].kl);
            }
        },
        error: function (data) {
            return "";
        }
    });



    //责任成本节超率
    zrcbjcl;
    zrcbjcldata = [];
    $.ajax({
        url: '../databycb/GetInspectionBycb.ashx',
        async: false,
        type: 'post',
        data: { operate: "zrcbjcl" },
        dataType: 'json',
        success: function (data) {
            var datas = JSON.stringify(data);
            if (data.length > 0) {
                zrcbjcl = (data[0].zrcb / data[0].sjcb * 100).toFixed(0)+"%";
                zrcbjcldata.push({ value: data[0].zrcb, name: '责任成本' });
                zrcbjcldata.push({ value: data[0].sjcb, name: '实际成本' });
            }
        },
        error: function (data) {
            return "";
        }
    });

}