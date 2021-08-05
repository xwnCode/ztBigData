using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using Maticsoft.DBUtility;


namespace Vline.Web.databycb
{
    /// <summary>
    /// GetInspectionBycb 的摘要说明
    /// </summary>
    public class GetInspectionBycb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.ContentType = "text/plain";
            string operate = context.Request.Params["operate"];
            string sqls = "";
            DataTable ds = new DataTable();
            if (operate == "bar")
            {
                sqls = " SELECT year,quarter,SUM(zrcb) as zrcb,SUM(rgf+clf+jxf+zyfbf+qtfy+xcjf) as sjcb from DM_BUSI_BigInspectionBycb  group by year,quarter  ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            if (operate == "danqi")
            {
                sqls = " SELECT SUM(rgf+clf+jxf+zyfbf+xcjf) as zl,SUM(rgf) as rgf,SUM(clf) as clf,SUM(jxf) as jxf,SUM(zyfbf) as zyfbf,SUM(xcjf) as xcjf  from DM_BUSI_BigInspectionBycb where year=year(getdate())  ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            if (operate == "kailei")
            {
                sqls = " SELECT SUM(rgf+clf+jxf+zyfbf+xcjf) as zl,SUM(rgf) as rgf,SUM(clf) as clf,SUM(jxf) as jxf,SUM(zyfbf) as zyfbf,SUM(xcjf) as xcjf  from DM_BUSI_BigInspectionBycb ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            if (operate == "dq")
            {
                sqls = " SELECT SUM(ygjj) as dq from DM_BUSI_BigInspectionBycb where year=year(getdate())  ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            if (operate == "kl")
            {
                sqls = " SELECT SUM(ygjj) as kl from DM_BUSI_BigInspectionBycb ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            if (operate == "zrcbjcl")
            {
                sqls = " SELECT SUM(zrcb) as zrcb,SUM(rgf+clf+jxf+zyfbf+qtfy+xcjf) as sjcb from DM_BUSI_BigInspectionBycb where year=year(getdate()) ";
                ds = DbHelperSQL.Query(sqls).Tables[0];
            }
            string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}