using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigAgreementBycb
	/// </summary>
	public partial class DM_BUSI_BigAgreementBycb
	{
		public DM_BUSI_BigAgreementBycb()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigAgreementBycb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigAgreementBycb");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigAgreementBycb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigAgreementBycb(");
			strSql.Append("Id,zhtje,bchtje,zrcbysje,lwfbhtje,zyfbhtje,wzhtje,jxzlhtje,year,quarter,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@zhtje,@bchtje,@zrcbysje,@lwfbhtje,@zyfbhtje,@wzhtje,@jxzlhtje,@year,@quarter,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@zhtje", SqlDbType.Decimal,9),
					new SqlParameter("@bchtje", SqlDbType.Decimal,9),
					new SqlParameter("@zrcbysje", SqlDbType.Decimal,9),
					new SqlParameter("@lwfbhtje", SqlDbType.Decimal,9),
					new SqlParameter("@zyfbhtje", SqlDbType.Decimal,9),
					new SqlParameter("@wzhtje", SqlDbType.Decimal,9),
					new SqlParameter("@jxzlhtje", SqlDbType.Decimal,9),
					new SqlParameter("@year", SqlDbType.VarChar,50),
					new SqlParameter("@quarter", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.zhtje;
			parameters[2].Value = model.bchtje;
			parameters[3].Value = model.zrcbysje;
			parameters[4].Value = model.lwfbhtje;
			parameters[5].Value = model.zyfbhtje;
			parameters[6].Value = model.wzhtje;
			parameters[7].Value = model.jxzlhtje;
			parameters[8].Value = model.year;
			parameters[9].Value = model.quarter;
			parameters[10].Value = model.by1;
			parameters[11].Value = model.by2;
			parameters[12].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigAgreementBycb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigAgreementBycb set ");
			strSql.Append("zhtje=@zhtje,");
			strSql.Append("bchtje=@bchtje,");
			strSql.Append("zrcbysje=@zrcbysje,");
			strSql.Append("lwfbhtje=@lwfbhtje,");
			strSql.Append("zyfbhtje=@zyfbhtje,");
			strSql.Append("wzhtje=@wzhtje,");
			strSql.Append("jxzlhtje=@jxzlhtje,");
			strSql.Append("year=@year,");
			strSql.Append("quarter=@quarter,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@zhtje", SqlDbType.Decimal,9),
					new SqlParameter("@bchtje", SqlDbType.Decimal,9),
					new SqlParameter("@zrcbysje", SqlDbType.Decimal,9),
					new SqlParameter("@lwfbhtje", SqlDbType.Decimal,9),
					new SqlParameter("@zyfbhtje", SqlDbType.Decimal,9),
					new SqlParameter("@wzhtje", SqlDbType.Decimal,9),
					new SqlParameter("@jxzlhtje", SqlDbType.Decimal,9),
					new SqlParameter("@year", SqlDbType.VarChar,50),
					new SqlParameter("@quarter", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.zhtje;
			parameters[1].Value = model.bchtje;
			parameters[2].Value = model.zrcbysje;
			parameters[3].Value = model.lwfbhtje;
			parameters[4].Value = model.zyfbhtje;
			parameters[5].Value = model.wzhtje;
			parameters[6].Value = model.jxzlhtje;
			parameters[7].Value = model.year;
			parameters[8].Value = model.quarter;
			parameters[9].Value = model.by1;
			parameters[10].Value = model.by2;
			parameters[11].Value = model.by3;
			parameters[12].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigAgreementBycb ");
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
			strSql.Append("delete from DM_BUSI_BigAgreementBycb ");
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
		public Vline.Model.DM_BUSI_BigAgreementBycb GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,zhtje,bchtje,zrcbysje,lwfbhtje,zyfbhtje,wzhtje,jxzlhtje,year,quarter,by1,by2,by3 from DM_BUSI_BigAgreementBycb ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigAgreementBycb model=new Vline.Model.DM_BUSI_BigAgreementBycb();
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
		public Vline.Model.DM_BUSI_BigAgreementBycb DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigAgreementBycb model=new Vline.Model.DM_BUSI_BigAgreementBycb();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["zhtje"]!=null && row["zhtje"].ToString()!="")
				{
					model.zhtje=decimal.Parse(row["zhtje"].ToString());
				}
				if(row["bchtje"]!=null && row["bchtje"].ToString()!="")
				{
					model.bchtje=decimal.Parse(row["bchtje"].ToString());
				}
				if(row["zrcbysje"]!=null && row["zrcbysje"].ToString()!="")
				{
					model.zrcbysje=decimal.Parse(row["zrcbysje"].ToString());
				}
				if(row["lwfbhtje"]!=null && row["lwfbhtje"].ToString()!="")
				{
					model.lwfbhtje=decimal.Parse(row["lwfbhtje"].ToString());
				}
				if(row["zyfbhtje"]!=null && row["zyfbhtje"].ToString()!="")
				{
					model.zyfbhtje=decimal.Parse(row["zyfbhtje"].ToString());
				}
				if(row["wzhtje"]!=null && row["wzhtje"].ToString()!="")
				{
					model.wzhtje=decimal.Parse(row["wzhtje"].ToString());
				}
				if(row["jxzlhtje"]!=null && row["jxzlhtje"].ToString()!="")
				{
					model.jxzlhtje=decimal.Parse(row["jxzlhtje"].ToString());
				}
				if(row["year"]!=null)
				{
					model.year=row["year"].ToString();
				}
				if(row["quarter"]!=null)
				{
					model.quarter=row["quarter"].ToString();
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
			strSql.Append("select Id,zhtje,bchtje,zrcbysje,lwfbhtje,zyfbhtje,wzhtje,jxzlhtje,year,quarter,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigAgreementBycb ");
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
			strSql.Append(" Id,zhtje,bchtje,zrcbysje,lwfbhtje,zyfbhtje,wzhtje,jxzlhtje,year,quarter,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigAgreementBycb ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigAgreementBycb ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigAgreementBycb T ");
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
			parameters[0].Value = "DM_BUSI_BigAgreementBycb";
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

