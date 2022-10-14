using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AnimeFun.WinUI.ViewModels
{
    public partial class InitialScreenViewModel : BaseViewModel<InitialScreen>
    {
        /// <summary>
        /// 是否完成
        /// </summary>
        [ObservableProperty]
        private bool completed = false;

        /// <summary>
        /// 是否加载
        /// </summary>
        [ObservableProperty]
        private bool loading = false;

        public InitialScreenViewModel(InitialScreen page) : base(page)
        {

        }

        [RelayCommand]
        private async void Loaded()
        {
            if (!completed)
            {
                await Task.Delay(1500);

                Completed = true;
                Page.CompleteStory.Begin();
                Page.CompleteStory.Completed += (a, b) => Loading = true;
            }
        }
    }
}
