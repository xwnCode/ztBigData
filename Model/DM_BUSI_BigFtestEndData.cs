using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigFtestEndData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigFtestEndData
	{
		public DM_BUSI_BigFtestEndData()
		{}
		#region Model
		private int _id;
		private int? _ftestid;
		private string _taskid;
		private string _taskname;
		private string _endstation;
		private string _taskdatetime;
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
		public string taskName
		{
			set{ _taskname=value;}
			get{return _taskname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string endStation
		{
			set{ _endstation=value;}
			get{return _endstation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string taskDateTime
		{
			set{ _taskdatetime=value;}
			get{return _taskdatetime;}
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

