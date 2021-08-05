﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigOutputValueByjd
	/// </summary>
	public partial class DM_BUSI_BigOutputValueByjd
	{
		public DM_BUSI_BigOutputValueByjd()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigOutputValueByjd"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigOutputValueByjd");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigOutputValueByjd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigOutputValueByjd(");
			strSql.Append("Id,profession,month,quarter,year,ydcomplete,ydplan,accumulative,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@profession,@month,@quarter,@year,@ydcomplete,@ydplan,@accumulative,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@profession", SqlDbType.VarChar,50),
					new SqlParameter("@month", SqlDbType.VarChar,50),
					new SqlParameter("@quarter", SqlDbType.VarChar,50),
					new SqlParameter("@year", SqlDbType.VarChar,50),
					new SqlParameter("@ydcomplete", SqlDbType.Decimal,9),
					new SqlParameter("@ydplan", SqlDbType.Decimal,9),
					new SqlParameter("@accumulative", SqlDbType.Decimal,9),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.profession;
			parameters[2].Value = model.month;
			parameters[3].Value = model.quarter;
			parameters[4].Value = model.year;
			parameters[5].Value = model.ydcomplete;
			parameters[6].Value = model.ydplan;
			parameters[7].Value = model.accumulative;
			parameters[8].Value = model.by1;
			parameters[9].Value = model.by2;
			parameters[10].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigOutputValueByjd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigOutputValueByjd set ");
			strSql.Append("profession=@profession,");
			strSql.Append("month=@month,");
			strSql.Append("quarter=@quarter,");
			strSql.Append("year=@year,");
			strSql.Append("ydcomplete=@ydcomplete,");
			strSql.Append("ydplan=@ydplan,");
			strSql.Append("accumulative=@accumulative,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@profession", SqlDbType.VarChar,50),
					new SqlParameter("@month", SqlDbType.VarChar,50),
					new SqlParameter("@quarter", SqlDbType.VarChar,50),
					new SqlParameter("@year", SqlDbType.VarChar,50),
					new SqlParameter("@ydcomplete", SqlDbType.Decimal,9),
					new SqlParameter("@ydplan", SqlDbType.Decimal,9),
					new SqlParameter("@accumulative", SqlDbType.Decimal,9),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.profession;
			parameters[1].Value = model.month;
			parameters[2].Value = model.quarter;
			parameters[3].Value = model.year;
			parameters[4].Value = model.ydcomplete;
			parameters[5].Value = model.ydplan;
			parameters[6].Value = model.accumulative;
			parameters[7].Value = model.by1;
			parameters[8].Value = model.by2;
			parameters[9].Value = model.by3;
			parameters[10].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigOutputValueByjd ");
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
			strSql.Append("delete from DM_BUSI_BigOutputValueByjd ");
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
		public Vline.Model.DM_BUSI_BigOutputValueByjd GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,profession,month,quarter,year,ydcomplete,ydplan,accumulative,by1,by2,by3 from DM_BUSI_BigOutputValueByjd ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigOutputValueByjd model=new Vline.Model.DM_BUSI_BigOutputValueByjd();
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
		public Vline.Model.DM_BUSI_BigOutputValueByjd DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigOutputValueByjd model=new Vline.Model.DM_BUSI_BigOutputValueByjd();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["profession"]!=null)
				{
					model.profession=row["profession"].ToString();
				}
				if(row["month"]!=null)
				{
					model.month=row["month"].ToString();
				}
				if(row["quarter"]!=null)
				{
					model.quarter=row["quarter"].ToString();
				}
				if(row["year"]!=null)
				{
					model.year=row["year"].ToString();
				}
				if(row["ydcomplete"]!=null && row["ydcomplete"].ToString()!="")
				{
					model.ydcomplete=decimal.Parse(row["ydcomplete"].ToString());
				}
				if(row["ydplan"]!=null && row["ydplan"].ToString()!="")
				{
					model.ydplan=decimal.Parse(row["ydplan"].ToString());
				}
				if(row["accumulative"]!=null && row["accumulative"].ToString()!="")
				{
					model.accumulative=decimal.Parse(row["accumulative"].ToString());
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
			strSql.Append("select Id,profession,month,quarter,year,ydcomplete,ydplan,accumulative,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigOutputValueByjd ");
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
			strSql.Append(" Id,profession,month,quarter,year,ydcomplete,ydplan,accumulative,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigOutputValueByjd ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigOutputValueByjd ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigOutputValueByjd T ");
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
			parameters[0].Value = "DM_BUSI_BigOutputValueByjd";
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

