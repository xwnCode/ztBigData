using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigFtestStartData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigFtestStartData
	{
		public DM_BUSI_BigFtestStartData()
		{}
		#region Model
		private int _id;
		private int? _ftestid;
		private string _stype;
		private string _linename;
		private string _taskname;
		private string _startstation;
		private string _endstation;
		private string _sstartpolename;
		private string _sendpolename;
		private string _taskdate;
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
		public string SType
		{
			set{ _stype=value;}
			get{return _stype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LineName
		{
			set{ _linename=value;}
			get{return _linename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaskName
		{
			set{ _taskname=value;}
			get{return _taskname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StartStation
		{
			set{ _startstation=value;}
			get{return _startstation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EndStation
		{
			set{ _endstation=value;}
			get{return _endstation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SStartPoleName
		{
			set{ _sstartpolename=value;}
			get{return _sstartpolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SEndPoleName
		{
			set{ _sendpolename=value;}
			get{return _sendpolename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaskDate
		{
			set{ _taskdate=value;}
			get{return _taskdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaskDateTime
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

