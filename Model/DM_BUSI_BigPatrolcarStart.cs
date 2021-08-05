using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPatrolcarStart:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPatrolcarStart
	{
		public DM_BUSI_BigPatrolcarStart()
		{}
		#region Model
		private int _id;
		private string _cmd;
		private string _timestamp;
		private string _sign;
		private string _data;
		private string _line;
		private string _direction;
		private string _taskname;
		private string _stations;
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
		public string line
		{
			set{ _line=value;}
			get{return _line;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string direction
		{
			set{ _direction=value;}
			get{return _direction;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string taskName
		{
			set{ _taskname=value;}
			get{return _taskname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string stations
		{
			set{ _stations=value;}
			get{return _stations;}
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

