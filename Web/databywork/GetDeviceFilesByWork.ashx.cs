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
    /// GetDeviceFilesByWork 的摘要说明
    /// </summary>
    public class GetDeviceFilesByWork : IHttpHandler,IReadOnlySessionState
    {
        Model.DM_BUSI_DeviceFiles m_bdf = new Model.DM_BUSI_DeviceFiles();
        BLL.DM_BUSI_DeviceFiles b_bdf = new BLL.DM_BUSI_DeviceFiles();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_DeviceFiles  order by Updatetime desc").Tables[0];
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