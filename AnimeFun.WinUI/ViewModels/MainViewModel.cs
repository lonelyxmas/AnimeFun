using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Windows.Media.Core;

namespace AnimeFun.WinUI.ViewModels
{
    public partial class MainViewModel : BaseViewModel<MainPage>
    {
        [ObservableProperty]
        private MediaSource source;

        public MainViewModel()
        {
            Source = MediaSource.CreateFromUri(new Uri(@"E:\Video\复仇者联盟2：奥创纪元\Avengers.Age.of.Ultron.2015.Bluray.2160p.x265.10bit.HDR.4Audio.mUHD-FRDS.mkv"));
        }
    }
}
