using AnimeFun.WinUI.Helpers;
using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using System.Collections.ObjectModel;

namespace AnimeFun.WinUI.ViewModels
{
    public partial class ShellViewModel : BaseViewModel<ShellPage>
    {
        [ObservableProperty]
        private ObservableCollection<PageModel> pages = new();

        [ObservableProperty]
        private object selected;

        [ObservableProperty]
        private bool isBackEnabled;

        public ShellViewModel()
        {
            Pages.Add(new PageModel
            {
                Title = "HomePage".GetLocalized(),
                Icon = "\ue7c3",
                View = typeof(MainPage),
                ViewModel = typeof(MainViewModel)
            });
        }

        /// <summary>
        /// 页面加载
        /// </summary>
        [RelayCommand]
        private void Loaded()
        {
            Selected = Pages.FirstOrDefault();
            FrameNavigate((Selected as PageModel).View, Selected);
        }

        /// <summary>
        /// 选择导航Item
        /// </summary>
        /// <param name="args"></param>
        [RelayCommand]
        private void NavigationItemInvoked(NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                FrameNavigate(typeof(SettingsPage), args.InvokedItemContainer);
            }
            else
            {
                FrameNavigate((args.InvokedItemContainer.DataContext as PageModel).View, args.InvokedItemContainer.DataContext);
            }
        }

        /// <summary>
        /// 后退页面
        /// </summary>
        [RelayCommand]
        private void NavigationBackRequested()
        {
            Page.NavigationFrame.GoBack();
        }

        /// <summary>
        /// 已导航到指定页面
        /// </summary>
        /// <param name="args"></param>
        [RelayCommand]
        private void FrameNavigated(NavigationEventArgs args)
        {
            if (args.NavigationMode == NavigationMode.Back)
            {
                Selected = args.Parameter;
            }
            IsBackEnabled = Page.NavigationFrame.CanGoBack;
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="viewType"></param>
        private void FrameNavigate(Type viewType, object parameter)
        {
            if (Page.NavigationFrame.Content == null || Page.NavigationFrame.Content.GetType() != viewType)
            {
                Page.NavigationFrame.Navigate(viewType, parameter);
            }
        }
    }
}
