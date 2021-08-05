﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigPatrolcarUpload
	/// </summary>
	public partial class DM_BUSI_BigPatrolcarUpload
	{
		public DM_BUSI_BigPatrolcarUpload()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigPatrolcarUpload"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigPatrolcarUpload");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigPatrolcarUpload model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigPatrolcarUpload(");
			strSql.Append("Id,cmd,timestamp,sign,taskId,packageId,data,datas,dash,fileTime,hei1,hei2,hei3,hei4,kiloMeter,maoduanName,mohao,moveDistance,poleName,speed,stationName,taskName,temperature,zig1,zig2,zig3,zig4,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@cmd,@timestamp,@sign,@taskId,@packageId,@data,@datas,@dash,@fileTime,@hei1,@hei2,@hei3,@hei4,@kiloMeter,@maoduanName,@mohao,@moveDistance,@poleName,@speed,@stationName,@taskName,@temperature,@zig1,@zig2,@zig3,@zig4,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@cmd", SqlDbType.VarChar,50),
					new SqlParameter("@timestamp", SqlDbType.VarChar,50),
					new SqlParameter("@sign", SqlDbType.VarChar,50),
					new SqlParameter("@taskId", SqlDbType.Int,4),
					new SqlParameter("@packageId", SqlDbType.Int,4),
					new SqlParameter("@data", SqlDbType.VarChar,-1),
					new SqlParameter("@datas", SqlDbType.VarChar,-1),
					new SqlParameter("@dash", SqlDbType.VarChar,50),
					new SqlParameter("@fileTime", SqlDbType.VarChar,50),
					new SqlParameter("@hei1", SqlDbType.VarChar,50),
					new SqlParameter("@hei2", SqlDbType.VarChar,50),
					new SqlParameter("@hei3", SqlDbType.VarChar,50),
					new SqlParameter("@hei4", SqlDbType.VarChar,50),
					new SqlParameter("@kiloMeter", SqlDbType.VarChar,50),
					new SqlParameter("@maoduanName", SqlDbType.VarChar,50),
					new SqlParameter("@mohao", SqlDbType.VarChar,50),
					new SqlParameter("@moveDistance", SqlDbType.VarChar,50),
					new SqlParameter("@poleName", SqlDbType.VarChar,50),
					new SqlParameter("@speed", SqlDbType.VarChar,50),
					new SqlParameter("@stationName", SqlDbType.VarChar,50),
					new SqlParameter("@taskName", SqlDbType.VarChar,50),
					new SqlParameter("@temperature", SqlDbType.VarChar,50),
					new SqlParameter("@zig1", SqlDbType.VarChar,50),
					new SqlParameter("@zig2", SqlDbType.VarChar,50),
					new SqlParameter("@zig3", SqlDbType.VarChar,50),
					new SqlParameter("@zig4", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.cmd;
			parameters[2].Value = model.timestamp;
			parameters[3].Value = model.sign;
			parameters[4].Value = model.taskId;
			parameters[5].Value = model.packageId;
			parameters[6].Value = model.data;
			parameters[7].Value = model.datas;
			parameters[8].Value = model.dash;
			parameters[9].Value = model.fileTime;
			parameters[10].Value = model.hei1;
			parameters[11].Value = model.hei2;
			parameters[12].Value = model.hei3;
			parameters[13].Value = model.hei4;
			parameters[14].Value = model.kiloMeter;
			parameters[15].Value = model.maoduanName;
			parameters[16].Value = model.mohao;
			parameters[17].Value = model.moveDistance;
			parameters[18].Value = model.poleName;
			parameters[19].Value = model.speed;
			parameters[20].Value = model.stationName;
			parameters[21].Value = model.taskName;
			parameters[22].Value = model.temperature;
			parameters[23].Value = model.zig1;
			parameters[24].Value = model.zig2;
			parameters[25].Value = model.zig3;
			parameters[26].Value = model.zig4;
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
		public bool Update(Vline.Model.DM_BUSI_BigPatrolcarUpload model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigPatrolcarUpload set ");
			strSql.Append("cmd=@cmd,");
			strSql.Append("timestamp=@timestamp,");
			strSql.Append("sign=@sign,");
			strSql.Append("taskId=@taskId,");
			strSql.Append("packageId=@packageId,");
			strSql.Append("data=@data,");
			strSql.Append("datas=@datas,");
			strSql.Append("dash=@dash,");
			strSql.Append("fileTime=@fileTime,");
			strSql.Append("hei1=@hei1,");
			strSql.Append("hei2=@hei2,");
			strSql.Append("hei3=@hei3,");
			strSql.Append("hei4=@hei4,");
			strSql.Append("kiloMeter=@kiloMeter,");
			strSql.Append("maoduanName=@maoduanName,");
			strSql.Append("mohao=@mohao,");
			strSql.Append("moveDistance=@moveDistance,");
			strSql.Append("poleName=@poleName,");
			strSql.Append("speed=@speed,");
			strSql.Append("stationName=@stationName,");
			strSql.Append("taskName=@taskName,");
			strSql.Append("temperature=@temperature,");
			strSql.Append("zig1=@zig1,");
			strSql.Append("zig2=@zig2,");
			strSql.Append("zig3=@zig3,");
			strSql.Append("zig4=@zig4,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@cmd", SqlDbType.VarChar,50),
					new SqlParameter("@timestamp", SqlDbType.VarChar,50),
					new SqlParameter("@sign", SqlDbType.VarChar,50),
					new SqlParameter("@taskId", SqlDbType.Int,4),
					new SqlParameter("@packageId", SqlDbType.Int,4),
					new SqlParameter("@data", SqlDbType.VarChar,-1),
					new SqlParameter("@datas", SqlDbType.VarChar,-1),
					new SqlParameter("@dash", SqlDbType.VarChar,50),
					new SqlParameter("@fileTime", SqlDbType.VarChar,50),
					new SqlParameter("@hei1", SqlDbType.VarChar,50),
					new SqlParameter("@hei2", SqlDbType.VarChar,50),
					new SqlParameter("@hei3", SqlDbType.VarChar,50),
					new SqlParameter("@hei4", SqlDbType.VarChar,50),
					new SqlParameter("@kiloMeter", SqlDbType.VarChar,50),
					new SqlParameter("@maoduanName", SqlDbType.VarChar,50),
					new SqlParameter("@mohao", SqlDbType.VarChar,50),
					new SqlParameter("@moveDistance", SqlDbType.VarChar,50),
					new SqlParameter("@poleName", SqlDbType.VarChar,50),
					new SqlParameter("@speed", SqlDbType.VarChar,50),
					new SqlParameter("@stationName", SqlDbType.VarChar,50),
					new SqlParameter("@taskName", SqlDbType.VarChar,50),
					new SqlParameter("@temperature", SqlDbType.VarChar,50),
					new SqlParameter("@zig1", SqlDbType.VarChar,50),
					new SqlParameter("@zig2", SqlDbType.VarChar,50),
					new SqlParameter("@zig3", SqlDbType.VarChar,50),
					new SqlParameter("@zig4", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.cmd;
			parameters[1].Value = model.timestamp;
			parameters[2].Value = model.sign;
			parameters[3].Value = model.taskId;
			parameters[4].Value = model.packageId;
			parameters[5].Value = model.data;
			parameters[6].Value = model.datas;
			parameters[7].Value = model.dash;
			parameters[8].Value = model.fileTime;
			parameters[9].Value = model.hei1;
			parameters[10].Value = model.hei2;
			parameters[11].Value = model.hei3;
			parameters[12].Value = model.hei4;
			parameters[13].Value = model.kiloMeter;
			parameters[14].Value = model.maoduanName;
			parameters[15].Value = model.mohao;
			parameters[16].Value = model.moveDistance;
			parameters[17].Value = model.poleName;
			parameters[18].Value = model.speed;
			parameters[19].Value = model.stationName;
			parameters[20].Value = model.taskName;
			parameters[21].Value = model.temperature;
			parameters[22].Value = model.zig1;
			parameters[23].Value = model.zig2;
			parameters[24].Value = model.zig3;
			parameters[25].Value = model.zig4;
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
			strSql.Append("delete from DM_BUSI_BigPatrolcarUpload ");
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
			strSql.Append("delete from DM_BUSI_BigPatrolcarUpload ");
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
		public Vline.Model.DM_BUSI_BigPatrolcarUpload GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,cmd,timestamp,sign,taskId,packageId,data,datas,dash,fileTime,hei1,hei2,hei3,hei4,kiloMeter,maoduanName,mohao,moveDistance,poleName,speed,stationName,taskName,temperature,zig1,zig2,zig3,zig4,by1,by2,by3 from DM_BUSI_BigPatrolcarUpload ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigPatrolcarUpload model=new Vline.Model.DM_BUSI_BigPatrolcarUpload();
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
		public Vline.Model.DM_BUSI_BigPatrolcarUpload DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigPatrolcarUpload model=new Vline.Model.DM_BUSI_BigPatrolcarUpload();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["cmd"]!=null)
				{
					model.cmd=row["cmd"].ToString();
				}
				if(row["timestamp"]!=null)
				{
					model.timestamp=row["timestamp"].ToString();
				}
				if(row["sign"]!=null)
				{
					model.sign=row["sign"].ToString();
				}
				if(row["taskId"]!=null && row["taskId"].ToString()!="")
				{
					model.taskId=int.Parse(row["taskId"].ToString());
				}
				if(row["packageId"]!=null && row["packageId"].ToString()!="")
				{
					model.packageId=int.Parse(row["packageId"].ToString());
				}
				if(row["data"]!=null)
				{
					model.data=row["data"].ToString();
				}
				if(row["datas"]!=null)
				{
					model.datas=row["datas"].ToString();
				}
				if(row["dash"]!=null)
				{
					model.dash=row["dash"].ToString();
				}
				if(row["fileTime"]!=null)
				{
					model.fileTime=row["fileTime"].ToString();
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
				if(row["kiloMeter"]!=null)
				{
					model.kiloMeter=row["kiloMeter"].ToString();
				}
				if(row["maoduanName"]!=null)
				{
					model.maoduanName=row["maoduanName"].ToString();
				}
				if(row["mohao"]!=null)
				{
					model.mohao=row["mohao"].ToString();
				}
				if(row["moveDistance"]!=null)
				{
					model.moveDistance=row["moveDistance"].ToString();
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
				if(row["taskName"]!=null)
				{
					model.taskName=row["taskName"].ToString();
				}
				if(row["temperature"]!=null)
				{
					model.temperature=row["temperature"].ToString();
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
			strSql.Append("select Id,cmd,timestamp,sign,taskId,packageId,data,datas,dash,fileTime,hei1,hei2,hei3,hei4,kiloMeter,maoduanName,mohao,moveDistance,poleName,speed,stationName,taskName,temperature,zig1,zig2,zig3,zig4,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPatrolcarUpload ");
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
			strSql.Append(" Id,cmd,timestamp,sign,taskId,packageId,data,datas,dash,fileTime,hei1,hei2,hei3,hei4,kiloMeter,maoduanName,mohao,moveDistance,poleName,speed,stationName,taskName,temperature,zig1,zig2,zig3,zig4,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigPatrolcarUpload ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigPatrolcarUpload ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigPatrolcarUpload T ");
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
			parameters[0].Value = "DM_BUSI_BigPatrolcarUpload";
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

