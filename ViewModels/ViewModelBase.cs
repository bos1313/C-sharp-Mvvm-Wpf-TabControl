using System.ComponentModel;

namespace TabControl.ViewModels
{
    public class ViewModelBase
    {
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

       
    }
}
