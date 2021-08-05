using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetDeviceFilesBydx 的摘要说明
    /// </summary>
    public class GetDeviceFilesBydx : IHttpHandler
    {
        Model.DM_BUSI_BigDeviceFilesBydx m_bdfb = new Model.DM_BUSI_BigDeviceFilesBydx();
        BLL.DM_BUSI_BigDeviceFilesBydx b_bdfb = new BLL.DM_BUSI_BigDeviceFilesBydx();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable ds = b_bdfb.GetList(" 1=1 ").Tables[0];

            DataTable ds = DbHelperSQL.Query("select  top 1 * from [dbo].[DM_BUSI_BigDeviceFilesBydx]  order by Updatetime desc").Tables[0];

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