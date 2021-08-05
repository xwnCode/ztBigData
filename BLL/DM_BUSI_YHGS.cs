using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Vline.BLL
{
    /// <summary>
	/// DM_BUSI_YHGS
	/// </summary>
	public partial class DM_BUSI_YHGS
	{
        private readonly Vline.DAL.DM_BUSI_YHGS dal = new Vline.DAL.DM_BUSI_YHGS();
		public DM_BUSI_YHGS()
		{}
		#region  BasicMethod


        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Vline.Model.DM_BUSI_YHGS model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Vline.Model.DM_BUSI_YHGS model)
		{
			return dal.Update(model);
		}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            return dal.Delete(Id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Vline.Model.DM_BUSI_YHGS GetModel(int Id)
        {

            return dal.GetModel(Id);
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
		public List<Vline.Model.DM_BUSI_YHGS> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Vline.Model.DM_BUSI_YHGS> DataTableToList(DataTable dt)
		{
			List<Vline.Model.DM_BUSI_YHGS> modelList = new List<Vline.Model.DM_BUSI_YHGS>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Vline.Model.DM_BUSI_YHGS model=new Model.DM_BUSI_YHGS();
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
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}
