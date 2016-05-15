﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SomeApiController.cs" company="">
//   
// </copyright>
// <summary>
//   Some api controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using System.Web.Http;
using System.Web.Http.OData;
using $safeprojectname$.Filters;
using $safeprojectname$.Models;
using Microsoft.AspNet.Identity;

namespace $safeprojectname$.Controllers
{
    /// <summary>WebApi controller.</summary>
    [System.Web.Http.Authorize]
    [IdentityBasicAuthentication]
    public class SomeApiController : ApiController
    {
        /// <summary>
        /// An instance of the user repository
        /// </summary>
        private readonly IGenericRepository<ApplicationUser> _userRepository;

    /// <summary>
    /// Initializes a new instance of the <see cref="SomeApiController" /> class.
    /// </summary>
    /// <param name="userRepository">The user repository.</param>
    public SomeApiController(IGenericRepository<ApplicationUser> userRepository)
        {
            this._userRepository = userRepository;
        }

        [System.Web.Http.HttpGet]
        public HttpResponseMessage Get()
        {
            var currentUserId = this.User.Identity.GetUserId();
            var currentUser = this._userRepository.FindById(currentUserId);
            if (currentUser == null)
            {
                return new HttpResponseMessage(HttpStatusCode.Forbidden);
            }

            var result = new HttpResponseMessage(HttpStatusCode.OK)
                             {
                                 Content = new StringContent("Some String!!!!!!!!", Encoding.UTF8, "text/plain")
                             };
            return result;
        }
    }
}
