var LODOP; //声明为全局变量 

function PrintDetail(htmlDetail, cssStyle, title, printStyle) {
    CreatePrintPage(htmlDetail, cssStyle, title, printStyle);
    LODOP.PREVIEW(); //打印预览

};


function CreatePrintPage(htmlDetail, cssStyle,title,printStyle) {
    LODOP = getLodop(document.getElementById('LODOP_OB'), document.getElementById('LODOP_EM'));
    // var css = "<link href=\"/themes/gray/easyui.css\" rel=\"stylesheet\" type=\"text/css\" />";
    var css = cssStyle;
    var strFormHtml = css + "<body>" + htmlDetail + " </body > ";

    LODOP.PRINT_INIT(title);
    LODOP.SET_PRINT_PAGESIZE(printStyle, 0, 0, "A4"); //A4纸张横向打印
    LODOP.SET_PRINT_STYLE("FontSize", 9);
    LODOP.ADD_PRINT_HTM("5%", "3%", "95%", "100%", strFormHtml); //四个数值分别表示Top,Left,Width,Height

}