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

        public void SetupComponentUI(ChatConvoItem chatConvoItem)
        {
            convoName.Text = chatConvoItem.Name;
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
