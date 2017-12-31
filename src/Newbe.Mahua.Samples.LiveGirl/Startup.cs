using Autofac;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Newbe.Mahua.Samples.LiveGirl.Startup))]

namespace Newbe.Mahua.Samples.LiveGirl
{
    public class Startup
    {
        public void Configuration(IAppBuilder app, ILifetimeScope lifetimeScope)
        {
            var config = GlobalConfiguration.Configuration;
            config.UseMemoryStorage();
            config.UseAutofacActivator(lifetimeScope);
            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}
