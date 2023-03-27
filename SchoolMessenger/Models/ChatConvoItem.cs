using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolMessenger.Core;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SchoolMessenger.Models
{
    public class ChatConvoItem : INotifyPropertyChanged
    {

        public string Name

        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged(); }
        }

        public string UUID
        {
            get { return _uuid; }
        }

        public string receiverUUID
        {
            get { return _receiverUUID; }
            set { _receiverUUID = value; }
        }

        public ConvoType Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged(); }
        }

        private string _receiverUUID;
        private string _name;
        private string _imagePath;
        private string _uuid;
        private ConvoType _type;

        public event PropertyChangedEventHandler? PropertyChanged;

        public ChatConvoItem(string name, string imagePath, ConvoType type) 
        {
            _uuid = IDGenerator.generateID();
            _name = name;
            _imagePath = imagePath;
            _type = type;
        }

        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
        }
    }
   
    public enum ConvoType
    {
        Dm, Group
    }
}
