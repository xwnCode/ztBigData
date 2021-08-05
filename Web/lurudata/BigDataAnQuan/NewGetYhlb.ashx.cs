using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Maticsoft.DBUtility;
using System.Data;
using System.Web.Script.Serialization;
using System.Collections;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace Vline.Web.DispatchManageSystem.BigDataAnQuan
{
    /// <summary>
    /// NewGetYhlb 的摘要说明
    /// </summary>
    public class NewGetYhlb : IHttpHandler
    {
        BLL.DM_BUSI_YHLB b_YearPlanType = new BLL.DM_BUSI_YHLB();
        Model.DM_BUSI_YHLB m_YearPlanType = new Model.DM_BUSI_YHLB();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "UTF-8";

            string opreate = context.Request["Opreate"];
            string Id = context.Request["Id"];
            string dataObject = context.Request["dataObject"];
            
            string pic = context.Request["pic1"];
            string Img1 = context.Request["pic2"];

            if (opreate == "GetList")
            {
                string sJson = GetData();
                sJson = Serialize.JsonSerializeDate(sJson);
                context.Response.Write(sJson);
            }
            if (opreate == "Add")
            {
                string sqlMessage = ToAdd(dataObject, pic, Img1);

                string str = GetData();
                str = Serialize.JsonSerializeDate(str);
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
                DataSet dsMessage = b_YearPlanType.GetList(" 1=1 order by Updatetime desc");
                return Serialize.DataTableToJsonWithJavaScriptSerializer(dsMessage.Tables[0]);
            }
            catch
            { return ""; }
        }

        //保存列表数据-----------------------------------------------------
        public string ToAdd(string json, string pic, string img)
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
                        res = UpdateType(dictionary, pic, img);
                    }
                    else
                    {
                        //新增
                        res = AddType(dictionary, pic, img);
                    }
                }
            }
            else
            {
                if (pic != null && img != null)
                {
                    res = UpdateType1(pic, img);
                }
            }
            return res;

        }
        private string AddType(Dictionary<string, object> dictionary, string pic, string img)
        {
            try
            {
                m_YearPlanType.Id = Convert.ToInt32(b_YearPlanType.GetMaxId());
                m_YearPlanType.SSGS = dictionary["SSGS"].ToString();
                m_YearPlanType.YHBM = dictionary["YHBM"].ToString();
                m_YearPlanType.ZY = dictionary["ZY"].ToString();
                m_YearPlanType.PCLB = dictionary["PCLB"].ToString();
                m_YearPlanType.PCXM = dictionary["PCXM"].ToString();
                m_YearPlanType.PCR = dictionary["PCR"].ToString();
                m_YearPlanType.YHJB = dictionary["YHJB"].ToString();
                m_YearPlanType.ZG = dictionary["ZG"].ToString();
                m_YearPlanType.BZ = dictionary["BZ"].ToString();
                m_YearPlanType.PCNRH = dictionary["PCNRH"].ToString();
                m_YearPlanType.PCNRQ = dictionary["PCNRQ"].ToString();
                m_YearPlanType.XMB = dictionary["XMB"].ToString(); 
                if (pic.Contains(",")) 
                {
                    m_YearPlanType.PCQ = Base64DecodeString(pic.Split(',')[1]);
                }
                if (pic.Contains(","))
                {
                    m_YearPlanType.PCH = Base64DecodeString(img.Split(',')[1]);
                }
                b_YearPlanType.Add(m_YearPlanType);
                return "1";
            }
            catch(Exception e)
            {
                return "-1";
            }
        }

        private string UpdateType(Dictionary<string, object> dictionary, string pic, string img)
        {
            try
            {
                if (!string.IsNullOrEmpty(dictionary["Id"].ToString()))
                {
                    m_YearPlanType = b_YearPlanType.GetModel(Convert.ToInt32(dictionary["Id"]));
                    m_YearPlanType.SSGS = dictionary["SSGS"].ToString();
                    m_YearPlanType.YHBM = dictionary["YHBM"].ToString();
                    m_YearPlanType.ZY = dictionary["ZY"].ToString();
                    m_YearPlanType.PCLB = dictionary["PCLB"].ToString();
                    m_YearPlanType.PCXM = dictionary["PCXM"].ToString();
                    m_YearPlanType.PCR = dictionary["PCR"].ToString();
                    m_YearPlanType.YHJB = dictionary["YHJB"].ToString();
                    m_YearPlanType.ZG = dictionary["ZG"].ToString();
                    m_YearPlanType.BZ = dictionary["BZ"].ToString();
                    m_YearPlanType.PCNRQ = dictionary["PCNRQ"].ToString();
                    m_YearPlanType.XMB = dictionary["XMB"].ToString(); 
                    m_YearPlanType.PCNRH = dictionary["PCNRH"].ToString();
                    if (pic.Contains(","))
                    {
                        m_YearPlanType.PCQ = Base64DecodeString(pic.Split(',')[1]);
                    }
                    if (pic.Contains(","))
                    {
                        m_YearPlanType.PCH = Base64DecodeString(img.Split(',')[1]);
                    }
                    b_YearPlanType.Update(m_YearPlanType);
                    return "1";
                }
                else
                    return "-2";
            }
            catch (InvalidCastException e)
            {
                return "-1";
            }
        }

        private string UpdateType1(string pic, string img)
        {
            try
            {
                var Id = Convert.ToInt32(b_YearPlanType.GetMaxId());
                m_YearPlanType = b_YearPlanType.GetModel(Convert.ToInt32(Id-1));
                if (pic.Contains(","))
                {
                    m_YearPlanType.PCQ = Convert.FromBase64String(pic.Split(',')[1]);
                    b_YearPlanType.UpdatePic(m_YearPlanType);

                    //string str = "update DM_BUSI_YHLB set PCQ =" + m_YearPlanType.PCQ + "where Id=" + m_YearPlanType.Id;
                    //DbHelperSQL.ExecuteSql(str);
                }
                if (img.Contains(","))
                {
                    m_YearPlanType.PCH = Base64DecodeString(img.Split(',')[1]);
                    b_YearPlanType.UpdateImg(m_YearPlanType);

                    //string str = "update DM_BUSI_YHLB set PCH =" + m_YearPlanType.PCH + "where Id=" + m_YearPlanType.Id;
                    //DbHelperSQL.ExecuteSql(str);
                }
                return "1";
            }
            catch (InvalidCastException e) { return "-1"; }
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

        //将本地图片转换成二进制保存起来
        private byte[] SetImageToByteArray(string fileName)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(fileName, FileMode.Open, System.IO.FileAccess.Read, FileShare.ReadWrite);
                Bitmap bt = new Bitmap(fs);
                int streamLength = (int)fs.Length;
                byte[] image = new byte[streamLength];
                fs.Read(image, 0, streamLength);

                return image;
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {

                fs.Close();
            }
        }

        public static byte[] Base64DecodeString(string inputStr)
        {
            byte[] decodedByteArray = Convert.FromBase64String(inputStr);

            return decodedByteArray;
        }

        private byte[] ConvetToObj(object obj)
        {
            BinaryFormatter se = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            se.Serialize(memStream, obj);
            byte[] bobj = memStream.ToArray();
            memStream.Close();
            return bobj;
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