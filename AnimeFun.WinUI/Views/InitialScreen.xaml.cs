using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class InitialScreen : Page
    {
        public InitialScreen()
        {
            DataContext = App.GetViewModel<InitialScreen, InitialScreenViewModel>(this);

            InitializeComponent();

            App.MainWindow.ExtendsContentIntoTitleBar = true;
            App.MainWindow.SetTitleBar(this);
        }
    }
}
