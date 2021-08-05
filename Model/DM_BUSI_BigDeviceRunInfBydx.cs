using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigDeviceRunInfBydx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigDeviceRunInfBydx
	{
		public DM_BUSI_BigDeviceRunInfBydx()
		{}
		#region Model
		private int _id;
		private DateTime? _updatetime;
		private decimal? _totallenofcopwire;
		private decimal? _remainlenofcopwire;
		private int? _totalnumofringhop;
		private int? _remainnumofringhop;
		private int? _totalnumofpipehop;
		private int? _remainnumofpipehop;
		private int? _totalnumofnosehop;
		private int? _remainnumofnosehop;
		private int? _robotrunstate;
		private int? _hydraulicrunstate;
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
		/// 铜绞线线材总长度
		/// </summary>
		public decimal? TotalLenofcopwire
		{
			set{ _totallenofcopwire=value;}
			get{return _totallenofcopwire;}
		}
		/// <summary>
		/// 铜绞线线材剩余长度
		/// </summary>
		public decimal? RemainLenofcopwire
		{
			set{ _remainlenofcopwire=value;}
			get{return _remainlenofcopwire;}
		}
		/// <summary>
		/// 心形环料斗总数
		/// </summary>
		public int? TotalNumofRinghop
		{
			set{ _totalnumofringhop=value;}
			get{return _totalnumofringhop;}
		}
		/// <summary>
		/// 心形环料斗剩余
		/// </summary>
		public int? RemainNumofRinghop
		{
			set{ _remainnumofringhop=value;}
			get{return _remainnumofringhop;}
		}
		/// <summary>
		/// 压接管料斗总数
		/// </summary>
		public int? TotalNumofPipehop
		{
			set{ _totalnumofpipehop=value;}
			get{return _totalnumofpipehop;}
		}
		/// <summary>
		/// 压接管料斗剩余
		/// </summary>
		public int? RemainNumofPipehop
		{
			set{ _remainnumofpipehop=value;}
			get{return _remainnumofpipehop;}
		}
		/// <summary>
		/// 铜鼻子料斗总数
		/// </summary>
		public int? TotalNumofNosehop
		{
			set{ _totalnumofnosehop=value;}
			get{return _totalnumofnosehop;}
		}
		/// <summary>
		/// 铜鼻子料斗剩余
		/// </summary>
		public int? RemainNumofNosehop
		{
			set{ _remainnumofnosehop=value;}
			get{return _remainnumofnosehop;}
		}
		/// <summary>
		/// 机器人运行状态（0:停机；1:运行；2:报错）
		/// </summary>
		public int? RobotRunState
		{
			set{ _robotrunstate=value;}
			get{return _robotrunstate;}
		}
		/// <summary>
		/// 液压运行状态（0:停机；1:运行；2:报错）
		/// </summary>
		public int? HydraulicRunState
		{
			set{ _hydraulicrunstate=value;}
			get{return _hydraulicrunstate;}
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

