using System;
using System.Collections.Generic;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_DeviceWork
    /// </summary>
    public partial class DM_BUSI_DeviceWork
    {
        public DM_BUSI_DeviceWork()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public string GetMaxId()
        {
            return DbHelperOra.GetMaxID("Id", "DM_BUSI_DeviceWork").ToString();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_DeviceWork model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_DeviceWork(");
            strSql.Append("Id,Updatetime,Enginespeed,Fueltank,Alternator,Deblockpre,By1,By2,By3)");
            strSql.Append(" values (");
            strSql.Append("@Id,@Updatetime,@Enginespeed,@Fueltank,@Alternator,@Deblockpre,@By1,@By2,@By3)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Enginespeed", SqlDbType.Int,4),
					new SqlParameter("@Fueltank", SqlDbType.Int,4),
					new SqlParameter("@Alternator", SqlDbType.Int,4),
					new SqlParameter("@Deblockpre", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,-1),
					new SqlParameter("@By2", SqlDbType.VarChar,-1),
					new SqlParameter("@By3", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.Updatetime;
            parameters[2].Value = model.Enginespeed;
            parameters[3].Value = model.Fueltank;
            parameters[4].Value = model.Alternator;
            parameters[5].Value = model.Deblockpre;
            parameters[7].Value = model.By1;
            parameters[8].Value = model.By2;
            parameters[9].Value = model.By3;

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
        public bool Update(Vline.Model.DM_BUSI_DeviceWork model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_DeviceWork set ");
            strSql.Append("Id=@Id,");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("Enginespeed=@Enginespeed,");
            strSql.Append("Fueltank=@Fueltank,");
            strSql.Append("Alternator=@Alternator,");
            strSql.Append("Deblockpre=@Deblockpre,");
            strSql.Append("By1=@By1,");
            strSql.Append("By2=@By2,");
            strSql.Append("By3=@By3");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Enginespeed", SqlDbType.Int,4),
					new SqlParameter("@Fueltank", SqlDbType.Int,4),
					new SqlParameter("@Alternator", SqlDbType.Int,4),
					new SqlParameter("@Deblockpre", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,-1),
					new SqlParameter("@By2", SqlDbType.VarChar,-1),
					new SqlParameter("@By3", SqlDbType.VarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = model.Updatetime;
            parameters[2].Value = model.Enginespeed;
            parameters[3].Value = model.Fueltank;
            parameters[4].Value = model.Alternator;
            parameters[5].Value = model.Deblockpre;
            parameters[7].Value = model.By1;
            parameters[8].Value = model.By2;
            parameters[9].Value = model.By3;

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
        public bool Delete()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DM_BUSI_DeviceWork ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

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
        public Vline.Model.DM_BUSI_DeviceWork GetModel()
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 Id,Updatetime,Enginespeed,Fueltank,Alternator,Deblockpre,By1,By2,By3 from DM_BUSI_DeviceWork ");
            strSql.Append(" where ");
            SqlParameter[] parameters = {
			};

            Vline.Model.DM_BUSI_DeviceWork model = new Vline.Model.DM_BUSI_DeviceWork();
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
        public Vline.Model.DM_BUSI_DeviceWork DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_DeviceWork model = new Vline.Model.DM_BUSI_DeviceWork();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Updatetime"] != null && row["Updatetime"].ToString() != "")
                {
                    model.Updatetime = DateTime.Parse(row["Updatetime"].ToString());
                }
                if (row["Enginespeed"].ToString() != null)
                {
                    model.Enginespeed =Convert.ToInt32(row["Enginespeed"]);
                }
                if (row["Fueltank"].ToString() != null)
                {
                    model.Fueltank = Convert.ToInt32(row["Fueltank"]);
                }
                if (row["Alternator"].ToString() != null)
                {
                    model.Alternator = Convert.ToInt32(row["Alternator"]);
                }
                if (row["Deblockpre"].ToString() != "")
                {
                    model.Deblockpre = Convert.ToInt32(row["Deblockpre"]);
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
            strSql.Append("select Id,Updatetime,Enginespeed,Fueltank,Alternator,Deblockpre,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_DeviceWork ");
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
            strSql.Append(" Id,Updatetime,Enginespeed,Fueltank,Alternator,Deblockpre,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_DeviceWork ");
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
            strSql.Append("select count(1) FROM DM_BUSI_DeviceWork ");
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
            strSql.Append(")AS Row, T.*  from DM_BUSI_DeviceWork T ");
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
        /// 得到一个对象实体
        /// </summary>
        public Model.DM_BUSI_DeviceWork GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Updatetime,Enginespeed,Fueltank,Alternator,Deblockpre,By1,By2,By3 FROM DM_BUSI_DeviceWork ");
            strSql.Append(" where Id=ID");

            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int)          };
            parameters[0].Value = ID;
            Model.DM_BUSI_DeviceWork model = new Model.DM_BUSI_DeviceWork();
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
        /// 获得数量
        /// </summary>
        public int GetCount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM DM_BUSI_DeviceWork ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
