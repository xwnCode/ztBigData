using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Maticsoft.DBUtility;
using System.Web.Script.Serialization;
using System.Text;

namespace Vline.Web.databycb
{
    /// <summary>
    /// InspectionBycb 的摘要说明
    /// </summary>
    public class InspectionBycb : IHttpHandler
    {

        BLL.DM_BUSI_BigInspectionBycb b_bovb = new BLL.DM_BUSI_BigInspectionBycb();
        Model.DM_BUSI_BigInspectionBycb m_bovb = new Model.DM_BUSI_BigInspectionBycb();
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
                    ds = b_bovb.GetListByPage("1=1", " id desc ", 1, 16).Tables[0];
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
                    //inserted = inserted.Replace("targetNode", "by4");
                    //if (!string.IsNullOrEmpty(updated))
                    //{
                    //    updated = updated.Replace("targetNode", "by4");
                    //}
                    //if (!string.IsNullOrEmpty(deleted))
                    //{
                    //    deleted = deleted.Replace("targetNode", "by4");
                    //}
                    List<Model.DM_BUSI_BigInspectionBycb> list_insert = inserted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigInspectionBycb>>(inserted);
                    List<Model.DM_BUSI_BigInspectionBycb> list_update = updated == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigInspectionBycb>>(updated);
                    List<Model.DM_BUSI_BigInspectionBycb> list_delete = deleted == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigInspectionBycb>>(deleted);

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
        protected int opreate(List<Model.DM_BUSI_BigInspectionBycb> insert, List<Model.DM_BUSI_BigInspectionBycb> update, List<Model.DM_BUSI_BigInspectionBycb> delete)
        {
            List<String> list_string = new List<string>();
            List<String> list_hospstring = new List<string>();

            if (insert != null)
            {
                foreach (Model.DM_BUSI_BigInspectionBycb m_insert in insert)
                {
                    //添加相应记录
                    list_string.Add(GetAddString(m_insert));
                }
            }
            if (update != null)
            {
                foreach (Model.DM_BUSI_BigInspectionBycb m_update in update)
                {
                    //修改的相应记录
                    list_string.Add(GetUpdateString(m_update));
                }

            }
            if (delete != null)
            {
                foreach (Model.DM_BUSI_BigInspectionBycb m_delete in delete)
                {
                    //删除相应记录
                    list_string.Add(GetDeleteString(m_delete.Id));
                }
            }
            int count = ExecuteSqlTran(list_string);
            return count;
        }

        public string GetAddString(Vline.Model.DM_BUSI_BigInspectionBycb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_BigInspectionBycb(");
            strSql.Append("Id,year,quarter,month,ygjj,rgf,clf,jxf,zyfbf,qtfy,xcjf,zrcb,by1,by2,by3 )");

            strSql.Append("select ISNULL(MAX(id),0)+1 ,'" + model.year + "','" + model.quarter + "','" + model.month + "','" + model.ygjj + "','" + model.rgf + "','" + model.clf + "','" + model.jxf + "','" + model.zyfbf + "','" + model.qtfy + "','" + model.xcjf + "','" + model.zrcb + "','" + model.by1 + "','" + model.by2 + "','" + model.by3 + "'  from DM_BUSI_BigInspectionBycb ");

            return strSql.ToString();
        }

        /// <summary>
        /// 获得修改一条数据的sql
        /// </summary>
        public string GetUpdateString(Vline.Model.DM_BUSI_BigInspectionBycb model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_BigInspectionBycb");
            strSql.Append(" set year='" + model.year + "',quarter='" + model.quarter + "',month='" + model.month + "',ygjj='" + model.ygjj + "',rgf='" + model.rgf + "',clf='" + model.clf + "',jxf='" + model.jxf + "',zyfbf='" + model.zyfbf + "',qtfy='" + model.qtfy + "',xcjf='" + model.xcjf + "',zrcb='" + model.zrcb + "' where Id=" + model.Id + " ");

            return strSql.ToString();
        }

        /// <summary>
        /// 获得删除一条数据的sql
        /// </summary>
        public string GetDeleteString(int P_id)
        {
            return "delete DM_BUSI_BigInspectionBycb where Id=" + P_id + "";
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