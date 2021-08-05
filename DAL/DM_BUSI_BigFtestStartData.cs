using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigFtestStartData
	/// </summary>
	public partial class DM_BUSI_BigFtestStartData
	{
		public DM_BUSI_BigFtestStartData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigFtestStartData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigFtestStartData");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigFtestStartData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigFtestStartData(");
			strSql.Append("Id,ftestId,SType,LineName,TaskName,StartStation,EndStation,SStartPoleName,SEndPoleName,TaskDate,TaskDateTime,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@ftestId,@SType,@LineName,@TaskName,@StartStation,@EndStation,@SStartPoleName,@SEndPoleName,@TaskDate,@TaskDateTime,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@SType", SqlDbType.VarChar,-1),
					new SqlParameter("@LineName", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskName", SqlDbType.VarChar,-1),
					new SqlParameter("@StartStation", SqlDbType.VarChar,-1),
					new SqlParameter("@EndStation", SqlDbType.VarChar,-1),
					new SqlParameter("@SStartPoleName", SqlDbType.VarChar,-1),
					new SqlParameter("@SEndPoleName", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskDate", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskDateTime", SqlDbType.VarChar,-1),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ftestId;
			parameters[2].Value = model.SType;
			parameters[3].Value = model.LineName;
			parameters[4].Value = model.TaskName;
			parameters[5].Value = model.StartStation;
			parameters[6].Value = model.EndStation;
			parameters[7].Value = model.SStartPoleName;
			parameters[8].Value = model.SEndPoleName;
			parameters[9].Value = model.TaskDate;
			parameters[10].Value = model.TaskDateTime;
			parameters[11].Value = model.by1;
			parameters[12].Value = model.by2;
			parameters[13].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigFtestStartData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigFtestStartData set ");
			strSql.Append("ftestId=@ftestId,");
			strSql.Append("SType=@SType,");
			strSql.Append("LineName=@LineName,");
			strSql.Append("TaskName=@TaskName,");
			strSql.Append("StartStation=@StartStation,");
			strSql.Append("EndStation=@EndStation,");
			strSql.Append("SStartPoleName=@SStartPoleName,");
			strSql.Append("SEndPoleName=@SEndPoleName,");
			strSql.Append("TaskDate=@TaskDate,");
			strSql.Append("TaskDateTime=@TaskDateTime,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@SType", SqlDbType.VarChar,-1),
					new SqlParameter("@LineName", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskName", SqlDbType.VarChar,-1),
					new SqlParameter("@StartStation", SqlDbType.VarChar,-1),
					new SqlParameter("@EndStation", SqlDbType.VarChar,-1),
					new SqlParameter("@SStartPoleName", SqlDbType.VarChar,-1),
					new SqlParameter("@SEndPoleName", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskDate", SqlDbType.VarChar,-1),
					new SqlParameter("@TaskDateTime", SqlDbType.VarChar,-1),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ftestId;
			parameters[1].Value = model.SType;
			parameters[2].Value = model.LineName;
			parameters[3].Value = model.TaskName;
			parameters[4].Value = model.StartStation;
			parameters[5].Value = model.EndStation;
			parameters[6].Value = model.SStartPoleName;
			parameters[7].Value = model.SEndPoleName;
			parameters[8].Value = model.TaskDate;
			parameters[9].Value = model.TaskDateTime;
			parameters[10].Value = model.by1;
			parameters[11].Value = model.by2;
			parameters[12].Value = model.by3;
			parameters[13].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_BUSI_BigFtestStartData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

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
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_BUSI_BigFtestStartData ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Vline.Model.DM_BUSI_BigFtestStartData GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ftestId,SType,LineName,TaskName,StartStation,EndStation,SStartPoleName,SEndPoleName,TaskDate,TaskDateTime,by1,by2,by3 from DM_BUSI_BigFtestStartData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigFtestStartData model=new Vline.Model.DM_BUSI_BigFtestStartData();
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
		public Vline.Model.DM_BUSI_BigFtestStartData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigFtestStartData model=new Vline.Model.DM_BUSI_BigFtestStartData();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["ftestId"]!=null && row["ftestId"].ToString()!="")
				{
					model.ftestId=int.Parse(row["ftestId"].ToString());
				}
				if(row["SType"]!=null)
				{
					model.SType=row["SType"].ToString();
				}
				if(row["LineName"]!=null)
				{
					model.LineName=row["LineName"].ToString();
				}
				if(row["TaskName"]!=null)
				{
					model.TaskName=row["TaskName"].ToString();
				}
				if(row["StartStation"]!=null)
				{
					model.StartStation=row["StartStation"].ToString();
				}
				if(row["EndStation"]!=null)
				{
					model.EndStation=row["EndStation"].ToString();
				}
				if(row["SStartPoleName"]!=null)
				{
					model.SStartPoleName=row["SStartPoleName"].ToString();
				}
				if(row["SEndPoleName"]!=null)
				{
					model.SEndPoleName=row["SEndPoleName"].ToString();
				}
				if(row["TaskDate"]!=null)
				{
					model.TaskDate=row["TaskDate"].ToString();
				}
				if(row["TaskDateTime"]!=null)
				{
					model.TaskDateTime=row["TaskDateTime"].ToString();
				}
				if(row["by1"]!=null)
				{
					model.by1=row["by1"].ToString();
				}
				if(row["by2"]!=null)
				{
					model.by2=row["by2"].ToString();
				}
				if(row["by3"]!=null)
				{
					model.by3=row["by3"].ToString();
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
			strSql.Append("select Id,ftestId,SType,LineName,TaskName,StartStation,EndStation,SStartPoleName,SEndPoleName,TaskDate,TaskDateTime,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestStartData ");
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
			strSql.Append(" Id,ftestId,SType,LineName,TaskName,StartStation,EndStation,SStartPoleName,SEndPoleName,TaskDate,TaskDateTime,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestStartData ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigFtestStartData ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigFtestStartData T ");
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
			parameters[0].Value = "DM_BUSI_BigFtestStartData";
			parameters[1].Value = "Id";
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

