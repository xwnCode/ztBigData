using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigCurrProDataBydx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigCurrProDataBydx
	{
		public DM_BUSI_BigCurrProDataBydx()
		{}
		#region Model
		private int _id;
		private DateTime? _updatetime;
		private string _crosssecnum;
		private string _twistedlinespecs;
		private string _prespipespecs;
		private string _thimblespecs;
		private string _copnosespecs;
		private decimal? _torquevalue;
		private DateTime? _curdropprostarttime;
		private DateTime? _curdropproendtime;
		private decimal? _curprolenofdrop;
		private decimal? _curproerrofdrop;
		private int? _isqualified;
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
		/// 跨段编号
		/// </summary>
		public string CrossSecNum
		{
			set{ _crosssecnum=value;}
			get{return _crosssecnum;}
		}
		/// <summary>
		/// 铜绞线规格
		/// </summary>
		public string TwistedLineSpecs
		{
			set{ _twistedlinespecs=value;}
			get{return _twistedlinespecs;}
		}
		/// <summary>
		/// 压接管规格
		/// </summary>
		public string PresPipeSpecs
		{
			set{ _prespipespecs=value;}
			get{return _prespipespecs;}
		}
		/// <summary>
		/// 心形环规格
		/// </summary>
		public string ThimbleSpecs
		{
			set{ _thimblespecs=value;}
			get{return _thimblespecs;}
		}
		/// <summary>
		/// 铜鼻子规格
		/// </summary>
		public string CopNoseSpecs
		{
			set{ _copnosespecs=value;}
			get{return _copnosespecs;}
		}
		/// <summary>
		/// 力矩值
		/// </summary>
		public decimal? TorqueValue
		{
			set{ _torquevalue=value;}
			get{return _torquevalue;}
		}
		/// <summary>
		/// 当前跨距吊弦开始生产时间
		/// </summary>
		public DateTime? CurDropProStarttime
		{
			set{ _curdropprostarttime=value;}
			get{return _curdropprostarttime;}
		}
		/// <summary>
		/// 当前跨距吊弦完成生产时间
		/// </summary>
		public DateTime? CurDropProEndtime
		{
			set{ _curdropproendtime=value;}
			get{return _curdropproendtime;}
		}
		/// <summary>
		/// 当前吊弦加工长度(单位m）
		/// </summary>
		public decimal? CurProLenofdrop
		{
			set{ _curprolenofdrop=value;}
			get{return _curprolenofdrop;}
		}
		/// <summary>
		/// 当前吊弦加工误差(单位mm)
		/// </summary>
		public decimal? CurProErrofdrop
		{
			set{ _curproerrofdrop=value;}
			get{return _curproerrofdrop;}
		}
		/// <summary>
		/// 当前吊弦加是否合格（0是初始值,1合格,2不合格）
		/// </summary>
		public int? IsQualified
		{
			set{ _isqualified=value;}
			get{return _isqualified;}
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

