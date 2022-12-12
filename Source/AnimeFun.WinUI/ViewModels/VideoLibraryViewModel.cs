using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace AnimeFun.WinUI.ViewModels;

public partial class VideoLibraryViewModel : BaseViewModel<VideoLibraryPage>
{
    [ObservableProperty]
    private ObservableCollection<string> hotDatas = new();

    public VideoLibraryViewModel()
    {
        for (int i = 0; i < 6; i++)
        {
            HotDatas.Add(i.ToString());
        }
    }
}