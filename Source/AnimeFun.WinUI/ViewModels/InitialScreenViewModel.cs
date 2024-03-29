﻿using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Media.Animation;

namespace AnimeFun.WinUI.ViewModels;

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

    [RelayCommand]
    private async void Loaded()
    {
        if (!Completed)
        {
            await Task.Delay(1500);

            Completed = true;
            Page.CompleteStory.Begin();
            Page.CompleteStory.Completed += (a, b) => Loading = true;

            await Task.Delay(5000);

            App.MainWindow.ContentFrame.Navigate(typeof(ShellPage), null, new DrillInNavigationTransitionInfo());
        }
    }
}
