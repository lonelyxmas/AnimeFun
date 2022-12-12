using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;

namespace AnimeFun.WinUI.ViewModels;

public partial class ShellViewModel : BaseViewModel<ShellPage>
{
    #region Property
    [ObservableProperty]
    private NavigationViewItem selected;

    [ObservableProperty]
    private bool isBackEnabled;
    #endregion

    #region Command
    /// <summary>
    /// Page Load
    /// </summary>
    [RelayCommand]
    private void Loaded()
    {
        Selected = Page.NavigationViewControl.MenuItems.FirstOrDefault() as NavigationViewItem;
        StartNavigate(GetPageType(Selected.Tag), Selected);
    }

    /// <summary>
    /// Navigate to Page
    /// </summary>
    /// <param name="args"></param>
    [RelayCommand]
    private void NavigationItemInvoked(NavigationViewItemInvokedEventArgs args)
    {
        Type type = GetPageType(args.InvokedItemContainer.Tag);
        if (args.IsSettingsInvoked)
        {
            type = typeof(SettingsPage);
        }
        StartNavigate(type, args.InvokedItemContainer);
    }

    /// <summary>
    /// Back Page
    /// </summary>
    [RelayCommand]
    private void NavigationBackRequested()
    {
        Page.NavigationFrame.GoBack();
    }

    /// <summary>
    /// Navigated
    /// </summary>
    /// <param name="args"></param>
    [RelayCommand]
    private void FrameNavigated(NavigationEventArgs args)
    {
        if (args.NavigationMode == NavigationMode.Back)
        {
            Selected = args.Parameter as NavigationViewItem;
        }
        IsBackEnabled = Page.NavigationFrame.CanGoBack;
    }
    #endregion

    #region Method
    /// <summary>
    /// Convert Tag property to Type
    /// </summary>
    /// <param name="tag"></param>
    /// <returns></returns>
    private static Type GetPageType(object tag)
    {
        Type type = typeof(Page);
        if (tag != null && Type.GetType(tag.ToString()) is Type pageType)
        {
            type = pageType;
        }

        return type;
    }

    /// <summary>
    /// Start Navigation
    /// </summary>
    /// <param name="viewType"></param>
    /// <param name="parameter"></param>
    private void StartNavigate(Type viewType, object parameter)
    {
        if (Page.NavigationFrame.Content == null || Page.NavigationFrame.Content.GetType() != viewType)
        {
            Page.NavigationFrame.Navigate(viewType, parameter);
        }
    }
    #endregion
}
