
namespace InputDemo.ViewModels
{
    public class ItemViewModel : BaseViewModel
    {
        #region private member
        private int _count;
        private string _name;
        #endregion

        #region properties
        public int Count
        {
            get { return _count; }
            set
            {
                if (_count != value)
                {
                    _count = value;
                    this.OnPropertyChanged();
                }
            }
        }
        
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    this.OnPropertyChanged();
                }
            }
        }
        #endregion

    }
}
