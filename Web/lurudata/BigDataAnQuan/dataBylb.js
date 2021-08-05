function arrayBufferToBase64(buffer) {
    var binary = '';
    var bytes = new Uint8Array(buffer);
    var len = bytes.byteLength;
    for (var i = 0; i < len; i++) {
        binary += String.fromCharCode(bytes[i]);
    }
    return window.btoa(binary);
}

var html = "";
$.ajax({
    url: '../BigDataAnQuan/NewGetYhlb.ashx',
    async: false,
    type: 'post',
    data: { oper: "GetList" },
    dataType: 'json',
    success: function (data) {
        debugger;
        var datas = JSON.stringify(data);
        for (var i = 0; i < data.length; i++) {
            var src = 'data:image/png;base64,' + arrayBufferToBase64(data[i].image); //转换字符串 
            html += "<li class='carousel-item'><img src='" + src + "' /><div style='position: absolute; bottom: -35%; width:100%;text-align:center; '>" + data[i].name + "</div></li>";
        }
        alert(html);
        $("#chooseAreaspi").empty();
        $("#chooseAreaspi").append(html);
    },
    error: function (data) {
        return "";
    }
});