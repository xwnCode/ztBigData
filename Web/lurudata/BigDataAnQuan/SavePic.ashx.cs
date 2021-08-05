using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.IO;
using System.Drawing;

namespace Vline.Web.DispatchManageSystem.BigDataAnQuan
{
    /// <summary>
    /// SavePic 的摘要说明
    /// </summary>
    public class SavePic : IHttpHandler
    {
        BLL.DM_BUSI_YHLB b_bovb = new BLL.DM_BUSI_YHLB();
        Model.DM_BUSI_YHLB m_bovb = new Model.DM_BUSI_YHLB();
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
        public void ProcessRequest(HttpContext context)
        {

            context.Response.ContentType = "text/plain";

            string operate = context.Request.Params["oper"];
            int Id = Convert.ToInt32(context.Request.Params["Id"]);
            string pic = context.Request.Params["pic1"];
            string Img1 = context.Request.Params["pic2"];

            m_bovb = b_bovb.GetModel(Id);
            m_bovb.QTP = Base64DecodeString(pic.Split(',')[1]).ToString();
            m_bovb.HTP = Base64DecodeString(Img1.Split(',')[1]).ToString();

            bool bo = b_bovb.Update(m_bovb);
            context.Response.Write(javaScriptSerializer.Serialize(bo));
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