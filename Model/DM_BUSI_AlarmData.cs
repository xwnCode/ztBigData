using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// DM_BUSI_AlarmData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_AlarmData
	{
		public DM_BUSI_AlarmData()
		{}
		#region Model
		private int _id;
        private DateTime _alarmdate;
        private string _alarmcontent;
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
		/// 报警时间
		/// </summary>
        public DateTime Alarmdate
		{
            set { _alarmdate = value; }
            get { return _alarmdate; }
		}
		/// <summary>
        /// 报警内容
		/// </summary>
        public string Alarmcontent
		{
            set { _alarmcontent = value; }
            get { return _alarmcontent; }
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
