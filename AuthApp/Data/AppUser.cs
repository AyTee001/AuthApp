using Microsoft.AspNetCore.Identity;

namespace AuthApp.Data
{
    //User entity that uses and extends IdentityUser provided by ASP.NET Identity
    public class AppUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
