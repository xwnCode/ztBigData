using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigCantilArmData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigCantilArmData
	{
		public DM_BUSI_BigCantilArmData()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
		private string _cantilarmnumber;
		private DateTime _cantilarmstarttime;
		private DateTime _cantilarmendtime;
		private decimal _cantilarmsupport;
		private decimal _cantilarmlocatingring;
		private decimal _cantildarmsite;
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
		/// 斜腕臂安装编号
		/// </summary>
		public string CantilArmNumber
		{
			set{ _cantilarmnumber=value;}
			get{return _cantilarmnumber;}
		}
		/// <summary>
		/// 斜腕臂安装开始时间
		/// </summary>
		public DateTime CantilArmStartTime
		{
			set{ _cantilarmstarttime=value;}
			get{return _cantilarmstarttime;}
		}
		/// <summary>
		/// 斜腕臂安装结束时间
		/// </summary>
		public DateTime CantilArmEndTime
		{
			set{ _cantilarmendtime=value;}
			get{return _cantilarmendtime;}
		}
		/// <summary>
		/// 斜腕臂安装腕臂支撑斜位置
		/// </summary>
		public decimal CantilArmSupport
		{
			set{ _cantilarmsupport=value;}
			get{return _cantilarmsupport;}
		}
		/// <summary>
		/// 斜腕臂安装定位环1/2
		/// </summary>
		public decimal CantilArmLocatingring
		{
			set{ _cantilarmlocatingring=value;}
			get{return _cantilarmlocatingring;}
		}
		/// <summary>
		/// 斜腕臂定位支撑（一）臂位置
		/// </summary>
		public decimal CantildArmSite
		{
			set{ _cantildarmsite=value;}
			get{return _cantildarmsite;}
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

