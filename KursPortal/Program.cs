using KursPortal.Models;
using Microsoft.EntityFrameworkCore; 

namespace KursPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC Activation
            builder.Services.AddControllersWithViews();

            //DatenBank Context registration
            builder.Services.AddDbContext<KursPortalDbContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("KursDB")));
            
            var app = builder.Build();




            app.MapControllerRoute(
                name: "default", 
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseStaticFiles();

            EnsureDatabse.Migrate(app);

            app.UseStaticFiles();   // <-- add this
            app.UseRouting();
            app.Run();
        }
    }
}
