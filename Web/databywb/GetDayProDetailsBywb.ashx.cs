using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using Maticsoft.DBUtility;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetDayProDetailsBywb 的摘要说明
    /// </summary>
    public class GetDayProDetailsBywb : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_BigDayProDetails m_bdpd = new Model.DM_BUSI_BigDayProDetails();
        BLL.DM_BUSI_BigDayProDetails b_bdpd = new BLL.DM_BUSI_BigDayProDetails();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["operate"];
            string sqls = "";

            DataTable dt = new DataTable();
            //dt.Columns.Add("dates");
            //dt.Columns.Add("sum");

            if (operate == "line")
            {
                dt = DbHelperSQL.Query("SELECT DATEPART(month,DayID)  AS dates,sum(DayTotal-DayQualified) as sum FROM DM_BUSI_BigDayProDetails where datediff(year,[DayID],getdate())=0 GROUP BY DATEPART(month,DayID) ORDER BY DATEPART(month,DayID)").Tables[0];
            }
            if (operate == "bar")
            {
                dt = DbHelperSQL.Query("SELECT DATEPART(month,DayID)  AS dates,sum(DayTotal) as total,sum(DayPlan) as plans FROM DM_BUSI_BigDayProDetails where datediff(year,[DayID],getdate())=0 GROUP BY DATEPART(month,DayID) ORDER BY DATEPART(month,DayID) ").Tables[0];
            }
            if (operate == "pie")
            {
                dt = DbHelperSQL.Query("SELECT sum(DayPlan) as plans,sum(DayTotal) as total FROM DM_BUSI_BigDayProDetails WHERE  DATEDIFF(day,[DayID],GETDATE())=0").Tables[0];

                //dt = DbHelperSQL.Query("SELECT isnull(sum(DayPlan),'') as plans,isnull(sum(DayTotal),'') as total FROM DM_BUSI_BigDayProDetails WHERE  DATEDIFF(day,[DayID],GETDATE())=0").Tables[0];

            }

            //if (operate == "line")
            //{
            //    sqls = " SELECT DATEPART(month,DayID)  AS dates,sum(DayTotal-DayQualified) as sum FROM DM_BUSI_BigDayProDetails where datediff(year,[DayID],getdate())=0 GROUP BY DATEPART(month,DayID) ORDER BY DATEPART(month,DayID) ";
            //}
            //if (operate == "bar")
            //{
            //    sqls = " SELECT DATEPART(month,DayID)  AS dates,sum(DayTotal) as total,sum(DayPlan) as plans FROM DM_BUSI_BigDayProDetails where datediff(year,[DayID],getdate())=0 GROUP BY DATEPART(month,DayID) ORDER BY DATEPART(month,DayID) ";
            //}
            //if (operate == "pie")
            //{
            //   // sqls = " SELECT sum(DayTotal) as total,(SELECT DayTotal as total FROM DM_BUSI_BigDayProDetails where DayID=CONVERT(varchar(10), getdate(), 120 )) as plans FROM DM_BUSI_BigDayProDetails ";
            //    sqls = "SELECT sum(DayPlan) as plans,sum(DayTotal) as total FROM DM_BUSI_BigDayProDetails WHERE  DATEDIFF(day,[DayID],GETDATE())=0";
            //}
            //DataTable ds = DbHelperSQL.Query(sqls).Tables[0];


            string json = Serialize.DataTableToJsonWithJavaScriptSerializer(dt);
            context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(dt));
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