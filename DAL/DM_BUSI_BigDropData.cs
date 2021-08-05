using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigDropData
	/// </summary>
	public partial class DM_BUSI_BigDropData
	{
		public DM_BUSI_BigDropData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigDropData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigDropData");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigDropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigDropData(");
			strSql.Append("Id,dropId,mdName,kdCount,dxCount,dsCount,kdNo,kj,type,dd1,dd2,dd3,dd4,dx1,dx2,dx3,dx4,dx5,dx6,dx7,dx8,dx9,dx10,dx11,mjj,zm,qsd,hsd,by1,by2,by3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@dropId,@mdName,@kdCount,@dxCount,@dsCount,@kdNo,@kj,@type,@dd1,@dd2,@dd3,@dd4,@dx1,@dx2,@dx3,@dx4,@dx5,@dx6,@dx7,@dx8,@dx9,@dx10,@dx11,@mjj,@zm,@qsd,@hsd,@by1,@by2,@by3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@dropId", SqlDbType.VarChar,50),
					new SqlParameter("@mdName", SqlDbType.VarChar,50),
					new SqlParameter("@kdCount", SqlDbType.VarChar,50),
					new SqlParameter("@dxCount", SqlDbType.VarChar,50),
					new SqlParameter("@dsCount", SqlDbType.VarChar,50),
					new SqlParameter("@kdNo", SqlDbType.VarChar,50),
					new SqlParameter("@kj", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@dd1", SqlDbType.VarChar,50),
					new SqlParameter("@dd2", SqlDbType.VarChar,50),
					new SqlParameter("@dd3", SqlDbType.VarChar,50),
					new SqlParameter("@dd4", SqlDbType.VarChar,50),
					new SqlParameter("@dx1", SqlDbType.VarChar,50),
					new SqlParameter("@dx2", SqlDbType.VarChar,50),
					new SqlParameter("@dx3", SqlDbType.VarChar,50),
					new SqlParameter("@dx4", SqlDbType.VarChar,50),
					new SqlParameter("@dx5", SqlDbType.VarChar,50),
					new SqlParameter("@dx6", SqlDbType.VarChar,50),
					new SqlParameter("@dx7", SqlDbType.VarChar,50),
					new SqlParameter("@dx8", SqlDbType.VarChar,50),
					new SqlParameter("@dx9", SqlDbType.VarChar,50),
					new SqlParameter("@dx10", SqlDbType.VarChar,50),
					new SqlParameter("@dx11", SqlDbType.VarChar,50),
					new SqlParameter("@mjj", SqlDbType.VarChar,50),
					new SqlParameter("@zm", SqlDbType.VarChar,50),
					new SqlParameter("@qsd", SqlDbType.VarChar,50),
					new SqlParameter("@hsd", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.dropId;
			parameters[2].Value = model.mdName;
			parameters[3].Value = model.kdCount;
			parameters[4].Value = model.dxCount;
			parameters[5].Value = model.dsCount;
			parameters[6].Value = model.kdNo;
			parameters[7].Value = model.kj;
			parameters[8].Value = model.type;
			parameters[9].Value = model.dd1;
			parameters[10].Value = model.dd2;
			parameters[11].Value = model.dd3;
			parameters[12].Value = model.dd4;
			parameters[13].Value = model.dx1;
			parameters[14].Value = model.dx2;
			parameters[15].Value = model.dx3;
			parameters[16].Value = model.dx4;
			parameters[17].Value = model.dx5;
			parameters[18].Value = model.dx6;
			parameters[19].Value = model.dx7;
			parameters[20].Value = model.dx8;
			parameters[21].Value = model.dx9;
			parameters[22].Value = model.dx10;
			parameters[23].Value = model.dx11;
			parameters[24].Value = model.mjj;
			parameters[25].Value = model.zm;
			parameters[26].Value = model.qsd;
			parameters[27].Value = model.hsd;
			parameters[28].Value = model.by1;
			parameters[29].Value = model.by2;
			parameters[30].Value = model.by3;

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
		public bool Update(Vline.Model.DM_BUSI_BigDropData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigDropData set ");
			strSql.Append("dropId=@dropId,");
			strSql.Append("mdName=@mdName,");
			strSql.Append("kdCount=@kdCount,");
			strSql.Append("dxCount=@dxCount,");
			strSql.Append("dsCount=@dsCount,");
			strSql.Append("kdNo=@kdNo,");
			strSql.Append("kj=@kj,");
			strSql.Append("type=@type,");
			strSql.Append("dd1=@dd1,");
			strSql.Append("dd2=@dd2,");
			strSql.Append("dd3=@dd3,");
			strSql.Append("dd4=@dd4,");
			strSql.Append("dx1=@dx1,");
			strSql.Append("dx2=@dx2,");
			strSql.Append("dx3=@dx3,");
			strSql.Append("dx4=@dx4,");
			strSql.Append("dx5=@dx5,");
			strSql.Append("dx6=@dx6,");
			strSql.Append("dx7=@dx7,");
			strSql.Append("dx8=@dx8,");
			strSql.Append("dx9=@dx9,");
			strSql.Append("dx10=@dx10,");
			strSql.Append("dx11=@dx11,");
			strSql.Append("mjj=@mjj,");
			strSql.Append("zm=@zm,");
			strSql.Append("qsd=@qsd,");
			strSql.Append("hsd=@hsd,");
			strSql.Append("by1=@by1,");
			strSql.Append("by2=@by2,");
			strSql.Append("by3=@by3");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@dropId", SqlDbType.VarChar,50),
					new SqlParameter("@mdName", SqlDbType.VarChar,50),
					new SqlParameter("@kdCount", SqlDbType.VarChar,50),
					new SqlParameter("@dxCount", SqlDbType.VarChar,50),
					new SqlParameter("@dsCount", SqlDbType.VarChar,50),
					new SqlParameter("@kdNo", SqlDbType.VarChar,50),
					new SqlParameter("@kj", SqlDbType.VarChar,50),
					new SqlParameter("@type", SqlDbType.VarChar,50),
					new SqlParameter("@dd1", SqlDbType.VarChar,50),
					new SqlParameter("@dd2", SqlDbType.VarChar,50),
					new SqlParameter("@dd3", SqlDbType.VarChar,50),
					new SqlParameter("@dd4", SqlDbType.VarChar,50),
					new SqlParameter("@dx1", SqlDbType.VarChar,50),
					new SqlParameter("@dx2", SqlDbType.VarChar,50),
					new SqlParameter("@dx3", SqlDbType.VarChar,50),
					new SqlParameter("@dx4", SqlDbType.VarChar,50),
					new SqlParameter("@dx5", SqlDbType.VarChar,50),
					new SqlParameter("@dx6", SqlDbType.VarChar,50),
					new SqlParameter("@dx7", SqlDbType.VarChar,50),
					new SqlParameter("@dx8", SqlDbType.VarChar,50),
					new SqlParameter("@dx9", SqlDbType.VarChar,50),
					new SqlParameter("@dx10", SqlDbType.VarChar,50),
					new SqlParameter("@dx11", SqlDbType.VarChar,50),
					new SqlParameter("@mjj", SqlDbType.VarChar,50),
					new SqlParameter("@zm", SqlDbType.VarChar,50),
					new SqlParameter("@qsd", SqlDbType.VarChar,50),
					new SqlParameter("@hsd", SqlDbType.VarChar,50),
					new SqlParameter("@by1", SqlDbType.VarChar,50),
					new SqlParameter("@by2", SqlDbType.VarChar,50),
					new SqlParameter("@by3", SqlDbType.VarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.dropId;
			parameters[1].Value = model.mdName;
			parameters[2].Value = model.kdCount;
			parameters[3].Value = model.dxCount;
			parameters[4].Value = model.dsCount;
			parameters[5].Value = model.kdNo;
			parameters[6].Value = model.kj;
			parameters[7].Value = model.type;
			parameters[8].Value = model.dd1;
			parameters[9].Value = model.dd2;
			parameters[10].Value = model.dd3;
			parameters[11].Value = model.dd4;
			parameters[12].Value = model.dx1;
			parameters[13].Value = model.dx2;
			parameters[14].Value = model.dx3;
			parameters[15].Value = model.dx4;
			parameters[16].Value = model.dx5;
			parameters[17].Value = model.dx6;
			parameters[18].Value = model.dx7;
			parameters[19].Value = model.dx8;
			parameters[20].Value = model.dx9;
			parameters[21].Value = model.dx10;
			parameters[22].Value = model.dx11;
			parameters[23].Value = model.mjj;
			parameters[24].Value = model.zm;
			parameters[25].Value = model.qsd;
			parameters[26].Value = model.hsd;
			parameters[27].Value = model.by1;
			parameters[28].Value = model.by2;
			parameters[29].Value = model.by3;
			parameters[30].Value = model.Id;

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
			strSql.Append("delete from DM_BUSI_BigDropData ");
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
			strSql.Append("delete from DM_BUSI_BigDropData ");
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
		public Vline.Model.DM_BUSI_BigDropData GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,dropId,mdName,kdCount,dxCount,dsCount,kdNo,kj,type,dd1,dd2,dd3,dd4,dx1,dx2,dx3,dx4,dx5,dx6,dx7,dx8,dx9,dx10,dx11,mjj,zm,qsd,hsd,by1,by2,by3 from DM_BUSI_BigDropData ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigDropData model=new Vline.Model.DM_BUSI_BigDropData();
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
		public Vline.Model.DM_BUSI_BigDropData DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigDropData model=new Vline.Model.DM_BUSI_BigDropData();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["dropId"]!=null)
				{
					model.dropId=row["dropId"].ToString();
				}
				if(row["mdName"]!=null)
				{
					model.mdName=row["mdName"].ToString();
				}
				if(row["kdCount"]!=null)
				{
					model.kdCount=row["kdCount"].ToString();
				}
				if(row["dxCount"]!=null)
				{
					model.dxCount=row["dxCount"].ToString();
				}
				if(row["dsCount"]!=null)
				{
					model.dsCount=row["dsCount"].ToString();
				}
				if(row["kdNo"]!=null)
				{
					model.kdNo=row["kdNo"].ToString();
				}
				if(row["kj"]!=null)
				{
					model.kj=row["kj"].ToString();
				}
				if(row["type"]!=null)
				{
					model.type=row["type"].ToString();
				}
				if(row["dd1"]!=null)
				{
					model.dd1=row["dd1"].ToString();
				}
				if(row["dd2"]!=null)
				{
					model.dd2=row["dd2"].ToString();
				}
				if(row["dd3"]!=null)
				{
					model.dd3=row["dd3"].ToString();
				}
				if(row["dd4"]!=null)
				{
					model.dd4=row["dd4"].ToString();
				}
				if(row["dx1"]!=null)
				{
					model.dx1=row["dx1"].ToString();
				}
				if(row["dx2"]!=null)
				{
					model.dx2=row["dx2"].ToString();
				}
				if(row["dx3"]!=null)
				{
					model.dx3=row["dx3"].ToString();
				}
				if(row["dx4"]!=null)
				{
					model.dx4=row["dx4"].ToString();
				}
				if(row["dx5"]!=null)
				{
					model.dx5=row["dx5"].ToString();
				}
				if(row["dx6"]!=null)
				{
					model.dx6=row["dx6"].ToString();
				}
				if(row["dx7"]!=null)
				{
					model.dx7=row["dx7"].ToString();
				}
				if(row["dx8"]!=null)
				{
					model.dx8=row["dx8"].ToString();
				}
				if(row["dx9"]!=null)
				{
					model.dx9=row["dx9"].ToString();
				}
				if(row["dx10"]!=null)
				{
					model.dx10=row["dx10"].ToString();
				}
				if(row["dx11"]!=null)
				{
					model.dx11=row["dx11"].ToString();
				}
				if(row["mjj"]!=null)
				{
					model.mjj=row["mjj"].ToString();
				}
				if(row["zm"]!=null)
				{
					model.zm=row["zm"].ToString();
				}
				if(row["qsd"]!=null)
				{
					model.qsd=row["qsd"].ToString();
				}
				if(row["hsd"]!=null)
				{
					model.hsd=row["hsd"].ToString();
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
			strSql.Append("select Id,dropId,mdName,kdCount,dxCount,dsCount,kdNo,kj,type,dd1,dd2,dd3,dd4,dx1,dx2,dx3,dx4,dx5,dx6,dx7,dx8,dx9,dx10,dx11,mjj,zm,qsd,hsd,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigDropData ");
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
			strSql.Append(" Id,dropId,mdName,kdCount,dxCount,dsCount,kdNo,kj,type,dd1,dd2,dd3,dd4,dx1,dx2,dx3,dx4,dx5,dx6,dx7,dx8,dx9,dx10,dx11,mjj,zm,qsd,hsd,by1,by2,by3 ");
			strSql.Append(" FROM DM_BUSI_BigDropData ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigDropData ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigDropData T ");
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
			parameters[0].Value = "DM_BUSI_BigDropData";
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

