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

            Items = new ObservableCollection<string>()
            {
                "0",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
            };

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

        private void ScrollToButton_Clicked(object sender, EventArgs e)
        {
            MyListView.ScrollTo("3", ScrollToPosition.Start, false);
        }
    }
}
