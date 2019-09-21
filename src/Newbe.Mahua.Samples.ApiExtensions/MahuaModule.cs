using Autofac;
using Newbe.Mahua.Apis;
using Newbe.Mahua.CQP.ApiExtensions;
using Newbe.Mahua.MahuaEvents;
using Newbe.Mahua.Samples.ApiExtensions.MahuaApis;
using Newbe.Mahua.Samples.ApiExtensions.MahuaEvents;

namespace Newbe.Mahua.Samples.ApiExtensions
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
                new MyApiModule(),

                // 引入CQP的API扩展包的模块注册
                new CqpApiExtensionsModule(),
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
                builder.RegisterType<PrivateMessageFromFriendReceivedMahuaEvent>()
                    .As<IPrivateMessageFromFriendReceivedMahuaEvent>();
            }
        }

        private class MyApiModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                base.Load(builder);

                // 当前平台是CQP时才注册这些扩展API
                if (MahuaGlobal.CurrentPlatform == MahuaPlatform.Cqp)
                {
                    // 作者名称，既然是你实现了这个功能，那就填上你的名字吧
                    var authorName = "Newbe36524";

                    // 此方法没有CQP提供，此处将注册自己的实现
                    builder.RegisterMahuaApi<GetFriendsApiMahuaCommandHandler, GetFriendsApiMahuaCommand, GetFriendsApiMahuaCommandResult>(authorName);

                    // CQP原生也提供了此API的实现，这里注册时候将会覆盖原来的实现
                    builder
                        .RegisterMahuaApi<SendPrivateMessageApiMahuaCommandHandler, SendPrivateMessageApiMahuaCommand, SendPrivateMessageApiMahuaCommandResult>(authorName);
                }

            }
        }
    }
}
