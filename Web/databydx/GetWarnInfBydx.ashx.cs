using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetWarnInfBydx 的摘要说明
    /// </summary>
    public class GetWarnInfBydx : IHttpHandler
    {
        Model.DM_BUSI_BigWarnInfBydx m_bwib = new Model.DM_BUSI_BigWarnInfBydx();
        BLL.DM_BUSI_BigWarnInfBydx b_bwib = new BLL.DM_BUSI_BigWarnInfBydx();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = b_bwib.GetListByPage(" 1=1 ", " WarnTime desc ", 1, 6).Tables[0];
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