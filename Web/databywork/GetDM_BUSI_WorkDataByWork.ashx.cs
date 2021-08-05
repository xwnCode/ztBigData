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
    /// DM_BUSI_WorkData 的摘要说明
    /// </summary>
    public class GetDM_BUSI_WorkDataByWork : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_WorkData m_bdf = new Model.DM_BUSI_WorkData();
        BLL.DM_BUSI_WorkData b_bdf = new BLL.DM_BUSI_WorkData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_WorkData  order by Updatetime desc").Tables[0];
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