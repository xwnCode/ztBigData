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
    /// GetYhqs 的摘要说明
    /// </summary>
    public class GetYhqs : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_SLQS m_bdf = new Model.DM_BUSI_SLQS();
        BLL.DM_BUSI_SLQS b_bdf = new BLL.DM_BUSI_SLQS();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_SLQS  order by Updatetime desc").Tables[0];
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