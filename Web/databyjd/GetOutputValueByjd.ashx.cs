using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using Maticsoft.DBUtility;

namespace Vline.Web.databyjd
{
    /// <summary>
    /// GetOutputValueByjd 的摘要说明
    /// </summary>
    public class GetOutputValueByjd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["operate"];

            string sqls = "";
            if (operate == "gauge")
            {
                sqls = " SELECT SUM(ydcomplete) as klwc,SUM(ydplan) as jhzl from DM_BUSI_BigOutputValueByjd   ";
                DataTable ds = DbHelperSQL.Query(sqls).Tables[0];
                ds.Columns.Add("bnwc");
                ds.Columns.Add("bnjh");
                ds.Columns.Add("bywc");
                ds.Columns.Add("byjh");
                sqls = " SELECT SUM(ydcomplete) as bnwc,SUM(ydplan) as bnjh from DM_BUSI_BigOutputValueByjd where year=year(getdate())   ";
                DataTable ds1 = DbHelperSQL.Query(sqls).Tables[0];
                sqls = " SELECT SUM(ydcomplete) as bywc,SUM(ydplan) as byjh from DM_BUSI_BigOutputValueByjd where month=month(getdate())   ";
                DataTable ds2 = DbHelperSQL.Query(sqls).Tables[0];
                if(ds1.Rows.Count>0){
                    ds.Rows[0]["bnwc"] = ds1.Rows[0]["bnwc"];
                    ds.Rows[0]["bnjh"] = ds1.Rows[0]["bnjh"];
                }
                if (ds2.Rows.Count > 0)
                {
                    ds.Rows[0]["bywc"] = ds2.Rows[0]["bywc"];
                    ds.Rows[0]["byjh"] = ds2.Rows[0]["byjh"];
                }
                string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
                context.Response.Write(json);
            }
            else
            {
                if (operate == "zy")
                {
                    sqls = " SELECT profession,SUM(ydcomplete) as sum from DM_BUSI_BigOutputValueByjd where year=year(getdate()) group by profession ";
                }
                if (operate == "line")
                {
                    sqls = " SELECT month,SUM(ydcomplete) as sum from DM_BUSI_BigOutputValueByjd where year=year(getdate()) group by month ";
                }
                if (operate == "bar")
                {
                    sqls = " SELECT year,quarter,SUM(ydcomplete) as wc,SUM(ydplan) as jh from DM_BUSI_BigOutputValueByjd  group by year,quarter   ";
                }
                DataTable ds = DbHelperSQL.Query(sqls).Tables[0];
                string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
                context.Response.Write(json);
            }
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