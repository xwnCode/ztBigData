using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetCurrProDataBydx 的摘要说明
    /// </summary>
    public class GetCurrProDataBydx : IHttpHandler
    {
        Model.DM_BUSI_BigCurrProDataBydx m_bpdb = new Model.DM_BUSI_BigCurrProDataBydx();
        BLL.DM_BUSI_BigCurrProDataBydx b_bpdb = new BLL.DM_BUSI_BigCurrProDataBydx();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable ds = b_bpdb.GetList(" 1=1 ").Tables[0];
            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigCurrProDataBydx order by Updatetime desc").Tables[0];

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