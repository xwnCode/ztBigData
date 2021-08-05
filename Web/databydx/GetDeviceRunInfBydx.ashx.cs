using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetDeviceRunInfBydx 的摘要说明
    /// </summary>
    public class GetDeviceRunInfBydx : IHttpHandler
    {
        Model.DM_BUSI_BigDeviceRunInfBydx m_bdrib = new Model.DM_BUSI_BigDeviceRunInfBydx();
        BLL.DM_BUSI_BigDeviceRunInfBydx b_bdrib = new BLL.DM_BUSI_BigDeviceRunInfBydx();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable ds = b_bdrib.GetList(" 1=1 ").Tables[0];
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigDeviceRunInfBydx  order by Updatetime desc").Tables[0];

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