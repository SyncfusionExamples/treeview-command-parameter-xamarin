using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace TreeViewXamarin
{
    public class FileManager : INotifyPropertyChanged
    {
        private bool isVisible = true;
        private string fileName;
        private ImageSource imageIcon;
        private ObservableCollection<FileManager> subFiles;

        public FileManager()
        {

        }
        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }

        public string ItemName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("ItemName");
            }
        }
        public bool ISVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;
                RaisedOnPropertyChanged("ISVisible");
            }
        }
        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }
    }
}
