﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Maticsoft.DBUtility;

namespace Vline.Web.DispatchManageSystem.BigDataAnQuan
{
    /// <summary>
    /// GetYhgs 的摘要说明
    /// </summary>
    public class GetYhgs : IHttpHandler
    {
        Model.DM_BUSI_YHGS m_pcd = new Model.DM_BUSI_YHGS();
        BLL.DM_BUSI_YHGS b_pcd = new BLL.DM_BUSI_YHGS();
        status statu = new status();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            string operate = context.Request.Params["operate"];
            String updated = context.Request.Params["updated"];//获取被修改的数据
            String inserted = context.Request.Params["inserted"];//获取插入的数据
            String deleted = context.Request.Params["deleted"];//获取删除的数据
            if (operate == "List")
            {
                System.Data.DataTable ds = b_pcd.GetList(" 1=1 order by Updatetime desc").Tables[0]; ;

                context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
            }
            if (updated != null | inserted != null | deleted != null)
            {
                try
                {
                    List<Model.DM_BUSI_YHGS> list_insert = inserted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_YHGS>>(inserted);
                    List<Model.DM_BUSI_YHGS> list_update = updated == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_YHGS>>(updated);
                    List<Model.DM_BUSI_YHGS> list_delete = deleted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_YHGS>>(deleted);

                    int count = opreate(list_insert, list_update, list_delete);
                    int item = 0;
                    if (list_insert != null) { item = item + list_insert.Count; }
                    if (list_update != null) { item = item + list_update.Count; }
                    if (list_delete != null) { item = item + list_delete.Count; }
                    statu.statu = true;
                    statu.Message = "保存成功，共有" + item + "行记录受影响";
                }
                catch
                {
                    statu.statu = false;
                    statu.Message = "保存失败";
                }
                context.Response.Write(javaScriptSerializer.Serialize(statu));
            }
        }

        /// <summary>
        /// 执行数据操作
        /// </summary>
        /// <param name="insert"></param>
        /// <param name="update"></param>
        /// <param name="delete"></param>
        protected int opreate(List<Model.DM_BUSI_YHGS> insert, List<Model.DM_BUSI_YHGS> update, List<Model.DM_BUSI_YHGS> delete)
        {
            List<String> list_string = new List<string>();
            List<String> list_hospstring = new List<string>();

            if (insert != null)
            {
                foreach (Model.DM_BUSI_YHGS m_insert in insert)
                {
                    //添加相应记录
                    list_string.Add(GetAddString(m_insert));
                }
            }
            if (update != null)
            {
                foreach (Model.DM_BUSI_YHGS m_update in update)
                {
                    //修改的相应记录
                    list_string.Add(GetUpdateString(m_update));
                }

            }
            if (delete != null)
            {
                foreach (Model.DM_BUSI_YHGS m_delete in delete)
                {
                    //删除相应记录
                    list_string.Add(GetDeleteString(m_delete.Id));
                }
            }
            int count = ExecuteSqlTran(list_string);
            return count;
        }

        public string GetAddString(Vline.Model.DM_BUSI_YHGS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_YHGS(");
            strSql.Append("YH,Updatetime )");

            strSql.Append("values ('" + model.YH + "','" + DateTime.Now + "') ");

            return strSql.ToString();
        }

        /// <summary>
        /// 获得修改一条数据的sql
        /// </summary>
        public string GetUpdateString(Vline.Model.DM_BUSI_YHGS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_YHGS");
            strSql.Append(" set YH='" + model.YH + "',Updatetime='" + DateTime.Now + "' where Id=" + model.Id + " ");
            return strSql.ToString();
        }

        /// <summary>
        /// 获得删除一条数据的sql
        /// </summary>
        public string GetDeleteString(int P_id)
        {
            return "delete DM_BUSI_YHGS where Id=" + P_id + "";
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