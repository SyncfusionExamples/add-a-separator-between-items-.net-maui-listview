using Microsoft.Maui.Controls;
using System.ComponentModel;


namespace ListViewMaui
{
    #region BookInfo
    public class BookInfo : INotifyPropertyChanged
    {
        #region Fields
        private string bookName;
        private string bookDesc;
        #endregion

        #region Properties
        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }
        #endregion

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
    #endregion
}