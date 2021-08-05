using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Collections;
using System.Data;

namespace Vline.Web.DispatchManageSystem.BigDataWuZi
{
    /// <summary>
    /// GetWzsj 的摘要说明
    /// </summary>
    public class GetWzsj : IHttpHandler
    {
        BLL.DM_BUSI_WZSJ b_YearPlanType = new BLL.DM_BUSI_WZSJ();
        Model.DM_BUSI_WZSJ m_YearPlanType = new Model.DM_BUSI_WZSJ();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "UTF-8";

            string opreate = context.Request["Opreate"];
            string Id = context.Request["Id"];
            string dataObject = context.Request["dataObject"];

            if (opreate == "GetList")
            {
                string sJson = GetData();
                sJson = Serialize.JsonSerializeDate(sJson);
                context.Response.Write(sJson);
            }
            if (opreate == "Add")
            {
                string sqlMessage = ToAdd(dataObject);

                string str = GetData();
                context.Response.Write(str);
            }
            if (opreate == "Delete")
            {
                ToDelete(Id);
                string str = GetData();
                context.Response.Write(str);
            }

        }

        public string GetData()
        {
            try
            {
                DataSet dsMessage = b_YearPlanType.GetAllList();
                return Serialize.DataTableToJsonWithJavaScriptSerializer(dsMessage.Tables[0]);
            }
            catch
            { return ""; }
        }

        //保存列表数据-----------------------------------------------------
        public string ToAdd(string json)
        {
            DataTable dataTable = new DataTable();  //实例化

            string res = "";
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值

            ArrayList arrayList = javaScriptSerializer.Deserialize<ArrayList>(json);
            if (arrayList.Count > 0)
            {
                foreach (Dictionary<string, object> dictionary in arrayList)
                {
                    if (dictionary.Keys.Contains<String>("Id"))
                    {
                        //编辑
                        res = UpdateType(dictionary);
                    }
                    else
                    {
                        //新增
                        res = AddType(dictionary);
                    }
                }
            }
            return res;

        }
        private string AddType(Dictionary<string, object> dictionary)
        {
            try
            {
                m_YearPlanType.Id = Convert.ToInt32(b_YearPlanType.GetMaxId());
                m_YearPlanType.CGZJE = dictionary["CGZJE"].ToString();
                m_YearPlanType.DHQK = dictionary["DHQK"].ToString();
                m_YearPlanType.GYS = Convert.ToInt32(dictionary["GYS"].ToString());
                m_YearPlanType.BXBL = dictionary["BXBL"].ToString();

                b_YearPlanType.Add(m_YearPlanType);
                return "1";
            }
            catch
            {
                return "-1";
            }
        }

        private string UpdateType(Dictionary<string, object> dictionary)
        {
            try
            {
                if (!string.IsNullOrEmpty(dictionary["Id"].ToString()))
                {
                    m_YearPlanType = b_YearPlanType.GetModel(Convert.ToInt32(dictionary["Id"]));
                    m_YearPlanType.CGZJE = dictionary["CGZJE"].ToString();
                    m_YearPlanType.DHQK = dictionary["DHQK"].ToString();
                    m_YearPlanType.GYS = Convert.ToInt32(dictionary["GYS"].ToString());
                    m_YearPlanType.BXBL = dictionary["BXBL"].ToString();
                    b_YearPlanType.Update(m_YearPlanType);
                    return "1";
                }
                else
                    return "2";
            }
            catch (InvalidCastException e)
            {
                return "-1";
            }
        }

        private void ToDelete(string Id)
        {
            try
            {
                if (!string.IsNullOrEmpty(Id))
                {
                    b_YearPlanType.Delete(Convert.ToInt32(Id));
                }

            }
            catch
            { }
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