using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using Maticsoft.DBUtility;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetDayProDetailsBydx 的摘要说明
    /// </summary>
    public class GetDayProDetailsBydx : IHttpHandler
    {
        Model.DM_BUSI_BigDayProDetailsBydx m_bdpdb = new Model.DM_BUSI_BigDayProDetailsBydx();
        BLL.DM_BUSI_BigDayProDetailsBydx b_bdpdb = new BLL.DM_BUSI_BigDayProDetailsBydx();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["operate"];
            string sqls = "";
            if (operate == "line")
            {
                //sqls = " SELECT DATEPART(weekday,DayID)  AS dates,sum(DayQualified) as qualified,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx GROUP BY DATEPART(weekday,DayID) ORDER BY DATEPART(weekday,DayID) ";

                //--本周记录 
                //sqls = " SELECT DATEPART(weekday,DayID)  AS dates,sum(DayQualified) as qualified,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx  where datediff(week,[DayID],getdate())=0 GROUP BY DATEPART(weekday,DayID) ORDER BY DATEPART(weekday,DayID) ";

                //--今年记录  按月排序
                sqls = " SELECT DATEPART(month,DayID)  AS dates,sum(DayQualified) as qualified,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx  where datediff(year,[DayID],getdate())=0 GROUP BY DATEPART(month,DayID) ORDER BY DATEPART(month,DayID) ";

            }
            if (operate == "bar")
            {
                //sqls = " SELECT DATEPART(weekday,DayID)  AS dates,sum(DayPlan) as plans,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx GROUP BY DATEPART(weekday,DayID) ORDER BY DATEPART(weekday,DayID) ";

                //--本周记录 这一种会把上周日也加上，不建议使用
                //sqls = " SELECT DATEPART(weekday,DayID)  AS dates,sum(DayPlan) as plans,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx where datediff(week,[DayID],getdate())=0 GROUP BY DATEPART(weekday,DayID) ORDER BY DATEPART(weekday,DayID) ";

                sqls = "SELECT DATEPART(weekday,DayID)  AS dates,sum(DayPlan) as plans,sum(DayTotal) as total  FROM DM_BUSI_BigDayProDetailsBydx where DayID>=DATEADD(week,DATEDIFF(week,0,getdate()),0) and DayID<=  DATEADD(week,DATEDIFF(week,0,getdate()),7) GROUP BY DATEPART(weekday,DayID) ORDER BY DATEPART(weekday,DayID) ";
            }
            if (operate == "pie")
            {
                sqls = " SELECT sum(DayPlan) as plans,sum(DayTotal) as total FROM DM_BUSI_BigDayProDetailsBydx WHERE  DATEDIFF(day,[DayID],GETDATE())=0 ";
            }
            DataTable ds = DbHelperSQL.Query(sqls).Tables[0];
            context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
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