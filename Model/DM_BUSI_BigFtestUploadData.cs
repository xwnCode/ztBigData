using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigFtestUploadData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigFtestUploadData
	{
		public DM_BUSI_BigFtestUploadData()
		{}
		#region Model
		private int _id;
		private int? _ftestid;
		private string _taskid;
		private string _filetime;
		private string _kilometer;
		private string _maoduanname;
		private string _polename;
		private string _speed;
		private string _stationname;
		private string _hei1;
		private string _hei2;
		private string _hei3;
		private string _hei4;
		private string _zig1;
		private string _zig2;
		private string _zig3;
		private string _zig4;
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
		public int? ftestId
		{
			set{ _ftestid=value;}
			get{return _ftestid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string taskId
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fileTime
		{
			set{ _filetime=value;}
			get{return _filetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string kiloMeter
		{
			set{ _kilometer=value;}
			get{return _kilometer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string maoduanName
		{
			set{ _maoduanname=value;}
			get{return _maoduanname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string poleName
		{
			set{ _polename=value;}
			get{return _polename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string speed
		{
			set{ _speed=value;}
			get{return _speed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stationName
		{
			set{ _stationname=value;}
			get{return _stationname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hei1
		{
			set{ _hei1=value;}
			get{return _hei1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hei2
		{
			set{ _hei2=value;}
			get{return _hei2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hei3
		{
			set{ _hei3=value;}
			get{return _hei3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string hei4
		{
			set{ _hei4=value;}
			get{return _hei4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zig1
		{
			set{ _zig1=value;}
			get{return _zig1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zig2
		{
			set{ _zig2=value;}
			get{return _zig2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zig3
		{
			set{ _zig3=value;}
			get{return _zig3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zig4
		{
			set{ _zig4=value;}
			get{return _zig4;}
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

