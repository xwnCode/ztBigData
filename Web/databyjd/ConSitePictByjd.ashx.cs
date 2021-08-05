using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using Maticsoft.DBUtility;
using System.IO;
using System.Drawing;
using System.Web.Script.Serialization;

namespace Vline.Web.databyjd
{
    /// <summary>
    /// ConSitePictByjd 的摘要说明
    /// </summary>
    public class ConSitePictByjd : IHttpHandler
    {
        BLL.DM_BUSI_BigConSitePictByjd b_bovb = new BLL.DM_BUSI_BigConSitePictByjd();
        Model.DM_BUSI_BigConSitePictByjd m_bovb = new Model.DM_BUSI_BigConSitePictByjd();
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["oper"];
            string name = context.Request.Params["name"];
            string pic = context.Request.Params["pic"];

            if (operate=="Add")
            {
                m_bovb.Id = b_bovb.GetMaxId();
                m_bovb.name = name;
                m_bovb.image = Base64DecodeString(pic.Split(',')[1]);

                bool bo = b_bovb.Add(m_bovb);
                context.Response.Write(javaScriptSerializer.Serialize(bo));
            }
            if (operate == "List")
            {
                DataTable ds = b_bovb.GetList("1=1").Tables[0];
                string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
                context.Response.Write(json);
            }
            if (operate == "del") {
                bool bo = b_bovb.Delete(Convert.ToInt32(name));

                context.Response.Write(javaScriptSerializer.Serialize(bo));
            }
            if (operate == "get")
            {
                string Id = context.Request.Params["Id"];

                m_bovb = b_bovb.GetModel(Convert.ToInt32(Id));

                context.Response.Write(javaScriptSerializer.Serialize(m_bovb));
            }
            if (operate == "update")
            {
                string Id = context.Request.Params["Id"];

                m_bovb = b_bovb.GetModel(Convert.ToInt32(Id));
                m_bovb.name = name;
                m_bovb.image = Base64DecodeString(pic.Split(',')[1]);

                bool bo = b_bovb.Update(m_bovb);

                context.Response.Write(javaScriptSerializer.Serialize(bo));
            }
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

            return (decodedByteArray);
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