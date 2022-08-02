using MinimalAPI.Services;
using MinimalAPI.Services.Interfaces;
using MinimalAPI.Routes;

namespace MinimalAPI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServiceCollection(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            
            // Add services to the container.
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }

        public static WebApplication ConfigureWebApplication(this WebApplication app)
        {
            app.MapConfigurations();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            return app;
        }
    }
}