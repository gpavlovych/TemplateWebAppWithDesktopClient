using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using $safeprojectname$.Controllers;
using $safeprojectname$.DAL;
using $safeprojectname$.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;
using $safeprojectname$.Services;

namespace $safeprojectname$
{
    [ExcludeFromCodeCoverage]
    public static class UnityConfig
    {
        private static IUnityContainer container;

        public static IUnityContainer GetConfiguredContainer()
        {
            if (container == null)
            {
                container = new UnityContainer();

                // Types registration
                container.RegisterInstance(Properties.Settings.Default);
                container.RegisterType<IApplicationUserManager, ApplicationUserManager>();
                container.RegisterType<IApplicationSignInManager, ApplicationSignInManager>();
                container.RegisterType<ISettingsProvider, SettingsProvider>();
                container.RegisterType<DbContext, ApplicationDbContext>(new PerRequestLifetimeManager());
                container.RegisterType<IUnitOfWork, UnitOfWork>();
                container.RegisterType<IUserService, UserService>();
                container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
                container.RegisterType<IAuthenticationManager>(
                    new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

                container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(
                    new InjectionConstructor(typeof(ApplicationDbContext)));
                // TODO: Uncomment if you want to use PerRequestLifetimeManager
                // Microsoft.Web.Infrastructure.DynamicModuleHelper.DynamicModuleUtility.RegisterModule(typeof(UnityPerRequestHttpModule));
            }
            return container;
        }
    }
}