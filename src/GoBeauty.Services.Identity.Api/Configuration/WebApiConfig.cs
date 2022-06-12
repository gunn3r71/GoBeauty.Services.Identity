using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GoBeauty.Services.Identity.Api.Configuration
{
    public static class WebApiConfig
    {
        public static IServiceCollection AddWebApiConfiguration(this IServiceCollection services)
        {
            services.AddControllers();
            return services;
        }

        public static IApplicationBuilder UseWebApiConfiguration(this IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
