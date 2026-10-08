namespace KursPortal.Models;

using Microsoft.EntityFrameworkCore;

public static class EnsureDatabse
{
    public static void Migrate(IApplicationBuilder app)
    {
        KursPortalDbContext ctx = app.ApplicationServices
            .CreateScope()
            .ServiceProvider
            .GetRequiredService<KursPortalDbContext>();

        if (ctx.Database.GetPendingMigrations().Any())
        {
            ctx.Database.Migrate();
        }
    }
}

