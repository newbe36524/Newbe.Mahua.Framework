using Autofac;
using Newbe.Mahua.Samples.OkexRobot.Daos.Impl;
using Newbe.Mahua.Samples.OkexRobot.MahuaEvents;
using Newbe.Mahua.Samples.OkexRobot.OkexApi;
using Newbe.Mahua.Samples.OkexRobot.Services;
using Newbe.Mahua.Samples.OkexRobot.Services.Impl;

namespace Newbe.Mahua.Samples.OkexRobot
{
    /// <summary>
    /// Ioc容器注册
    /// </summary>
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            // 可以按照功能模块进行划分，此处可以改造为基于文件配置进行构造。实现模块化编程。
            return new Module[]
            {
                new PluginModule(),
                new MahuaEventsModule(),
                new OkModule(),
            };
        }

        /// <summary>
        /// 基本模块
        /// </summary>
        private class PluginModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                // 将实现类与接口的关系注入到Autofac的Ioc容器中。如果此处缺少注册将无法启动插件。
                // 注意！！！PluginInfo是插件运行必须注册的，其他内容则不是必要的！！！
                builder.RegisterType<PluginInfo>()
                    .As<IPluginInfo>();

                //注册在“设置中心”中注册菜单，若想订阅菜单点击事件，可以查看教程。http://www.newbe.cf/docs/mahua/2017/12/24/Newbe-Mahua-Navigations.html
                builder.RegisterType<MyMenuProvider>()
                    .As<IMahuaMenuProvider>();

                // 确保Web服务是单例
                builder.RegisterType<OwinWebHost>()
                    .As<IWebHost>()
                    .SingleInstance();
            }
        }

        /// <summary>
        /// <see cref="IMahuaEvent"/> 事件处理模块
        /// </summary>
        private class MahuaEventsModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<InitializationMahuaEvent>().AsImplementedInterfaces();
                builder.RegisterType<GetMenuEvent>().AsImplementedInterfaces();
                builder.RegisterType<GetAssetEvent>().AsImplementedInterfaces();
                builder.RegisterType<GetOrdersEvent>().AsImplementedInterfaces();
            }
        }

        private class OkModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<OkexOkexApiFactory>().AsImplementedInterfaces().SingleInstance();
                builder.RegisterType<UserAssetService>().AsImplementedInterfaces();
                builder.RegisterType<TickerProvider>().AsImplementedInterfaces();

                builder.RegisterType<UserAssetDao>().AsImplementedInterfaces();
                builder.RegisterType<UserAssetTracer>().AsImplementedInterfaces().AsSelf();
                builder.RegisterType<OrderTracer>().AsImplementedInterfaces().AsSelf();

            }
        }
    }
}
