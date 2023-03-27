using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMessenger.Models
{
    public class MessageItem
    {
		public string senderName
		{
			get { return _senderName; }
			set { _senderName = value; }
		}
		public string UUID
		{
			get { return _uuid; }
			set { _uuid = value; }
		}

		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

        private string _text;
        private string _senderName;
        private string _uuid;
    }
}
