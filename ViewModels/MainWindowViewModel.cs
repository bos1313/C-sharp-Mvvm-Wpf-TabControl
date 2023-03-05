using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TabControl.Commands;
using TabControl.Services;
using TabStudents.Model;

namespace TabControl.ViewModels
{
    [ObservableObject]
    public partial class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<StudentsCollection> _people = new ObservableCollection<StudentsCollection>();
        public DelegateCommand<object> ItemSelectionChanged { get; private set; }

        public ObservableCollection<TabItemViewModel> Tabs { get; } = new();

        private ObservableCollection<TabItemViewModel> _items = new ObservableCollection<TabItemViewModel>();
        public IEnumerable<TabItemViewModel> Items { get { return _items; } }
              

        public ObservableCollection<Students> People { get; set; }

        public MainWindowViewModel()
        {
            ItemSelectionChanged = new DelegateCommand<object>((obj) => { OnItemSelectionChanged(obj); });

            StudentsCollection osobeCollection = new StudentsCollection();
            People = osobeCollection.People;

        }


        [RelayCommand]
        private void CloseTab(TabItemViewModel obj)
        {
            Tabs.Remove(obj);
                       
        }


        public string? Fullname { get; private set; }
       
        public string? id { get; private set; }

        private TabItemViewModel? currentPage;

        public TabItemViewModel CurrentPage
        {
            
            get { return currentPage; }
            set
            {
                currentPage = value;
                               
                if (!_items.Contains(value))
                {
                    _items.Add(value);
                }

                OnPropertyChanged(nameof(CurrentPage));
            }
        }
      
        public int SelectedTabIndex { get; set; }
        
        private void OnItemSelectionChanged(object obj)
        {
            if (obj != null)
            {
               
                if (currentPage == obj)
                {
                    return;
                }
                if (obj is Students _objos)
                {
                    id = _objos.Id.ToString();
                    Fullname = _objos.FullName;
                }

                TabItemViewModel newTab;
                newTab = new TabItemViewModel(obj);
               
                newTab.Title = $"{Fullname}";
                Tabs.Add(newTab);
               
                this.CurrentPage = newTab;
                                
            }       
            
        }       

    }
}
