
using LearnCSharp.Services;

namespace LearnCSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
           
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton<IMyFakeDataService, MyFakeDataService>();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();
            // app.MapDefaultControllerRoute();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Instructor}/{action=Index}/{id?}"
                );
            app.Run();
        }
    }
}
