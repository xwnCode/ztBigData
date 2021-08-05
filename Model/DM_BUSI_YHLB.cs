using System;
using System.Collections.Generic;
using System.Text;

namespace Vline.Model
{
    ///<summary>
    /// 隐患排查列表 :实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DM_BUSI_YHLB
	{
        public DM_BUSI_YHLB()
		{}
		#region Model
		private int _id;
		private DateTime _updatetime;
        private string _ssgs;
        private string _xmb;
        private string _yhbm;
        private string _zy;

        private string _pclb;
        private string _pcxm;
        private string _pcnrq;
        private string _pcnrh;
        private string _wtms;

        private string _pcr;
        private string _yhjb;
        private string _zg;
        private string _bz;
        private string _qtp;
        private string _htp;
		private string _by1;
		private string _by2;
		private string _by3;
        private byte[] _pcq;
        private byte[] _pch;
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
        /// 所属公司
		/// </summary>
        public string SSGS
		{
            set { _ssgs = value; }
            get { return _ssgs; }
		}
		/// <summary>
        /// 项目部
		/// </summary>
        public string XMB
		{
            set { _xmb = value; }
            get { return _xmb; }
		}
		/// <summary>
        /// 隐患编码
		/// </summary>
        public string YHBM
		{
            set { _yhbm = value; }
            get { return _yhbm; }
		}
		/// <summary>
        /// 专业
		/// </summary>
        public string ZY
		{
            set { _zy = value; }
            get { return _zy; }
		}
        /// <summary>
        /// 排查类别
        /// </summary>
        public string PCLB
        {
            set { _pclb = value; }
            get { return _pclb; }
        }
        /// <summary>
        /// 排查项目
        /// </summary>
        public string PCXM
        {
            set { _pcxm = value; }
            get { return _pcxm; }
        }
        /// <summary>
        /// 排查内容前
		/// </summary>
        public string PCNRQ
		{
            set { _pcnrq = value; }
            get { return _pcnrq; }
		}
        /// <summary>
        /// 排查内容后
        /// </summary>
        public string PCNRH
        {
            set { _pcnrh = value; }
            get { return _pcnrh; }
        }
        /// <summary>
        /// 问题描述
        /// </summary>
        public string WTMS
        {
            set { _wtms = value; }
            get { return _wtms; }
        }
        /// <summary>
        /// 排查人
        /// </summary>
        public string PCR
        {
            set { _pcr = value; }
            get { return _pcr; }
        }
        /// <summary>
        /// 隐患级别
        /// </summary>
        public string YHJB
        {
            set { _yhjb = value; }
            get { return _yhjb; }
        }
        /// <summary>
        /// 是否整改
        /// </summary>
        public string ZG
        {
            set { _zg = value; }
            get { return _zg; }
        }
        /// <summary>
        /// 备注
        /// </summary>
        public string BZ
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 前图片
        /// </summary>
        public string QTP
        {
            set { _qtp = value; }
            get { return _qtp; }
        }
        /// <summary>
        /// 后图片
        /// </summary>
        public string HTP
        {
            set { _htp = value; }
            get { return _htp; }
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

        /// <summary>
        /// 
        /// </summary>
        public byte[] PCQ
        {
            set { _pcq = value; }
            get { return _pcq; }
        }

        /// <summary>
        /// 
        /// </summary>
        public byte[] PCH
        {
            set { _pch = value; }
            get { return _pch; }
        }
		#endregion Model

	}
}
