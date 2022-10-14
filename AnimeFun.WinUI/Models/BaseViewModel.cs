using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace AnimeFun.WinUI.Models
{
    public partial class BaseViewModel<TPage> : ObservableRecipient where TPage : Page
    {
        public TPage Page { get; }

        public BaseViewModel(TPage page)
        {
            Page = page;
            Page.DataContext = this;
        }
    }
}
