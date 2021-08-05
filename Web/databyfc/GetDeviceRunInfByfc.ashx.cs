using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyfc
{
    /// <summary>
    /// GetDeviceRunInfByfc 的摘要说明
    /// </summary>
    public class GetDeviceRunInfByfc : IHttpHandler
    {
        Model.DM_BUSI_BigFtestStart m_bfs = new Model.DM_BUSI_BigFtestStart();
        BLL.DM_BUSI_BigFtestStart b_bfs = new BLL.DM_BUSI_BigFtestStart();

        Model.DM_BUSI_BigFtestStartData m_bfsb = new Model.DM_BUSI_BigFtestStartData();
        BLL.DM_BUSI_BigFtestStartData b_bfsb = new BLL.DM_BUSI_BigFtestStartData();

        Model.DM_BUSI_BigFtestUploadData m_bfud = new Model.DM_BUSI_BigFtestUploadData();
        BLL.DM_BUSI_BigFtestUploadData b_bfud = new BLL.DM_BUSI_BigFtestUploadData();

        Model.DM_BUSI_BigFtestEndData m_bfed = new Model.DM_BUSI_BigFtestEndData();
        BLL.DM_BUSI_BigFtestEndData b_bfed = new BLL.DM_BUSI_BigFtestEndData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigFtestStart order by id desc").Tables[0];
            if (ds.Rows.Count > 0)
            {
                DataTable ds1 = b_bfsb.GetList(" ftestId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0];

                DataTable ds2 = b_bfed.GetList(" taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0];

                DataTable ds3 = b_bfud.GetList(" taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0];

                if (ds1.Rows.Count > 0)
                {
                    ds.Rows[0]["by1"] = ds1.Rows[0]["StartStation"] + "-" + ds1.Rows[0]["EndStation"];
                }
                if (ds1.Rows.Count > 0 && ds2.Rows.Count > 0)
                {
                    ds.Rows[0]["by2"] = ds1.Rows[0]["taskDateTime"] + "至" + ds2.Rows[0]["TaskDateTime"];
                } 
                if (ds3.Rows.Count > 0)
                {
                    ds.Rows[0]["by3"] = ds3.Rows[0]["speed"];
                }
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