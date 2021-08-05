using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyzn
{
    /// <summary>
    /// GetPictureUp 的摘要说明
    /// </summary>
    public class GetPictureUp : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarStart order by id desc").Tables[0];

            DataTable ds1 = new DataTable();
            if (ds.Rows.Count > 0)
            {
                ds1 = DbHelperSQL.Query("select  top 2 * from DM_BUSI_BigPatrolcarPuploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " order by id desc ").Tables[0];

                //ds1 = DbHelperSQL.Query("select  top 2 * from DM_BUSI_BigPatrolcarPuploadData where taskId = 231 order by id desc ").Tables[0];

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