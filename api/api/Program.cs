using api.Model;
using api.Service;
using api.Service.UserService;

namespace api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();
            var app = builder.Build();


            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseRouting(); 

            app.UseCors();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
