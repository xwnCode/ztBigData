using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Vline.DAL
{
	/// <summary>
	/// 数据访问类:DM_BUSI_BigDeviceRunInf
	/// </summary>
	public partial class DM_BUSI_BigDeviceRunInf
	{
		public DM_BUSI_BigDeviceRunInf()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_BigDeviceRunInf model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DM_BUSI_BigDeviceRunInf(");
			strSql.Append("Id,Updatetime,CutSpeed,CutRunStatus,FlatFixRunStatus,FlatFixWrenchOneTop,FlatFixWrenchTwoTop,FlatFixWrenchThreeTop,FlatFixWrenchFourTop,FlatFixWrenchOneAim,FlatFixWrenchTwoAim,FlatFixWrenchThreeAim,FlatFixWrenchFourAim,CantilArmRunStatus,CantilArmWrenchOneTop,CantilArmWrenchTwoTop,CantilArmOneAim,CantilArmTwoAim,ArrangeTotal,ArrangeRemain,FlatOneTotal,FlatOneRemain,FlatTwoTotal,FlatTwoRemain,FlatThreeTotal,FlatThreeRemain,CantilArmOneTotal,CantilArmOneRemain,CantilArmTwoTotal,CantilArmTwoRemain,AirRunStatus,AirTotalPre,AirFeedPre,AirAssemPre,By1,By2,By3)");
			strSql.Append(" values (");
			strSql.Append("@Id,@Updatetime,@CutSpeed,@CutRunStatus,@FlatFixRunStatus,@FlatFixWrenchOneTop,@FlatFixWrenchTwoTop,@FlatFixWrenchThreeTop,@FlatFixWrenchFourTop,@FlatFixWrenchOneAim,@FlatFixWrenchTwoAim,@FlatFixWrenchThreeAim,@FlatFixWrenchFourAim,@CantilArmRunStatus,@CantilArmWrenchOneTop,@CantilArmWrenchTwoTop,@CantilArmOneAim,@CantilArmTwoAim,@ArrangeTotal,@ArrangeRemain,@FlatOneTotal,@FlatOneRemain,@FlatTwoTotal,@FlatTwoRemain,@FlatThreeTotal,@FlatThreeRemain,@CantilArmOneTotal,@CantilArmOneRemain,@CantilArmTwoTotal,@CantilArmTwoRemain,@AirRunStatus,@AirTotalPre,@AirFeedPre,@AirAssemPre,@By1,@By2,@By3)");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CutSpeed", SqlDbType.Float,8),
					new SqlParameter("@CutRunStatus", SqlDbType.Int,4),
					new SqlParameter("@FlatFixRunStatus", SqlDbType.Int,4),
					new SqlParameter("@FlatFixWrenchOneTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchTwoTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchThreeTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchFourTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchOneAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchTwoAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchThreeAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchFourAim", SqlDbType.Float,8),
					new SqlParameter("@CantilArmRunStatus", SqlDbType.Int,4),
					new SqlParameter("@CantilArmWrenchOneTop", SqlDbType.Float,8),
					new SqlParameter("@CantilArmWrenchTwoTop", SqlDbType.Float,8),
					new SqlParameter("@CantilArmOneAim", SqlDbType.Float,8),
					new SqlParameter("@CantilArmTwoAim", SqlDbType.Float,8),
					new SqlParameter("@ArrangeTotal", SqlDbType.Int,4),
					new SqlParameter("@ArrangeRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatOneTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatOneRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatTwoTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatTwoRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatThreeTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatThreeRemain", SqlDbType.Int,4),
					new SqlParameter("@CantilArmOneTotal", SqlDbType.Int,4),
					new SqlParameter("@CantilArmOneRemain", SqlDbType.Int,4),
					new SqlParameter("@CantilArmTwoTotal", SqlDbType.Int,4),
					new SqlParameter("@CantilArmTwoRemain", SqlDbType.Int,4),
					new SqlParameter("@AirRunStatus", SqlDbType.Int,4),
					new SqlParameter("@AirTotalPre", SqlDbType.Float,8),
					new SqlParameter("@AirFeedPre", SqlDbType.Float,8),
					new SqlParameter("@AirAssemPre", SqlDbType.Float,8),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.CutSpeed;
			parameters[3].Value = model.CutRunStatus;
			parameters[4].Value = model.FlatFixRunStatus;
			parameters[5].Value = model.FlatFixWrenchOneTop;
			parameters[6].Value = model.FlatFixWrenchTwoTop;
			parameters[7].Value = model.FlatFixWrenchThreeTop;
			parameters[8].Value = model.FlatFixWrenchFourTop;
			parameters[9].Value = model.FlatFixWrenchOneAim;
			parameters[10].Value = model.FlatFixWrenchTwoAim;
			parameters[11].Value = model.FlatFixWrenchThreeAim;
			parameters[12].Value = model.FlatFixWrenchFourAim;
			parameters[13].Value = model.CantilArmRunStatus;
			parameters[14].Value = model.CantilArmWrenchOneTop;
			parameters[15].Value = model.CantilArmWrenchTwoTop;
			parameters[16].Value = model.CantilArmOneAim;
			parameters[17].Value = model.CantilArmTwoAim;
			parameters[18].Value = model.ArrangeTotal;
			parameters[19].Value = model.ArrangeRemain;
			parameters[20].Value = model.FlatOneTotal;
			parameters[21].Value = model.FlatOneRemain;
			parameters[22].Value = model.FlatTwoTotal;
			parameters[23].Value = model.FlatTwoRemain;
			parameters[24].Value = model.FlatThreeTotal;
			parameters[25].Value = model.FlatThreeRemain;
			parameters[26].Value = model.CantilArmOneTotal;
			parameters[27].Value = model.CantilArmOneRemain;
			parameters[28].Value = model.CantilArmTwoTotal;
			parameters[29].Value = model.CantilArmTwoRemain;
			parameters[30].Value = model.AirRunStatus;
			parameters[31].Value = model.AirTotalPre;
			parameters[32].Value = model.AirFeedPre;
			parameters[33].Value = model.AirAssemPre;
			parameters[34].Value = model.By1;
			parameters[35].Value = model.By2;
			parameters[36].Value = model.By3;

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
		public bool Update(Vline.Model.DM_BUSI_BigDeviceRunInf model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DM_BUSI_BigDeviceRunInf set ");
			strSql.Append("Id=@Id,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("CutSpeed=@CutSpeed,");
			strSql.Append("CutRunStatus=@CutRunStatus,");
			strSql.Append("FlatFixRunStatus=@FlatFixRunStatus,");
			strSql.Append("FlatFixWrenchOneTop=@FlatFixWrenchOneTop,");
			strSql.Append("FlatFixWrenchTwoTop=@FlatFixWrenchTwoTop,");
			strSql.Append("FlatFixWrenchThreeTop=@FlatFixWrenchThreeTop,");
			strSql.Append("FlatFixWrenchFourTop=@FlatFixWrenchFourTop,");
			strSql.Append("FlatFixWrenchOneAim=@FlatFixWrenchOneAim,");
			strSql.Append("FlatFixWrenchTwoAim=@FlatFixWrenchTwoAim,");
			strSql.Append("FlatFixWrenchThreeAim=@FlatFixWrenchThreeAim,");
			strSql.Append("FlatFixWrenchFourAim=@FlatFixWrenchFourAim,");
			strSql.Append("CantilArmRunStatus=@CantilArmRunStatus,");
			strSql.Append("CantilArmWrenchOneTop=@CantilArmWrenchOneTop,");
			strSql.Append("CantilArmWrenchTwoTop=@CantilArmWrenchTwoTop,");
			strSql.Append("CantilArmOneAim=@CantilArmOneAim,");
			strSql.Append("CantilArmTwoAim=@CantilArmTwoAim,");
			strSql.Append("ArrangeTotal=@ArrangeTotal,");
			strSql.Append("ArrangeRemain=@ArrangeRemain,");
			strSql.Append("FlatOneTotal=@FlatOneTotal,");
			strSql.Append("FlatOneRemain=@FlatOneRemain,");
			strSql.Append("FlatTwoTotal=@FlatTwoTotal,");
			strSql.Append("FlatTwoRemain=@FlatTwoRemain,");
			strSql.Append("FlatThreeTotal=@FlatThreeTotal,");
			strSql.Append("FlatThreeRemain=@FlatThreeRemain,");
			strSql.Append("CantilArmOneTotal=@CantilArmOneTotal,");
			strSql.Append("CantilArmOneRemain=@CantilArmOneRemain,");
			strSql.Append("CantilArmTwoTotal=@CantilArmTwoTotal,");
			strSql.Append("CantilArmTwoRemain=@CantilArmTwoRemain,");
			strSql.Append("AirRunStatus=@AirRunStatus,");
			strSql.Append("AirTotalPre=@AirTotalPre,");
			strSql.Append("AirFeedPre=@AirFeedPre,");
			strSql.Append("AirAssemPre=@AirAssemPre,");
			strSql.Append("By1=@By1,");
			strSql.Append("By2=@By2,");
			strSql.Append("By3=@By3");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.Int,4),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@CutSpeed", SqlDbType.Float,8),
					new SqlParameter("@CutRunStatus", SqlDbType.Int,4),
					new SqlParameter("@FlatFixRunStatus", SqlDbType.Int,4),
					new SqlParameter("@FlatFixWrenchOneTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchTwoTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchThreeTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchFourTop", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchOneAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchTwoAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchThreeAim", SqlDbType.Float,8),
					new SqlParameter("@FlatFixWrenchFourAim", SqlDbType.Float,8),
					new SqlParameter("@CantilArmRunStatus", SqlDbType.Int,4),
					new SqlParameter("@CantilArmWrenchOneTop", SqlDbType.Float,8),
					new SqlParameter("@CantilArmWrenchTwoTop", SqlDbType.Float,8),
					new SqlParameter("@CantilArmOneAim", SqlDbType.Float,8),
					new SqlParameter("@CantilArmTwoAim", SqlDbType.Float,8),
					new SqlParameter("@ArrangeTotal", SqlDbType.Int,4),
					new SqlParameter("@ArrangeRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatOneTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatOneRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatTwoTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatTwoRemain", SqlDbType.Int,4),
					new SqlParameter("@FlatThreeTotal", SqlDbType.Int,4),
					new SqlParameter("@FlatThreeRemain", SqlDbType.Int,4),
					new SqlParameter("@CantilArmOneTotal", SqlDbType.Int,4),
					new SqlParameter("@CantilArmOneRemain", SqlDbType.Int,4),
					new SqlParameter("@CantilArmTwoTotal", SqlDbType.Int,4),
					new SqlParameter("@CantilArmTwoRemain", SqlDbType.Int,4),
					new SqlParameter("@AirRunStatus", SqlDbType.Int,4),
					new SqlParameter("@AirTotalPre", SqlDbType.Float,8),
					new SqlParameter("@AirFeedPre", SqlDbType.Float,8),
					new SqlParameter("@AirAssemPre", SqlDbType.Float,8),
					new SqlParameter("@By1", SqlDbType.VarChar,50),
					new SqlParameter("@By2", SqlDbType.VarChar,50),
					new SqlParameter("@By3", SqlDbType.VarChar,50)};
			parameters[0].Value = model.Id;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.CutSpeed;
			parameters[3].Value = model.CutRunStatus;
			parameters[4].Value = model.FlatFixRunStatus;
			parameters[5].Value = model.FlatFixWrenchOneTop;
			parameters[6].Value = model.FlatFixWrenchTwoTop;
			parameters[7].Value = model.FlatFixWrenchThreeTop;
			parameters[8].Value = model.FlatFixWrenchFourTop;
			parameters[9].Value = model.FlatFixWrenchOneAim;
			parameters[10].Value = model.FlatFixWrenchTwoAim;
			parameters[11].Value = model.FlatFixWrenchThreeAim;
			parameters[12].Value = model.FlatFixWrenchFourAim;
			parameters[13].Value = model.CantilArmRunStatus;
			parameters[14].Value = model.CantilArmWrenchOneTop;
			parameters[15].Value = model.CantilArmWrenchTwoTop;
			parameters[16].Value = model.CantilArmOneAim;
			parameters[17].Value = model.CantilArmTwoAim;
			parameters[18].Value = model.ArrangeTotal;
			parameters[19].Value = model.ArrangeRemain;
			parameters[20].Value = model.FlatOneTotal;
			parameters[21].Value = model.FlatOneRemain;
			parameters[22].Value = model.FlatTwoTotal;
			parameters[23].Value = model.FlatTwoRemain;
			parameters[24].Value = model.FlatThreeTotal;
			parameters[25].Value = model.FlatThreeRemain;
			parameters[26].Value = model.CantilArmOneTotal;
			parameters[27].Value = model.CantilArmOneRemain;
			parameters[28].Value = model.CantilArmTwoTotal;
			parameters[29].Value = model.CantilArmTwoRemain;
			parameters[30].Value = model.AirRunStatus;
			parameters[31].Value = model.AirTotalPre;
			parameters[32].Value = model.AirFeedPre;
			parameters[33].Value = model.AirAssemPre;
			parameters[34].Value = model.By1;
			parameters[35].Value = model.By2;
			parameters[36].Value = model.By3;

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
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DM_BUSI_BigDeviceRunInf ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

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
		/// 得到一个对象实体
		/// </summary>
		public Vline.Model.DM_BUSI_BigDeviceRunInf GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Id,Updatetime,CutSpeed,CutRunStatus,FlatFixRunStatus,FlatFixWrenchOneTop,FlatFixWrenchTwoTop,FlatFixWrenchThreeTop,FlatFixWrenchFourTop,FlatFixWrenchOneAim,FlatFixWrenchTwoAim,FlatFixWrenchThreeAim,FlatFixWrenchFourAim,CantilArmRunStatus,CantilArmWrenchOneTop,CantilArmWrenchTwoTop,CantilArmOneAim,CantilArmTwoAim,ArrangeTotal,ArrangeRemain,FlatOneTotal,FlatOneRemain,FlatTwoTotal,FlatTwoRemain,FlatThreeTotal,FlatThreeRemain,CantilArmOneTotal,CantilArmOneRemain,CantilArmTwoTotal,CantilArmTwoRemain,AirRunStatus,AirTotalPre,AirFeedPre,AirAssemPre,By1,By2,By3 from DM_BUSI_BigDeviceRunInf ");
			strSql.Append(" where ");
			SqlParameter[] parameters = {
			};

			Vline.Model.DM_BUSI_BigDeviceRunInf model=new Vline.Model.DM_BUSI_BigDeviceRunInf();
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
		public Vline.Model.DM_BUSI_BigDeviceRunInf DataRowToModel(DataRow row)
		{
			Vline.Model.DM_BUSI_BigDeviceRunInf model=new Vline.Model.DM_BUSI_BigDeviceRunInf();
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
				if(row["CutSpeed"]!=null && row["CutSpeed"].ToString()!="")
				{
					model.CutSpeed=decimal.Parse(row["CutSpeed"].ToString());
				}
				if(row["CutRunStatus"]!=null && row["CutRunStatus"].ToString()!="")
				{
					model.CutRunStatus=int.Parse(row["CutRunStatus"].ToString());
				}
				if(row["FlatFixRunStatus"]!=null && row["FlatFixRunStatus"].ToString()!="")
				{
					model.FlatFixRunStatus=int.Parse(row["FlatFixRunStatus"].ToString());
				}
				if(row["FlatFixWrenchOneTop"]!=null && row["FlatFixWrenchOneTop"].ToString()!="")
				{
					model.FlatFixWrenchOneTop=decimal.Parse(row["FlatFixWrenchOneTop"].ToString());
				}
				if(row["FlatFixWrenchTwoTop"]!=null && row["FlatFixWrenchTwoTop"].ToString()!="")
				{
					model.FlatFixWrenchTwoTop=decimal.Parse(row["FlatFixWrenchTwoTop"].ToString());
				}
				if(row["FlatFixWrenchThreeTop"]!=null && row["FlatFixWrenchThreeTop"].ToString()!="")
				{
					model.FlatFixWrenchThreeTop=decimal.Parse(row["FlatFixWrenchThreeTop"].ToString());
				}
				if(row["FlatFixWrenchFourTop"]!=null && row["FlatFixWrenchFourTop"].ToString()!="")
				{
					model.FlatFixWrenchFourTop=decimal.Parse(row["FlatFixWrenchFourTop"].ToString());
				}
				if(row["FlatFixWrenchOneAim"]!=null && row["FlatFixWrenchOneAim"].ToString()!="")
				{
					model.FlatFixWrenchOneAim=decimal.Parse(row["FlatFixWrenchOneAim"].ToString());
				}
				if(row["FlatFixWrenchTwoAim"]!=null && row["FlatFixWrenchTwoAim"].ToString()!="")
				{
					model.FlatFixWrenchTwoAim=decimal.Parse(row["FlatFixWrenchTwoAim"].ToString());
				}
				if(row["FlatFixWrenchThreeAim"]!=null && row["FlatFixWrenchThreeAim"].ToString()!="")
				{
					model.FlatFixWrenchThreeAim=decimal.Parse(row["FlatFixWrenchThreeAim"].ToString());
				}
				if(row["FlatFixWrenchFourAim"]!=null && row["FlatFixWrenchFourAim"].ToString()!="")
				{
					model.FlatFixWrenchFourAim=decimal.Parse(row["FlatFixWrenchFourAim"].ToString());
				}
				if(row["CantilArmRunStatus"]!=null && row["CantilArmRunStatus"].ToString()!="")
				{
					model.CantilArmRunStatus=int.Parse(row["CantilArmRunStatus"].ToString());
				}
				if(row["CantilArmWrenchOneTop"]!=null && row["CantilArmWrenchOneTop"].ToString()!="")
				{
					model.CantilArmWrenchOneTop=decimal.Parse(row["CantilArmWrenchOneTop"].ToString());
				}
				if(row["CantilArmWrenchTwoTop"]!=null && row["CantilArmWrenchTwoTop"].ToString()!="")
				{
					model.CantilArmWrenchTwoTop=decimal.Parse(row["CantilArmWrenchTwoTop"].ToString());
				}
				if(row["CantilArmOneAim"]!=null && row["CantilArmOneAim"].ToString()!="")
				{
					model.CantilArmOneAim=decimal.Parse(row["CantilArmOneAim"].ToString());
				}
				if(row["CantilArmTwoAim"]!=null && row["CantilArmTwoAim"].ToString()!="")
				{
					model.CantilArmTwoAim=decimal.Parse(row["CantilArmTwoAim"].ToString());
				}
				if(row["ArrangeTotal"]!=null && row["ArrangeTotal"].ToString()!="")
				{
					model.ArrangeTotal=int.Parse(row["ArrangeTotal"].ToString());
				}
				if(row["ArrangeRemain"]!=null && row["ArrangeRemain"].ToString()!="")
				{
					model.ArrangeRemain=int.Parse(row["ArrangeRemain"].ToString());
				}
				if(row["FlatOneTotal"]!=null && row["FlatOneTotal"].ToString()!="")
				{
					model.FlatOneTotal=int.Parse(row["FlatOneTotal"].ToString());
				}
				if(row["FlatOneRemain"]!=null && row["FlatOneRemain"].ToString()!="")
				{
					model.FlatOneRemain=int.Parse(row["FlatOneRemain"].ToString());
				}
				if(row["FlatTwoTotal"]!=null && row["FlatTwoTotal"].ToString()!="")
				{
					model.FlatTwoTotal=int.Parse(row["FlatTwoTotal"].ToString());
				}
				if(row["FlatTwoRemain"]!=null && row["FlatTwoRemain"].ToString()!="")
				{
					model.FlatTwoRemain=int.Parse(row["FlatTwoRemain"].ToString());
				}
				if(row["FlatThreeTotal"]!=null && row["FlatThreeTotal"].ToString()!="")
				{
					model.FlatThreeTotal=int.Parse(row["FlatThreeTotal"].ToString());
				}
				if(row["FlatThreeRemain"]!=null && row["FlatThreeRemain"].ToString()!="")
				{
					model.FlatThreeRemain=int.Parse(row["FlatThreeRemain"].ToString());
				}
				if(row["CantilArmOneTotal"]!=null && row["CantilArmOneTotal"].ToString()!="")
				{
					model.CantilArmOneTotal=int.Parse(row["CantilArmOneTotal"].ToString());
				}
				if(row["CantilArmOneRemain"]!=null && row["CantilArmOneRemain"].ToString()!="")
				{
					model.CantilArmOneRemain=int.Parse(row["CantilArmOneRemain"].ToString());
				}
				if(row["CantilArmTwoTotal"]!=null && row["CantilArmTwoTotal"].ToString()!="")
				{
					model.CantilArmTwoTotal=int.Parse(row["CantilArmTwoTotal"].ToString());
				}
				if(row["CantilArmTwoRemain"]!=null && row["CantilArmTwoRemain"].ToString()!="")
				{
					model.CantilArmTwoRemain=int.Parse(row["CantilArmTwoRemain"].ToString());
				}
				if(row["AirRunStatus"]!=null && row["AirRunStatus"].ToString()!="")
				{
					model.AirRunStatus=int.Parse(row["AirRunStatus"].ToString());
				}
				if(row["AirTotalPre"]!=null && row["AirTotalPre"].ToString()!="")
				{
					model.AirTotalPre=decimal.Parse(row["AirTotalPre"].ToString());
				}
				if(row["AirFeedPre"]!=null && row["AirFeedPre"].ToString()!="")
				{
					model.AirFeedPre=decimal.Parse(row["AirFeedPre"].ToString());
				}
				if(row["AirAssemPre"]!=null && row["AirAssemPre"].ToString()!="")
				{
					model.AirAssemPre=decimal.Parse(row["AirAssemPre"].ToString());
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
			strSql.Append("select Id,Updatetime,CutSpeed,CutRunStatus,FlatFixRunStatus,FlatFixWrenchOneTop,FlatFixWrenchTwoTop,FlatFixWrenchThreeTop,FlatFixWrenchFourTop,FlatFixWrenchOneAim,FlatFixWrenchTwoAim,FlatFixWrenchThreeAim,FlatFixWrenchFourAim,CantilArmRunStatus,CantilArmWrenchOneTop,CantilArmWrenchTwoTop,CantilArmOneAim,CantilArmTwoAim,ArrangeTotal,ArrangeRemain,FlatOneTotal,FlatOneRemain,FlatTwoTotal,FlatTwoRemain,FlatThreeTotal,FlatThreeRemain,CantilArmOneTotal,CantilArmOneRemain,CantilArmTwoTotal,CantilArmTwoRemain,AirRunStatus,AirTotalPre,AirFeedPre,AirAssemPre,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigDeviceRunInf ");
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
			strSql.Append(" Id,Updatetime,CutSpeed,CutRunStatus,FlatFixRunStatus,FlatFixWrenchOneTop,FlatFixWrenchTwoTop,FlatFixWrenchThreeTop,FlatFixWrenchFourTop,FlatFixWrenchOneAim,FlatFixWrenchTwoAim,FlatFixWrenchThreeAim,FlatFixWrenchFourAim,CantilArmRunStatus,CantilArmWrenchOneTop,CantilArmWrenchTwoTop,CantilArmOneAim,CantilArmTwoAim,ArrangeTotal,ArrangeRemain,FlatOneTotal,FlatOneRemain,FlatTwoTotal,FlatTwoRemain,FlatThreeTotal,FlatThreeRemain,CantilArmOneTotal,CantilArmOneRemain,CantilArmTwoTotal,CantilArmTwoRemain,AirRunStatus,AirTotalPre,AirFeedPre,AirAssemPre,By1,By2,By3 ");
			strSql.Append(" FROM DM_BUSI_BigDeviceRunInf ");
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
			strSql.Append("select count(1) FROM DM_BUSI_BigDeviceRunInf ");
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
				strSql.Append("order by T. desc");
			}
			strSql.Append(")AS Row, T.*  from DM_BUSI_BigDeviceRunInf T ");
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
			parameters[0].Value = "DM_BUSI_BigDeviceRunInf";
			parameters[1].Value = "";
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

