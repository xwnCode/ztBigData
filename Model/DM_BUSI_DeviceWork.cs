using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// DM_BUSI_DeviceWork:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_DeviceWork
	{
		public DM_BUSI_DeviceWork()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
		private int _enginespeed;
		private int _fueltank;
		private int _alternator;
		private int _deblockpre;
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
		/// 发动机转速
		/// </summary>
		public int Enginespeed
		{
			set{ _enginespeed=value;}
			get{return _enginespeed;}
		}
		/// <summary>
		/// 剩余油量
		/// </summary>
		public int Fueltank
		{
			set{ _fueltank=value;}
			get{return _fueltank;}
		}
		/// <summary>
		/// 输出电压
		/// </summary>
		public int Alternator
		{
			set{ _alternator=value;}
			get{return _alternator;}
		}
		/// <summary>
		/// 柴油机机油压力
		/// </summary>
		public int Deblockpre
		{
			set{ _deblockpre=value;}
			get{return _deblockpre;}
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
