// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnityConfig.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The unity config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Data.Entity;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using $safeprojectname$.Controllers;
using $safeprojectname$.DAL;
using $safeprojectname$.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.Practices.Unity;

namespace $safeprojectname$
{
    /// <summary>TODO The unity config.</summary>
    public static class UnityConfig
    {
        public static UnityContainer GetConfiguredContainer()
        {
            var container = new UnityContainer();
            // Types registration
            container.RegisterInstance(Properties.Settings.Default);
            container.RegisterType<IApplicationUserManager, ApplicationUserManager>();
            container.RegisterType<IApplicationSignInManager, ApplicationSignInManager>();
            container.RegisterType<ISettingsProvider, SettingsProvider>();
            container.RegisterType<DbContext, ApplicationDbContext>(new PerRequestLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            container.RegisterType<IAuthenticationManager>(
                new InjectionFactory(c => HttpContext.Current.GetOwinContext().Authentication));

            container.RegisterType<IUserStore<ApplicationUser>, UserStore<ApplicationUser>>(
                new InjectionConstructor(typeof(ApplicationDbContext)));
            return container;
        }
    }
}