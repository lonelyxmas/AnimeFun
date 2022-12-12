using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            DataContext = App.GetViewModel<MainPage, MainViewModel>(this);

            InitializeComponent();
        }
    }
}
