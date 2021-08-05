using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.DispatchManageSystem.BigDataAnQuan
{
    /// <summary>
    /// GetPCLB 的摘要说明
    /// </summary>
    public class GetPCLB : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_YHLB m_bdf = new Model.DM_BUSI_YHLB();
        BLL.DM_BUSI_YHLB b_bdf = new BLL.DM_BUSI_YHLB();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
                DataTable ds = DbHelperSQL.Query("select PCQ,PCH from DM_BUSI_YHLB  order by Updatetime desc").Tables[0];
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