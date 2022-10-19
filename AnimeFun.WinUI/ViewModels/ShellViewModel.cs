using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace AnimeFun.WinUI.ViewModels
{
    public partial class ShellViewModel : BaseViewModel<ShellPage>
    {
        #region 属性
        [ObservableProperty]
        private ObservableCollection<PageModel> pages = new();

        [ObservableProperty]
        private PageModel selectPage;
        #endregion

        public ShellViewModel()
        {
            Pages.Add(new PageModel
            {
                Title = "首页",
                Icon = "\ue7c3",
                View = typeof(MainPage),
                ViewModel = typeof(MainViewModel)
            });
        }

        [RelayCommand]
        private void Loaded()
        {
            SelectPage = Pages.FirstOrDefault();
            FrameNavigate(SelectPage.View);
        }

        [RelayCommand]
        private void ItemInvoked(NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                FrameNavigate(typeof(SettingsPage));
            }
            else
            {
                SelectPage = args.InvokedItemContainer.DataContext as PageModel;
                FrameNavigate(SelectPage.View);
            }
        }

        /// <summary>
        /// 导航到页面
        /// </summary>
        /// <param name="viewType"></param>
        private void FrameNavigate(Type viewType)
        {
            if (Page.NavigationFrame.Content == null || Page.NavigationFrame.Content.GetType() != viewType)
            {
                Page.NavigationFrame.Navigate(viewType, null);
            }
        }
    }
}
