<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="IndexBySuperAdminManage.aspx.cs"
    Inherits="Vline.Web.lurudata.IndexBySuperAdminManage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <title>主页</title>
    
	<link rel="stylesheet" type="text/css" href="TLMessage/fonts/iconfont.css">
    <link rel="stylesheet" type="text/css" href="TLMessage/css/frameStyle.css">
    <script src="TLMessage/demo/js/jquery.min.js" type="text/javascript"></script>
    <script src="TLMessage/demo/js/jquery.easyui.min.js" type="text/javascript"></script>
    <link href="TLMessage/demo/css/default.css" rel="stylesheet" type="text/css" />
    <link href="TLMessage/demo/themes/default/easyui.css" rel="stylesheet" type="text/css" />
    <link href="TLMessage/demo/themes/icon.css" rel="stylesheet" type="text/css" />

    <script src="TLMessage/demo/js/jquery.easyui.min.js" type="text/javascript"></script>
    
    <link href="TLMessage/demo/css/grid.css" rel="stylesheet" type="text/css" />
    <link href="TLMessage/demo/css/layout.css" rel="stylesheet" type="text/css" />
    <link href="TLMessage/demo/css/nav.css" rel="stylesheet" type="text/css" />
    <!--[if IE 6]><link rel="stylesheet" type="text/css" href="css/ie6.css" media="screen" /><![endif]-->
    <!--[if IE 7]><link rel="stylesheet" type="text/css" href="css/ie.css" media="screen" /><![endif]-->
    <!-- BEGIN: load jquery -->
    <script src="JSMap/js/layer_v2.1/layer/layer.js" type="text/javascript"></script>
    <script src="TLMessage/demo/js/jquery-1.6.4.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="TLMessage/demo/js/jquery-ui/jquery.ui.core.min.js"></script>
    <script src="TLMessage/demo/js/jquery-ui/jquery.ui.widget.min.js" type="text/javascript"></script>
    <script src="TLMessage/demo/js/jquery-ui/jquery.ui.accordion.min.js" type="text/javascript"></script>
    <script src="TLMessage/demo/js/jquery-ui/jquery.effects.core.min.js" type="text/javascript"></script>
    <script src="TLMessage/demo/js/jquery-ui/jquery.effects.slide.min.js" type="text/javascript"></script>
  10  <!-- END: load jquery -->
 
    <script src="TLMessage/demo/js/setup.js" type="text/javascript"></script>
    <link href="Left/Left.css" rel="stylesheet" type="text/css" />
    <script src="Left/index.js" type="text/javascript"></script>
    
    <style type="text/css">
        i.right {
        float: right;
        color: #373d41;
        font-size: 16px;
    </style>


    <script type="text/javascript">
        $(document).ready(function () {
            // setupDashboardChart('chart1');
            setupLeftMenu();
            setSidebarHeight();
            //            $("#iframeContent").load(function () {

            $("#iframeContent").load(function () {

                $("#iframeContent").height(0); //用于每次刷新时控制IFRAME高度初始化 
                var height = $(this).contents().height() + 20;

                $("#iframeContent").height(height < 766 ? 766 : height);
            });
            // });
        });
        </script>
</head>
<body style="font-size: 12px; background-color: #2E5E79" class="easyui-layout container_12">
    <div data-options="region:'north'" style="height: 119px; background-color: #2E5E79">
        <div class="grid_12 header-repeat" style="height: 73px">
            <div id="branding">
                <div class="floatleft">
                    <span style="font-size: 16.0pt; color: White; font-weight: bold">中铁武汉电气化局智能调度指挥系统</span></div>
                
                <div class="clear">
                </div>
            </div>
        </div>
        <div class="clear">
        </div>
        <div class="grid_12">
            <ul class="nav main">
                <li class="ic-dashboard"><a href="IndexBySuperAdminManage.aspx"><span>主页</span></a>
                </li>
              
            </ul>
        </div>
        <div class="copyrights">
            Collect from <a href="http://www.vline.net.cn/" title="合肥未来">合肥未来</a></div>
        <div class="clear">
        </div>
    </div>
    <div  data-options="region:'west',split:true" title="我的导航" style="width: 180px">
        <div class="grid_21">
            <div class="box sidemenu">
                <div class="block" id="section-menu">
                    <ul class="section menu">

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >作业任务<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataZH/NewZHZYPTSubmit.htm?t=20181225')">钻孔作业任务下发</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataZH/LBSYSubmit.htm?t=20181225')">拉拔试验任务下发</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataZH/WBDXSubmit.htm?t=20181225')">腕臂和吊悬任务下发</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataZH/Sgtj.htm?t=20181225')">施工统计</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >安全质量<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataAnQuan/NewYhsl.htm?t=20181225')">各级别隐患数量</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataAnQuan/NewYhqs.htm?t=20181225')">隐患排查数量趋势</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataAnQuan/NewYhgs.htm?t=20181225')">常发隐患公示</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataAnQuan/NewYhsj.htm?t=20181225')">隐患大数据</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataAnQuan/NewYhlb.htm?t=20181225')">隐患排查列表</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >物资<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Dhqk.htm?t=20181225')">到货情况</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Bxbl.htm?t=20181225')">报险比例</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Cght.htm?t=20181225')">各专业物资采购合同情况</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Wzsj.htm?t=20181225')">物资数据</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Llqk.htm?t=20181225')">作业队领料情况</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Jqwzyj.htm?t=20181225')">急缺物资预警</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('BigDataWuZi/Jcwz.htm?t=20181225')">近7日进场物资</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >成本<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbycb/AgreementBycb.htm?t=20181225')">合同及责任成本预算情况</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbycb/InspectionBycb.htm?t=20181225')">项目验工计价、实际成本及责任成本</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >进度<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbyjd/BigPhyWorkByjd.htm?t=20181225')">实物工程量</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbyjd/ConSitePictByjdList.htm?t=20181225')">施工现场进度图</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbyjd/OutputValueByjd.htm?t=20181225')">计划产量及已完产量</a> </li>
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/czbyjd/TodayPlanByjd.htm?t=20181225')">今日施工安排</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >吊悬<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/diaoxuanAdd.htm?t=20181225')">吊悬</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >腕臂<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a onclick="UrlRedict('../html/wanbiAdd.htm?t=20181225')">腕臂</a> </li>
                            </ul>
                        </li>

                        <li class="first">
                            <div class="d-firstNav s-firstNav clearfix">
                                <i class="fa fa-bars"></i><a class="menuitem" >大数据展示平台<i class="iconfont icon-iconfonti right"></i></a> 
                            </div>
                            <ul class="d-firstDrop s-firstDrop">
                                <li class="s-secondItem"><a href="../html/work.html"  target="_blank">大数据展示平台</a> </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </div>

    </div>
    <div data-options="region:'center',iconCls:'icon-ok'" title="">
        <%--<iframe id="iframeContent"   style=" border:0;" class="grid_101"  src="IndexBySuperAdminIframe.aspx"></iframe>--%>
        <iframe id="iframeContent"   style=" border:0;" class="grid_101"  src="BigDataWuZi/Dhqk.htm?t=20181225"></iframe>
    </div>
    <script type="text/javascript">
        
    </script>
</body>
</html>
