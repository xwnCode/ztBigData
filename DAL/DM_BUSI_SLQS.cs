using System;
using System.Collections.Generic;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_SLQS
    /// </summary>
    public partial class DM_BUSI_SLQS
    {
        public DM_BUSI_SLQS()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "DM_BUSI_SLQS");
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_SLQS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_SLQS(");
            strSql.Append("Updatetime,YIYUE,ERYUE,SANYUE,SIYUE,WUYUE,LIUYUE,QIYUE,BAYUE,JIUYUE,SHIYUE,SHIYIYUE,SHIERYUE,By1,By2,By3)");
            strSql.Append(" values (");
            strSql.Append("@Updatetime,@YIYUE,@ERYUE,@SANYUE,@SIYUE,@WUYUE,@LIUYUE,@QIYUE,@BAYUE,@JIUYUE,@SHIYUE,@SHIYIYUE,@SHIERYUE,@By1,@By2,@By3)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@YIYUE", SqlDbType.Int,4),
					new SqlParameter("@ERYUE", SqlDbType.Int,4),
					new SqlParameter("@SANYUE", SqlDbType.Int,4),
                    new SqlParameter("@SIYUE", SqlDbType.Int,4),
                    new SqlParameter("@WUYUE", SqlDbType.Int,4),
					new SqlParameter("@LIUYUE", SqlDbType.Int,4),
					new SqlParameter("@QIYUE", SqlDbType.Int,4),
                    new SqlParameter("@BAYUE", SqlDbType.Int,4),
                    new SqlParameter("@JIUYUE", SqlDbType.Int,4),
					new SqlParameter("@SHIYUE", SqlDbType.Int,4),
					new SqlParameter("@SHIYIYUE", SqlDbType.Int,4),
                    new SqlParameter("@SHIERYUE", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.YIYUE;
            parameters[3].Value = model.ERYUE;
            parameters[4].Value = model.SANYUE;
            parameters[5].Value = model.SIYUE;

            parameters[6].Value = model.WUYUE;
            parameters[7].Value = model.LIUYUE;
            parameters[8].Value = model.QIYUE;
            parameters[9].Value = model.BAYUE;
            parameters[10].Value = model.JIUYUE;
            parameters[11].Value = model.SHIYUE;
            parameters[12].Value = model.SHIYIYUE;
            parameters[13].Value = model.SHIERYUE;
            parameters[14].Value = model.By1;
            parameters[15].Value = model.By2;
            parameters[16].Value = model.By3;

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
        public bool Update(Vline.Model.DM_BUSI_SLQS model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_SLQS set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("YIYUE=@YIYUE,");
            strSql.Append("ERYUE=@ERYUE,");
            strSql.Append("SANYUE=@SANYUE,");
            strSql.Append("SIYUE=@SIYUE,");

            strSql.Append("WUYUE=@WUYUE,");
            strSql.Append("LIUYUE=@LIUYUE,");
            strSql.Append("QIYUE=@QIYUE,");
            strSql.Append("BAYUE=@BAYUE,");
            strSql.Append("JIUYUE=@JIUYUE,");
            strSql.Append("SHIYUE=@SHIYUE,");
            strSql.Append("SHIYIYUE=@SHIYIYUE,");
            strSql.Append("SHIERYUE=@SHIERYUE,");
            strSql.Append("By1=@By1,");
            strSql.Append("By2=@By2,");
            strSql.Append("By3=@By3");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@YIYUE", SqlDbType.Int,4),
					new SqlParameter("@ERYUE", SqlDbType.Int,4),
					new SqlParameter("@SANYUE", SqlDbType.Int,4),
                    new SqlParameter("@SIYUE", SqlDbType.Int,4),
                    new SqlParameter("@WUYUE", SqlDbType.Int,4),
					new SqlParameter("@LIUYUE", SqlDbType.Int,4),
					new SqlParameter("@QIYUE", SqlDbType.Int,4),
                    new SqlParameter("@BAYUE", SqlDbType.Int,4),
                    new SqlParameter("@JIUYUE", SqlDbType.Int,4),
					new SqlParameter("@SHIYUE", SqlDbType.Int,4),
					new SqlParameter("@SHIYIYUE", SqlDbType.Int,4),
                    new SqlParameter("@SHIERYUE", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.YIYUE;
            parameters[3].Value = model.ERYUE;
            parameters[4].Value = model.SANYUE;
            parameters[5].Value = model.SIYUE;

            parameters[6].Value = model.WUYUE;
            parameters[7].Value = model.LIUYUE;
            parameters[8].Value = model.QIYUE;
            parameters[9].Value = model.BAYUE;
            parameters[10].Value = model.JIUYUE;
            parameters[11].Value = model.SHIYUE;
            parameters[12].Value = model.SHIYIYUE;
            parameters[13].Value = model.SHIERYUE;
            parameters[14].Value = model.By1;
            parameters[15].Value = model.By2;
            parameters[16].Value = model.By3;

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
            strSql.Append("delete from DM_BUSI_SLQS ");
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
        public Vline.Model.DM_BUSI_SLQS GetModel(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Updatetime,YIYUE,ERYUE,SANYUE,SIYUE,WUYUE,LIUYUE,QIYUE,BAYUE,JIUYUE,SHIYUE,SHIYIYUE,SHIERYUE,By1,By2,By3 from DM_BUSI_SLQS ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            Vline.Model.DM_BUSI_SLQS model = new Vline.Model.DM_BUSI_SLQS();
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
        public Vline.Model.DM_BUSI_SLQS DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_SLQS model = new Vline.Model.DM_BUSI_SLQS();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Updatetime"].ToString() != null)
                {
                    model.Updatetime = DateTime.Now;
                }
                if (row["YIYUE"] != null)
                {
                    model.YIYUE = Convert.ToInt32(row["YIYUE"].ToString());
                }
                if (row["ERYUE"] != null)
                {
                    model.ERYUE = Convert.ToInt32(row["ERYUE"].ToString());
                }
                if (row["SANYUE"] != null)
                {
                    model.SANYUE = Convert.ToInt32(row["SANYUE"].ToString());
                }
                if (row["SIYUE"].ToString() != null)
                {
                    model.SIYUE = Convert.ToInt32(row["SIYUE"].ToString());
                }

                if (row["WUYUE"] != null)
                {
                    model.WUYUE = Convert.ToInt32(row["WUYUE"].ToString());
                }
                if (row["LIUYUE"] != null)
                {
                    model.LIUYUE = Convert.ToInt32(row["LIUYUE"].ToString());
                }
                if (row["QIYUE"] != null)
                {
                    model.QIYUE = Convert.ToInt32(row["QIYUE"].ToString());
                }
                if (row["BAYUE"].ToString() != null)
                {
                    model.BAYUE = Convert.ToInt32(row["BAYUE"].ToString());
                }
                if (row["JIUYUE"] != null)
                {
                    model.JIUYUE = Convert.ToInt32(row["JIUYUE"].ToString());
                }
                if (row["SHIYUE"] != null)
                {
                    model.SHIYUE = Convert.ToInt32(row["SHIYUE"].ToString());
                }
                if (row["SHIYIYUE"] != null)
                {
                    model.SHIYIYUE = Convert.ToInt32(row["SHIYIYUE"].ToString());
                }
                if (row["SHIERYUE"].ToString() != null)
                {
                    model.SHIERYUE = Convert.ToInt32(row["SHIERYUE"].ToString());
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
            strSql.Append("select top 1 Id,Updatetime,YIYUE,ERYUE,SANYUE,SIYUE,WUYUE,LIUYUE,QIYUE,BAYUE,JIUYUE,SHIYUE,SHIYIYUE,SHIERYUE,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_SLQS order by Updatetime desc ");
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
            strSql.Append(" Id,Updatetime,YIYUE,ERYUE,SANYUE,SIYUE,WUYUE,LIUYUE,QIYUE,BAYUE,JIUYUE,SHIYUE,SHIYIYUE,SHIERYUE,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_SLQS ");
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
            strSql.Append("select count(1) FROM DM_BUSI_SLQS ");
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
            strSql.Append(")AS Row, T.*  from DM_BUSI_SLQS T ");
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
            strSql.Append("select count(1) FROM DM_BUSI_SLQS ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
