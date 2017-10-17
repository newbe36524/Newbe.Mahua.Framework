using System;
using Autofac;
using Newbe.Mahua.MahuaEvents;

namespace Newbe.Mahua.Plugins.Parrot
{
    /**
     * 此文件为了演示方便，将所有的类合并在同一个文件中，实际项目中可以根据要求分开放置
     */

    /// <summary>
    /// 本插件的基本信息
    /// </summary>
    public class PluginInfo : IPluginInfo
    {
        /// <summary>
        /// 版本号，建议采用 主版本.次版本.修订号 的形式
        /// </summary>
        public string Version { get; set; } = "1.0.0";

        /// <summary>
        /// 插件名称
        /// </summary>

        public string Name { get; set; } = "鹦鹉学舌";

        /// <summary>
        /// 作者名称
        /// </summary>
        public string Author { get; set; } = "Newbe";

        /// <summary>
        /// 插件Id，用于唯一标识插件产品的Id，至少包含 AAA.BBB.CCC 三个部分
        /// </summary>
        public string Id { get; set; } = "Newbe.Mahua.Plugins.Parrot";

        /// <summary>
        /// 插件描述
        /// </summary>
        public string Description { get; set; } = "鹦鹉学舌，是一个使用Mahua框架开发的第一个插件。该插件实现将好友的私聊消息回发给好友的功能。";
    }

    /// <summary>
    /// 监听来自好友的私聊消息事件
    /// </summary>
    public class PrivateMessageFromFriendReceivedMahuaEvent : IPrivateMessageFromFriendReceivedMahuaEvent
    {
        private readonly IMahuaApi _mahuaApi;

        /// <summary>
        /// 采用构造函数注入<see cref="IMahuaApi"/>，以便后续调用
        /// </summary>
        /// <param name="mahuaApi"></param>
        public PrivateMessageFromFriendReceivedMahuaEvent(IMahuaApi mahuaApi)
        {
            _mahuaApi = mahuaApi;
        }

        /// <summary>
        /// 处理事件
        /// </summary>
        /// <param name="context"></param>
        public void ProcessFriendMessage(PrivateMessageFromFriendReceivedContext context)
        {
            //调用_mahuaApi实现将消息回发给好友的功能
            _mahuaApi.SendPrivateMessage(context.FromQq, context.Message);
        }
    }

    /// <summary>
    /// Ioc容器注册
    /// </summary>
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] {new PluginModule(),};
        }

        private class PluginModule : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //将相关的实现类注册到，此处可以根据自定义的配置文件进行按需加载，可以自行发挥想象力。
                base.Load(builder);
                //将实现类与接口的关系注入到Autofac的Ioc容器中。如果此处缺少注册将无法启动插件。注意！！！PluginInfo是插件运行必须注册的，其他内容则不是必要的！！！
                builder.RegisterType<PluginInfo>().AsImplementedInterfaces();
                //将需要监听的事件注册，若缺少此注册，则不会调用相关的实现类
                builder.RegisterType<PrivateMessageFromFriendReceivedMahuaEvent>().AsImplementedInterfaces();
            }
        }
    }
}