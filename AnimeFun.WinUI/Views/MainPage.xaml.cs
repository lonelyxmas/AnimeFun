using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            NavigationCacheMode = NavigationCacheMode.Required;
            DataContext = App.GetViewModel<MainPage, MainViewModel>(this);

            InitializeComponent();
        }
    }
}
