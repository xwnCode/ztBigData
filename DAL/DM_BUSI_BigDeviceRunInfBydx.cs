using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigDeviceRunInfBydx
	/// </summary>
	public partial class DM_BUSI_BigDeviceRunInfBydx
	{
		public DM_BUSI_BigDeviceRunInfBydx()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigDeviceRunInfBydx"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigDeviceRunInfBydx");
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
		public int Add(Vline.Model.DM_BUSI_BigDeviceRunInfBydx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigDeviceRunInfBydx(");
			strSql.Append("Updatetime,TotalLenofcopwire,RemainLenofcopwire,TotalNumofRinghop,RemainNumofRinghop,TotalNumofPipehop,RemainNumofPipehop,TotalNumofNosehop,RemainNumofNosehop,RobotRunState,HydraulicRunState,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@Updatetime,@TotalLenofcopwire,@RemainLenofcopwire,@TotalNumofRinghop,@RemainNumofRinghop,@TotalNumofPipehop,@RemainNumofPipehop,@TotalNumofNosehop,@RemainNumofNosehop,@RobotRunState,@HydraulicRunState,@By1,@By2,@By3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@TotalLenofcopwire", SqlDbType.Float,8),
					new SqlParameter("@RemainLenofcopwire", SqlDbType.Float,8),
					new SqlParameter("@TotalNumofRinghop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofRinghop", SqlDbType.Int,4),
					new SqlParameter("@TotalNumofPipehop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofPipehop", SqlDbType.Int,4),
					new SqlParameter("@TotalNumofNosehop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofNosehop", SqlDbType.Int,4),
					new SqlParameter("@RobotRunState", SqlDbType.Int,4),
					new SqlParameter("@HydraulicRunState", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Updatetime;
			parameters[1].Value = model.TotalLenofcopwire;
			parameters[2].Value = model.RemainLenofcopwire;
			parameters[3].Value = model.TotalNumofRinghop;
			parameters[4].Value = model.RemainNumofRinghop;
			parameters[5].Value = model.TotalNumofPipehop;
			parameters[6].Value = model.RemainNumofPipehop;
			parameters[7].Value = model.TotalNumofNosehop;
			parameters[8].Value = model.RemainNumofNosehop;
			parameters[9].Value = model.RobotRunState;
			parameters[10].Value = model.HydraulicRunState;
			parameters[11].Value = model.By1;
			parameters[12].Value = model.By2;
			parameters[13].Value = model.By3;

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
		public bool Update(Vline.Model.DM_BUSI_BigDeviceRunInfBydx model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigDeviceRunInfBydx set ");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("TotalLenofcopwire=@TotalLenofcopwire,");
			strSql.Append("RemainLenofcopwire=@RemainLenofcopwire,");
			strSql.Append("TotalNumofRinghop=@TotalNumofRinghop,");
			strSql.Append("RemainNumofRinghop=@RemainNumofRinghop,");
			strSql.Append("TotalNumofPipehop=@TotalNumofPipehop,");
			strSql.Append("RemainNumofPipehop=@RemainNumofPipehop,");
			strSql.Append("TotalNumofNosehop=@TotalNumofNosehop,");
			strSql.Append("RemainNumofNosehop=@RemainNumofNosehop,");
			strSql.Append("RobotRunState=@RobotRunState,");
			strSql.Append("HydraulicRunState=@HydraulicRunState,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@TotalLenofcopwire", SqlDbType.Float,8),
					new SqlParameter("@RemainLenofcopwire", SqlDbType.Float,8),
					new SqlParameter("@TotalNumofRinghop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofRinghop", SqlDbType.Int,4),
					new SqlParameter("@TotalNumofPipehop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofPipehop", SqlDbType.Int,4),
					new SqlParameter("@TotalNumofNosehop", SqlDbType.Int,4),
					new SqlParameter("@RemainNumofNosehop", SqlDbType.Int,4),
					new SqlParameter("@RobotRunState", SqlDbType.Int,4),
					new SqlParameter("@HydraulicRunState", SqlDbType.Int,4),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.Updatetime;
			parameters[1].Value = model.TotalLenofcopwire;
			parameters[2].Value = model.RemainLenofcopwire;
			parameters[3].Value = model.TotalNumofRinghop;
			parameters[4].Value = model.RemainNumofRinghop;
			parameters[5].Value = model.TotalNumofPipehop;
			parameters[6].Value = model.RemainNumofPipehop;
			parameters[7].Value = model.TotalNumofNosehop;
			parameters[8].Value = model.RemainNumofNosehop;
			parameters[9].Value = model.RobotRunState;
			parameters[10].Value = model.HydraulicRunState;
			parameters[11].Value = model.By1;
			parameters[12].Value = model.By2;
			parameters[13].Value = model.By3;
			parameters[14].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigDeviceRunInfBydx ");
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
			strSql.Append("delete from DM_BUSI_BigDeviceRunInfBydx ");
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
		public Vline.Model.DM_BUSI_BigDeviceRunInfBydx GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Updatetime,TotalLenofcopwire,RemainLenofcopwire,TotalNumofRinghop,RemainNumofRinghop,TotalNumofPipehop,RemainNumofPipehop,TotalNumofNosehop,RemainNumofNosehop,RobotRunState,HydraulicRunState,By1,By2,By3 from DM_BUSI_BigDeviceRunInfBydx ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigDeviceRunInfBydx model=new Vline.Model.DM_BUSI_BigDeviceRunInfBydx();
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
		public Vline.Model.DM_BUSI_BigDeviceRunInfBydx DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigDeviceRunInfBydx model=new Vline.Model.DM_BUSI_BigDeviceRunInfBydx();
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
				if(row["TotalLenofcopwire"]!=null && row["TotalLenofcopwire"].ToString()!="")
				{
					model.TotalLenofcopwire=decimal.Parse(row["TotalLenofcopwire"].ToString());
				}
				if(row["RemainLenofcopwire"]!=null && row["RemainLenofcopwire"].ToString()!="")
				{
					model.RemainLenofcopwire=decimal.Parse(row["RemainLenofcopwire"].ToString());
				}
				if(row["TotalNumofRinghop"]!=null && row["TotalNumofRinghop"].ToString()!="")
				{
					model.TotalNumofRinghop=int.Parse(row["TotalNumofRinghop"].ToString());
				}
				if(row["RemainNumofRinghop"]!=null && row["RemainNumofRinghop"].ToString()!="")
				{
					model.RemainNumofRinghop=int.Parse(row["RemainNumofRinghop"].ToString());
				}
				if(row["TotalNumofPipehop"]!=null && row["TotalNumofPipehop"].ToString()!="")
				{
					model.TotalNumofPipehop=int.Parse(row["TotalNumofPipehop"].ToString());
				}
				if(row["RemainNumofPipehop"]!=null && row["RemainNumofPipehop"].ToString()!="")
				{
					model.RemainNumofPipehop=int.Parse(row["RemainNumofPipehop"].ToString());
				}
				if(row["TotalNumofNosehop"]!=null && row["TotalNumofNosehop"].ToString()!="")
				{
					model.TotalNumofNosehop=int.Parse(row["TotalNumofNosehop"].ToString());
				}
				if(row["RemainNumofNosehop"]!=null && row["RemainNumofNosehop"].ToString()!="")
				{
					model.RemainNumofNosehop=int.Parse(row["RemainNumofNosehop"].ToString());
				}
				if(row["RobotRunState"]!=null && row["RobotRunState"].ToString()!="")
				{
					model.RobotRunState=int.Parse(row["RobotRunState"].ToString());
				}
				if(row["HydraulicRunState"]!=null && row["HydraulicRunState"].ToString()!="")
				{
					model.HydraulicRunState=int.Parse(row["HydraulicRunState"].ToString());
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
			strSql.Append("select Id,Updatetime,TotalLenofcopwire,RemainLenofcopwire,TotalNumofRinghop,RemainNumofRinghop,TotalNumofPipehop,RemainNumofPipehop,TotalNumofNosehop,RemainNumofNosehop,RobotRunState,HydraulicRunState,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigDeviceRunInfBydx ");
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
			strSql.Append(" Id,Updatetime,TotalLenofcopwire,RemainLenofcopwire,TotalNumofRinghop,RemainNumofRinghop,TotalNumofPipehop,RemainNumofPipehop,TotalNumofNosehop,RemainNumofNosehop,RobotRunState,HydraulicRunState,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigDeviceRunInfBydx ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigDeviceRunInfBydx ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigDeviceRunInfBydx T ");
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
			parameters[0].Value = "DM_BUSI_BigDeviceRunInfBydx";
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

