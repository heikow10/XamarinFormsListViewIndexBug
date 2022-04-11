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
    }
}
