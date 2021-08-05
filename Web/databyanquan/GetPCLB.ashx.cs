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
    /// GetPCLB 的摘要说明
    /// </summary>
    public class GetPCLB : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_YHLB m_bdf = new Model.DM_BUSI_YHLB();
        BLL.DM_BUSI_YHLB b_bdf = new BLL.DM_BUSI_YHLB();
        
        public void ProcessRequest(HttpContext context)
        {
            string ID = context.Request.Params["oper"];
            context.Response.ContentType = "text/plain";
            if (ID != null)
            {
                DataTable ds = DbHelperSQL.Query("select PCQ,PCH,PCNRQ,PCNRH from DM_BUSI_YHLB where Id=" + Convert.ToInt32(ID)).Tables[0];
                context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
            }
            else 
            {
                DataTable ds = DbHelperSQL.Query("select PCQ,PCH,PCNRQ,PCNRH from DM_BUSI_YHLB  order by Updatetime desc").Tables[0];
                context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
            }
            
            
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