using AnimeFun.WinUI.ViewModels;
using AnimeFun.WinUI.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Windows.UI;
using WinUIEx;

namespace AnimeFun.WinUI
{
    public partial class App : Application
    {
        public IHost Host
        {
            get;
        }

        public static T GetService<T>() where T : class
        {
            if ((Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
            {
                throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
            }

            return service;
        }

        public static Window MainWindow { get; } = new MainWindow();

        public App()
        {
            InitializeComponent();

            Host = Microsoft.Extensions.Hosting.Host.
                CreateDefaultBuilder().
                UseContentRoot(AppContext.BaseDirectory).
                ConfigureServices((context, services) =>
                {
                    services.AddTransient<InitialScreen>();
                    services.AddTransient<InitialScreenViewModel>();
                }).
                Build();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            MainWindow.Content = GetService<InitialScreenViewModel>().Page;
            MainWindow.SetTitleBarBackgroundColors(Color.FromArgb(255, 238, 69, 105));
            MainWindow.Activate();
        }
    }
}
