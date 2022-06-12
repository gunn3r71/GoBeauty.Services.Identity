using GoBeauty.Services.Identity.Api.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoBeauty.Services.Identity.Api
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services) => services.AddWebApiConfiguration();

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) => app.UseWebApiConfiguration(env);
    }
}
