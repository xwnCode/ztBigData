using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigFtestPhotoData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigFtestPhotoData
	{
		public DM_BUSI_BigFtestPhotoData()
		{}
		#region Model
		private int _id;
		private int? _ftestid;
		private int? _taskid;
		private int? _type;
		private int? _shootnum;
		private int? _faultnum;
		private int? _savenum;
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
		public int? taskId
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? shootNum
		{
			set{ _shootnum=value;}
			get{return _shootnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? faultNum
		{
			set{ _faultnum=value;}
			get{return _faultnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? saveNum
		{
			set{ _savenum=value;}
			get{return _savenum;}
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

