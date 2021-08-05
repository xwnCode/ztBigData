using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigOutputValueByjd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigOutputValueByjd
	{
		public DM_BUSI_BigOutputValueByjd()
		{}
		#region Model
		private int _id;
		private string _profession;
		private string _month;
		private string _quarter;
		private string _year;
		private decimal? _ydcomplete;
		private decimal? _ydplan;
		private decimal? _accumulative;
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
		public string month
		{
			set{ _month=value;}
			get{return _month;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string quarter
		{
			set{ _quarter=value;}
			get{return _quarter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string year
		{
			set{ _year=value;}
			get{return _year;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ydcomplete
		{
			set{ _ydcomplete=value;}
			get{return _ydcomplete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ydplan
		{
			set{ _ydplan=value;}
			get{return _ydplan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? accumulative
		{
			set{ _accumulative=value;}
			get{return _accumulative;}
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

