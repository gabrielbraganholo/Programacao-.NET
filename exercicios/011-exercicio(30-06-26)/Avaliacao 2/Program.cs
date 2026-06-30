using Avaliacao_2.Services;

namespace Avaliacao_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            builder.Services.AddSingleton<EquipamentoService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapGet("/", context =>
            {
                context.Response.Redirect("/Equipamentos/Index");
                return Task.CompletedTask;
            });

            app.MapRazorPages()
                .WithStaticAssets();

            app.Run();
        }
    }
}