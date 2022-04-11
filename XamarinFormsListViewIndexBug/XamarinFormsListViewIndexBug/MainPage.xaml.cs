using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinFormsListViewIndexBug
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Items = new ObservableCollection<string>() { "first item", "second item", };

            BindingContext = this;
        }

        public ObservableCollection<string> Items { get; }

        private async void ListView_ItemSelectedAsync(object sender, SelectedItemChangedEventArgs e)
        {
            await DisplayAlert("ListView_ItemSelected", "e.SelectedItem = " + e.SelectedItem + ", e.SelectedItemIndex = " + e.SelectedItemIndex, "OK");
        }

        private async void ListView_ItemTappedAsync(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("ListView_ItemTapped", "e.Item = " + e.Item + ", e.ItemIndex = " + e.ItemIndex, "OK");
        }

        private async void MenuItem_ClickedAsync(object sender, EventArgs e)
        {
            if (sender is MenuItem menuItem && menuItem.BindingContext is string item)
            {
                await DisplayAlert("MenuItem_Clicked", "item = " + item, "OK");
            }
        }
    }
}
