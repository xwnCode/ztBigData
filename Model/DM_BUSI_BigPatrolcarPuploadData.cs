using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPatrolcarPuploadData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPatrolcarPuploadData
	{
		public DM_BUSI_BigPatrolcarPuploadData()
		{}
		#region Model
		private int _id;
		private int? _patrolcarid;
		private int? _taskid;
		private string _img;
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
		public int? taskId
		{
			set{ _taskid=value;}
			get{return _taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string img
		{
			set{ _img=value;}
			get{return _img;}
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

