using System;
using System.Collections.Generic;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_LLQK
    /// </summary>
    public partial class DM_BUSI_LLQK
    {
        public DM_BUSI_LLQK()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "DM_BUSI_LLQK");
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_LLQK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_LLQK(");
            strSql.Append("Updatetime,JCW,DL,BD,TX,XX,XH,Fas,Bas,By1,By2,By3)");
            strSql.Append(" values (");
            strSql.Append("@Updatetime,@JCW,@DL,@BD,@TX,@XX,@XH,@Fas,@Bas,@By1,@By2,@By3)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@JCW", SqlDbType.Int,4),
                    new SqlParameter("@DL", SqlDbType.Int,4),
					new SqlParameter("@BD", SqlDbType.Int,4),
                    new SqlParameter("@TX", SqlDbType.Int,4),
                    new SqlParameter("@XX", SqlDbType.Int,4),
                    new SqlParameter("@XH", SqlDbType.Int,4),
                    new SqlParameter("@Fas", SqlDbType.Int,4),
                    new SqlParameter("@Bas", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.JCW;
            parameters[3].Value = model.DL;
            parameters[4].Value = model.BD;
            parameters[5].Value = model.TX;
            parameters[6].Value = model.XX;
            parameters[7].Value = model.XH;
            parameters[8].Value = model.Fas;
            parameters[9].Value = model.Bas;
            parameters[10].Value = model.By1;
            parameters[11].Value = model.By2;
            parameters[12].Value = model.By3;

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
        public bool Update(Vline.Model.DM_BUSI_LLQK model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_LLQK set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("JCW=@JCW,");
            strSql.Append("DL=@DL,");
            strSql.Append("BD=@BD,");
            strSql.Append("TX=@TX,");
            strSql.Append("XX=@XX,");
            strSql.Append("XH=@XH,");
            strSql.Append("Fas=@Fas,");
            strSql.Append("Bas=@Bas,");
            strSql.Append("By1=@By1,");
            strSql.Append("By2=@By2,");
            strSql.Append("By3=@By3");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@JCW", SqlDbType.Int,4),
                    new SqlParameter("@DL", SqlDbType.Int,4),
					new SqlParameter("@BD", SqlDbType.Int,4),
                    new SqlParameter("@TX", SqlDbType.Int,4),
                    new SqlParameter("@XX", SqlDbType.Int,4),
                    new SqlParameter("@XH", SqlDbType.Int,4),
                    new SqlParameter("@Fas", SqlDbType.Int,4),
                    new SqlParameter("@Bas", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.JCW;
            parameters[3].Value = model.DL;
            parameters[4].Value = model.BD;
            parameters[5].Value = model.TX;
            parameters[6].Value = model.XX;
            parameters[7].Value = model.XH;
            parameters[8].Value = model.Fas;
            parameters[9].Value = model.Bas;
            parameters[10].Value = model.By1;
            parameters[11].Value = model.By2;
            parameters[12].Value = model.By3;

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
            strSql.Append("delete from DM_BUSI_LLQK ");
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
        public Vline.Model.DM_BUSI_LLQK GetModel(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Updatetime,JCW,DL,BD,TX,XX,XH,Fas,Bas,By1,By2,By3 from DM_BUSI_LLQK ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            Vline.Model.DM_BUSI_LLQK model = new Vline.Model.DM_BUSI_LLQK();
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
        public Vline.Model.DM_BUSI_LLQK DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_LLQK model = new Vline.Model.DM_BUSI_LLQK();
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
                if (row["JCW"] != null)
                {
                    model.JCW =Convert.ToInt32( row["JCW"].ToString());
                }
                if (row["DL"] != null)
                {
                    model.DL = Convert.ToInt32(row["DL"].ToString());
                }
                if (row["BD"] != null)
                {
                    model.BD = Convert.ToInt32(row["BD"].ToString());
                }
                if (row["TX"].ToString() != null)
                {
                    model.TX = Convert.ToInt32(row["TX"].ToString());
                }
                if (row["XX"].ToString() != null)
                {
                    model.XX = Convert.ToInt32(row["XX"].ToString());
                }
                if (row["XH"].ToString() != null)
                {
                    model.XH = Convert.ToInt32(row["XH"].ToString());
                }
                if (row["Fas"].ToString() != null)
                {
                    model.Fas = Convert.ToInt32(row["Fas"].ToString());
                }
                if (row["Bas"].ToString() != null)
                {
                    model.Bas = Convert.ToInt32(row["Bas"].ToString());
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
            strSql.Append("select Id,Updatetime,JCW,DL,BD,TX,XX,XH,Fas,Bas,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_LLQK ");
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
            strSql.Append(" Id,Updatetime,JCW,DL,BD,TX,XX,XH,Fas,Bas,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_LLQK ");
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
            strSql.Append("select count(1) FROM DM_BUSI_LLQK ");
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
            strSql.Append(")AS Row, T.*  from DM_BUSI_LLQK T ");
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
            strSql.Append("select count(1) FROM DM_BUSI_LLQK ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
