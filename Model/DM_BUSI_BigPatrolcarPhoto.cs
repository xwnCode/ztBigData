using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPatrolcarPhoto:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPatrolcarPhoto
	{
		public DM_BUSI_BigPatrolcarPhoto()
		{}
		#region Model
		private int _id;
		private string _cmd;
		private string _timestamp;
		private string _sign;
		private string _data;
		private int? _taskid;
		private int? _type;
		private int? _shootnum;
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
		public string cmd
		{
			set{ _cmd=value;}
			get{return _cmd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string timestamp
		{
			set{ _timestamp=value;}
			get{return _timestamp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sign
		{
			set{ _sign=value;}
			get{return _sign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string data
		{
			set{ _data=value;}
			get{return _data;}
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

