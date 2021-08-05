﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Vline.BLL
{
    /// <summary>
	/// DM_BUSI_AlarmData
	/// </summary>
	public partial class DM_BUSI_AlarmData
	{
		private readonly Vline.DAL.DM_BUSI_AlarmData dal=new Vline.DAL.DM_BUSI_AlarmData();
		public DM_BUSI_AlarmData()
		{}
		#region  BasicMethod


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public string GetMaxId()
        {
            return dal.GetMaxId();
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_AlarmData model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Vline.Model.DM_BUSI_AlarmData model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Vline.Model.DM_BUSI_AlarmData GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public Vline.Model.DM_BUSI_AlarmData GetModelByCache()
		{
			//该表无主键信息，请自定义主键/条件字段
			string CacheKey = "DM_BUSI_BigDeviceFilesModel-" ;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel();
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (Vline.Model.DM_BUSI_AlarmData)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Vline.Model.DM_BUSI_AlarmData> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Vline.Model.DM_BUSI_AlarmData> DataTableToList(DataTable dt)
		{
			List<Vline.Model.DM_BUSI_AlarmData> modelList = new List<Vline.Model.DM_BUSI_AlarmData>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Vline.Model.DM_BUSI_AlarmData model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.DM_BUSI_AlarmData GetModel(int Id)
        {

            return dal.GetModel(Id);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            return dal.GetCount();
        }

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
