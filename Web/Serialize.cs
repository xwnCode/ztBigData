using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Data;
using System.Text.RegularExpressions;

namespace Vline.Web
{
    public class Serialize
    {
        public static string JsonSerializeDate(string sJson)
        {
            sJson = Regex.Replace(sJson, @"\\/Date\((\d+)\)\\/", match =>
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(match.Groups[1].Value));
                dt = dt.ToLocalTime();
                return dt.ToString("yyyy-MM-dd");
            });
            sJson = Regex.Replace(sJson, @"\\/Date\((-*)(\d+)\)\\/", match =>
            {
                return "";
            });
            return sJson;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        public static string DataTableToJsonWithJavaScriptSerializer(DataTable table)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>();
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            return jsSerializer.Serialize(parentRow);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table">数据源</param>
        /// <param name="count">总数</param>
        /// <returns></returns>
        public static string DataTableToJsonWithJavaScriptSerializer(DataTable table, int count)
        {
            JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
            jsSerializer.MaxJsonLength = Int32.MaxValue;
            List<Dictionary<string, object>> parentRow = new List<Dictionary<string, object>>();
            Dictionary<string, object> childRow;
            foreach (DataRow row in table.Rows)
            {
                childRow = new Dictionary<string, object>(); ;
                foreach (DataColumn col in table.Columns)
                {
                    childRow.Add(col.ColumnName, row[col]);
                }
                parentRow.Add(childRow);
            }
            Dictionary<string, object> ReturnResult = new Dictionary<string, object>();
            ReturnResult.Add("total", count);
            ReturnResult.Add("rows", parentRow);
            return jsSerializer.Serialize(ReturnResult);
        }    
    }
}