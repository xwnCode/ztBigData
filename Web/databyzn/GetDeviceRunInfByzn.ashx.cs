using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;

namespace Vline.Web.databyzn
{
    /// <summary>
    /// GetDeviceRunInfByzn 的摘要说明
    /// </summary>
    public class GetDeviceRunInfByzn : IHttpHandler
    {
        Model.DM_BUSI_BigPatrolcarStartData m_bpsd = new Model.DM_BUSI_BigPatrolcarStartData();
        BLL.DM_BUSI_BigPatrolcarStartData b_bpsd = new BLL.DM_BUSI_BigPatrolcarStartData();

        Model.DM_BUSI_BigPatrolcarBatteryData m_bpbd = new Model.DM_BUSI_BigPatrolcarBatteryData();
        BLL.DM_BUSI_BigPatrolcarBatteryData b_bpbd = new BLL.DM_BUSI_BigPatrolcarBatteryData();

        Model.DM_BUSI_BigPatrolcarEnd m_bpe = new Model.DM_BUSI_BigPatrolcarEnd();
        BLL.DM_BUSI_BigPatrolcarEnd b_bpe = new BLL.DM_BUSI_BigPatrolcarEnd();

        Model.DM_BUSI_BigPatrolcarEndData m_bped = new Model.DM_BUSI_BigPatrolcarEndData();
        BLL.DM_BUSI_BigPatrolcarEndData b_bped = new BLL.DM_BUSI_BigPatrolcarEndData();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarStart order by id desc").Tables[0];

            if (ds.Rows.Count > 0)
            {
                ds.Columns.Add("by4");
                DataTable ds1 = b_bpsd.GetList(" patrolcarId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0];

                //DataTable ds2 = b_bpe.GetList(" id= " + b_bped.GetList(" taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " ").Tables[0].Rows[0]["Id"] + "").Tables[0];
                DataTable ds2 = DbHelperSQL.Query("SELECT * from DM_BUSI_BigPatrolcarEnd where id in (SELECT patrolcarId FROM DM_BUSI_BigPatrolcarEndData where taskid= " + Convert.ToInt32(ds.Rows[0]["Id"]) + ") ").Tables[0];


                DataTable ds3 = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigPatrolcarBatteryData where taskId = " + Convert.ToInt32(ds.Rows[0]["Id"]) + " order by id desc").Tables[0];

                if (ds1.Rows.Count > 0)
                {
                    ds.Rows[0]["by1"] = ds1.Rows[0]["stations"];
                }
                if (ds.Rows.Count > 0 && ds2.Rows.Count > 0)
                {
                    ds.Rows[0]["by2"] = ToDateTime(ds.Rows[0]["timestamp"].ToString()) + "至" + ToDateTime(ds2.Rows[0]["timestamp"].ToString());
                }
                if (ds3.Rows.Count > 0)
                {
                    ds.Rows[0]["by3"] = ds3.Rows[0]["remainCapacity"];
                    ds.Rows[0]["by4"] = ds3.Rows[0]["remainTime"];
                }
                string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
                //int a = ToDateTime(DateTime.Now);
                context.Response.Write(json);
            }
        }

        // 时间戳转为C#格式时间
        private DateTime ToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
            long lTime = long.Parse(timeStamp);
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }

        // 时间戳转为C#格式时间
        private DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);

            return dateTimeStart.Add(toNow);
        }

        // DateTime时间格式转换为Unix时间戳格式
        private int DateTimeToStamp(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
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