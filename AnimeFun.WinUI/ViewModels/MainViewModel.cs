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

        }
    }
}
