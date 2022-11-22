using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            NavigationCacheMode = Microsoft.UI.Xaml.Navigation.NavigationCacheMode.Required;
            DataContext = App.GetViewModel<MainPage, MainViewModel>(this);
            InitializeComponent();
        }
    }
}
