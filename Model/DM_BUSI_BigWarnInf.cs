using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigWarnInf:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigWarnInf
	{
		public DM_BUSI_BigWarnInf()
		{}
		#region Model
		private int _id;
		private string _devicename;
		private string _modulename;
		private string _warnlevel;
		private string _warncontent;
		private DateTime _warntime;
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
		/// 设备名称
		/// </summary>
		public string DeviceName
		{
			set{ _devicename=value;}
			get{return _devicename;}
		}
		/// <summary>
		/// 模块名称
		/// </summary>
		public string ModuleName
		{
			set{ _modulename=value;}
			get{return _modulename;}
		}
		/// <summary>
		/// 预警级别
		/// </summary>
		public string WarnLevel
		{
			set{ _warnlevel=value;}
			get{return _warnlevel;}
		}
		/// <summary>
		/// 预警内容
		/// </summary>
		public string WarnContent
		{
			set{ _warncontent=value;}
			get{return _warncontent;}
		}
		/// <summary>
		/// 预警时间
		/// </summary>
		public DateTime WarnTime
		{
			set{ _warntime=value;}
			get{return _warntime;}
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

