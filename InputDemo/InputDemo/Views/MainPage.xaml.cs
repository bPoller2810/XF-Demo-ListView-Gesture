using InputDemo.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InputDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        #region Properties
        public MainViewModel ViewModel
        {
            get => this.BindingContext as MainViewModel;
            set => this.BindingContext = value;
        }
        #endregion

        #region ctor
        public MainPage()
        {
            InitializeComponent();
            this.ViewModel = new MainViewModel();
        }
        #endregion

        #region view events
        private void ItemTapped(object sender, EventArgs args)
        {
            this.ViewModel.Big++;
        }

        private void OnBoxTapped(object sender, EventArgs args)
        {
            if(((BindableObject)sender).BindingContext is ItemViewModel ivm)
            {
                ivm.Count++;
            }
        }
        #endregion
    }
}