using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 各专业物资采购合同情况 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_CGHT
	{
        public DM_BUSI_CGHT()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private int _jcw;
        private int _dl;
        private int _bd;
        private int _tx;

        private int _xx;
        private int _xh;
        private int _fas;
        private int _bas;
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
		/// 接触网
		/// </summary>
        public int JCW
		{
            set { _jcw = value; }
            get { return _jcw; }
		}
		/// <summary>
        /// 电力
		/// </summary>
        public int DL
		{
            set { _dl = value; }
            get { return _dl; }
		}
		/// <summary>
		/// 变电
		/// </summary>
        public int BD
		{
            set { _bd = value; }
            get { return _bd; }
		}
		/// <summary>
		/// 通信
		/// </summary>
        public int TX
		{
            set { _tx = value; }
            get { return _tx; }
		}
        /// <summary>
        /// 信息
        /// </summary>
        public int XX
        {
            set { _xx = value; }
            get { return _xx; }
        }
        /// <summary>
        /// 信号
        /// </summary>
        public int XH
        {
            set { _xh = value; }
            get { return _xh; }
        }
        /// <summary>
        /// Fas
        /// </summary>
        public int Fas
        {
            set { _fas = value; }
            get { return _fas; }
        }
        /// <summary>
        /// Bas
        /// </summary>
        public int Bas
        {
            set { _bas = value; }
            get { return _bas; }
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
