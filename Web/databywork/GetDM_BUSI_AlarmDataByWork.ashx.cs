using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Maticsoft.DBUtility;
using System.Data;

namespace Vline.Web.databywork
{

    /// <summary>
    /// GetDM_BUSI_AlarmDataByWork 的摘要说明
    /// </summary>
    public class GetDM_BUSI_AlarmDataByWork : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_AlarmData m_bdf = new Model.DM_BUSI_AlarmData();
        BLL.DM_BUSI_AlarmData b_bdf = new BLL.DM_BUSI_AlarmData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_AlarmData  order by Alarmdate desc").Tables[0];
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