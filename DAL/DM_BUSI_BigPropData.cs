using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigPropData
	/// </summary>
	public partial class DM_BUSI_BigPropData
	{
		public DM_BUSI_BigPropData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigPropData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigPropData");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigPropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigPropData(");
			strSql.Append("Id,propId,mdName,code,type,czz,psr,xsr,dwh,dwz,ffk,pwb,xwb,dwg,wbzcL,wbzcP,wbzcX,dwzc1L,dwzc1B,dwzc1D,dwzc2L,dwzc2B,dwzc2D,dwParam,dzParam,xgParam,dwpd,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@propId,@mdName,@code,@type,@czz,@psr,@xsr,@dwh,@dwz,@ffk,@pwb,@xwb,@dwg,@wbzcL,@wbzcP,@wbzcX,@dwzc1L,@dwzc1B,@dwzc1D,@dwzc2L,@dwzc2B,@dwzc2D,@dwParam,@dzParam,@xgParam,@dwpd,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@propId", SqlDbType.VarChar,50),
					new SqlParameter("@mdName", SqlDbType.VarChar,50),
					new SqlParameter("@code", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@czz", SqlDbType.VarChar,50),
					new SqlParameter("@psr", SqlDbType.VarChar,50),
					new SqlParameter("@xsr", SqlDbType.VarChar,50),
					new SqlParameter("@dwh", SqlDbType.VarChar,50),
					new SqlParameter("@dwz", SqlDbType.VarChar,50),
					new SqlParameter("@ffk", SqlDbType.VarChar,50),
					new SqlParameter("@pwb", SqlDbType.VarChar,50),
					new SqlParameter("@xwb", SqlDbType.VarChar,50),
					new SqlParameter("@dwg", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcL", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcP", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcX", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1L", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1B", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1D", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2L", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2B", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2D", SqlDbType.VarChar,50),
					new SqlParameter("@dwParam", SqlDbType.VarChar,50),
					new SqlParameter("@dzParam", SqlDbType.VarChar,50),
					new SqlParameter("@xgParam", SqlDbType.VarChar,50),
					new SqlParameter("@dwpd", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.propId;
			parameters[2].Value = model.mdName;
			parameters[3].Value = model.code;
			parameters[4].Value = model.type;
			parameters[5].Value = model.czz;
			parameters[6].Value = model.psr;
			parameters[7].Value = model.xsr;
			parameters[8].Value = model.dwh;
			parameters[9].Value = model.dwz;
			parameters[10].Value = model.ffk;
			parameters[11].Value = model.pwb;
			parameters[12].Value = model.xwb;
			parameters[13].Value = model.dwg;
			parameters[14].Value = model.wbzcL;
			parameters[15].Value = model.wbzcP;
			parameters[16].Value = model.wbzcX;
			parameters[17].Value = model.dwzc1L;
			parameters[18].Value = model.dwzc1B;
			parameters[19].Value = model.dwzc1D;
			parameters[20].Value = model.dwzc2L;
			parameters[21].Value = model.dwzc2B;
			parameters[22].Value = model.dwzc2D;
			parameters[23].Value = model.dwParam;
			parameters[24].Value = model.dzParam;
			parameters[25].Value = model.xgParam;
			parameters[26].Value = model.dwpd;
			parameters[27].Value = model.by1;
			parameters[28].Value = model.by2;
			parameters[29].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigPropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigPropData set ");
			strSql.Append("propId=@propId,");
			strSql.Append("mdName=@mdName,");
			strSql.Append("code=@code,");
			strSql.Append("type=@type,");
			strSql.Append("czz=@czz,");
			strSql.Append("psr=@psr,");
			strSql.Append("xsr=@xsr,");
			strSql.Append("dwh=@dwh,");
			strSql.Append("dwz=@dwz,");
			strSql.Append("ffk=@ffk,");
			strSql.Append("pwb=@pwb,");
			strSql.Append("xwb=@xwb,");
			strSql.Append("dwg=@dwg,");
			strSql.Append("wbzcL=@wbzcL,");
			strSql.Append("wbzcP=@wbzcP,");
			strSql.Append("wbzcX=@wbzcX,");
			strSql.Append("dwzc1L=@dwzc1L,");
			strSql.Append("dwzc1B=@dwzc1B,");
			strSql.Append("dwzc1D=@dwzc1D,");
			strSql.Append("dwzc2L=@dwzc2L,");
			strSql.Append("dwzc2B=@dwzc2B,");
			strSql.Append("dwzc2D=@dwzc2D,");
			strSql.Append("dwParam=@dwParam,");
			strSql.Append("dzParam=@dzParam,");
			strSql.Append("xgParam=@xgParam,");
			strSql.Append("dwpd=@dwpd,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@propId", SqlDbType.VarChar,50),
					new SqlParameter("@mdName", SqlDbType.VarChar,50),
					new SqlParameter("@code", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@czz", SqlDbType.VarChar,50),
					new SqlParameter("@psr", SqlDbType.VarChar,50),
					new SqlParameter("@xsr", SqlDbType.VarChar,50),
					new SqlParameter("@dwh", SqlDbType.VarChar,50),
					new SqlParameter("@dwz", SqlDbType.VarChar,50),
					new SqlParameter("@ffk", SqlDbType.VarChar,50),
					new SqlParameter("@pwb", SqlDbType.VarChar,50),
					new SqlParameter("@xwb", SqlDbType.VarChar,50),
					new SqlParameter("@dwg", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcL", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcP", SqlDbType.VarChar,50),
					new SqlParameter("@wbzcX", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1L", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1B", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc1D", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2L", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2B", SqlDbType.VarChar,50),
					new SqlParameter("@dwzc2D", SqlDbType.VarChar,50),
					new SqlParameter("@dwParam", SqlDbType.VarChar,50),
					new SqlParameter("@dzParam", SqlDbType.VarChar,50),
					new SqlParameter("@xgParam", SqlDbType.VarChar,50),
					new SqlParameter("@dwpd", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.propId;
			parameters[1].Value = model.mdName;
			parameters[2].Value = model.code;
			parameters[3].Value = model.type;
			parameters[4].Value = model.czz;
			parameters[5].Value = model.psr;
			parameters[6].Value = model.xsr;
			parameters[7].Value = model.dwh;
			parameters[8].Value = model.dwz;
			parameters[9].Value = model.ffk;
			parameters[10].Value = model.pwb;
			parameters[11].Value = model.xwb;
			parameters[12].Value = model.dwg;
			parameters[13].Value = model.wbzcL;
			parameters[14].Value = model.wbzcP;
			parameters[15].Value = model.wbzcX;
			parameters[16].Value = model.dwzc1L;
			parameters[17].Value = model.dwzc1B;
			parameters[18].Value = model.dwzc1D;
			parameters[19].Value = model.dwzc2L;
			parameters[20].Value = model.dwzc2B;
			parameters[21].Value = model.dwzc2D;
			parameters[22].Value = model.dwParam;
			parameters[23].Value = model.dzParam;
			parameters[24].Value = model.xgParam;
			parameters[25].Value = model.dwpd;
			parameters[26].Value = model.by1;
			parameters[27].Value = model.by2;
			parameters[28].Value = model.by3;
			parameters[29].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigPropData ");
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
			strSql.Append("delete from DM_BUSI_BigPropData ");
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
		public Vline.Model.DM_BUSI_BigPropData GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,propId,mdName,code,type,czz,psr,xsr,dwh,dwz,ffk,pwb,xwb,dwg,wbzcL,wbzcP,wbzcX,dwzc1L,dwzc1B,dwzc1D,dwzc2L,dwzc2B,dwzc2D,dwParam,dzParam,xgParam,dwpd,by1,by2,by3 from DM_BUSI_BigPropData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigPropData model=new Vline.Model.DM_BUSI_BigPropData();
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
		public Vline.Model.DM_BUSI_BigPropData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigPropData model=new Vline.Model.DM_BUSI_BigPropData();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["propId"]!=null)
				{
					model.propId=row["propId"].ToString();
				}
				if(row["mdName"]!=null)
				{
					model.mdName=row["mdName"].ToString();
				}
				if(row["code"]!=null)
				{
					model.code=row["code"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["czz"]!=null)
				{
					model.czz=row["czz"].ToString();
				}
				if(row["psr"]!=null)
				{
					model.psr=row["psr"].ToString();
				}
				if(row["xsr"]!=null)
				{
					model.xsr=row["xsr"].ToString();
				}
				if(row["dwh"]!=null)
				{
					model.dwh=row["dwh"].ToString();
				}
				if(row["dwz"]!=null)
				{
					model.dwz=row["dwz"].ToString();
				}
				if(row["ffk"]!=null)
				{
					model.ffk=row["ffk"].ToString();
				}
				if(row["pwb"]!=null)
				{
					model.pwb=row["pwb"].ToString();
				}
				if(row["xwb"]!=null)
				{
					model.xwb=row["xwb"].ToString();
				}
				if(row["dwg"]!=null)
				{
					model.dwg=row["dwg"].ToString();
				}
				if(row["wbzcL"]!=null)
				{
					model.wbzcL=row["wbzcL"].ToString();
				}
				if(row["wbzcP"]!=null)
				{
					model.wbzcP=row["wbzcP"].ToString();
				}
				if(row["wbzcX"]!=null)
				{
					model.wbzcX=row["wbzcX"].ToString();
				}
				if(row["dwzc1L"]!=null)
				{
					model.dwzc1L=row["dwzc1L"].ToString();
				}
				if(row["dwzc1B"]!=null)
				{
					model.dwzc1B=row["dwzc1B"].ToString();
				}
				if(row["dwzc1D"]!=null)
				{
					model.dwzc1D=row["dwzc1D"].ToString();
				}
				if(row["dwzc2L"]!=null)
				{
					model.dwzc2L=row["dwzc2L"].ToString();
				}
				if(row["dwzc2B"]!=null)
				{
					model.dwzc2B=row["dwzc2B"].ToString();
				}
				if(row["dwzc2D"]!=null)
				{
					model.dwzc2D=row["dwzc2D"].ToString();
				}
				if(row["dwParam"]!=null)
				{
					model.dwParam=row["dwParam"].ToString();
				}
				if(row["dzParam"]!=null)
				{
					model.dzParam=row["dzParam"].ToString();
				}
				if(row["xgParam"]!=null)
				{
					model.xgParam=row["xgParam"].ToString();
				}
				if(row["dwpd"]!=null)
				{
					model.dwpd=row["dwpd"].ToString();
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
			strSql.Append("select Id,propId,mdName,code,type,czz,psr,xsr,dwh,dwz,ffk,pwb,xwb,dwg,wbzcL,wbzcP,wbzcX,dwzc1L,dwzc1B,dwzc1D,dwzc2L,dwzc2B,dwzc2D,dwParam,dzParam,xgParam,dwpd,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPropData ");
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
			strSql.Append(" Id,propId,mdName,code,type,czz,psr,xsr,dwh,dwz,ffk,pwb,xwb,dwg,wbzcL,wbzcP,wbzcX,dwzc1L,dwzc1B,dwzc1D,dwzc2L,dwzc2B,dwzc2D,dwParam,dzParam,xgParam,dwpd,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPropData ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigPropData ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigPropData T ");
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
			parameters[0].Value = "DM_BUSI_BigPropData";
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

