﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;
using System.Web.Script.Serialization;
using System.Text;

namespace Vline.Web.databyjd
{
    /// <summary>
    /// TodayPlanByjd 的摘要说明
    /// </summary>
    public class TodayPlanByjd : IHttpHandler
    {
        BLL.DM_BUSI_BigTodayPlanByjd b_bovb = new BLL.DM_BUSI_BigTodayPlanByjd();
        Model.DM_BUSI_BigTodayPlanByjd m_bovb = new Model.DM_BUSI_BigTodayPlanByjd();
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        status statu = new status();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["oper"];
            if (!string.IsNullOrEmpty(operate))
            {
                DataTable ds = new DataTable();
                if (operate == "op")
                {
                    ds = b_bovb.GetList("1=1").Tables[0];
                }
                else
                {
                    ds = ds = b_bovb.GetListByPage("1=1", " id desc ", 1, 5).Tables[0];
                }
                string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
                context.Response.Write(json);
            }
            else
            {
                String updated = context.Request.Params["updated"];//获取被修改的数据
                String inserted = context.Request.Params["inserted"];//获取插入的数据
                String deleted = context.Request.Params["deleted"];//获取删除的数据

                try
                {
                    if (!string.IsNullOrEmpty(updated))
                    {
                        updated = updated.Replace("date", "by4");
                    }
                    if (!string.IsNullOrEmpty(deleted))
                    {
                        deleted = deleted.Replace("date", "by4");
                    }

                    List<Model.DM_BUSI_BigTodayPlanByjd> list_insert = inserted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigTodayPlanByjd>>(inserted);
                    List<Model.DM_BUSI_BigTodayPlanByjd> list_update = updated == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigTodayPlanByjd>>(updated);
                    List<Model.DM_BUSI_BigTodayPlanByjd> list_delete = deleted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigTodayPlanByjd>>(deleted);

                    int count = opreate(list_insert, list_update, list_delete);
                    statu.statu = true;
                    statu.Message = "保存成功，共有" + count + "行记录受影响";
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
        protected int opreate(List<Model.DM_BUSI_BigTodayPlanByjd> insert, List<Model.DM_BUSI_BigTodayPlanByjd> update, List<Model.DM_BUSI_BigTodayPlanByjd> delete)
        {
            List<String> list_string = new List<string>();
            List<String> list_hospstring = new List<string>();

            if (insert != null)
            {
                foreach (Model.DM_BUSI_BigTodayPlanByjd m_insert in insert)
                {
                    //添加相应记录
                    list_string.Add(GetAddString(m_insert));
                }
            }
            if (update != null)
            {
                foreach (Model.DM_BUSI_BigTodayPlanByjd m_update in update)
                {
                    //修改的相应记录
                    list_string.Add(GetUpdateString(m_update));
                }

            }
            if (delete != null)
            {
                foreach (Model.DM_BUSI_BigTodayPlanByjd m_delete in delete)
                {
                    //删除相应记录
                    list_string.Add(GetDeleteString(m_delete.Id));
                }
            }
            int count = ExecuteSqlTran(list_string);
            return count;
        }

        public string GetAddString(Vline.Model.DM_BUSI_BigTodayPlanByjd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_BigTodayPlanByjd(");
            strSql.Append("Id,date,deptName,profession,workContent,workPlace,principal,by1,by2,by3 )");

            strSql.Append("select ISNULL(MAX(id),0)+1 ,'" + DateTime.Now + "','" + model.deptName + "','" + model.profession + "','" + model.workContent + "','" + model.workPlace + "','" + model.principal + "','" + model.by1 + "','" + model.by2 + "','" + model.by3 + "'  from DM_BUSI_BigTodayPlanByjd ");

            return strSql.ToString();
        }

        /// <summary>
        /// 获得修改一条数据的sql
        /// </summary>
        public string GetUpdateString(Vline.Model.DM_BUSI_BigTodayPlanByjd model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_BigTodayPlanByjd");
            strSql.Append(" set date='" + DateTime.Now + "',deptName='" + model.deptName + "',profession='" + model.profession + "',workContent='" + model.workContent + "',workPlace='" + model.workPlace + "',principal='" + model.principal + "' where Id=" + model.Id + " ");

            return strSql.ToString();
        }

        /// <summary>
        /// 获得删除一条数据的sql
        /// </summary>
        public string GetDeleteString(int P_id)
        {
            return "delete DM_BUSI_BigTodayPlanByjd where Id=" + P_id + "";
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
    }
}