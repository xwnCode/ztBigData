using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.SessionState;
using Maticsoft.DBUtility;
using System.IO;
using System.Drawing;

namespace Vline.Web.databywb
{
    /// <summary>
    /// GetDeviceFilesBywb 的摘要说明
    /// </summary>
    public class GetDeviceFilesBywb : IHttpHandler, IReadOnlySessionState
    {
        Model.DM_BUSI_BigDeviceFiles m_bdf = new Model.DM_BUSI_BigDeviceFiles();
        BLL.DM_BUSI_BigDeviceFiles b_bdf = new BLL.DM_BUSI_BigDeviceFiles();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            //DataTable ds = b_bdf.GetList(" 1=1 ").Tables[0];

            DataTable ds = DbHelperSQL.Query("select  top 1 * from DM_BUSI_BigDeviceFiles  order by Updatetime desc").Tables[0];

            //ByteToImage((byte[])ds.Rows[0]["Devicepicture"]);
            //ds.Rows[0]["Devicepicture"] = ByteToImage((byte[])ds.Rows[0]["Devicepicture"]);
//            byte[] buffer = (byte[])ds.Rows[0]["Devicepicture"];
//            MemoryStream ms = new MemoryStream(buffer); // MemoryStream创建其支持存储区为内存的流。          
////MemoryStream属于System.IO类
//ms.Position = 0;
//Image img = Image.FromStream(ms);
//ms.Close();
//ds.Rows[0]["Devicepicture"] = img;

            context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
        }

        //二进制转换为图像
        private Image ByteToImage(byte[] btImage)
        {
            if (btImage.Length == 0)
                return null;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(btImage);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
            return image;
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