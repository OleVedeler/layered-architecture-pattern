using System.ComponentModel;

namespace TheShop.Business.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void ShoutAbout(string propertyName)
        {
            if (string.IsNullOrEmpty(propertyName))
                return;

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
