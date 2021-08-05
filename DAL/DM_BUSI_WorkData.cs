using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;
using System.Data.SqlClient;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_WorkData
    /// </summary>
    public partial class DM_BUSI_WorkData
    {
        public DM_BUSI_WorkData()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "DM_BUSI_WorkData");
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_WorkData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_WorkData(");
            strSql.Append("Updatetime,Qujian,Ganhao,Direction,Site,Coordinate,Type,Worktype,Ks,Kj,Kjj,Kzquantity,Lbsyzh,Pausetime,By1,By2,By3)");
            strSql.Append(" values (");
            strSql.Append("@Updatetime,@Qujian,@Ganhao,@Direction,@Site,@Coordinate,@Type,@Worktype,@Ks,@Kj,@Kjj,@Kzquantity,@Lbsyzh,@Pausetime,@By1,@By2,@By3)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Qujian", SqlDbType.NVarChar,-1),
					new SqlParameter("@Ganhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@Direction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Site", SqlDbType.Float),
					new SqlParameter("@Coordinate", SqlDbType.Float),
                    new SqlParameter("@Type", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Worktype", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Ks", SqlDbType.Float),
                    new SqlParameter("@Kj", SqlDbType.Float),
                    new SqlParameter("@Kjj", SqlDbType.Float),
                    new SqlParameter("@Kzquantity", SqlDbType.Int,4),
                    new SqlParameter("@Lbsyzh", SqlDbType.Float),
                    new SqlParameter("@Pausetime", SqlDbType.Float),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.Qujian;
            parameters[3].Value = model.Ganhao;
            parameters[4].Value = model.Direction;
            parameters[5].Value = model.Site;
            parameters[6].Value = model.Coordinate;
            parameters[7].Value = model.Type;
            parameters[8].Value = model.Worktype;
            parameters[9].Value = model.Ks;
            parameters[10].Value = model.Kj;
            parameters[11].Value = model.Kjj;
            parameters[12].Value = model.Kzquantity;
            parameters[13].Value = model.Lbsyzh;
            parameters[14].Value = model.Pausetime;
            parameters[15].Value = model.By1;
            parameters[16].Value = model.By2;
            parameters[17].Value = model.By3;

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
        public bool Update(Vline.Model.DM_BUSI_WorkData model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_WorkData set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("Qujian=@Qujian,");
            strSql.Append("Ganhao=@Ganhao,");
            strSql.Append("Direction=@Direction,");
            strSql.Append("Site=@Site,");
            strSql.Append("Coordinate=@Coordinate,");
            strSql.Append("Type=@Type,");
            strSql.Append("Worktype=@Worktype,");
            strSql.Append("Ks=@Ks,");
            strSql.Append("Kj=@Kj,");
            strSql.Append("Kjj=@Kjj,");
            strSql.Append("Kzquantity=@Kzquantity,");
            strSql.Append("Lbsyzh=@Lbsyzh,");
            strSql.Append("Pausetime=@Pausetime,");
            strSql.Append("By1=@By1,");
            strSql.Append("By2=@By2,");
            strSql.Append("By3=@By3");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Qujian", SqlDbType.NVarChar,-1),
					new SqlParameter("@Ganhao", SqlDbType.NVarChar,-1),
					new SqlParameter("@Direction", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Site", SqlDbType.Float),
					new SqlParameter("@Coordinate", SqlDbType.Float),
                    new SqlParameter("@Type", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Worktype", SqlDbType.NVarChar,-1),
                    new SqlParameter("@Ks", SqlDbType.Float),
                    new SqlParameter("@Kj", SqlDbType.Float),
                    new SqlParameter("@Kjj", SqlDbType.Float),
                    new SqlParameter("@Kzquantity", SqlDbType.Int,4),
                    new SqlParameter("@Lbsyzh", SqlDbType.Float),
                    new SqlParameter("@Pausetime", SqlDbType.Float),
					new SqlParameter("@By1", SqlDbType.NVarChar,-1),
					new SqlParameter("@By2", SqlDbType.NVarChar,-1),
					new SqlParameter("@By3", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.Qujian;
            parameters[3].Value = model.Ganhao;
            parameters[4].Value = model.Direction;
            parameters[5].Value = model.Site;
            parameters[6].Value = model.Coordinate;
            parameters[7].Value = model.Type;
            parameters[8].Value = model.Worktype;
            parameters[9].Value = model.Ks;
            parameters[10].Value = model.Kj;
            parameters[11].Value = model.Kjj;
            parameters[12].Value = model.Kzquantity;
            parameters[13].Value = model.Lbsyzh;
            parameters[14].Value = model.Pausetime;
            parameters[15].Value = model.By1;
            parameters[16].Value = model.By2;
            parameters[17].Value = model.By3;

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
            strSql.Append("delete from DM_BUSI_WorkData ");
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
        public Vline.Model.DM_BUSI_WorkData GetModel(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Updatetime,Qujian,Ganhao,Direction,Site,Coordinate,Type,Worktype,Ks,Kj,Kjj,Kzquantity,Lbsyzh,Pausetime,By1,By2,By3 from DM_BUSI_WorkData ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            Vline.Model.DM_BUSI_WorkData model = new Vline.Model.DM_BUSI_WorkData();
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
        public Vline.Model.DM_BUSI_WorkData DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_WorkData model = new Vline.Model.DM_BUSI_WorkData();
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
                if (row["Qujian"] != null)
                {
                    model.Qujian = row["Qujian"].ToString();
                }
                if (row["Ganhao"] != null)
                {
                    model.Ganhao = row["Ganhao"].ToString();
                }
                if (row["Direction"] != null)
                {
                    model.Direction = row["Direction"].ToString();
                }
                if (row["Site"].ToString() != null)
                {
                    model.Site = Convert.ToSingle(row["Site"].ToString());
                }
                if (row["Coordinate"].ToString() != null)
                {
                    model.Coordinate = Convert.ToSingle(row["Coordinate"].ToString());
                }
                if (row["Type"] != null)
                {
                    model.Type = row["Type"].ToString();
                }
                if (row["Worktype"] != null)
                {
                    model.Worktype = row["Worktype"].ToString();
                }
                if (row["Ks"].ToString() != null)
                {
                    model.Ks = Convert.ToSingle(row["Ks"].ToString());
                }
                if (row["Kj"].ToString() != null)
                {
                    model.Kj = Convert.ToSingle(row["Kj"].ToString());
                }
                if (row["Kjj"].ToString() != null)
                {
                    model.Kjj = Convert.ToSingle(row["Kjj"].ToString());
                }
                if (row["Kzquantity"].ToString() != null)
                {
                    model.Kzquantity = Convert.ToInt32(row["Kzquantity"].ToString());
                }
                if (row["Lbsyzh"].ToString() != null)
                {
                    model.Lbsyzh = Convert.ToSingle(row["Lbsyzh"].ToString());
                }
                if (row["Pausetime"].ToString() != null)
                {
                    model.Pausetime = Convert.ToSingle(row["Pausetime"].ToString());
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
            strSql.Append("select Id,Updatetime,Qujian,Ganhao,Direction,Site,Coordinate,Type,Worktype,Ks,Kj,Kjj,Kzquantity,Lbsyzh,Pausetime,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_WorkData ");
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
            strSql.Append(" Id,Updatetime,Qujian,Ganhao,Direction,Site,Coordinate,Type,Worktype,Ks,Kj,Kjj,Kzquantity,Lbsyzh,Pausetime,By1,By2,By3 ");
            strSql.Append(" FROM DM_BUSI_WorkData ");
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
            strSql.Append("select count(1) FROM DM_BUSI_WorkData ");
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
            strSql.Append(")AS Row, T.*  from DM_BUSI_WorkData T ");
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
            strSql.Append("select count(1) FROM DM_BUSI_WorkData ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
