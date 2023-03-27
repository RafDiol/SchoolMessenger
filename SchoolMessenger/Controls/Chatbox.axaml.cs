using Avalonia.Controls;
using Avalonia.Interactivity;
using SchoolMessenger.Core;
using SchoolMessenger.Models;

namespace SchoolMessenger.Controls
{
    public partial class Chatbox : UserControl
    {
        string? userUUID;

        public Chatbox()
        {
            InitializeComponent();
        }

        public void SetupComponentUI(ChatConvoItem chatConvoItem, string _userUUID)
        {
            convoName.Text = chatConvoItem.Name;
            userUUID = _userUUID;
        }

        private void sendBtnClicked(object sender, RoutedEventArgs e)
        {
            string text = messageTxtBox.Text;
            MessageItem messageItem = new MessageItem()
            {
                senderName = "",
                senderUUID = userUUID,
                messageUUID = IDGenerator.generateID(),
                Text = text
            };
        }

        private void sendMessage(MessageItem messageItem)
        {

        }
    }
}
