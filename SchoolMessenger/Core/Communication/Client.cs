using SchoolMessenger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMessenger.Core.Communication
{
    public class Client
    {
        private string uuid;

        public Client(string clientUUID)
        {
            uuid = clientUUID;
        }

        public void sendMessage(MessageItem message, string receiverUUID)
        {

        }
    }
}
