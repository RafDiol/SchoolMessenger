using SchoolMessenger.Core;
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

		public string senderUUID
		{
			get { return _senderUUID; }
			set { _senderUUID = value; }
		}


		public string messageUUID
		{
			get { return _messageUUID; }
			set { _messageUUID = value; }
		}

		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

        private string _senderUUID;
        private string _text;
        private string _senderName;
        private string _messageUUID;
    }
}
