using Autofac;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.LiveGirl.MahuaEvents;
using Newbe.Mahua.Samples.LiveGirl.Services;
using Newbe.Mahua.Samples.LiveGirl.Services.Impl;

namespace Newbe.Mahua.Samples.LiveGirl
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
                new MyServiceModule(),
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
                // 将需要监听的事件注册，若缺少此注册，则不会调用相关的实现类
                builder.RegisterType<InitializationMahuaEvent>()
                    .As<IInitializationMahuaEvent>();
                builder.RegisterType<PrivateMessageFromFriendReceivedMahuaEvent>()
                    .As<IPrivateMessageFromFriendReceivedMahuaEvent>();
            }
        }

        private class MyServiceModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);
                builder.RegisterType<OwinWebHost>()
                    .As<IWebHost>()
                    .SingleInstance();
                builder.RegisterType<Livegirl>()
                    .As<ILivegirl>()
                    .AsSelf();
                builder.RegisterType<LiveRoom>()
                    .As<ILiveRoom>();
            }
        }
    }
}
