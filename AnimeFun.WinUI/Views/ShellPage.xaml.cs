using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class ShellPage : Page
    {
        public ShellPage()
        {
            DataContext = App.GetViewModel<ShellPage, ShellViewModel>(this);
            InitializeComponent();

            App.MainWindow.ExtendsContentIntoTitleBar = true;
            App.MainWindow.SetTitleBar(AppTitleBar);
        }
    }
}
