namespace KursPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //MVC Activation
            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            //app.MapGet("/", () => "Hasan is gay and eats Möhren!!");

            app.MapControllerRoute(
                name: "default", 
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.UseStaticFiles();


            app.UseStaticFiles();   // <-- add this
            app.UseRouting();
            app.Run();
        }
    }
}
