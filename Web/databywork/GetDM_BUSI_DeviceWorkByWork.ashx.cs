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
    /// GetDM_BUSI_DeviceWorkByWork 的摘要说明
    /// </summary>
    public class GetDM_BUSI_DeviceWorkByWork : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_DeviceWork m_bdf = new Model.DM_BUSI_DeviceWork();
        BLL.DM_BUSI_DeviceWork b_bdf = new BLL.DM_BUSI_DeviceWork();
        char n;
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_DeviceWork  order by Updatetime desc").Tables[0];
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