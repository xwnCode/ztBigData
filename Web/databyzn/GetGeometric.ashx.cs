using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyzn
{
    /// <summary>
    /// GetGeometric 的摘要说明
    /// </summary>
    public class GetGeometric : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable dt = new DataTable();
            //dt.Columns.Add("zz");
            //dt.Columns.Add("dg");
            //dt.Columns.Add("lcz");
            //dt.Columns.Add("sd");
            string operate = context.Request.Params["operate"];
            //DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarStart order by id desc").Tables[0];

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarStart where id=230 order by id desc").Tables[0];

            DataTable ds1 = new DataTable();
            DataTable ds2 = new DataTable();
            if (ds.Rows.Count>0)
            {
                //ds1 = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarUploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " order by id desc").Tables[0];

                //ds1 = DbHelperSQL.Query("select  id from DM_BUSI_BigPatrolcarUploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0];

                 ds1 = DbHelperSQL.Query("select  id  from DM_BUSI_BigPatrolcarUploadData where taskId =230").Tables[0];
            }

            if (ds1.Rows.Count>0){
                if (operate == "table1")
                {
                    //ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid = " + Convert.ToInt32(ds1.Rows[0]["Id"]) + " order by id desc").Tables[0];

                    //ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select  id from DM_BUSI_BigPatrolcarUploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + ") order by id desc").Tables[0];

                    ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select  id from DM_BUSI_BigPatrolcarUploadData where taskId = 230) order by id desc").Tables[0];

                }
                if (operate == "table2")
                {
                    //ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid = " + Convert.ToInt32(ds1.Rows[0]["Id"]) + " and (cast(zig1 as numeric(18,2)) not between -400 and 400  or cast(hei1 as numeric(18,2)) not  between -30 and 30) order by id desc").Tables[0];

                    //ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select  id from DM_BUSI_BigPatrolcarUploadData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ) and (cast(zig1 as numeric(18,2)) not between -400 and 400  or cast(hei1 as numeric(18,2)) not  between -30 and 30) order by id desc").Tables[0];

                    ds2 = DbHelperSQL.Query("select  top 5 * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select  id from DM_BUSI_BigPatrolcarUploadData where taskId = 230 ) and (cast(zig1 as numeric(18,2)) not between -400 and 400  or cast(hei1 as numeric(18,2)) not  between -30 and 30) order by id desc").Tables[0];
                }
                if (operate == "bo")
                {
                    //ds2 = DbHelperSQL.Query("select  top 10 * from DM_BUSI_BigPatrolcarUploadDatas where dataid = " + Convert.ToInt32(ds1.Rows[0]["Id"]) + " convert(datetime2,stime,20)>=dateadd(SECOND,-2,GETDATE()) ").Tables[0];


                    //ds2 = DbHelperSQL.Query("select * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select  top 1 id from DM_BUSI_BigPatrolcarUploadData  where taskid in(select top 1 id  from DM_BUSI_BigPatrolcarStart order by id desc)) and convert(datetime2,stime,20)>=dateadd(SECOND,-2,GETDATE())").Tables[0];

                    //ds2 = DbHelperSQL.Query("select * from DM_BUSI_BigPatrolcarUploadDatas where dataid in (select id from DM_BUSI_BigPatrolcarUploadData  where taskid in(select top 1 id  from DM_BUSI_BigPatrolcarStart order by id desc)) and convert(datetime2,stime,20)>=dateadd(SECOND,-2,GETDATE())").Tables[0];

                    ds2 = DbHelperSQL.Query("select moveDistance,hei1,zig1,speed from DM_BUSI_BigPatrolcarUploadDatas where  dataid in (select id from DM_BUSI_BigPatrolcarUploadData  where taskid in(select top 1 id  from DM_BUSI_BigPatrolcarStart where id =230 order by id desc)) and convert(datetime2,stime,20)>='2021-07-01 15:04:10.535' ").Tables[0];

                }
            }
            string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds2);

            context.Response.Write(json);
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