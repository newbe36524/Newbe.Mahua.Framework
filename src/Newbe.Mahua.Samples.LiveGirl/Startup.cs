using Autofac;
using Hangfire;
using Hangfire.MemoryStorage;
using Microsoft.Owin;
using Owin;

// 这是Startup的入口标记
[assembly: OwinStartup(typeof(Newbe.Mahua.Samples.LiveGirl.Startup))]

namespace Newbe.Mahua.Samples.LiveGirl
{
    public class Startup
    {
        public void Configuration(IAppBuilder app, ILifetimeScope lifetimeScope)
        {
            // 初始化Hangfire
            var config = GlobalConfiguration.Configuration;

            // 使用内存存储任务，若有持久化任务的需求，可以根据Hangfire的文档使用数据库方式存储
            config.UseMemoryStorage();

            // 通过Autofac容器来实现任务的构建
            config.UseAutofacActivator(lifetimeScope);

            // 启用Hangfire的web界面
            app.UseHangfireDashboard();

            // 初始化Hangfire服务
            app.UseHangfireServer();
        }
    }
}
