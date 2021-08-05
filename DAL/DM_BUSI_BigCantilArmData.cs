using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigCantilArmData
	/// </summary>
	public partial class DM_BUSI_BigCantilArmData
	{
		public DM_BUSI_BigCantilArmData()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigCantilArmData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigCantilArmData(");
			strSql.Append("Id,Updatetime,CantilArmNumber,CantilArmStartTime,CantilArmEndTime,CantilArmSupport,CantilArmLocatingring,CantildArmSite,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Updatetime,@CantilArmNumber,@CantilArmStartTime,@CantilArmEndTime,@CantilArmSupport,@CantilArmLocatingring,@CantildArmSite,@By1,@By2,@By3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CantilArmStartTime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmEndTime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmSupport", SqlDbType.Float,8),
					new SqlParameter("@CantilArmLocatingring", SqlDbType.Float,8),
					new SqlParameter("@CantildArmSite", SqlDbType.Float,8),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.CantilArmNumber;
			parameters[3].Value = model.CantilArmStartTime;
			parameters[4].Value = model.CantilArmEndTime;
			parameters[5].Value = model.CantilArmSupport;
			parameters[6].Value = model.CantilArmLocatingring;
			parameters[7].Value = model.CantildArmSite;
			parameters[8].Value = model.By1;
			parameters[9].Value = model.By2;
			parameters[10].Value = model.By3;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Vline.Model.DM_BUSI_BigCantilArmData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigCantilArmData set ");
			strSql.Append("Id=@Id,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("CantilArmNumber=@CantilArmNumber,");
			strSql.Append("CantilArmStartTime=@CantilArmStartTime,");
			strSql.Append("CantilArmEndTime=@CantilArmEndTime,");
			strSql.Append("CantilArmSupport=@CantilArmSupport,");
			strSql.Append("CantilArmLocatingring=@CantilArmLocatingring,");
			strSql.Append("CantildArmSite=@CantildArmSite,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CantilArmStartTime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmEndTime", SqlDbType.DateTime),
					new SqlParameter("@CantilArmSupport", SqlDbType.Float,8),
					new SqlParameter("@CantilArmLocatingring", SqlDbType.Float,8),
					new SqlParameter("@CantildArmSite", SqlDbType.Float,8),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.CantilArmNumber;
			parameters[3].Value = model.CantilArmStartTime;
			parameters[4].Value = model.CantilArmEndTime;
			parameters[5].Value = model.CantilArmSupport;
			parameters[6].Value = model.CantilArmLocatingring;
			parameters[7].Value = model.CantildArmSite;
			parameters[8].Value = model.By1;
			parameters[9].Value = model.By2;
			parameters[10].Value = model.By3;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_BUSI_BigCantilArmData ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public Vline.Model.DM_BUSI_BigCantilArmData GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Updatetime,CantilArmNumber,CantilArmStartTime,CantilArmEndTime,CantilArmSupport,CantilArmLocatingring,CantildArmSite,By1,By2,By3 from DM_BUSI_BigCantilArmData ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Vline.Model.DM_BUSI_BigCantilArmData model=new Vline.Model.DM_BUSI_BigCantilArmData();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Vline.Model.DM_BUSI_BigCantilArmData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigCantilArmData model=new Vline.Model.DM_BUSI_BigCantilArmData();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Updatetime"]!=null && row["Updatetime"].ToString()!="")
				{
					model.Updatetime=DateTime.Parse(row["Updatetime"].ToString());
				}
				if(row["CantilArmNumber"]!=null)
				{
					model.CantilArmNumber=row["CantilArmNumber"].ToString();
				}
				if(row["CantilArmStartTime"]!=null && row["CantilArmStartTime"].ToString()!="")
				{
					model.CantilArmStartTime=DateTime.Parse(row["CantilArmStartTime"].ToString());
				}
				if(row["CantilArmEndTime"]!=null && row["CantilArmEndTime"].ToString()!="")
				{
					model.CantilArmEndTime=DateTime.Parse(row["CantilArmEndTime"].ToString());
				}
				if(row["CantilArmSupport"]!=null && row["CantilArmSupport"].ToString()!="")
				{
					model.CantilArmSupport=decimal.Parse(row["CantilArmSupport"].ToString());
				}
				if(row["CantilArmLocatingring"]!=null && row["CantilArmLocatingring"].ToString()!="")
				{
					model.CantilArmLocatingring=decimal.Parse(row["CantilArmLocatingring"].ToString());
				}
				if(row["CantildArmSite"]!=null && row["CantildArmSite"].ToString()!="")
				{
					model.CantildArmSite=decimal.Parse(row["CantildArmSite"].ToString());
				}
				if(row["By1"]!=null)
				{
					model.By1=row["By1"].ToString();
				}
				if(row["By2"]!=null)
				{
					model.By2=row["By2"].ToString();
				}
				if(row["By3"]!=null)
				{
					model.By3=row["By3"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Updatetime,CantilArmNumber,CantilArmStartTime,CantilArmEndTime,CantilArmSupport,CantilArmLocatingring,CantildArmSite,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigCantilArmData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Id,Updatetime,CantilArmNumber,CantilArmStartTime,CantilArmEndTime,CantilArmSupport,CantilArmLocatingring,CantildArmSite,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigCantilArmData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DM_BUSI_BigCantilArmData ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigCantilArmData T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DM_BUSI_BigCantilArmData";
			parameters[1].Value = "";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

