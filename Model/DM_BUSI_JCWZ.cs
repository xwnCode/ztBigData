using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
     ///<summary>
    /// 近7天进场物资 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_JCWZ
	{
        public DM_BUSI_JCWZ()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private string _name;
        private string _xh;
        private string _dw;
        private string _jcsl;
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
		/// 物资名称
		/// </summary>
        public string NAME
		{
            set { _name = value; }
            get { return _name; }
		}
		/// <summary>
        /// 型号
		/// </summary>
        public string XH
		{
            set { _xh = value; }
            get { return _xh; }
		}
		/// <summary>
		/// 单位
		/// </summary>
        public string DW
		{
            set { _dw = value; }
            get { return _dw; }
		}
		/// <summary>
		/// 进场数量
		/// </summary>
        public string JCSL
		{
            set { _jcsl = value; }
            get { return _jcsl; }
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
