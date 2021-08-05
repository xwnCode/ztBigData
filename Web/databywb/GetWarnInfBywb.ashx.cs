using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetWarnInfBywb 的摘要说明
    /// </summary>
    public class GetWarnInfBywb : IHttpHandler
    {
        Model.DM_BUSI_BigWarnInf m_bwi = new Model.DM_BUSI_BigWarnInf();
        BLL.DM_BUSI_BigWarnInf b_bwi = new BLL.DM_BUSI_BigWarnInf();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = b_bwi.GetListByPage(" 1=1 ", " id ", 1, 6).Tables[0];

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