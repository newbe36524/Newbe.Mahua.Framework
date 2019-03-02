using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.WebSockets;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newbe.Mahua.IpcShared.WebsocketApi;

namespace Newbe.Mahua.InputReceivers.WebsocketApi.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddWebSockets(
                options => { options.AllowedOrigins.Add("*"); });
            services.AddSingleton(typeof(IMahuaCenter),
                b => PluginInstanceManager.GetInstance());
            services.AddSingleton<IMahuaWebsocketClientManager, MahuaWebsocketClientManager>();
            services.AddTransient<MahuaMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseWebSockets();
            app.UseMiddleware<MahuaMiddleware>();
        }
    }
}