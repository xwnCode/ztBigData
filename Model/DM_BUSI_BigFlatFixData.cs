using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigFlatFixData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigFlatFixData
	{
		public DM_BUSI_BigFlatFixData()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
		private string _flatfixnumber;
		private DateTime _flatfixstarttime;
		private DateTime _flatfixendtime;
		private decimal _flatfixposition;
		private decimal _flatfixears;
		private decimal _flatfixseat;
		private decimal _flatfixsupport;
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
		/// 平腕臂安装编号
		/// </summary>
		public string FlatFixNumber
		{
			set{ _flatfixnumber=value;}
			get{return _flatfixnumber;}
		}
		/// <summary>
		/// 平腕臂安装开始时间
		/// </summary>
		public DateTime FlatFixStartTime
		{
			set{ _flatfixstarttime=value;}
			get{return _flatfixstarttime;}
		}
		/// <summary>
		/// 平腕臂安装结束时间
		/// </summary>
		public DateTime FlatFixEndTime
		{
			set{ _flatfixendtime=value;}
			get{return _flatfixendtime;}
		}
		/// <summary>
		/// 平腕臂安装腕臂支撑平位置
		/// </summary>
		public decimal FlatFixPosition
		{
			set{ _flatfixposition=value;}
			get{return _flatfixposition;}
		}
		/// <summary>
		/// 平腕臂安装平双耳
		/// </summary>
		public decimal FlatFixEars
		{
			set{ _flatfixears=value;}
			get{return _flatfixears;}
		}
		/// <summary>
		/// 平腕臂安装承支座
		/// </summary>
		public decimal FlatFixSeat
		{
			set{ _flatfixseat=value;}
			get{return _flatfixseat;}
		}
		/// <summary>
		/// 平腕臂定位支撑（二）臂位置
		/// </summary>
		public decimal FlatFixSupport
		{
			set{ _flatfixsupport=value;}
			get{return _flatfixsupport;}
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

