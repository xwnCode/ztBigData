using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigCurrProDataBydx
	/// </summary>
	public partial class DM_BUSI_BigCurrProDataBydx
	{
		public DM_BUSI_BigCurrProDataBydx()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigCurrProDataBydx"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigCurrProDataBydx");
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
		public int Add(Vline.Model.DM_BUSI_BigCurrProDataBydx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigCurrProDataBydx(");
			strSql.Append("Updatetime,CrossSecNum,TwistedLineSpecs,PresPipeSpecs,ThimbleSpecs,CopNoseSpecs,TorqueValue,CurDropProStarttime,CurDropProEndtime,CurProLenofdrop,CurProErrofdrop,IsQualified,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@Updatetime,@CrossSecNum,@TwistedLineSpecs,@PresPipeSpecs,@ThimbleSpecs,@CopNoseSpecs,@TorqueValue,@CurDropProStarttime,@CurDropProEndtime,@CurProLenofdrop,@CurProErrofdrop,@IsQualified,@By1,@By2,@By3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CrossSecNum", SqlDbType.NVarChar,50),
					new SqlParameter("@TwistedLineSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@PresPipeSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@ThimbleSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@CopNoseSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@TorqueValue", SqlDbType.Float,8),
					new SqlParameter("@CurDropProStarttime", SqlDbType.DateTime),
					new SqlParameter("@CurDropProEndtime", SqlDbType.DateTime),
					new SqlParameter("@CurProLenofdrop", SqlDbType.Float,8),
					new SqlParameter("@CurProErrofdrop", SqlDbType.Float,8),
					new SqlParameter("@IsQualified", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Updatetime;
			parameters[1].Value = model.CrossSecNum;
			parameters[2].Value = model.TwistedLineSpecs;
			parameters[3].Value = model.PresPipeSpecs;
			parameters[4].Value = model.ThimbleSpecs;
			parameters[5].Value = model.CopNoseSpecs;
			parameters[6].Value = model.TorqueValue;
			parameters[7].Value = model.CurDropProStarttime;
			parameters[8].Value = model.CurDropProEndtime;
			parameters[9].Value = model.CurProLenofdrop;
			parameters[10].Value = model.CurProErrofdrop;
			parameters[11].Value = model.IsQualified;
			parameters[12].Value = model.By1;
			parameters[13].Value = model.By2;
			parameters[14].Value = model.By3;

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
		public bool Update(Vline.Model.DM_BUSI_BigCurrProDataBydx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigCurrProDataBydx set ");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("CrossSecNum=@CrossSecNum,");
			strSql.Append("TwistedLineSpecs=@TwistedLineSpecs,");
			strSql.Append("PresPipeSpecs=@PresPipeSpecs,");
			strSql.Append("ThimbleSpecs=@ThimbleSpecs,");
			strSql.Append("CopNoseSpecs=@CopNoseSpecs,");
			strSql.Append("TorqueValue=@TorqueValue,");
			strSql.Append("CurDropProStarttime=@CurDropProStarttime,");
			strSql.Append("CurDropProEndtime=@CurDropProEndtime,");
			strSql.Append("CurProLenofdrop=@CurProLenofdrop,");
			strSql.Append("CurProErrofdrop=@CurProErrofdrop,");
			strSql.Append("IsQualified=@IsQualified,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CrossSecNum", SqlDbType.NVarChar,50),
					new SqlParameter("@TwistedLineSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@PresPipeSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@ThimbleSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@CopNoseSpecs", SqlDbType.NVarChar,50),
					new SqlParameter("@TorqueValue", SqlDbType.Float,8),
					new SqlParameter("@CurDropProStarttime", SqlDbType.DateTime),
					new SqlParameter("@CurDropProEndtime", SqlDbType.DateTime),
					new SqlParameter("@CurProLenofdrop", SqlDbType.Float,8),
					new SqlParameter("@CurProErrofdrop", SqlDbType.Float,8),
					new SqlParameter("@IsQualified", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Updatetime;
			parameters[1].Value = model.CrossSecNum;
			parameters[2].Value = model.TwistedLineSpecs;
			parameters[3].Value = model.PresPipeSpecs;
			parameters[4].Value = model.ThimbleSpecs;
			parameters[5].Value = model.CopNoseSpecs;
			parameters[6].Value = model.TorqueValue;
			parameters[7].Value = model.CurDropProStarttime;
			parameters[8].Value = model.CurDropProEndtime;
			parameters[9].Value = model.CurProLenofdrop;
			parameters[10].Value = model.CurProErrofdrop;
			parameters[11].Value = model.IsQualified;
			parameters[12].Value = model.By1;
			parameters[13].Value = model.By2;
			parameters[14].Value = model.By3;
			parameters[15].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigCurrProDataBydx ");
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
			strSql.Append("delete from DM_BUSI_BigCurrProDataBydx ");
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
		public Vline.Model.DM_BUSI_BigCurrProDataBydx GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Updatetime,CrossSecNum,TwistedLineSpecs,PresPipeSpecs,ThimbleSpecs,CopNoseSpecs,TorqueValue,CurDropProStarttime,CurDropProEndtime,CurProLenofdrop,CurProErrofdrop,IsQualified,By1,By2,By3 from DM_BUSI_BigCurrProDataBydx ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigCurrProDataBydx model=new Vline.Model.DM_BUSI_BigCurrProDataBydx();
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
		public Vline.Model.DM_BUSI_BigCurrProDataBydx DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigCurrProDataBydx model=new Vline.Model.DM_BUSI_BigCurrProDataBydx();
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
				if(row["CrossSecNum"]!=null)
				{
					model.CrossSecNum=row["CrossSecNum"].ToString();
				}
				if(row["TwistedLineSpecs"]!=null)
				{
					model.TwistedLineSpecs=row["TwistedLineSpecs"].ToString();
				}
				if(row["PresPipeSpecs"]!=null)
				{
					model.PresPipeSpecs=row["PresPipeSpecs"].ToString();
				}
				if(row["ThimbleSpecs"]!=null)
				{
					model.ThimbleSpecs=row["ThimbleSpecs"].ToString();
				}
				if(row["CopNoseSpecs"]!=null)
				{
					model.CopNoseSpecs=row["CopNoseSpecs"].ToString();
				}
				if(row["TorqueValue"]!=null && row["TorqueValue"].ToString()!="")
				{
					model.TorqueValue=decimal.Parse(row["TorqueValue"].ToString());
				}
				if(row["CurDropProStarttime"]!=null && row["CurDropProStarttime"].ToString()!="")
				{
					model.CurDropProStarttime=DateTime.Parse(row["CurDropProStarttime"].ToString());
				}
				if(row["CurDropProEndtime"]!=null && row["CurDropProEndtime"].ToString()!="")
				{
					model.CurDropProEndtime=DateTime.Parse(row["CurDropProEndtime"].ToString());
				}
				if(row["CurProLenofdrop"]!=null && row["CurProLenofdrop"].ToString()!="")
				{
					model.CurProLenofdrop=decimal.Parse(row["CurProLenofdrop"].ToString());
				}
				if(row["CurProErrofdrop"]!=null && row["CurProErrofdrop"].ToString()!="")
				{
					model.CurProErrofdrop=decimal.Parse(row["CurProErrofdrop"].ToString());
				}
				if(row["IsQualified"]!=null && row["IsQualified"].ToString()!="")
				{
					model.IsQualified=int.Parse(row["IsQualified"].ToString());
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
			strSql.Append("select Id,Updatetime,CrossSecNum,TwistedLineSpecs,PresPipeSpecs,ThimbleSpecs,CopNoseSpecs,TorqueValue,CurDropProStarttime,CurDropProEndtime,CurProLenofdrop,CurProErrofdrop,IsQualified,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigCurrProDataBydx ");
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
			strSql.Append(" Id,Updatetime,CrossSecNum,TwistedLineSpecs,PresPipeSpecs,ThimbleSpecs,CopNoseSpecs,TorqueValue,CurDropProStarttime,CurDropProEndtime,CurProLenofdrop,CurProErrofdrop,IsQualified,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigCurrProDataBydx ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigCurrProDataBydx ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigCurrProDataBydx T ");
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
			parameters[0].Value = "DM_BUSI_BigCurrProDataBydx";
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

