using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            DataContext = App.GetViewModel<SettingsPage, SettingsViewModel>(this);

            InitializeComponent();
        }
    }
}
