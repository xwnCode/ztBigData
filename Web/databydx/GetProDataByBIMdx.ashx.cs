using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.Script.Serialization;
using System.Text;
using Maticsoft.DBUtility;

namespace Vline.Web.databydx
{
    /// <summary>
    /// GetProDataByBIMdx 的摘要说明
    /// </summary>
    public class GetProDataByBIMdx : IHttpHandler
    {

        Model.DM_BUSI_BigDropData m_pcd = new Model.DM_BUSI_BigDropData();
        BLL.DM_BUSI_BigDropData b_pcd = new BLL.DM_BUSI_BigDropData();

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            string operate = context.Request.Params["operate"];
            if (operate == "List")
            {
                DataTable ds = b_pcd.GetList(" 1=1 and type='校对长度' ").Tables[0];

                //DataTable ds = b_pcd.GetList(" 1=1 and DATEDIFF(day,[DayID],GETDATE())=0 ").Tables[0];

                context.Response.Write(Serialize.DataTableToJsonWithJavaScriptSerializer(ds));
            }
            if (operate == "Add")
            {
                String Add = context.Request.Params["Add"];//获取添加的数据
               // Add = Add.Replace("DateofData", "by1");
                List<Model.DM_BUSI_BigDropData> list = Add == null ? null : javaScriptSerializer.Deserialize<List<Model.DM_BUSI_BigDropData>>(Add);

                if (Add != null)
                {
                    int count = opreate(list);
                    if (count > 0)
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
        protected int opreate(List<Model.DM_BUSI_BigDropData> Add)
        {
            List<String> list_string = new List<string>();

            foreach (Model.DM_BUSI_BigDropData m_update in Add)
            {

                //添加相应记录
                list_string.Add(GetAddString(m_update));

            }
            int count = ExecuteSqlTran(list_string);
            return count;
        }

        public string GetAddString(Vline.Model.DM_BUSI_BigDropData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_BigGetProDataBydx(");
            strSql.Append("DateofData,NameofAnsec,CrossSecNum,Span,ProjectType,BombCraOne,BombCraThr,DropperOne,DropperTwo,DropperThr,DropperFou,DropperFiv,DropperSix,DropperSev,DropperEig,DropperNin,DropperTen,DropperEle,BombCraFou,BombCraTwo,TerminalSpacing,MiddleAnchor,AnteriorFunEnd,AnteriorFunStart)");

            strSql.Append(" values (");
            strSql.Append("'" + DateTime.Now + "','" + model.mdName + "','" + model.kdNo + "','" + model.kj + "','" + model.type + "','" + model.dd1 + "','" + model.dd3 + "','" + model.dx1 + "','" + model.dx2 + "','" + model.dx3 + "','" + model.dx4 + "','" + model.dx5 + "','" + model.dx6 + "','" + model.dx7 + "','" + model.dx8 + "','" + model.dx9 + "','" + model.dx10 + "','" + model.dx11 + "','" + model.dd4 + "','" + model.dd2 + "','" + model.mjj + "','" + model.zm + "','" + model.qsd + "','" + model.hsd + "')");

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
    }
}