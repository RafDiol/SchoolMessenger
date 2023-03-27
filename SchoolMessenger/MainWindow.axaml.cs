using Avalonia.Controls;
using SchoolMessenger.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace SchoolMessenger
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<ChatConvoItem> chatConvos {get;set;}

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            chatConvos = new ObservableCollection<ChatConvoItem>();

            chatConvos.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler((a, b) => { updateConvoList(); } );

            ChatConvoItem item1 = new ChatConvoItem("Test 1", "", ConvoType.Dm);
            ChatConvoItem item2 = new ChatConvoItem("Test 2", "", ConvoType.Dm);
            ChatConvoItem item3 = new ChatConvoItem("Test 3", "", ConvoType.Dm);

            chatConvos.Add(item1);
            chatConvos.Add(item2);
            chatConvos.Add(item3);
        }

        private void updateConvoList()
        {
            convoList.Items = chatConvos;
        }

        private void chatConvoListSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            ChatConvoItem? chatConvoItem = convoList.SelectedItem as ChatConvoItem;
            
            if (chatConvoItem != null)
            {
                chatbox.SetupComponentUI(chatConvoItem);
            }
        }
    }
}
