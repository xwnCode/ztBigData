using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigConSitePictByjd:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigConSitePictByjd
	{
		public DM_BUSI_BigConSitePictByjd()
		{}
		#region Model
		private int _id;
		private string _name;
		private byte[] _image;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] image
		{
			set{ _image=value;}
			get{return _image;}
		}
		#endregion Model

	}
}

