namespace AspNetTasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            

            builder.Services.AddControllersWithViews(); // yeni mvc ile isleyecek model views controller mentiqi ile isleyecek demekdi.

            var app = builder.Build();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}