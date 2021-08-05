using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigDayProDetailsBydx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigDayProDetailsBydx
	{
		public DM_BUSI_BigDayProDetailsBydx()
		{}
		#region Model
		private int _id;
		private DateTime? _updatetime;
		private DateTime? _dayid;
		private int? _daytotal;
		private int? _dayplan;
		private int? _dayqualified;
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
		public DateTime? Updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 当天日期
		/// </summary>
		public DateTime? DayID
		{
			set{ _dayid=value;}
			get{return _dayid;}
		}
		/// <summary>
		/// 当天生产总数
		/// </summary>
		public int? DayTotal
		{
			set{ _daytotal=value;}
			get{return _daytotal;}
		}
		/// <summary>
		/// 当天生产计划数
		/// </summary>
		public int? DayPlan
		{
			set{ _dayplan=value;}
			get{return _dayplan;}
		}
		/// <summary>
		/// 当天生产合格数
		/// </summary>
		public int? DayQualified
		{
			set{ _dayqualified=value;}
			get{return _dayqualified;}
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

