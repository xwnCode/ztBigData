using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPatrolcarStartData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPatrolcarStartData
	{
		public DM_BUSI_BigPatrolcarStartData()
		{}
		#region Model
		private int _id;
		private int? _patrolcarid;
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
		public int? patrolcarId
		{
			set{ _patrolcarid=value;}
			get{return _patrolcarid;}
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

