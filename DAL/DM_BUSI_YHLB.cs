using System;
using System.Collections.Generic;
using System.Text;
using Maticsoft.DBUtility;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Vline.DAL
{
    /// <summary>
    /// 数据访问类:DM_BUSI_YHLB
    /// </summary>
    public partial class DM_BUSI_YHLB
    {
        public DM_BUSI_YHLB()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("Id", "DM_BUSI_YHLB");
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Vline.Model.DM_BUSI_YHLB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DM_BUSI_YHLB(");
            strSql.Append("Updatetime,SSGS,XMB,YHBM,ZY,PCLB,PCXM,PCNRQ,WTMS,PCR,YHJB,ZG,BZ,PCNRH,QTP,HTP)");
            strSql.Append(" values (");
            strSql.Append("@Updatetime,@SSGS,@XMB,@YHBM,@ZY,@PCLB,@PCXM,@PCNRQ,@WTMS,@PCR,@YHJB,@ZG,@BZ,@PCNRH,@QTP,@HTP)");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@SSGS", SqlDbType.NVarChar,-1),
					new SqlParameter("@XMB", SqlDbType.NVarChar,-1),
					new SqlParameter("@YHBM", SqlDbType.NVarChar,-1),
                    new SqlParameter("@ZY", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCLB", SqlDbType.NVarChar,-1),
					new SqlParameter("@PCXM", SqlDbType.NVarChar,-1),
					new SqlParameter("@PCNRQ", SqlDbType.NVarChar,-1),
                    new SqlParameter("@WTMS", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCR", SqlDbType.NVarChar,-1),
					new SqlParameter("@YHJB", SqlDbType.NVarChar,-1),
					new SqlParameter("@ZG", SqlDbType.NVarChar,-1),
                    new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCNRH", SqlDbType.NVarChar,-1),
                    new SqlParameter("@QTP", SqlDbType.NVarChar,-1),
                    new SqlParameter("@HTP", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.SSGS;
            parameters[3].Value = model.XMB;
            parameters[4].Value = model.YHBM;
            parameters[5].Value = model.ZY;
            parameters[6].Value = model.PCLB;
            parameters[7].Value = model.PCXM;
            parameters[8].Value = model.PCNRQ;
            parameters[9].Value = model.WTMS;
            parameters[10].Value = model.PCR;
            parameters[11].Value = model.YHJB;
            parameters[12].Value = model.ZG;
            parameters[13].Value = model.BZ;
            parameters[14].Value = model.PCNRH;
            parameters[15].Value = model.QTP;
            parameters[16].Value = model.HTP;

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
        public bool Update(Vline.Model.DM_BUSI_YHLB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_YHLB set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("SSGS=@SSGS,");
            strSql.Append("XMB=@XMB,");
            strSql.Append("YHBM=@YHBM,");
            strSql.Append("ZY=@ZY,");
            strSql.Append("PCLB=@PCLB,");
            strSql.Append("PCXM=@PCXM,");
            strSql.Append("PCNRQ=@PCNRQ,");
            strSql.Append("WTMS=@WTMS,");
            strSql.Append("PCR=@PCR,");
            strSql.Append("YHJB=@YHJB,");
            strSql.Append("ZG=@ZG,");
            strSql.Append("BZ=@BZ,");
            strSql.Append("PCNRH=@PCNRH,");
            strSql.Append("QTP=@QTP,");
            strSql.Append("HTP=@HTP");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@SSGS", SqlDbType.NVarChar,-1),
					new SqlParameter("@XMB", SqlDbType.NVarChar,-1),
					new SqlParameter("@YHBM", SqlDbType.NVarChar,-1),
                    new SqlParameter("@ZY", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCLB", SqlDbType.NVarChar,-1),
					new SqlParameter("@PCXM", SqlDbType.NVarChar,-1),
					new SqlParameter("@PCNRQ", SqlDbType.NVarChar,-1),
                    new SqlParameter("@WTMS", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCR", SqlDbType.NVarChar,-1),
					new SqlParameter("@YHJB", SqlDbType.NVarChar,-1),
					new SqlParameter("@ZG", SqlDbType.NVarChar,-1),
                    new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
                    new SqlParameter("@PCNRH", SqlDbType.NVarChar,-1),
                    new SqlParameter("@QTP", SqlDbType.NVarChar,-1),
                    new SqlParameter("@HTP", SqlDbType.NVarChar,-1)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.SSGS;
            parameters[3].Value = model.XMB;
            parameters[4].Value = model.YHBM;
            parameters[5].Value = model.ZY;
            parameters[6].Value = model.PCLB;
            parameters[7].Value = model.PCXM;
            parameters[8].Value = model.PCNRQ;
            parameters[9].Value = model.WTMS;
            parameters[10].Value = model.PCR;
            parameters[11].Value = model.YHJB;
            parameters[12].Value = model.ZG;
            parameters[13].Value = model.BZ;
            parameters[14].Value = model.PCNRH;
            parameters[15].Value = model.QTP;
            parameters[16].Value = model.HTP;

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
        /// 更新排查前图片
        /// </summary>
        public bool UpdatePic(Vline.Model.DM_BUSI_YHLB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_YHLB set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("PCQ=@PCQ");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
                                        new SqlParameter("@PCQ", SqlDbType.Image)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.PCQ;

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
        /// 更新排查后图片
        /// </summary>
        public bool UpdateImg(Vline.Model.DM_BUSI_YHLB model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DM_BUSI_YHLB set ");
            strSql.Append("Updatetime=@Updatetime,");
            strSql.Append("PCH=@PCH");
            strSql.Append(" where Id=@Id");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
                                        new SqlParameter("@PCH", SqlDbType.Image)};
            parameters[0].Value = model.Id;
            parameters[1].Value = DateTime.Now;
            parameters[2].Value = model.PCH;

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
            strSql.Append("delete from DM_BUSI_YHLB ");
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
        public Vline.Model.DM_BUSI_YHLB GetModel(int Id)
        {
            //该表无主键信息，请自定义主键/条件字段
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Updatetime,SSGS,XMB,YHBM,ZY,PCLB,PCXM,PCNRQ,WTMS,PCR,YHJB,ZG,BZ,PCNRH,QTP,HTP,By1,By2,By3,PCQ,PCH from DM_BUSI_YHLB ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
            parameters[0].Value = Id;

            Vline.Model.DM_BUSI_YHLB model = new Vline.Model.DM_BUSI_YHLB();
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
        public Vline.Model.DM_BUSI_YHLB DataRowToModel(DataRow row)
        {
            Vline.Model.DM_BUSI_YHLB model = new Vline.Model.DM_BUSI_YHLB();
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
                if (row["SSGS"] != null)
                {
                    model.SSGS = row["SSGS"].ToString();
                }
                if (row["XMB"] != null)
                {
                    model.XMB = row["XMB"].ToString();
                }
                if (row["YHBM"] != null)
                {
                    model.YHBM = row["YHBM"].ToString();
                }
                if (row["ZY"].ToString() != null)
                {
                    model.ZY = row["ZY"].ToString();
                }
                if (row["PCLB"] != null)
                {
                    model.PCLB = row["PCLB"].ToString();
                }
                if (row["PCXM"] != null)
                {
                    model.PCXM = row["PCXM"].ToString();
                }
                if (row["PCNRQ"] != null)
                {
                    model.PCNRQ = row["PCNRQ"].ToString();
                }
                if (row["WTMS"].ToString() != null)
                {
                    model.WTMS = row["WTMS"].ToString();
                }
                if (row["PCR"] != null)
                {
                    model.PCR = row["PCR"].ToString();
                }
                if (row["YHJB"] != null)
                {
                    model.YHJB = row["YHJB"].ToString();
                }
                if (row["ZG"] != null)
                {
                    model.ZG = row["ZG"].ToString();
                }
                if (row["BZ"].ToString() != null)
                {
                    model.BZ = row["BZ"].ToString();
                }
                if (row["PCNRH"].ToString() != null)
                {
                    model.PCNRH = row["PCNRH"].ToString();
                }
                if (row["QTP"] != null)
                {
                    model.QTP = row["QTP"].ToString();
                }
                if (row["HTP"] != null)
                {
                    model.HTP = row["HTP"].ToString();
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
                if (row["PCQ"].ToString() != null)
                {
                    model.PCQ = ConvetToObj(row["PCQ"]);
                }
                if (row["PCH"] != null)
                {
                    model.PCH = ConvetToObj(row["PCH"]);
                }
            }
            return model;
        }

        private byte[] ConvetToObj(object obj)
        {
            BinaryFormatter se = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            se.Serialize(memStream, obj);
            byte[] bobj = memStream.ToArray();
            memStream.Close();
            return bobj;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Id,Updatetime,SSGS,XMB,YHBM,ZY,PCLB,PCXM,PCNRQ,WTMS,PCR,YHJB,ZG,BZ,PCNRH,QTP,HTP,By1,By2,By3,PCQ,PCH ");
            strSql.Append(" FROM DM_BUSI_YHLB ");
            strSql.Append(" order by Updatetime desc ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetONEList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 Id,Updatetime,SSGS,XMB,YHBM,ZY,PCLB,PCXM,PCNRQ,WTMS,PCR,YHJB,ZG,BZ,PCNRH,QTP,HTP,By1,By2,By3,PCQ,PCH ");
            strSql.Append(" FROM DM_BUSI_YHLB ");
            strSql.Append(" order by Updatetime desc ");
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
            strSql.Append(" Id,Updatetime,SSGS,XMB,YHBM,ZY,PCLB,PCXM,PCNRQ,WTMS,PCR,YHJB,ZG,BZ,PCNRH,QTP,HTP,By1,By2,By3,PCQ,PCH ");
            strSql.Append(" FROM DM_BUSI_YHLB ");
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
            strSql.Append("select count(1) FROM DM_BUSI_YHLB ");
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
            strSql.Append(")AS Row, T.*  from DM_BUSI_YHLB T ");
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
            strSql.Append("select count(1) FROM DM_BUSI_YHLB ");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            return Convert.ToInt32(obj);
        }
        #endregion
    }
}
