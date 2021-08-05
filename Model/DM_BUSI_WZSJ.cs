using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 物资数据 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_WZSJ
	{
        public DM_BUSI_WZSJ()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private string _cgzje;
        private string _dhqk;
        private int _gys;
        private string _bxbl;
		private string _by1;
		private string _by2;
		private string _by3;
		/// <summary>
		/// 
		/// </summary>
        public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 更新时间
		/// </summary>
		public DateTime Updatetime
		{
			set{ _updatetime=DateTime.Now;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 采购总金额
		/// </summary>
        public string CGZJE
		{
            set { _cgzje = value; }
            get { return _cgzje; }
		}
		/// <summary>
        /// 到货情况
		/// </summary>
        public string DHQK
		{
            set { _dhqk = value; }
            get { return _dhqk; }
		}
		/// <summary>
		/// 供应商数量
		/// </summary>
        public int GYS
		{
            set { _gys = value; }
            get { return _gys; }
		}
		/// <summary>
		/// 报险比例
		/// </summary>
        public string BXBL
		{
            set { _bxbl = value; }
            get { return _bxbl; }
		}
		/// <summary>
		/// 
		/// </summary>
		public string By1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string By3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		#endregion Model

	}
}
