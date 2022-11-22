using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            NavigationCacheMode = Microsoft.UI.Xaml.Navigation.NavigationCacheMode.Required;
            DataContext = App.GetViewModel<SettingsPage, SettingsViewModel>(this);
            InitializeComponent();
        }
    }
}
