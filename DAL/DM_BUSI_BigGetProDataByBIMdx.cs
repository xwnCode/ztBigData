using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigGetProDataByBIMdx
	/// </summary>
	public partial class DM_BUSI_BigGetProDataByBIMdx
	{
		public DM_BUSI_BigGetProDataByBIMdx()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigGetProDataByBIMdx"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigGetProDataByBIMdx");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Vline.Model.DM_BUSI_BigGetProDataByBIMdx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigGetProDataByBIMdx(");
			strSql.Append("DateofData,NameofAnsec,CrossSecNum,Span,ProjectType,BombCraOne,BombCraThr,DropperOne,DropperTwo,DropperThr,DropperFou,DropperFiv,DropperSix,DropperSev,DropperEig,DropperNin,DropperTen,DropperEle,BombCraFou,BombCraTwo,TerminalSpacing,MiddleAnchor,AnteriorFunEnd,AnteriorFunStart,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@DateofData,@NameofAnsec,@CrossSecNum,@Span,@ProjectType,@BombCraOne,@BombCraThr,@DropperOne,@DropperTwo,@DropperThr,@DropperFou,@DropperFiv,@DropperSix,@DropperSev,@DropperEig,@DropperNin,@DropperTen,@DropperEle,@BombCraFou,@BombCraTwo,@TerminalSpacing,@MiddleAnchor,@AnteriorFunEnd,@AnteriorFunStart,@By1,@By2,@By3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DateofData", SqlDbType.DateTime),
					new SqlParameter("@NameofAnsec", SqlDbType.NVarChar,50),
					new SqlParameter("@CrossSecNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Span", SqlDbType.NVarChar,50),
					new SqlParameter("@ProjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraOne", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraThr", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperOne", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperTwo", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperThr", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperFou", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperFiv", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperSix", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperSev", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperEig", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperNin", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperTen", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperEle", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraFou", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraTwo", SqlDbType.NVarChar,50),
					new SqlParameter("@TerminalSpacing", SqlDbType.NVarChar,50),
					new SqlParameter("@MiddleAnchor", SqlDbType.NVarChar,50),
					new SqlParameter("@AnteriorFunEnd", SqlDbType.NVarChar,50),
					new SqlParameter("@AnteriorFunStart", SqlDbType.NVarChar,50),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.DateofData;
			parameters[1].Value = model.NameofAnsec;
			parameters[2].Value = model.CrossSecNum;
			parameters[3].Value = model.Span;
			parameters[4].Value = model.ProjectType;
			parameters[5].Value = model.BombCraOne;
			parameters[6].Value = model.BombCraThr;
			parameters[7].Value = model.DropperOne;
			parameters[8].Value = model.DropperTwo;
			parameters[9].Value = model.DropperThr;
			parameters[10].Value = model.DropperFou;
			parameters[11].Value = model.DropperFiv;
			parameters[12].Value = model.DropperSix;
			parameters[13].Value = model.DropperSev;
			parameters[14].Value = model.DropperEig;
			parameters[15].Value = model.DropperNin;
			parameters[16].Value = model.DropperTen;
			parameters[17].Value = model.DropperEle;
			parameters[18].Value = model.BombCraFou;
			parameters[19].Value = model.BombCraTwo;
			parameters[20].Value = model.TerminalSpacing;
			parameters[21].Value = model.MiddleAnchor;
			parameters[22].Value = model.AnteriorFunEnd;
			parameters[23].Value = model.AnteriorFunStart;
			parameters[24].Value = model.By1;
			parameters[25].Value = model.By2;
			parameters[26].Value = model.By3;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		/// 更新一条数据
		/// </summary>
		public bool Update(Vline.Model.DM_BUSI_BigGetProDataByBIMdx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigGetProDataByBIMdx set ");
			strSql.Append("DateofData=@DateofData,");
			strSql.Append("NameofAnsec=@NameofAnsec,");
			strSql.Append("CrossSecNum=@CrossSecNum,");
			strSql.Append("Span=@Span,");
			strSql.Append("ProjectType=@ProjectType,");
			strSql.Append("BombCraOne=@BombCraOne,");
			strSql.Append("BombCraThr=@BombCraThr,");
			strSql.Append("DropperOne=@DropperOne,");
			strSql.Append("DropperTwo=@DropperTwo,");
			strSql.Append("DropperThr=@DropperThr,");
			strSql.Append("DropperFou=@DropperFou,");
			strSql.Append("DropperFiv=@DropperFiv,");
			strSql.Append("DropperSix=@DropperSix,");
			strSql.Append("DropperSev=@DropperSev,");
			strSql.Append("DropperEig=@DropperEig,");
			strSql.Append("DropperNin=@DropperNin,");
			strSql.Append("DropperTen=@DropperTen,");
			strSql.Append("DropperEle=@DropperEle,");
			strSql.Append("BombCraFou=@BombCraFou,");
			strSql.Append("BombCraTwo=@BombCraTwo,");
			strSql.Append("TerminalSpacing=@TerminalSpacing,");
			strSql.Append("MiddleAnchor=@MiddleAnchor,");
			strSql.Append("AnteriorFunEnd=@AnteriorFunEnd,");
			strSql.Append("AnteriorFunStart=@AnteriorFunStart,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@DateofData", SqlDbType.DateTime),
					new SqlParameter("@NameofAnsec", SqlDbType.NVarChar,50),
					new SqlParameter("@CrossSecNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Span", SqlDbType.NVarChar,50),
					new SqlParameter("@ProjectType", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraOne", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraThr", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperOne", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperTwo", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperThr", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperFou", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperFiv", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperSix", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperSev", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperEig", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperNin", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperTen", SqlDbType.NVarChar,50),
					new SqlParameter("@DropperEle", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraFou", SqlDbType.NVarChar,50),
					new SqlParameter("@BombCraTwo", SqlDbType.NVarChar,50),
					new SqlParameter("@TerminalSpacing", SqlDbType.NVarChar,50),
					new SqlParameter("@MiddleAnchor", SqlDbType.NVarChar,50),
					new SqlParameter("@AnteriorFunEnd", SqlDbType.NVarChar,50),
					new SqlParameter("@AnteriorFunStart", SqlDbType.NVarChar,50),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.DateofData;
			parameters[1].Value = model.NameofAnsec;
			parameters[2].Value = model.CrossSecNum;
			parameters[3].Value = model.Span;
			parameters[4].Value = model.ProjectType;
			parameters[5].Value = model.BombCraOne;
			parameters[6].Value = model.BombCraThr;
			parameters[7].Value = model.DropperOne;
			parameters[8].Value = model.DropperTwo;
			parameters[9].Value = model.DropperThr;
			parameters[10].Value = model.DropperFou;
			parameters[11].Value = model.DropperFiv;
			parameters[12].Value = model.DropperSix;
			parameters[13].Value = model.DropperSev;
			parameters[14].Value = model.DropperEig;
			parameters[15].Value = model.DropperNin;
			parameters[16].Value = model.DropperTen;
			parameters[17].Value = model.DropperEle;
			parameters[18].Value = model.BombCraFou;
			parameters[19].Value = model.BombCraTwo;
			parameters[20].Value = model.TerminalSpacing;
			parameters[21].Value = model.MiddleAnchor;
			parameters[22].Value = model.AnteriorFunEnd;
			parameters[23].Value = model.AnteriorFunStart;
			parameters[24].Value = model.By1;
			parameters[25].Value = model.By2;
			parameters[26].Value = model.By3;
			parameters[27].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigGetProDataByBIMdx ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
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
			strSql.Append("delete from DM_BUSI_BigGetProDataByBIMdx ");
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
		public Vline.Model.DM_BUSI_BigGetProDataByBIMdx GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,DateofData,NameofAnsec,CrossSecNum,Span,ProjectType,BombCraOne,BombCraThr,DropperOne,DropperTwo,DropperThr,DropperFou,DropperFiv,DropperSix,DropperSev,DropperEig,DropperNin,DropperTen,DropperEle,BombCraFou,BombCraTwo,TerminalSpacing,MiddleAnchor,AnteriorFunEnd,AnteriorFunStart,By1,By2,By3 from DM_BUSI_BigGetProDataByBIMdx ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigGetProDataByBIMdx model=new Vline.Model.DM_BUSI_BigGetProDataByBIMdx();
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
		public Vline.Model.DM_BUSI_BigGetProDataByBIMdx DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigGetProDataByBIMdx model=new Vline.Model.DM_BUSI_BigGetProDataByBIMdx();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DateofData"]!=null && row["DateofData"].ToString()!="")
				{
					model.DateofData=DateTime.Parse(row["DateofData"].ToString());
				}
				if(row["NameofAnsec"]!=null)
				{
					model.NameofAnsec=row["NameofAnsec"].ToString();
				}
				if(row["CrossSecNum"]!=null)
				{
					model.CrossSecNum=row["CrossSecNum"].ToString();
				}
				if(row["Span"]!=null)
				{
					model.Span=row["Span"].ToString();
				}
				if(row["ProjectType"]!=null)
				{
					model.ProjectType=row["ProjectType"].ToString();
				}
				if(row["BombCraOne"]!=null)
				{
					model.BombCraOne=row["BombCraOne"].ToString();
				}
				if(row["BombCraThr"]!=null)
				{
					model.BombCraThr=row["BombCraThr"].ToString();
				}
				if(row["DropperOne"]!=null)
				{
					model.DropperOne=row["DropperOne"].ToString();
				}
				if(row["DropperTwo"]!=null)
				{
					model.DropperTwo=row["DropperTwo"].ToString();
				}
				if(row["DropperThr"]!=null)
				{
					model.DropperThr=row["DropperThr"].ToString();
				}
				if(row["DropperFou"]!=null)
				{
					model.DropperFou=row["DropperFou"].ToString();
				}
				if(row["DropperFiv"]!=null)
				{
					model.DropperFiv=row["DropperFiv"].ToString();
				}
				if(row["DropperSix"]!=null)
				{
					model.DropperSix=row["DropperSix"].ToString();
				}
				if(row["DropperSev"]!=null)
				{
					model.DropperSev=row["DropperSev"].ToString();
				}
				if(row["DropperEig"]!=null)
				{
					model.DropperEig=row["DropperEig"].ToString();
				}
				if(row["DropperNin"]!=null)
				{
					model.DropperNin=row["DropperNin"].ToString();
				}
				if(row["DropperTen"]!=null)
				{
					model.DropperTen=row["DropperTen"].ToString();
				}
				if(row["DropperEle"]!=null)
				{
					model.DropperEle=row["DropperEle"].ToString();
				}
				if(row["BombCraFou"]!=null)
				{
					model.BombCraFou=row["BombCraFou"].ToString();
				}
				if(row["BombCraTwo"]!=null)
				{
					model.BombCraTwo=row["BombCraTwo"].ToString();
				}
				if(row["TerminalSpacing"]!=null)
				{
					model.TerminalSpacing=row["TerminalSpacing"].ToString();
				}
				if(row["MiddleAnchor"]!=null)
				{
					model.MiddleAnchor=row["MiddleAnchor"].ToString();
				}
				if(row["AnteriorFunEnd"]!=null)
				{
					model.AnteriorFunEnd=row["AnteriorFunEnd"].ToString();
				}
				if(row["AnteriorFunStart"]!=null)
				{
					model.AnteriorFunStart=row["AnteriorFunStart"].ToString();
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
			strSql.Append("select Id,DateofData,NameofAnsec,CrossSecNum,Span,ProjectType,BombCraOne,BombCraThr,DropperOne,DropperTwo,DropperThr,DropperFou,DropperFiv,DropperSix,DropperSev,DropperEig,DropperNin,DropperTen,DropperEle,BombCraFou,BombCraTwo,TerminalSpacing,MiddleAnchor,AnteriorFunEnd,AnteriorFunStart,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigGetProDataByBIMdx ");
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
			strSql.Append(" Id,DateofData,NameofAnsec,CrossSecNum,Span,ProjectType,BombCraOne,BombCraThr,DropperOne,DropperTwo,DropperThr,DropperFou,DropperFiv,DropperSix,DropperSev,DropperEig,DropperNin,DropperTen,DropperEle,BombCraFou,BombCraTwo,TerminalSpacing,MiddleAnchor,AnteriorFunEnd,AnteriorFunStart,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigGetProDataByBIMdx ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigGetProDataByBIMdx ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigGetProDataByBIMdx T ");
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
			parameters[0].Value = "DM_BUSI_BigGetProDataByBIMdx";
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

