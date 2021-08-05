using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// DM_BUSI_WorkData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_WorkData
	{
		public DM_BUSI_WorkData()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private string _qujian;
        private string _ganhao;
        private string _direction;
        private float _site;
        private float _coordinate;
        private string _type;
        private string _worktype;
        private float _kj;
        private float _ks;
        private float _kjj;
        private int _kzquantity;
        private float _lbsyzh;
        private float _pausetime;
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
			set{ _updatetime=DateTime.Now;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 发动机转速
		/// </summary>
        public string Qujian
		{
            set { _qujian = value; }
            get { return _qujian; }
		}
		/// <summary>
		/// 剩余油量
		/// </summary>
        public string Ganhao
		{
            set { _ganhao = value; }
            get { return _ganhao; }
		}
		/// <summary>
		/// 输出电压
		/// </summary>
        public string Direction
		{
            set { _direction = value; }
            get { return _direction; }
		}
		/// <summary>
		/// 柴油机机油压力
		/// </summary>
        public float Site
		{
            set { _site = value; }
            get { return _site; }
		}
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Coordinate
        {
            set { _coordinate = value; }
            get { return _coordinate; }
        }
        /// <summary>
        /// 输出电压
        /// </summary>
        public string Type
        {
            set { _type = value; }
            get { return _type; }
        }
        /// <summary>
        /// 输出电压
        /// </summary>
        public string Worktype
        {
            set { _worktype = value; }
            get { return _worktype; }
        }
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Kj
        {
            set { _ks = value; }
            get { return _ks; }
        }
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Ks
        {
            set { _kj = value; }
            get { return _kj; }
        }
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Kjj
        {
            set { _kjj = value; }
            get { return _kjj; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Kzquantity
        {
            set { _kzquantity = value; }
            get { return _kzquantity; }
        }
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Lbsyzh
        {
            set { _lbsyzh = value; }
            get { return _lbsyzh; }
        }
        /// <summary>
        /// 柴油机机油压力
        /// </summary>
        public float Pausetime
        {
            set { _pausetime = value; }
            get { return _pausetime; }
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
