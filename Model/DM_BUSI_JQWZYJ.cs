using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 作业队领料情况 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_JQWZYJ
	{
        public DM_BUSI_JQWZYJ()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private string _jqwz;
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
		/// 急缺物资
		/// </summary>
        public string JQWZ
		{
            set { _jqwz = value; }
            get { return _jqwz; }
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
