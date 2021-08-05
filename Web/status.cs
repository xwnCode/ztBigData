using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vline.Web
{

    public class status
    {
        public status()
        { }
        private bool _status;
        private string _message;
        private int _id;
        private string _name;
        private int _parentid;
        /// <summary>
        /// 状态
        /// </summary>
        public bool statu
        {
            set { _status = value; }
            get { return _status; }
        }
        /// <summary>
        /// 消息
        /// </summary>
        public string Message
        {
            set { _message = value; }
            get { return _message; }
        }
        /// <summary>
        /// 消息
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 消息
        /// </summary>
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// _parentId
        /// </summary>
        public int _parentId
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
    }
}
