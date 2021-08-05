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
    /// GetYhlb 的摘要说明
    /// </summary>
    public class GetYhlb : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_YHLB m_bdf = new Model.DM_BUSI_YHLB();
        BLL.DM_BUSI_YHLB b_bdf = new BLL.DM_BUSI_YHLB();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //context.Response.Write("Hello World");
            DataTable ds = DbHelperSQL.Query("select convert(varchar(10),Updatetime,20) AS Updatetime,YHJB,PCR,ZG,ZY,Id,PCQ,PCH from DM_BUSI_YHLB  order by Updatetime desc").Tables[0];
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