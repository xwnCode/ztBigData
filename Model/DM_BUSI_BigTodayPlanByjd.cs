using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigTodayPlanByjd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigTodayPlanByjd
	{
		public DM_BUSI_BigTodayPlanByjd()
		{}
		#region Model
		private int _id;
		private DateTime? _date;
		private string _deptname;
		private string _profession;
		private string _workcontent;
		private string _workplace;
		private string _principal;
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
		/// 
		/// </summary>
		public DateTime? date
		{
			set{ _date=value;}
			get{return _date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string deptName
		{
			set{ _deptname=value;}
			get{return _deptname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string profession
		{
			set{ _profession=value;}
			get{return _profession;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string workContent
		{
			set{ _workcontent=value;}
			get{return _workcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string workPlace
		{
			set{ _workplace=value;}
			get{return _workplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string principal
		{
			set{ _principal=value;}
			get{return _principal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by1
		{
			set{ _by1=value;}
			get{return _by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by2
		{
			set{ _by2=value;}
			get{return _by2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string by3
		{
			set{ _by3=value;}
			get{return _by3;}
		}
		#endregion Model

	}
}

