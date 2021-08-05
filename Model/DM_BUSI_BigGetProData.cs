using System;
namespace Vline.Model
{
	/// <summary>
	/// DM_BUSI_BigGetProData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_BigGetProData
	{
		public DM_BUSI_BigGetProData()
		{}
		#region Model
		private int _id;
		private DateTime _dateofdata;
		private string _nameofanchor;
		private string _number;
		private string _type;
		private string _abutment;
		private string _flatears;
		private string _cantilears;
		private string _locatingring;
		private string _posseat;
		private string _windbreak;
		private string _flatfix;
		private string _cantilarm;
		private string _postube;
		private string _carpalsuplon;
		private string _carpalsupflat;
		private string _carpalsupobl;
		private string _locasupsupo;
		private string _locasuparmo;
		private string _locasupseto;
		private string _locasupsupt;
		private string _locasuparmt;
		private string _locasupsett;
		private string _posparameters;
		private string _baseparameters;
		private string _susparameters;
		private string _posslope;
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
		/// 数据日期
		/// </summary>
		public DateTime DateOfdata
		{
			set{ _dateofdata=value;}
			get{return _dateofdata;}
		}
		/// <summary>
		/// 锚段名称
		/// </summary>
		public string NameOfAnchor
		{
			set{ _nameofanchor=value;}
			get{return _nameofanchor;}
		}
		/// <summary>
		/// 编号
		/// </summary>
		public string Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 类型
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 承支座
		/// </summary>
		public string Abutment
		{
			set{ _abutment=value;}
			get{return _abutment;}
		}
		/// <summary>
		/// 平双耳
		/// </summary>
		public string Flatears
		{
			set{ _flatears=value;}
			get{return _flatears;}
		}
		/// <summary>
		/// 斜双耳
		/// </summary>
		public string Cantilears
		{
			set{ _cantilears=value;}
			get{return _cantilears;}
		}
		/// <summary>
		/// 定位环1/2
		/// </summary>
		public string Locatingring
		{
			set{ _locatingring=value;}
			get{return _locatingring;}
		}
		/// <summary>
		/// 定位座
		/// </summary>
		public string Posseat
		{
			set{ _posseat=value;}
			get{return _posseat;}
		}
		/// <summary>
		/// 防风卡
		/// </summary>
		public string Windbreak
		{
			set{ _windbreak=value;}
			get{return _windbreak;}
		}
		/// <summary>
		/// 平腕臂
		/// </summary>
		public string FlatFix
		{
			set{ _flatfix=value;}
			get{return _flatfix;}
		}
		/// <summary>
		/// 斜腕臂
		/// </summary>
		public string CantilArm
		{
			set{ _cantilarm=value;}
			get{return _cantilarm;}
		}
		/// <summary>
		/// 定位管1/2
		/// </summary>
		public string Postube
		{
			set{ _postube=value;}
			get{return _postube;}
		}
		/// <summary>
		/// 腕臂支撑_支撑长
		/// </summary>
		public string Carpalsuplon
		{
			set{ _carpalsuplon=value;}
			get{return _carpalsuplon;}
		}
		/// <summary>
		/// 腕臂支撑_平位置
		/// </summary>
		public string Carpalsupflat
		{
			set{ _carpalsupflat=value;}
			get{return _carpalsupflat;}
		}
		/// <summary>
		/// 腕臂支撑_斜位置
		/// </summary>
		public string Carpalsupobl
		{
			set{ _carpalsupobl=value;}
			get{return _carpalsupobl;}
		}
		/// <summary>
		/// 定位支撑(一)_支撑长
		/// </summary>
		public string LocasupSupo
		{
			set{ _locasupsupo=value;}
			get{return _locasupsupo;}
		}
		/// <summary>
		/// 定位支撑(一)_臂位置
		/// </summary>
		public string LocasupArmo
		{
			set{ _locasuparmo=value;}
			get{return _locasuparmo;}
		}
		/// <summary>
		/// 定位支撑(一)_定位置
		/// </summary>
		public string LocasupSeto
		{
			set{ _locasupseto=value;}
			get{return _locasupseto;}
		}
		/// <summary>
		/// 定位支撑(二)_支撑长
		/// </summary>
		public string LocasupSupt
		{
			set{ _locasupsupt=value;}
			get{return _locasupsupt;}
		}
		/// <summary>
		/// 定位支撑(二)_臂位置
		/// </summary>
		public string LocasupArmt
		{
			set{ _locasuparmt=value;}
			get{return _locasuparmt;}
		}
		/// <summary>
		/// 定位支撑(二)_定位置
		/// </summary>
		public string LocasupSett
		{
			set{ _locasupsett=value;}
			get{return _locasupsett;}
		}
		/// <summary>
		/// 定位参数
		/// </summary>
		public string PosParameters
		{
			set{ _posparameters=value;}
			get{return _posparameters;}
		}
		/// <summary>
		/// 底座参数
		/// </summary>
		public string BaseParameters
		{
			set{ _baseparameters=value;}
			get{return _baseparameters;}
		}
		/// <summary>
		/// 悬挂参数
		/// </summary>
		public string SusParameters
		{
			set{ _susparameters=value;}
			get{return _susparameters;}
		}
		/// <summary>
		/// 定位坡度
		/// </summary>
		public string Posslope
		{
			set{ _posslope=value;}
			get{return _posslope;}
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

