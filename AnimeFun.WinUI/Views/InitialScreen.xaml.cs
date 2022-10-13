using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;

namespace AnimeFun.WinUI.Views
{
    public sealed partial class InitialScreen : Page
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        private async void PageMain_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1500);
            imgLogoGif.Visibility = Visibility.Collapsed;
            Storyboard storyboard = new();
            DoubleAnimation doubleAnimation = new()
            {
                To = -60,
                Duration = new TimeSpan(0, 0, 0, 0, 500)
            };
            Storyboard.SetTargetProperty(doubleAnimation, "Y");
            Storyboard.SetTarget(doubleAnimation, trnMain);
            storyboard.Children.Add(doubleAnimation);
            storyboard.Begin();
            storyboard.Completed += delegate
            {
                proRing.Visibility = Visibility.Visible;
            };
        }
    }
}
