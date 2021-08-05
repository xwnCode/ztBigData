using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigDeviceRunInf:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigDeviceRunInf
	{
		public DM_BUSI_BigDeviceRunInf()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
		private decimal _cutspeed;
		private int _cutrunstatus;
		private int _flatfixrunstatus;
		private decimal _flatfixwrenchonetop;
		private decimal _flatfixwrenchtwotop;
		private decimal _flatfixwrenchthreetop;
		private decimal _flatfixwrenchfourtop;
		private decimal _flatfixwrenchoneaim;
		private decimal _flatfixwrenchtwoaim;
		private decimal _flatfixwrenchthreeaim;
		private decimal _flatfixwrenchfouraim;
		private int _cantilarmrunstatus;
		private decimal _cantilarmwrenchonetop;
		private decimal _cantilarmwrenchtwotop;
		private decimal _cantilarmoneaim;
		private decimal _cantilarmtwoaim;
		private int _arrangetotal;
		private int _arrangeremain;
		private int _flatonetotal;
		private int _flatoneremain;
		private int _flattwototal;
		private int _flattworemain;
		private int _flatthreetotal;
		private int _FlatThreeRemain;
		private int _cantilarmonetotal;
		private int _cantilarmoneremain;
		private int _cantilarmtwototal;
		private int _cantilarmtworemain;
		private int _airrunstatus;
		private decimal _airtotalpre;
		private decimal _airfeedpre;
		private decimal _airassempre;
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
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 切割机转速
		/// </summary>
		public decimal CutSpeed
		{
			set{ _cutspeed=value;}
			get{return _cutspeed;}
		}
		/// <summary>
		/// 切割机运行状态（0:离线；1:正常）
		/// </summary>
		public int CutRunStatus
		{
			set{ _cutrunstatus=value;}
			get{return _cutrunstatus;}
		}
		/// <summary>
		/// 平腕臂安装  运行状态（0:离线；1:正常；2:异常）
		/// </summary>
		public int FlatFixRunStatus
		{
			set{ _flatfixrunstatus=value;}
			get{return _flatfixrunstatus;}
		}
		/// <summary>
		/// 平腕臂安装  扳手1峰值扭矩
		/// </summary>
		public decimal FlatFixWrenchOneTop
		{
			set{ _flatfixwrenchonetop=value;}
			get{return _flatfixwrenchonetop;}
		}
		/// <summary>
		/// 平腕臂安装  扳手2峰值扭矩
		/// </summary>
		public decimal FlatFixWrenchTwoTop
		{
			set{ _flatfixwrenchtwotop=value;}
			get{return _flatfixwrenchtwotop;}
		}
		/// <summary>
		/// 平腕臂安装  扳手3峰值扭矩
		/// </summary>
		public decimal FlatFixWrenchThreeTop
		{
			set{ _flatfixwrenchthreetop=value;}
			get{return _flatfixwrenchthreetop;}
		}
		/// <summary>
		/// 平腕臂安装  扳手4峰值扭矩
		/// </summary>
		public decimal FlatFixWrenchFourTop
		{
			set{ _flatfixwrenchfourtop=value;}
			get{return _flatfixwrenchfourtop;}
		}
		/// <summary>
		/// 平腕臂安装  扳手1目标扭矩
		/// </summary>
		public decimal FlatFixWrenchOneAim
		{
			set{ _flatfixwrenchoneaim=value;}
			get{return _flatfixwrenchoneaim;}
		}
		/// <summary>
		/// 平腕臂安装  扳手2目标扭矩
		/// </summary>
		public decimal FlatFixWrenchTwoAim
		{
			set{ _flatfixwrenchtwoaim=value;}
			get{return _flatfixwrenchtwoaim;}
		}
		/// <summary>
		/// 平腕臂安装  扳手3目标扭矩
		/// </summary>
		public decimal FlatFixWrenchThreeAim
		{
			set{ _flatfixwrenchthreeaim=value;}
			get{return _flatfixwrenchthreeaim;}
		}
		/// <summary>
		/// 平腕臂安装  扳手4目标扭矩
		/// </summary>
		public decimal FlatFixWrenchFourAim
		{
			set{ _flatfixwrenchfouraim=value;}
			get{return _flatfixwrenchfouraim;}
		}
		/// <summary>
		/// 斜腕臂安装  运行状态（0:离线；1:正常；2:异常）
		/// </summary>
		public int CantilArmRunStatus
		{
			set{ _cantilarmrunstatus=value;}
			get{return _cantilarmrunstatus;}
		}
		/// <summary>
		/// 斜腕臂安装  扳手1峰值扭矩
		/// </summary>
		public decimal CantilArmWrenchOneTop
		{
			set{ _cantilarmwrenchonetop=value;}
			get{return _cantilarmwrenchonetop;}
		}
		/// <summary>
		/// 斜腕臂安装  扳手2峰值扭矩
		/// </summary>
		public decimal CantilArmWrenchTwoTop
		{
			set{ _cantilarmwrenchtwotop=value;}
			get{return _cantilarmwrenchtwotop;}
		}
		/// <summary>
		/// 斜腕臂安装  扳手1目标扭矩
		/// </summary>
		public decimal CantilArmOneAim
		{
			set{ _cantilarmoneaim=value;}
			get{return _cantilarmoneaim;}
		}
		/// <summary>
		/// 斜腕臂安装  扳手2目标扭矩
		/// </summary>
		public decimal CantilArmTwoAim
		{
			set{ _cantilarmtwoaim=value;}
			get{return _cantilarmtwoaim;}
		}
		/// <summary>
		/// 管料料理  总容量
		/// </summary>
		public int ArrangeTotal
		{
			set{ _arrangetotal=value;}
			get{return _arrangetotal;}
		}
		/// <summary>
		/// 管料料理  剩余容量
		/// </summary>
		public int ArrangeRemain
		{
			set{ _arrangeremain=value;}
			get{return _arrangeremain;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件1总容量
		/// </summary>
		public int FlatOneTotal
		{
			set{ _flatonetotal=value;}
			get{return _flatonetotal;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件1剩余容量
		/// </summary>
		public int FlatOneRemain
		{
			set{ _flatoneremain=value;}
			get{return _flatoneremain;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件2总容量
		/// </summary>
		public int FlatTwoTotal
		{
			set{ _flattwototal=value;}
			get{return _flattwototal;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件2剩余容量
		/// </summary>
		public int FlatTwoRemain
		{
			set{ _flattworemain=value;}
			get{return _flattworemain;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件3总容量
		/// </summary>
		public int FlatThreeTotal
		{
			set{ _flatthreetotal=value;}
			get{return _flatthreetotal;}
		}
		/// <summary>
		/// 平腕臂工件料库   工件4剩余容量
		/// </summary>
		public int FlatThreeRemain
		{
			set{ _FlatThreeRemain=value;}
			get{return _FlatThreeRemain;}
		}
		/// <summary>
		/// 斜腕臂工件料库   工件1总容量
		/// </summary>
		public int CantilArmOneTotal
		{
			set{ _cantilarmonetotal=value;}
			get{return _cantilarmonetotal;}
		}
		/// <summary>
		/// 斜腕臂工件料库   工件1剩余容量
		/// </summary>
		public int CantilArmOneRemain
		{
			set{ _cantilarmoneremain=value;}
			get{return _cantilarmoneremain;}
		}
		/// <summary>
		/// 斜腕臂工件料库   工件2总容量
		/// </summary>
		public int CantilArmTwoTotal
		{
			set{ _cantilarmtwototal=value;}
			get{return _cantilarmtwototal;}
		}
		/// <summary>
		/// 斜腕臂工件料库   工件2剩余容量
		/// </summary>
		public int CantilArmTwoRemain
		{
			set{ _cantilarmtworemain=value;}
			get{return _cantilarmtworemain;}
		}
		/// <summary>
		/// 气泵   运行状态（0:离线；1:正常）
		/// </summary>
		public int AirRunStatus
		{
			set{ _airrunstatus=value;}
			get{return _airrunstatus;}
		}
		/// <summary>
		/// 气泵   总气压值
		/// </summary>
		public decimal AirTotalPre
		{
			set{ _airtotalpre=value;}
			get{return _airtotalpre;}
		}
		/// <summary>
		/// 气泵   上料气压值
		/// </summary>
		public decimal AirFeedPre
		{
			set{ _airfeedpre=value;}
			get{return _airfeedpre;}
		}
		/// <summary>
		/// 气泵   装配气压值
		/// </summary>
		public decimal AirAssemPre
		{
			set{ _airassempre=value;}
			get{return _airassempre;}
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

