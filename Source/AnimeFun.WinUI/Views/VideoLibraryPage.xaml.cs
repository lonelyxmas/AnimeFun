using AnimeFun.WinUI.ViewModels;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class VideoLibraryPage : Page
    {
        public VideoLibraryPage()
        {
            DataContext = App.GetViewModel<VideoLibraryPage, VideoLibraryViewModel>(this);

            InitializeComponent();
        }
    }
}
