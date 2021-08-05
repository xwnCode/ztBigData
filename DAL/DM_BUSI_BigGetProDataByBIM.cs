using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigGetProDataByBIM
	/// </summary>
	public partial class DM_BUSI_BigGetProDataByBIM
	{
		public DM_BUSI_BigGetProDataByBIM()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Id", "DM_BUSI_BigGetProDataByBIM"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DM_BUSI_BigGetProDataByBIM");
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
		public int Add(Vline.Model.DM_BUSI_BigGetProDataByBIM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigGetProDataByBIM(");
			strSql.Append("DateOfdata,NameOfAnchor,Number,Type,Abutment,Flatears,Cantilears,Locatingring,Posseat,Windbreak,FlatFix,CantilArm,Postube,Carpalsuplon,Carpalsupflat,Carpalsupobl,LocasupSupo,LocasupArmo,LocasupSeto,LocasupSupt,LocasupArmt,LocasupSett,PosParameters,BaseParameters,SusParameters,Posslope,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@DateOfdata,@NameOfAnchor,@Number,@Type,@Abutment,@Flatears,@Cantilears,@Locatingring,@Posseat,@Windbreak,@FlatFix,@CantilArm,@Postube,@Carpalsuplon,@Carpalsupflat,@Carpalsupobl,@LocasupSupo,@LocasupArmo,@LocasupSeto,@LocasupSupt,@LocasupArmt,@LocasupSett,@PosParameters,@BaseParameters,@SusParameters,@Posslope,@By1,@By2,@By3)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DateOfdata", SqlDbType.DateTime),
					new SqlParameter("@NameOfAnchor", SqlDbType.NVarChar,50),
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Abutment", SqlDbType.NVarChar,50),
					new SqlParameter("@Flatears", SqlDbType.NVarChar,50),
					new SqlParameter("@Cantilears", SqlDbType.NVarChar,50),
					new SqlParameter("@Locatingring", SqlDbType.NVarChar,50),
					new SqlParameter("@Posseat", SqlDbType.NVarChar,50),
					new SqlParameter("@Windbreak", SqlDbType.NVarChar,50),
					new SqlParameter("@FlatFix", SqlDbType.NVarChar,50),
					new SqlParameter("@CantilArm", SqlDbType.NVarChar,50),
					new SqlParameter("@Postube", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsuplon", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsupflat", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsupobl", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSupo", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupArmo", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSeto", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSupt", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupArmt", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSett", SqlDbType.NVarChar,50),
					new SqlParameter("@PosParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@BaseParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@SusParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@Posslope", SqlDbType.NVarChar,50),
					new SqlParameter("@By1", SqlDbType.NVarChar,50),
					new SqlParameter("@By2", SqlDbType.NVarChar,50),
					new SqlParameter("@By3", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.DateOfdata;
			parameters[1].Value = model.NameOfAnchor;
			parameters[2].Value = model.Number;
			parameters[3].Value = model.Type;
			parameters[4].Value = model.Abutment;
			parameters[5].Value = model.Flatears;
			parameters[6].Value = model.Cantilears;
			parameters[7].Value = model.Locatingring;
			parameters[8].Value = model.Posseat;
			parameters[9].Value = model.Windbreak;
			parameters[10].Value = model.FlatFix;
			parameters[11].Value = model.CantilArm;
			parameters[12].Value = model.Postube;
			parameters[13].Value = model.Carpalsuplon;
			parameters[14].Value = model.Carpalsupflat;
			parameters[15].Value = model.Carpalsupobl;
			parameters[16].Value = model.LocasupSupo;
			parameters[17].Value = model.LocasupArmo;
			parameters[18].Value = model.LocasupSeto;
			parameters[19].Value = model.LocasupSupt;
			parameters[20].Value = model.LocasupArmt;
			parameters[21].Value = model.LocasupSett;
			parameters[22].Value = model.PosParameters;
			parameters[23].Value = model.BaseParameters;
			parameters[24].Value = model.SusParameters;
			parameters[25].Value = model.Posslope;
			parameters[26].Value = model.By1;
			parameters[27].Value = model.By2;
			parameters[28].Value = model.By3;

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
		public bool Update(Vline.Model.DM_BUSI_BigGetProDataByBIM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigGetProDataByBIM set ");
			strSql.Append("DateOfdata=@DateOfdata,");
			strSql.Append("NameOfAnchor=@NameOfAnchor,");
			strSql.Append("Number=@Number,");
			strSql.Append("Type=@Type,");
			strSql.Append("Abutment=@Abutment,");
			strSql.Append("Flatears=@Flatears,");
			strSql.Append("Cantilears=@Cantilears,");
			strSql.Append("Locatingring=@Locatingring,");
			strSql.Append("Posseat=@Posseat,");
			strSql.Append("Windbreak=@Windbreak,");
			strSql.Append("FlatFix=@FlatFix,");
			strSql.Append("CantilArm=@CantilArm,");
			strSql.Append("Postube=@Postube,");
			strSql.Append("Carpalsuplon=@Carpalsuplon,");
			strSql.Append("Carpalsupflat=@Carpalsupflat,");
			strSql.Append("Carpalsupobl=@Carpalsupobl,");
			strSql.Append("LocasupSupo=@LocasupSupo,");
			strSql.Append("LocasupArmo=@LocasupArmo,");
			strSql.Append("LocasupSeto=@LocasupSeto,");
			strSql.Append("LocasupSupt=@LocasupSupt,");
			strSql.Append("LocasupArmt=@LocasupArmt,");
			strSql.Append("LocasupSett=@LocasupSett,");
			strSql.Append("PosParameters=@PosParameters,");
			strSql.Append("BaseParameters=@BaseParameters,");
			strSql.Append("SusParameters=@SusParameters,");
			strSql.Append("Posslope=@Posslope,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@DateOfdata", SqlDbType.DateTime),
					new SqlParameter("@NameOfAnchor", SqlDbType.NVarChar,50),
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Abutment", SqlDbType.NVarChar,50),
					new SqlParameter("@Flatears", SqlDbType.NVarChar,50),
					new SqlParameter("@Cantilears", SqlDbType.NVarChar,50),
					new SqlParameter("@Locatingring", SqlDbType.NVarChar,50),
					new SqlParameter("@Posseat", SqlDbType.NVarChar,50),
					new SqlParameter("@Windbreak", SqlDbType.NVarChar,50),
					new SqlParameter("@FlatFix", SqlDbType.NVarChar,50),
					new SqlParameter("@CantilArm", SqlDbType.NVarChar,50),
					new SqlParameter("@Postube", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsuplon", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsupflat", SqlDbType.NVarChar,50),
					new SqlParameter("@Carpalsupobl", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSupo", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupArmo", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSeto", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSupt", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupArmt", SqlDbType.NVarChar,50),
					new SqlParameter("@LocasupSett", SqlDbType.NVarChar,50),
					new SqlParameter("@PosParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@BaseParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@SusParameters", SqlDbType.NVarChar,50),
					new SqlParameter("@Posslope", SqlDbType.NVarChar,50),
					new SqlParameter("@By1", SqlDbType.NVarChar,50),
					new SqlParameter("@By2", SqlDbType.NVarChar,50),
					new SqlParameter("@By3", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.Int,4)};
			parameters[0].Value = model.DateOfdata;
			parameters[1].Value = model.NameOfAnchor;
			parameters[2].Value = model.Number;
			parameters[3].Value = model.Type;
			parameters[4].Value = model.Abutment;
			parameters[5].Value = model.Flatears;
			parameters[6].Value = model.Cantilears;
			parameters[7].Value = model.Locatingring;
			parameters[8].Value = model.Posseat;
			parameters[9].Value = model.Windbreak;
			parameters[10].Value = model.FlatFix;
			parameters[11].Value = model.CantilArm;
			parameters[12].Value = model.Postube;
			parameters[13].Value = model.Carpalsuplon;
			parameters[14].Value = model.Carpalsupflat;
			parameters[15].Value = model.Carpalsupobl;
			parameters[16].Value = model.LocasupSupo;
			parameters[17].Value = model.LocasupArmo;
			parameters[18].Value = model.LocasupSeto;
			parameters[19].Value = model.LocasupSupt;
			parameters[20].Value = model.LocasupArmt;
			parameters[21].Value = model.LocasupSett;
			parameters[22].Value = model.PosParameters;
			parameters[23].Value = model.BaseParameters;
			parameters[24].Value = model.SusParameters;
			parameters[25].Value = model.Posslope;
			parameters[26].Value = model.By1;
			parameters[27].Value = model.By2;
			parameters[28].Value = model.By3;
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
			strSql.Append("delete from DM_BUSI_BigGetProDataByBIM ");
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
			strSql.Append("delete from DM_BUSI_BigGetProDataByBIM ");
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
		public Vline.Model.DM_BUSI_BigGetProDataByBIM GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,DateOfdata,NameOfAnchor,Number,Type,Abutment,Flatears,Cantilears,Locatingring,Posseat,Windbreak,FlatFix,CantilArm,Postube,Carpalsuplon,Carpalsupflat,Carpalsupobl,LocasupSupo,LocasupArmo,LocasupSeto,LocasupSupt,LocasupArmt,LocasupSett,PosParameters,BaseParameters,SusParameters,Posslope,By1,By2,By3 from DM_BUSI_BigGetProDataByBIM ");
			strSql.Append(" where Id=@Id");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4)
			};
			parameters[0].Value = Id;

			Vline.Model.DM_BUSI_BigGetProDataByBIM model=new Vline.Model.DM_BUSI_BigGetProDataByBIM();
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
		public Vline.Model.DM_BUSI_BigGetProDataByBIM DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigGetProDataByBIM model=new Vline.Model.DM_BUSI_BigGetProDataByBIM();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["DateOfdata"]!=null && row["DateOfdata"].ToString()!="")
				{
					model.DateOfdata=DateTime.Parse(row["DateOfdata"].ToString());
				}
				if(row["NameOfAnchor"]!=null)
				{
					model.NameOfAnchor=row["NameOfAnchor"].ToString();
				}
				if(row["Number"]!=null)
				{
					model.Number=row["Number"].ToString();
				}
				if(row["Type"]!=null)
				{
					model.Type=row["Type"].ToString();
				}
				if(row["Abutment"]!=null)
				{
					model.Abutment=row["Abutment"].ToString();
				}
				if(row["Flatears"]!=null)
				{
					model.Flatears=row["Flatears"].ToString();
				}
				if(row["Cantilears"]!=null)
				{
					model.Cantilears=row["Cantilears"].ToString();
				}
				if(row["Locatingring"]!=null)
				{
					model.Locatingring=row["Locatingring"].ToString();
				}
				if(row["Posseat"]!=null)
				{
					model.Posseat=row["Posseat"].ToString();
				}
				if(row["Windbreak"]!=null)
				{
					model.Windbreak=row["Windbreak"].ToString();
				}
				if(row["FlatFix"]!=null)
				{
					model.FlatFix=row["FlatFix"].ToString();
				}
				if(row["CantilArm"]!=null)
				{
					model.CantilArm=row["CantilArm"].ToString();
				}
				if(row["Postube"]!=null)
				{
					model.Postube=row["Postube"].ToString();
				}
				if(row["Carpalsuplon"]!=null)
				{
					model.Carpalsuplon=row["Carpalsuplon"].ToString();
				}
				if(row["Carpalsupflat"]!=null)
				{
					model.Carpalsupflat=row["Carpalsupflat"].ToString();
				}
				if(row["Carpalsupobl"]!=null)
				{
					model.Carpalsupobl=row["Carpalsupobl"].ToString();
				}
				if(row["LocasupSupo"]!=null)
				{
					model.LocasupSupo=row["LocasupSupo"].ToString();
				}
				if(row["LocasupArmo"]!=null)
				{
					model.LocasupArmo=row["LocasupArmo"].ToString();
				}
				if(row["LocasupSeto"]!=null)
				{
					model.LocasupSeto=row["LocasupSeto"].ToString();
				}
				if(row["LocasupSupt"]!=null)
				{
					model.LocasupSupt=row["LocasupSupt"].ToString();
				}
				if(row["LocasupArmt"]!=null)
				{
					model.LocasupArmt=row["LocasupArmt"].ToString();
				}
				if(row["LocasupSett"]!=null)
				{
					model.LocasupSett=row["LocasupSett"].ToString();
				}
				if(row["PosParameters"]!=null)
				{
					model.PosParameters=row["PosParameters"].ToString();
				}
				if(row["BaseParameters"]!=null)
				{
					model.BaseParameters=row["BaseParameters"].ToString();
				}
				if(row["SusParameters"]!=null)
				{
					model.SusParameters=row["SusParameters"].ToString();
				}
				if(row["Posslope"]!=null)
				{
					model.Posslope=row["Posslope"].ToString();
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
			strSql.Append("select Id,DateOfdata,NameOfAnchor,Number,Type,Abutment,Flatears,Cantilears,Locatingring,Posseat,Windbreak,FlatFix,CantilArm,Postube,Carpalsuplon,Carpalsupflat,Carpalsupobl,LocasupSupo,LocasupArmo,LocasupSeto,LocasupSupt,LocasupArmt,LocasupSett,PosParameters,BaseParameters,SusParameters,Posslope,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigGetProDataByBIM ");
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
			strSql.Append(" Id,DateOfdata,NameOfAnchor,Number,Type,Abutment,Flatears,Cantilears,Locatingring,Posseat,Windbreak,FlatFix,CantilArm,Postube,Carpalsuplon,Carpalsupflat,Carpalsupobl,LocasupSupo,LocasupArmo,LocasupSeto,LocasupSupt,LocasupArmt,LocasupSett,PosParameters,BaseParameters,SusParameters,Posslope,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigGetProDataByBIM ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigGetProDataByBIM ");
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
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigGetProDataByBIM T ");
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
			parameters[0].Value = "DM_BUSI_BigGetProDataByBIM";
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

