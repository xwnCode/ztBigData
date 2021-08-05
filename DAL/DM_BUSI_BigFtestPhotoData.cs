﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigFtestPhotoData
	/// </summary>
	public partial class DM_BUSI_BigFtestPhotoData
	{
		public DM_BUSI_BigFtestPhotoData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigFtestPhotoData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigFtestPhotoData");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigFtestPhotoData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigFtestPhotoData(");
			strSql.Append("Id,ftestId,taskId,type,shootNum,faultNum,saveNum,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@ftestId,@taskId,@type,@shootNum,@faultNum,@saveNum,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@taskId", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@shootNum", SqlDbType.Int,4),
					new SqlParameter("@faultNum", SqlDbType.Int,4),
					new SqlParameter("@saveNum", SqlDbType.Int,4),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ftestId;
			parameters[2].Value = model.taskId;
			parameters[3].Value = model.type;
			parameters[4].Value = model.shootNum;
			parameters[5].Value = model.faultNum;
			parameters[6].Value = model.saveNum;
			parameters[7].Value = model.by1;
			parameters[8].Value = model.by2;
			parameters[9].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigFtestPhotoData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigFtestPhotoData set ");
			strSql.Append("ftestId=@ftestId,");
			strSql.Append("taskId=@taskId,");
			strSql.Append("type=@type,");
			strSql.Append("shootNum=@shootNum,");
			strSql.Append("faultNum=@faultNum,");
			strSql.Append("saveNum=@saveNum,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@taskId", SqlDbType.Int,4),
					new SqlParameter("@type", SqlDbType.Int,4),
					new SqlParameter("@shootNum", SqlDbType.Int,4),
					new SqlParameter("@faultNum", SqlDbType.Int,4),
					new SqlParameter("@saveNum", SqlDbType.Int,4),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ftestId;
			parameters[1].Value = model.taskId;
			parameters[2].Value = model.type;
			parameters[3].Value = model.shootNum;
			parameters[4].Value = model.faultNum;
			parameters[5].Value = model.saveNum;
			parameters[6].Value = model.by1;
			parameters[7].Value = model.by2;
			parameters[8].Value = model.by3;
			parameters[9].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigFtestPhotoData ");
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
			strSql.Append("delete from DM_BUSI_BigFtestPhotoData ");
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
		public Vline.Model.DM_BUSI_BigFtestPhotoData GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ftestId,taskId,type,shootNum,faultNum,saveNum,by1,by2,by3 from DM_BUSI_BigFtestPhotoData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigFtestPhotoData model=new Vline.Model.DM_BUSI_BigFtestPhotoData();
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
		public Vline.Model.DM_BUSI_BigFtestPhotoData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigFtestPhotoData model=new Vline.Model.DM_BUSI_BigFtestPhotoData();
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
				if(row["taskId"]!=null && row["taskId"].ToString()!="")
				{
					model.taskId=int.Parse(row["taskId"].ToString());
				}
				if(row["type"]!=null && row["type"].ToString()!="")
				{
					model.type=int.Parse(row["type"].ToString());
				}
				if(row["shootNum"]!=null && row["shootNum"].ToString()!="")
				{
					model.shootNum=int.Parse(row["shootNum"].ToString());
				}
				if(row["faultNum"]!=null && row["faultNum"].ToString()!="")
				{
					model.faultNum=int.Parse(row["faultNum"].ToString());
				}
				if(row["saveNum"]!=null && row["saveNum"].ToString()!="")
				{
					model.saveNum=int.Parse(row["saveNum"].ToString());
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
			strSql.Append("select Id,ftestId,taskId,type,shootNum,faultNum,saveNum,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestPhotoData ");
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
			strSql.Append(" Id,ftestId,taskId,type,shootNum,faultNum,saveNum,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestPhotoData ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigFtestPhotoData ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigFtestPhotoData T ");
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
			parameters[0].Value = "DM_BUSI_BigFtestPhotoData";
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

