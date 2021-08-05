using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Maticsoft.DBUtility;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetDeviceRunInfBywb 的摘要说明
    /// </summary>
    public class GetDeviceRunInfBywb : IHttpHandler
    {
        Model.DM_BUSI_BigDeviceRunInf m_bdri = new Model.DM_BUSI_BigDeviceRunInf();
        BLL.DM_BUSI_BigDeviceRunInf b_bdri = new BLL.DM_BUSI_BigDeviceRunInf();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable ds = b_bdri.GetList(" 1=1 ").Tables[0];
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigDeviceRunInf  order by Updatetime desc").Tables[0];

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