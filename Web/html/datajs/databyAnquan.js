yhsldata1 = [];
yhsldata2 = [];
yhsldata3 = [];
yhsldata4 = [];

$.ajax({
    url: '../databyanquan/GetYhsl.ashx',
    async: false,
    type: 'post',
    data: { operate: 'bar' },
    dataType: 'json',
    success: function (data) {
        var datas = JSON.stringify(data);
        yhsldata1.push(data[0].YIJI);
        yhsldata2.push(data[0].ERJI);
        yhsldata3.push(data[0].SANJI);
        yhsldata4.push(data[0].SIJI);
    }
});

YIYUE = [];
ERYUE = [];
SANYUE = [];
SIYUE = [];
WUYUE = [];
LIUYUE = [];
QIYUE = [];
BAYUE = [];
JIUYUE = [];
SHIYUE = [];
SHIYIYUE = [];
SHIERYUE = [];

$.ajax({
    url: '../databyanquan/GetYhqs.ashx',
    async: false,
    type: 'post',
    data: { operate: 'bar' },
    dataType: 'json',
    success: function (data) {
        var datas = JSON.stringify(data);
        YIYUE.push(data[0].YIYUE);
        ERYUE.push(data[0].ERYUE);
        SANYUE.push(data[0].SANYUE);
        SIYUE.push(data[0].SIYUE);
        WUYUE.push(data[0].WUYUE);
        LIUYUE.push(data[0].LIUYUE);
        QIYUE.push(data[0].QIYUE);
        BAYUE.push(data[0].BAYUE);
        JIUYUE.push(data[0].JIUYUE);
        SHIYUE.push(data[0].SHIYUE);
        SHIYIYUE.push(data[0].SHIYIYUE);
        SHIERYUE.push(data[0].SHIERYUE);
    }
});