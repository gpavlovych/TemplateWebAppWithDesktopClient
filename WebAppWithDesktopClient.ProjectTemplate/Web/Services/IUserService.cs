using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;

namespace $safeprojectname$.Services
{
    public interface IUserService
    {
        Task<ExternalLoginInfo> GetExternalLoginInfoAsync();

        IEnumerable<AuthenticationDescription> GetExternalAuthenticationTypes();

        Task<ExternalLoginInfo> GetExternalLoginInfoAsync(string xSrfKey, string userId);

        Task<bool> TwoFactorBrowserRememberedAsync(string userId);
    }
}
