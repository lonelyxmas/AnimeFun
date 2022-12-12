using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class MusicLibraryPage : Page
    {
        public MusicLibraryPage()
        {
            DataContext = App.GetViewModel<MusicLibraryPage, MusicLibraryViewModel>(this);

            InitializeComponent();
        }
    }
}
