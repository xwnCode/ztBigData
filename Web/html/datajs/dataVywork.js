xzdata = [];
yzdata = [];
zzdata = [];
/// <reference path="../../../databywork/GetDM_BUSI_ProduceQuantityByWork.ashx" />

$.ajax({
    url: '../../../databywork/GetDM_BUSI_ProduceQuantityByWork.ashx',
    async: false,
    type: 'post',
    data: { operate: 'bar' },
    dataType: 'json',
    success: function (data) {
        var datas = JSON.stringify(data);
        var total = 0;
        var yue = 1;
        for (var i = 0; i < data.length; i++) {
            var aaa = data[i].dates;
            for (yue; yue <= aaa; yue++) {
                if (aaa <= yue) {
                    total = total + data[i].total;
                    yzdata.push(total);
                    zzdata.push(data[i].plans);
                }
                else {
                    yzdata.push(0);
                    zzdata.push(0);
                }
            }
        }
        //        for (var i = 0; i < data.length; i++) {
        //            total = total + data[i].total;
        //            yzdata.push(total);
        //            zzdata.push(data[i].plans);
        //        }
    }
});
    


xyzdata = [];
yyzdata = [];
$.ajax({
    url: '../../../databywork/GetDM_BUSI_ProduceQuantityByWork.ashx',
    async: false,
    type: 'post',
    data: { operate: 'pie' },
    dataType: 'json',
    success: function (data) {
        var datas = JSON.stringify(data);
        var total;
        for (var i = 0; i < data.length; i++) {
            total = total + data[i].total;
        }
        xyzdata = [
                { value: data[0].plans, name: '当天' },
                { value: data[0].total, name: '开累' }
                ]

//        if (dayplan == null && daytotal == null) {
//            xyzdata = [
//                { value: 1, name: '当天' },
//                { value: 0, name: '开累' }
//                ]
//            
//        }
//        else {
//            xyzdata = [
//                { value: data[0].plans, name: '当天' },
//                { value: data[0].total, name: '开累' }
//                ]
//        }

    }
});