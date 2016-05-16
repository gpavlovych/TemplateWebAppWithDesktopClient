﻿using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace $safeprojectname$.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    [ExcludeFromCodeCoverage]
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }

    [ExcludeFromCodeCoverage]
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            // Change default table names for Identity Framework
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");

            // Create mappings for Identity Framework
            modelBuilder.Entity<IdentityUserLogin>().HasKey(
                m => new
                         {
                             m.UserId, 
                             m.ProviderKey
                         });
            modelBuilder.Entity<IdentityRole>().HasKey<string>(m => m.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(
                m => new
                         {
                             m.RoleId, 
                             m.UserId
                         });
            modelBuilder.Entity<ApplicationUser>().HasMany(m => m.Logins).WithRequired().HasForeignKey(m => m.UserId);
            modelBuilder.Entity<IdentityRole>().HasMany(m => m.Users).WithRequired().HasForeignKey(m => m.RoleId);

            modelBuilder.Entity<ApplicationUser>().HasKey(s => s.Id);
        }
    }
}