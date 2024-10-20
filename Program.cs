namespace CarwashPrime
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddSession(); // Habilitar sesión
            builder.Services.AddHttpContextAccessor(); // Registrar IHttpContextAccessor

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession(); // Usar sesión
            app.UseAuthorization();

            app.MapRazorPages();
            app.Run();
        }
    }
}
