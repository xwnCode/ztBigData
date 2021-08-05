using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 大数据:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_YHSJ
	{
        public DM_BUSI_YHSJ()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private int _pcsl;
        private int _wcsl;
        private string _wcbl;
        private string _khfs;
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
        /// 隐患排查数量
		/// </summary>
        public int PCSL
		{
            set { _pcsl = value; }
            get { return _pcsl; }
		}
		/// <summary>
        ///  整改完成数量
		/// </summary>
        public int WCSL
		{
            set { _wcsl = value; }
            get { return _wcsl; }
		}
		/// <summary>
        /// 整改完成比例
		/// </summary>
        public string WCBL
		{
            set { _wcbl = value; }
            get { return _wcbl; }
		}
		/// <summary>
        /// 考核分数
		/// </summary>
        public string KHFS
		{
            set { _khfs = value; }
            get { return _khfs; }
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
