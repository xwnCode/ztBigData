using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.SessionState;
using Maticsoft.DBUtility;

namespace Vline.Web.databycb
{
    /// <summary>
    /// GetAgreementBycb 的摘要说明
    /// </summary>
    public class GetAgreementBycb : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string operate = context.Request.Params["operate"];
              string sqls = "";
              DataTable ds = new DataTable();
              if (operate == "sum")
              {
                  sqls = " SELECT SUM(zhtje) as htje from DM_BUSI_BigAgreementBycb where year=year(getdate())  ";
                  ds = DbHelperSQL.Query(sqls).Tables[0];
              }
              if (operate == "bar")
              {
                  sqls = " SELECT SUM(zhtje) as zhtje,SUM(bchtje) as bchtje from DM_BUSI_BigAgreementBycb where year=year(getdate())  ";
                  ds = DbHelperSQL.Query(sqls).Tables[0];
              }
              if (operate == "bars")
              {
                  sqls = " SELECT SUM(lwfbhtje) as lwfbhtje,SUM(zyfbhtje) as zyfbhtje,SUM(wzhtje) as wzhtje,SUM(jxzlhtje) as jxzlhtje from DM_BUSI_BigAgreementBycb where year=year(getdate())  ";
                  ds = DbHelperSQL.Query(sqls).Tables[0];
              }
              string json = Serialize.DataTableToJsonWithJavaScriptSerializer(ds);
              context.Response.Write(json);
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