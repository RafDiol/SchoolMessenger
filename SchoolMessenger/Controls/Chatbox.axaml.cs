using Avalonia.Controls;
using SchoolMessenger.Models;

namespace SchoolMessenger.Controls
{
    public partial class Chatbox : UserControl
    {
        public Chatbox()
        {
            InitializeComponent();
        }

        public void SetupComponentUI(ChatConvoItem chatConvoItem)
        {
            convoName.Text = chatConvoItem.Name;
        }

        public void sendMessage(MessageItem messageItem)
        {

        }
    }
}
