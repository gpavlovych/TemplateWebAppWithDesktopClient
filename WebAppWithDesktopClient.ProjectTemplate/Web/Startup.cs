// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The startup.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof($safeprojectname$.Startup))]
namespace $safeprojectname$
{
    /// <summary>TODO The startup.</summary>
    public partial class Startup
    {
        /// <summary>TODO The configuration.</summary>
        /// <param name="app">TODO The app.</param>
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
        }
    }
}
