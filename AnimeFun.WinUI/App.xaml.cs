using AnimeFun.WinUI.Views;
using Microsoft.UI.Xaml;
using Windows.UI;
using WinUIEx;

namespace AnimeFun.WinUI
{
    public partial class App : Application
    {
        private Window m_window;

        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            m_window = new MainWindow
            {
                Title = string.Empty,
                Content = new InitialScreen()
            };
            m_window.SetTitleBarBackgroundColors(Color.FromArgb(255, 238, 69, 105));
            m_window.Activate();
        }
    }
}
