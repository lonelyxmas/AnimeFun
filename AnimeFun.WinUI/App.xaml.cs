using AnimeFun.WinUI.Models;
using AnimeFun.WinUI.ViewModels;
using AnimeFun.WinUI.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Reflection;
using WinUIEx;

namespace AnimeFun.WinUI
{
    public partial class App : Application
    {
        public static MainWindow MainWindow { get; } = new MainWindow();

        public IHost Host { get; }

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
                    services.AddTransient<ShellPage>();
                    services.AddTransient<ShellViewModel>();
                }).
                Build();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            MainWindow.ContentFrame.Content = GetService<InitialScreen>();
            MainWindow.CenterOnScreen();
            MainWindow.Activate();
        }

        public static T GetService<T>() where T : class
        {
            if ((Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
            {
                throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
            }

            return service;
        }

        public static T GetViewModel<TPage, T>(TPage page) where TPage : Page where T : BaseViewModel<TPage>
        {
            T viewModel = GetService<T>();
            FieldInfo[] fieldInfos = typeof(BaseViewModel<TPage>).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (FieldInfo item in fieldInfos)
            {
                if (item.Name == $"<{nameof(BaseViewModel<TPage>.Page)}>k__BackingField")
                {
                    item.SetValue(viewModel, page);
                    break;
                }
            }

            return viewModel;
        }
    }
}
