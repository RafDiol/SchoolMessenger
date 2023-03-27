using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMessenger.Models
{
    public class Account
    {
		public string imagePath
		{
			get { return _imagePath; }
			set { _imagePath = value; }
		}

		public string passwordHash
		{
			get { return _passwordHash; }
			set { _passwordHash = value; }
		}

		public string userUUID
		{
			get { return _userUUID; }
			set { _userUUID = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        private string _imagePath;
        private string _passwordHash;
        private string _userUUID;
        private string _name;
    }
}
