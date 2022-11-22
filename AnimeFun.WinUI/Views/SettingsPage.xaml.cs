using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            NavigationCacheMode = NavigationCacheMode.Required;
            DataContext = App.GetViewModel<SettingsPage, SettingsViewModel>(this);

            InitializeComponent();
        }
    }
}
