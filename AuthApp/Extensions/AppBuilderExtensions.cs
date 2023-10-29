using AuthApp.Data;
using Microsoft.EntityFrameworkCore;

namespace AuthApp.Extensions
{
    public static class AppBuilderExtensions
    {
        //Ensures auto-migrating on start
        public static void UseApplicationDbContext(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            context?.Database.Migrate();
        }
    }
}
