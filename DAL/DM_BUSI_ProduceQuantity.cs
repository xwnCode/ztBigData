using System;
using System.Collections.Generic;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_ProduceQuantity
    /// </summary>
    public partial class DM_BUSI_ProduceQuantity
    {
        public DM_BUSI_ProduceQuantity()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "DM_BUSI_YHSJ");
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_ProduceQuantity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_ProduceQuantity(");
            strSql.Append("Date,Dayplan,Daytotal,Dayqualified,By1,By2,By3)");
            strSql.Append("values (");
            strSql.Append("@Date,@Dayplan,@Daytotal,@Dayqualified,@By1,@By2,@By3)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@Dayplan", SqlDbType.Int,4),
					new SqlParameter("@Daytotal", SqlDbType.Int,4),
					new SqlParameter("@Dayqualified", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,-1),
					new SqlParameter("@By2", SqlDbType.VarChar,-1),
					new SqlParameter("@By3", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.Dayplan;
            parameters[3].Value = model.Daytotal;
            parameters[4].Value = model.Dayqualified;
            parameters[5].Value = model.By1;
            parameters[6].Value = model.By2;
            parameters[7].Value = model.By3;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Vline.Model.DM_BUSI_ProduceQuantity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_ProduceQuantity set ");
            strSql.Append("Date=@Date,");
            strSql.Append("Dayplan=@Dayplan,");
            strSql.Append("Daytotal=@Daytotal,");
            strSql.Append("Dayqualified=@Dayqualified,");
            strSql.Append("By1=@By1,");
            strSql.Append("By2=@By2,");
            strSql.Append("By3=@By3");
            strSql.Append(" where Id=@Id  ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Date", SqlDbType.DateTime),
					new SqlParameter("@Dayplan", SqlDbType.Int,4),
					new SqlParameter("@Daytotal", SqlDbType.Int,4),
					new SqlParameter("@Dayqualified", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,-1),
					new SqlParameter("@By2", SqlDbType.VarChar,-1),
					new SqlParameter("@By3", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.Dayplan;
            parameters[3].Value = model.Daytotal;
            parameters[4].Value = model.Dayqualified;
            parameters[5].Value = model.By1;
            parameters[6].Value = model.By2;
            parameters[7].Value = model.By3;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DM_BUSI_ProduceQuantity ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Vline.Model.DM_BUSI_ProduceQuantity GetModel(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Date,Dayplan,Daytotal,Dayqualified,By1,By2,By3 from DM_BUSI_ProduceQuantity ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            Vline.Model.DM_BUSI_ProduceQuantity model = new Vline.Model.DM_BUSI_ProduceQuantity();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }




        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Vline.Model.DM_BUSI_ProduceQuantity DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_ProduceQuantity model = new Vline.Model.DM_BUSI_ProduceQuantity();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Date"] != null && row["Date"].ToString() != "")
                {
                    model.Date = DateTime.Parse(row["Date"].ToString());
                }
                if (row["Dayplan"].ToString() != null)
                {
                    model.Dayplan = Convert.ToInt32(row["Dayplan"]);
                }
                if (row["Daytotal"].ToString() != null)
                {
                    model.Daytotal = Convert.ToInt32(row["Daytotal"]);
                }
                if (row["Dayqualified"].ToString() != null)
                {
                    model.Dayqualified = Convert.ToInt32(row["Dayqualified"]);
                }
                if (row["By1"] != null)
                {
                    model.By1 = row["By1"].ToString();
                }
                if (row["By2"] != null)
                {
                    model.By2 = row["By2"].ToString();
                }
                if (row["By3"] != null)
                {
                    model.By3 = row["By3"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Id,Date,Dayplan,Daytotal,Dayqualified,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_ProduceQuantity order by Date desc");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }





        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" Id,Date,Dayplan,Daytotal,Dayqualified,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_ProduceQuantity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM DM_BUSI_ProduceQuantity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T. desc");
            }
            strSql.Append(")AS Row, T.*  from DM_BUSI_ProduceQuantity T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperSQL.Query(strSql.ToString());
        }


        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod

        #region zrz

        /// <summary>
        /// 获得数量
        /// </summary>
        public int GetCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM DM_BUSI_ProduceQuantity ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
