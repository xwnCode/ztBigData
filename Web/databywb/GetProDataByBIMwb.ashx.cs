using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Script.Serialization;
using System.Text;
using Maticsoft.DBUtility;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetProDataByBIMwb 的摘要说明
    /// </summary>
    public class GetProDataByBIMwb : IHttpHandler
    {
        Model.DM_BUSI_BigPropData m_pcd = new Model.DM_BUSI_BigPropData();
        BLL.DM_BUSI_BigPropData b_pcd = new BLL.DM_BUSI_BigPropData();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string operate = context.Request.Params["operate"];
            if (operate=="List")
            {
               
                DataTable ds = b_pcd.GetList(" 1=1 ").Tables[0];

                //DataTable ds = b_pcd.GetList(" 1=1 and DATEDIFF(day,[DayID],GETDATE())=0 ").Tables[0];

                context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
            } 
            if (operate == "Add") {
                String Add = context.Request.Params["Add"];//获取添加的数据
                //Add = Add.Replace("DateOfdata", "by1");
                List<Model.DM_BUSI_BigPropData> list = Add == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigPropData>>(Add);

                if (Add != null)
                {
                    int count = opreate(list);
                    if (count>0)
                    {
                        context.Response.Write(javaScriptSerializer.Serialize(true));
                    }
                }
            }
        }

        /// <summary>
        /// 执行数据操作
        /// </summary>
        /// <param name="update"></param>
        protected int opreate(List<Model.DM_BUSI_BigPropData> Add)
        {
            List<String> list_string = new List<string>();

            foreach (Model.DM_BUSI_BigPropData m_update in Add)
            {

                    //添加相应记录
                    list_string.Add(GetAddString(m_update));
              
            }
            int count = ExecuteSqlTran(list_string);
            return count;
        }

        public string GetAddString(Vline.Model.DM_BUSI_BigPropData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_BigGetProData(");
            strSql.Append("DateOfdata,NameOfAnchor,Number,Type,Abutment,Flatears,Cantilears,Locatingring,Posseat,Windbreak,FlatFix,CantilArm,Postube,Carpalsuplon,Carpalsupflat,Carpalsupobl,LocasupSupo,LocasupArmo,LocasupSeto,LocasupSupt,LocasupArmt,LocasupSett,PosParameters,BaseParameters,SusParameters,Posslope)");

            strSql.Append(" values (");
            strSql.Append("'" + DateTime.Now + "','" + model.mdName + "','" + model.code + "','" + model.type + "','" + model.czz + "','" + model.psr + "','" + model.xsr + "','" + model.dwh + "','" + model.dwz + "','" + model.ffk + "','" + model.pwb + "','" + model.xwb + "','" + model.dwg + "','" + model.wbzcL + "','" + model.wbzcP + "','" + model.wbzcX + "','" + model.dwzc1L + "','" + model.dwzc1B + "','" + model.dwzc1D + "','" + model.dwzc2L + "','" + model.dwzc2B + "','" + model.dwzc2D + "','" + model.dwParam + "','" + model.dzParam + "','" + model.xgParam + "','" + model.dwpd + "')");

            return strSql.ToString();

        }

        /// <summary>
        /// 批量执行sql语句
        /// </summary>
        public int ExecuteSqlTran(List<String> list_str)
        {
            int count = DbHelperSQL.ExecuteSqlTran(list_str);

            return count;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


        /// <summary>
        /// Json 的日期格式与.Net DateTime类型的转换
        /// </summary>
        /// <param name="jsonDate">Json 的日期,例如:/Date(928120800000+0800)/</param>
        /// <returns></returns>
        public static DateTime JsonToDateTime(string jsonDate)
        {
            string value = jsonDate.Substring(6, jsonDate.Length - 8);
            DateTimeKind kind = DateTimeKind.Utc;
            int index = value.IndexOf('+', 1);
            if (index == -1)
                index = value.IndexOf('-', 1);
            if (index != -1)
            {
                kind = DateTimeKind.Local;
                value = value.Substring(0, index);
            }
            long javaScriptTicks = long.Parse(value, System.Globalization.NumberStyles.Integer, System.Globalization.CultureInfo.InvariantCulture);
            long InitialJavaScriptDateTicks = (new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).Ticks;
            DateTime utcDateTime = new DateTime((javaScriptTicks * 10000) + InitialJavaScriptDateTicks, DateTimeKind.Utc);
            DateTime dateTime;
            switch (kind)
            {
                case DateTimeKind.Unspecified:
                    dateTime = DateTime.SpecifyKind(utcDateTime.ToLocalTime(), DateTimeKind.Unspecified);
                    break;
                case DateTimeKind.Local:
                    dateTime = utcDateTime.ToLocalTime();
                    break;
                default:
                    dateTime = utcDateTime;
                    break;
            }
            return dateTime;
        }
    }
}