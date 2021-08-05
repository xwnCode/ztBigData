using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPhyWorkByjd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPhyWorkByjd
	{
		public DM_BUSI_BigPhyWorkByjd()
		{}
		#region Model
		private int _id;
		private string _profession;
		private string _projectname;
		private string _unit;
		private decimal? _projecttotal;
		private decimal? _cumtotal;
		private DateTime? _targetnode;
		private decimal? _monthplan;
		private decimal? _monthfinish;
		private decimal? _cumfinish;
		private decimal? _nextplan;
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
		public string profession
		{
			set{ _profession=value;}
			get{return _profession;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string projectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? projectTotal
		{
			set{ _projecttotal=value;}
			get{return _projecttotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cumTotal
		{
			set{ _cumtotal=value;}
			get{return _cumtotal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? targetNode
		{
			set{ _targetnode=value;}
			get{return _targetnode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? monthPlan
		{
			set{ _monthplan=value;}
			get{return _monthplan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? monthFinish
		{
			set{ _monthfinish=value;}
			get{return _monthfinish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? cumFinish
		{
			set{ _cumfinish=value;}
			get{return _cumfinish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? nextPlan
		{
			set{ _nextplan=value;}
			get{return _nextplan;}
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

