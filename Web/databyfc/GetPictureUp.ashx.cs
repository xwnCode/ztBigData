using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyfc
{
    /// <summary>
    /// GetPictureUp 的摘要说明
    /// </summary>
    public class GetPictureUp : IHttpHandler
    {
        Model.DM_BUSI_BigFtestStart m_bfs = new Model.DM_BUSI_BigFtestStart();
        BLL.DM_BUSI_BigFtestStart b_bfs = new BLL.DM_BUSI_BigFtestStart();

        Model.DM_BUSI_BigFtestStartData m_bfsb = new Model.DM_BUSI_BigFtestStartData();
        BLL.DM_BUSI_BigFtestStartData b_bfsb = new BLL.DM_BUSI_BigFtestStartData();

        Model.DM_BUSI_BigFtestUploadData m_bfud = new Model.DM_BUSI_BigFtestUploadData();
        BLL.DM_BUSI_BigFtestUploadData b_bfud = new BLL.DM_BUSI_BigFtestUploadData();

        Model.DM_BUSI_BigFtestPhotoData m_bfpd = new Model.DM_BUSI_BigFtestPhotoData();
        BLL.DM_BUSI_BigFtestPhotoData b_bfpd = new BLL.DM_BUSI_BigFtestPhotoData();

        Model.DM_BUSI_BigFtestPuploadData m_bfpud = new Model.DM_BUSI_BigFtestPuploadData();
        BLL.DM_BUSI_BigFtestPuploadData b_bfpud = new BLL.DM_BUSI_BigFtestPuploadData();

        Model.DM_BUSI_BigFtestEndData m_bfed = new Model.DM_BUSI_BigFtestEndData();
        BLL.DM_BUSI_BigFtestEndData b_bfed = new BLL.DM_BUSI_BigFtestEndData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigFtestStart order by id desc").Tables[0];
             DataTable ds1 = new DataTable();
             if (ds.Rows.Count > 0)
             {
                  ds1 = DbHelperSQL.Query("select  top 3 * from DM_BUSI_BigFtestPuploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " order by id desc ").Tables[0];
             }
            context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds1));

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