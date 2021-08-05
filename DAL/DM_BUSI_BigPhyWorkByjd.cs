using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigPhyWorkByjd
	/// </summary>
	public partial class DM_BUSI_BigPhyWorkByjd
	{
		public DM_BUSI_BigPhyWorkByjd()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigPhyWorkByjd"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigPhyWorkByjd");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigPhyWorkByjd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigPhyWorkByjd(");
			strSql.Append("Id,profession,projectName,unit,projectTotal,cumTotal,targetNode,monthPlan,monthFinish,cumFinish,nextPlan,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@profession,@projectName,@unit,@projectTotal,@cumTotal,@targetNode,@monthPlan,@monthFinish,@cumFinish,@nextPlan,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@profession", SqlDbType.VarChar,50),
					new SqlParameter("@projectName", SqlDbType.VarChar,50),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@projectTotal", SqlDbType.Decimal,9),
					new SqlParameter("@cumTotal", SqlDbType.Decimal,9),
					new SqlParameter("@targetNode", SqlDbType.DateTime),
					new SqlParameter("@monthPlan", SqlDbType.Decimal,9),
					new SqlParameter("@monthFinish", SqlDbType.Decimal,9),
					new SqlParameter("@cumFinish", SqlDbType.Decimal,9),
					new SqlParameter("@nextPlan", SqlDbType.Decimal,9),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.profession;
			parameters[2].Value = model.projectName;
			parameters[3].Value = model.unit;
			parameters[4].Value = model.projectTotal;
			parameters[5].Value = model.cumTotal;
			parameters[6].Value = model.targetNode;
			parameters[7].Value = model.monthPlan;
			parameters[8].Value = model.monthFinish;
			parameters[9].Value = model.cumFinish;
			parameters[10].Value = model.nextPlan;
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
		public bool Update(Vline.Model.DM_BUSI_BigPhyWorkByjd model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigPhyWorkByjd set ");
			strSql.Append("profession=@profession,");
			strSql.Append("projectName=@projectName,");
			strSql.Append("unit=@unit,");
			strSql.Append("projectTotal=@projectTotal,");
			strSql.Append("cumTotal=@cumTotal,");
			strSql.Append("targetNode=@targetNode,");
			strSql.Append("monthPlan=@monthPlan,");
			strSql.Append("monthFinish=@monthFinish,");
			strSql.Append("cumFinish=@cumFinish,");
			strSql.Append("nextPlan=@nextPlan,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@profession", SqlDbType.VarChar,50),
					new SqlParameter("@projectName", SqlDbType.VarChar,50),
					new SqlParameter("@unit", SqlDbType.VarChar,50),
					new SqlParameter("@projectTotal", SqlDbType.Decimal,9),
					new SqlParameter("@cumTotal", SqlDbType.Decimal,9),
					new SqlParameter("@targetNode", SqlDbType.DateTime),
					new SqlParameter("@monthPlan", SqlDbType.Decimal,9),
					new SqlParameter("@monthFinish", SqlDbType.Decimal,9),
					new SqlParameter("@cumFinish", SqlDbType.Decimal,9),
					new SqlParameter("@nextPlan", SqlDbType.Decimal,9),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.profession;
			parameters[1].Value = model.projectName;
			parameters[2].Value = model.unit;
			parameters[3].Value = model.projectTotal;
			parameters[4].Value = model.cumTotal;
			parameters[5].Value = model.targetNode;
			parameters[6].Value = model.monthPlan;
			parameters[7].Value = model.monthFinish;
			parameters[8].Value = model.cumFinish;
			parameters[9].Value = model.nextPlan;
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
			strSql.Append("delete from DM_BUSI_BigPhyWorkByjd ");
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
			strSql.Append("delete from DM_BUSI_BigPhyWorkByjd ");
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
		public Vline.Model.DM_BUSI_BigPhyWorkByjd GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,profession,projectName,unit,projectTotal,cumTotal,targetNode,monthPlan,monthFinish,cumFinish,nextPlan,by1,by2,by3 from DM_BUSI_BigPhyWorkByjd ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigPhyWorkByjd model=new Vline.Model.DM_BUSI_BigPhyWorkByjd();
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
		public Vline.Model.DM_BUSI_BigPhyWorkByjd DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigPhyWorkByjd model=new Vline.Model.DM_BUSI_BigPhyWorkByjd();
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
				if(row["projectName"]!=null)
				{
					model.projectName=row["projectName"].ToString();
				}
				if(row["unit"]!=null)
				{
					model.unit=row["unit"].ToString();
				}
				if(row["projectTotal"]!=null && row["projectTotal"].ToString()!="")
				{
					model.projectTotal=decimal.Parse(row["projectTotal"].ToString());
				}
				if(row["cumTotal"]!=null && row["cumTotal"].ToString()!="")
				{
					model.cumTotal=decimal.Parse(row["cumTotal"].ToString());
				}
				if(row["targetNode"]!=null && row["targetNode"].ToString()!="")
				{
					model.targetNode=DateTime.Parse(row["targetNode"].ToString());
				}
				if(row["monthPlan"]!=null && row["monthPlan"].ToString()!="")
				{
					model.monthPlan=decimal.Parse(row["monthPlan"].ToString());
				}
				if(row["monthFinish"]!=null && row["monthFinish"].ToString()!="")
				{
					model.monthFinish=decimal.Parse(row["monthFinish"].ToString());
				}
				if(row["cumFinish"]!=null && row["cumFinish"].ToString()!="")
				{
					model.cumFinish=decimal.Parse(row["cumFinish"].ToString());
				}
				if(row["nextPlan"]!=null && row["nextPlan"].ToString()!="")
				{
					model.nextPlan=decimal.Parse(row["nextPlan"].ToString());
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
			strSql.Append("select Id,profession,projectName,unit,projectTotal,cumTotal,targetNode,monthPlan,monthFinish,cumFinish,nextPlan,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPhyWorkByjd ");
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
			strSql.Append(" Id,profession,projectName,unit,projectTotal,cumTotal,targetNode,monthPlan,monthFinish,cumFinish,nextPlan,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPhyWorkByjd ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigPhyWorkByjd ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigPhyWorkByjd T ");
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
			parameters[0].Value = "DM_BUSI_BigPhyWorkByjd";
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

