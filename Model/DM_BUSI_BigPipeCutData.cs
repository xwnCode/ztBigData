using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigPipeCutData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigPipeCutData
	{
		public DM_BUSI_BigPipeCutData()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
		private string _pipecutnumber;
		private string _pipecuttype;
		private decimal _pipecutlength;
		private DateTime _pipecutstarttime;
		private DateTime _pipecutendtime;
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
		public DateTime Updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 管长切割编号
		/// </summary>
		public string PipeCutNumber
		{
			set{ _pipecutnumber=value;}
			get{return _pipecutnumber;}
		}
		/// <summary>
		/// 管长切割管型
		/// </summary>
		public string PipeCutType
		{
			set{ _pipecuttype=value;}
			get{return _pipecuttype;}
		}
		/// <summary>
		/// 管长切割管长
		/// </summary>
		public decimal PipeCutLength
		{
			set{ _pipecutlength=value;}
			get{return _pipecutlength;}
		}
		/// <summary>
		/// 管长切割开始时间
		/// </summary>
		public DateTime PipeCutStartTime
		{
			set{ _pipecutstarttime=value;}
			get{return _pipecutstarttime;}
		}
		/// <summary>
		/// 管长切割结束时间
		/// </summary>
		public DateTime PipeCutEndTime
		{
			set{ _pipecutendtime=value;}
			get{return _pipecutendtime;}
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

