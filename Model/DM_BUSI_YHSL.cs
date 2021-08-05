using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 各级别隐患数量:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_YHSL
	{
        public DM_BUSI_YHSL()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private int _yiji;
        private int _erji;
        private int _sanji;
        private int _siji;
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
        public int YIJI
		{
            set { _yiji = value; }
            get { return _yiji; }
		}
		/// <summary>
        /// 二级
		/// </summary>
        public int ERJI
		{
            set { _erji = value; }
            get { return _erji; }
		}
		/// <summary>
		/// 三级
		/// </summary>
        public int SANJI
		{
            set { _sanji = value; }
            get { return _sanji; }
		}
		/// <summary>
		/// 四级
		/// </summary>
        public int SIJI
		{
            set { _siji = value; }
            get { return _siji; }
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
