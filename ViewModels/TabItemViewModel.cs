using CommunityToolkit.Mvvm.ComponentModel;

namespace TabControl.ViewModels
{
    [ObservableObject]
    public partial class TabItemViewModel
    {
        [ObservableProperty]
        private string _title = string.Empty;

        [ObservableProperty]
        private string _id = string.Empty;
      
        [ObservableProperty]
        private string _firstName = string.Empty;

        [ObservableProperty]
        private string _lastName = string.Empty;

        [ObservableProperty]
        private string _dob = string.Empty;

              
        public TabItemViewModel(dynamic tab)
        {            
            if (tab != null)
            {
                Id = tab.Id.ToString();
                FirstName = tab.FirstName;
                LastName = tab.LastName;
                Dob= tab.Dob;                

            }
        }

    }

}
