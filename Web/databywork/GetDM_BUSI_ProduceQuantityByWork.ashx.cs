using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databywork
{

    /// <summary>
    /// DM_BUSI_ProduceQuantity 的摘要说明
    /// </summary>
    public class GetDM_BUSI_ProduceQuantityByWork : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_ProduceQuantity m_bdf = new Model.DM_BUSI_ProduceQuantity();
        BLL.DM_BUSI_ProduceQuantity b_bdf = new BLL.DM_BUSI_ProduceQuantity();

        BLL.DM_BUSI_ProduceQuantity b_YearPlanType = new BLL.DM_BUSI_ProduceQuantity();
        Model.DM_BUSI_ProduceQuantity m_YearPlanType = new Model.DM_BUSI_ProduceQuantity();
        public void ProcessRequest(HttpContext context)
        {
            DataSet dsMessage = b_YearPlanType.GetAllList();
            
            var worktype = dsMessage.Tables[0].Rows[0]["By1"].ToString() ;
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["operate"];
            DataTable dt = new DataTable();

            if (operate == "bar")
            {
                var sss = "SELECT DATEPART(month,Date)  AS dates,sum(Daytotal) as total,sum(Dayplan) as plans FROM DM_BUSI_ProduceQuantity where By1= '"+  worktype + "' and datediff(year,[Date],getdate())=0 GROUP BY DATEPART(month,Date) ORDER BY DATEPART(month,Date)";
                dt = DbHelperSQL.Query("SELECT DATEPART(month,Date)  AS dates,sum(Daytotal) as total,sum(Dayplan) as plans FROM DM_BUSI_ProduceQuantity where By1='" + worktype + "' and datediff(year,[Date],getdate())=0 GROUP BY DATEPART(month,Date) ORDER BY DATEPART(month,Date)").Tables[0];
            }
            var date = DateTime.Now;
            if (operate == "pie")
            {
                var sss = "SELECT sum(DayPlan) as plans,sum(DayTotal) as total FROM DM_BUSI_ProduceQuantity WHERE By1= '" + worktype + "' and  DATEDIFF(day,Date,GETDATE())=0";
                dt = DbHelperSQL.Query("SELECT sum(DayPlan) as plans,sum(DayTotal) as total FROM DM_BUSI_ProduceQuantity WHERE By1= '" + worktype + "' and  DATEDIFF(day,Date,GETDATE())=0").Tables[0];

            }


            string json = Serialize.DataTableToJsonWithJavaScriptSerializer(dt);

            //DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_ProduceQuantity  order by Date desc").Tables[0];
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