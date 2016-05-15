// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   
// </copyright>
// <summary>
//   TODO The route config.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$
{
    /// <summary>TODO The route config.</summary>
    public class RouteConfig
    {
        /// <summary>TODO The register routes.</summary>
        /// <param name="routes">TODO The routes.</param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default", 
                url: "{controller}/{action}", 
                defaults: new { controller = "Some", action = "Index" }
            );
        }
    }
}
