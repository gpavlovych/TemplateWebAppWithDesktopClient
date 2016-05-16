using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Windows;
using $safeprojectname$.Properties;
using $safeprojectname$.Services;
using $safeprojectname$.Views;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace $safeprojectname$
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class App
    {
        /// <summary>The logics to be performed during application startup</summary>
        /// <param name="e">An instance of <see cref="StartupEventArgs"/> to be used.</param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            IUnityContainer container = new UnityContainer();
            container.RegisterType<HttpClient>(new InjectionFactory(x => new HttpClient()));
            container.RegisterType<ILoginWindow>(new InjectionFactory(x => new LoginWindow()));
            container.RegisterInstance(Settings.Default);
            container.RegisterType<IHttpClient, HttpClientWrapper>(new PerResolveLifetimeManager());
            container.RegisterType<ISettingsService, SettingsService>();
            container.RegisterType<ISearchService, SearchService>();
            ViewModelLocationProvider.SetDefaultViewModelFactory(viewModelType => container.Resolve(viewModelType));
        }
    }
}