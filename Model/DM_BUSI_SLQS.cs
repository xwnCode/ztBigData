using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 隐患排查数量趋势 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_SLQS
	{
        public DM_BUSI_SLQS()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private int _yiyue;
        private int _eryue;
        private int _sanyue;
        private int _siyue;

        private int _wuyue;
        private int _liuyue;
        private int _qiyue;
        private int _bayue;
        private int _jiuyue;
        private int _shiyue;
        private int _shiyiyue;
        private int _shieryue;
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
		/// 一级
		/// </summary>
        public int YIYUE
		{
            set { _yiyue = value; }
            get { return _yiyue; }
		}
		/// <summary>
        /// 二级
		/// </summary>
        public int ERYUE
		{
            set { _eryue = value; }
            get { return _eryue; }
		}
		/// <summary>
		/// 三级
		/// </summary>
        public int SANYUE
		{
            set { _sanyue = value; }
            get { return _sanyue; }
		}
		/// <summary>
		/// 4
		/// </summary>
        public int SIYUE
		{
            set { _siyue = value; }
            get { return _siyue; }
		}
        /// <summary>
        /// 5
        /// </summary>
        public int WUYUE
        {
            set { _wuyue = value; }
            get { return _wuyue; }
        }
        /// <summary>
        /// 6
        /// </summary>
        public int LIUYUE
        {
            set { _liuyue = value; }
            get { return _liuyue; }
        }
        /// <summary>
        /// 7
        /// </summary>
        public int QIYUE
        {
            set { _qiyue = value; }
            get { return _qiyue; }
        }
        /// <summary>
        /// 8
        /// </summary>
        public int BAYUE
        {
            set { _bayue = value; }
            get { return _bayue; }
        }
        /// <summary>
        /// 9
        /// </summary>
        public int JIUYUE
        {
            set { _jiuyue = value; }
            get { return _jiuyue; }
        }
        /// <summary>
        /// 10
        /// </summary>
        public int SHIYUE
        {
            set { _shiyue = value; }
            get { return _shiyue; }
        }
        /// <summary>
        /// 11
        /// </summary>
        public int SHIYIYUE
        {
            set { _shiyiyue = value; }
            get { return _shiyiyue; }
        }
        /// <summary>
        /// 12
        /// </summary>
        public int SHIERYUE
        {
            set { _shieryue = value; }
            get { return _shieryue; }
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
