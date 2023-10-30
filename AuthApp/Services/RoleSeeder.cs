using AuthApp.Constants;
using AuthApp.Data;
using Microsoft.AspNetCore.Identity;

namespace AuthApp.Services
{
    public static class RoleSeeder
    {
        // Seeds roles into db and creates one admin account
        public static async Task AddRolesAndDefaultAdmin(IServiceProvider services)
        {
            var userManager = services.GetRequiredService<UserManager<AppUser>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            if (!await roleManager.RoleExistsAsync(Roles.Admin.ToString()))
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            }

            if (!await roleManager.RoleExistsAsync(Roles.User.ToString()))
            {
                await roleManager.CreateAsync(new IdentityRole(Roles.User.ToString()));
            }

            var user = new AppUser
            {
                UserName = "tiutiun@mail.com",
                Email = "tiutiun@mail.com",
                FirstName = "Anastasiia",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var userFromDb = await userManager.FindByEmailAsync(user.Email);
            if (userFromDb == null)
            {
                await userManager.CreateAsync(user, "1234#Abcd");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }
        }
    }
}
