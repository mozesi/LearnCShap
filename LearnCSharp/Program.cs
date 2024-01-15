
namespace LearnCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                name: "home",
                pattern:"{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "showStudent",
                pattern: "student/{id?}",
                defaults : new { controller = "Student", action = "showDetails" });
            app.Run();
        }
    }
}
