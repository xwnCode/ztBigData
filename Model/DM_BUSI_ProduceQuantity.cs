using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// DM_BUSI_ProduceQuantity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_ProduceQuantity
	{
		public DM_BUSI_ProduceQuantity()
		{}
		#region Model
		private int _id;
        private DateTime _date;
        private int _dayplan;
        private int _daytotal;
        private int _dayqualified;
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
		/// 时间
		/// </summary>
        public DateTime Date
		{
			set{ _date=value;}
            get { return _date; }
		}
		/// <summary>
        /// 当天生产计划数
		/// </summary>
        public int Dayplan
		{
            set { _dayplan = value; }
            get { return _dayplan; }
		}
		/// <summary>
        /// 当天生产总数
		/// </summary>
        public int Daytotal
		{
            set { _daytotal = value; }
            get { return _daytotal; }
		}
		/// <summary>
        /// 当天生产合格数
		/// </summary>
        public int Dayqualified
		{
            set { _dayqualified = value; }
            get { return _dayqualified; }
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
