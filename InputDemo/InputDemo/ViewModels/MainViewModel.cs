using System.Collections.ObjectModel;

namespace InputDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region private member
        private int _big;
        #endregion

        #region properties
        public int Big
        {
            get { return _big; }
            set
            {
                if (_big != value)
                {
                    _big = value;
                    this.OnPropertyChanged();
                }
            }
        }
       
        public ObservableCollection<ItemViewModel> Items { get; } = new ObservableCollection<ItemViewModel>();
        #endregion

        #region ctor
        public MainViewModel()
        {
            Items.Add(new ItemViewModel() { Name = "Eins", });
            Items.Add(new ItemViewModel() { Name = "Doppel", });
            Items.Add(new ItemViewModel() { Name = "3", });
        }
        #endregion
    }
}
