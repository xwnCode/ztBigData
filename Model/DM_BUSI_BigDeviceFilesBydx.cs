using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigDeviceFilesBydx:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigDeviceFilesBydx
	{
		public DM_BUSI_BigDeviceFilesBydx()
		{}
		#region Model
		private int _id;
		private DateTime? _updatetime;
		private string _devicename;
		private string _charger;
		private string _phone;
		private byte[] _devicepicture;
		private string _deviceaddress;
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
		/// 设备名称
		/// </summary>
		public string Devicename
		{
			set{ _devicename=value;}
			get{return _devicename;}
		}
		/// <summary>
		/// 负责人
		/// </summary>
		public string Charger
		{
			set{ _charger=value;}
			get{return _charger;}
		}
		/// <summary>
		/// 电话
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 设备图片
		/// </summary>
		public byte[] Devicepicture
		{
			set{ _devicepicture=value;}
			get{return _devicepicture;}
		}
		/// <summary>
		/// 设备地址
		/// </summary>
		public string Deviceaddress
		{
			set{ _deviceaddress=value;}
			get{return _deviceaddress;}
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

