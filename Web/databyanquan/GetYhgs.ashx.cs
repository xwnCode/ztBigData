using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyanquan
{
    /// <summary>
    /// GetYhgs 的摘要说明
    /// </summary>
    public class GetYhgs : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_YHGS m_bdf = new Model.DM_BUSI_YHGS();
        BLL.DM_BUSI_YHGS b_bdf = new BLL.DM_BUSI_YHGS();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select * from DM_BUSI_YHGS  order by Updatetime desc").Tables[0];

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