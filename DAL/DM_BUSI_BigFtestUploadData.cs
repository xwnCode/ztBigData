using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigFtestUploadData
	/// </summary>
	public partial class DM_BUSI_BigFtestUploadData
	{
		public DM_BUSI_BigFtestUploadData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigFtestUploadData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigFtestUploadData");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigFtestUploadData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigFtestUploadData(");
			strSql.Append("Id,ftestId,taskId,fileTime,kiloMeter,maoduanName,poleName,speed,stationName,hei1,hei2,hei3,hei4,zig1,zig2,zig3,zig4,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@ftestId,@taskId,@fileTime,@kiloMeter,@maoduanName,@poleName,@speed,@stationName,@hei1,@hei2,@hei3,@hei4,@zig1,@zig2,@zig3,@zig4,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@taskId", SqlDbType.VarChar,-1),
					new SqlParameter("@fileTime", SqlDbType.VarChar,-1),
					new SqlParameter("@kiloMeter", SqlDbType.VarChar,-1),
					new SqlParameter("@maoduanName", SqlDbType.VarChar,-1),
					new SqlParameter("@poleName", SqlDbType.VarChar,-1),
					new SqlParameter("@speed", SqlDbType.VarChar,-1),
					new SqlParameter("@stationName", SqlDbType.VarChar,-1),
					new SqlParameter("@hei1", SqlDbType.VarChar,-1),
					new SqlParameter("@hei2", SqlDbType.VarChar,-1),
					new SqlParameter("@hei3", SqlDbType.VarChar,-1),
					new SqlParameter("@hei4", SqlDbType.VarChar,-1),
					new SqlParameter("@zig1", SqlDbType.VarChar,-1),
					new SqlParameter("@zig2", SqlDbType.VarChar,-1),
					new SqlParameter("@zig3", SqlDbType.VarChar,-1),
					new SqlParameter("@zig4", SqlDbType.VarChar,-1),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.ftestId;
			parameters[2].Value = model.taskId;
			parameters[3].Value = model.fileTime;
			parameters[4].Value = model.kiloMeter;
			parameters[5].Value = model.maoduanName;
			parameters[6].Value = model.poleName;
			parameters[7].Value = model.speed;
			parameters[8].Value = model.stationName;
			parameters[9].Value = model.hei1;
			parameters[10].Value = model.hei2;
			parameters[11].Value = model.hei3;
			parameters[12].Value = model.hei4;
			parameters[13].Value = model.zig1;
			parameters[14].Value = model.zig2;
			parameters[15].Value = model.zig3;
			parameters[16].Value = model.zig4;
			parameters[17].Value = model.by1;
			parameters[18].Value = model.by2;
			parameters[19].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigFtestUploadData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigFtestUploadData set ");
			strSql.Append("ftestId=@ftestId,");
			strSql.Append("taskId=@taskId,");
			strSql.Append("fileTime=@fileTime,");
			strSql.Append("kiloMeter=@kiloMeter,");
			strSql.Append("maoduanName=@maoduanName,");
			strSql.Append("poleName=@poleName,");
			strSql.Append("speed=@speed,");
			strSql.Append("stationName=@stationName,");
			strSql.Append("hei1=@hei1,");
			strSql.Append("hei2=@hei2,");
			strSql.Append("hei3=@hei3,");
			strSql.Append("hei4=@hei4,");
			strSql.Append("zig1=@zig1,");
			strSql.Append("zig2=@zig2,");
			strSql.Append("zig3=@zig3,");
			strSql.Append("zig4=@zig4,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@ftestId", SqlDbType.Int,4),
					new SqlParameter("@taskId", SqlDbType.VarChar,-1),
					new SqlParameter("@fileTime", SqlDbType.VarChar,-1),
					new SqlParameter("@kiloMeter", SqlDbType.VarChar,-1),
					new SqlParameter("@maoduanName", SqlDbType.VarChar,-1),
					new SqlParameter("@poleName", SqlDbType.VarChar,-1),
					new SqlParameter("@speed", SqlDbType.VarChar,-1),
					new SqlParameter("@stationName", SqlDbType.VarChar,-1),
					new SqlParameter("@hei1", SqlDbType.VarChar,-1),
					new SqlParameter("@hei2", SqlDbType.VarChar,-1),
					new SqlParameter("@hei3", SqlDbType.VarChar,-1),
					new SqlParameter("@hei4", SqlDbType.VarChar,-1),
					new SqlParameter("@zig1", SqlDbType.VarChar,-1),
					new SqlParameter("@zig2", SqlDbType.VarChar,-1),
					new SqlParameter("@zig3", SqlDbType.VarChar,-1),
					new SqlParameter("@zig4", SqlDbType.VarChar,-1),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.ftestId;
			parameters[1].Value = model.taskId;
			parameters[2].Value = model.fileTime;
			parameters[3].Value = model.kiloMeter;
			parameters[4].Value = model.maoduanName;
			parameters[5].Value = model.poleName;
			parameters[6].Value = model.speed;
			parameters[7].Value = model.stationName;
			parameters[8].Value = model.hei1;
			parameters[9].Value = model.hei2;
			parameters[10].Value = model.hei3;
			parameters[11].Value = model.hei4;
			parameters[12].Value = model.zig1;
			parameters[13].Value = model.zig2;
			parameters[14].Value = model.zig3;
			parameters[15].Value = model.zig4;
			parameters[16].Value = model.by1;
			parameters[17].Value = model.by2;
			parameters[18].Value = model.by3;
			parameters[19].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigFtestUploadData ");
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
			strSql.Append("delete from DM_BUSI_BigFtestUploadData ");
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
		public Vline.Model.DM_BUSI_BigFtestUploadData GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,ftestId,taskId,fileTime,kiloMeter,maoduanName,poleName,speed,stationName,hei1,hei2,hei3,hei4,zig1,zig2,zig3,zig4,by1,by2,by3 from DM_BUSI_BigFtestUploadData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigFtestUploadData model=new Vline.Model.DM_BUSI_BigFtestUploadData();
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
		public Vline.Model.DM_BUSI_BigFtestUploadData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigFtestUploadData model=new Vline.Model.DM_BUSI_BigFtestUploadData();
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
				if(row["taskId"]!=null)
				{
					model.taskId=row["taskId"].ToString();
				}
				if(row["fileTime"]!=null)
				{
					model.fileTime=row["fileTime"].ToString();
				}
				if(row["kiloMeter"]!=null)
				{
					model.kiloMeter=row["kiloMeter"].ToString();
				}
				if(row["maoduanName"]!=null)
				{
					model.maoduanName=row["maoduanName"].ToString();
				}
				if(row["poleName"]!=null)
				{
					model.poleName=row["poleName"].ToString();
				}
				if(row["speed"]!=null)
				{
					model.speed=row["speed"].ToString();
				}
				if(row["stationName"]!=null)
				{
					model.stationName=row["stationName"].ToString();
				}
				if(row["hei1"]!=null)
				{
					model.hei1=row["hei1"].ToString();
				}
				if(row["hei2"]!=null)
				{
					model.hei2=row["hei2"].ToString();
				}
				if(row["hei3"]!=null)
				{
					model.hei3=row["hei3"].ToString();
				}
				if(row["hei4"]!=null)
				{
					model.hei4=row["hei4"].ToString();
				}
				if(row["zig1"]!=null)
				{
					model.zig1=row["zig1"].ToString();
				}
				if(row["zig2"]!=null)
				{
					model.zig2=row["zig2"].ToString();
				}
				if(row["zig3"]!=null)
				{
					model.zig3=row["zig3"].ToString();
				}
				if(row["zig4"]!=null)
				{
					model.zig4=row["zig4"].ToString();
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
			strSql.Append("select Id,ftestId,taskId,fileTime,kiloMeter,maoduanName,poleName,speed,stationName,hei1,hei2,hei3,hei4,zig1,zig2,zig3,zig4,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestUploadData ");
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
			strSql.Append(" Id,ftestId,taskId,fileTime,kiloMeter,maoduanName,poleName,speed,stationName,hei1,hei2,hei3,hei4,zig1,zig2,zig3,zig4,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigFtestUploadData ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigFtestUploadData ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigFtestUploadData T ");
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
			parameters[0].Value = "DM_BUSI_BigFtestUploadData";
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

