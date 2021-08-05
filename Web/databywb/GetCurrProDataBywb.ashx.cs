using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using Maticsoft.DBUtility;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetCurrProDataBywb 的摘要说明
    /// </summary>
    public class GetCurrProDataBywb : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_BigPipeCutData m_pcd = new Model.DM_BUSI_BigPipeCutData();
        BLL.DM_BUSI_BigPipeCutData b_pcd = new BLL.DM_BUSI_BigPipeCutData();


        Model.DM_BUSI_BigFlatFixData m_bffd = new Model.DM_BUSI_BigFlatFixData();
        BLL.DM_BUSI_BigFlatFixData b_bffd = new BLL.DM_BUSI_BigFlatFixData();


        Model.DM_BUSI_BigCantilArmData m_bcad = new Model.DM_BUSI_BigCantilArmData();
        BLL.DM_BUSI_BigCantilArmData b_bcad = new BLL.DM_BUSI_BigCantilArmData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["oper"];

            string sqls = "";
            if (operate == "pipe")
            {
                sqls = " select  top 1 *, datediff(minute, PipeCutStartTime,PipeCutEndTime)  as cv from DM_BUSI_BigPipeCutData  order by Updatetime desc ";
            }
            if (operate == "flax")
            {
                sqls = " select  top 1 *, datediff(minute, FlatFixStartTime,FlatFixEndTime)  as cvs from DM_BUSI_BigFlatFixData  order by Updatetime desc ";
            }
            if (operate == "arm")
            {
                sqls = " select  top 1 * , datediff(minute, CantilArmStartTime,CantilArmEndTime)  as cvk from DM_BUSI_BigCantilArmData  order by Updatetime desc ";
            }
            DataTable ds = DbHelperSQL.Query(sqls).Tables[0];

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