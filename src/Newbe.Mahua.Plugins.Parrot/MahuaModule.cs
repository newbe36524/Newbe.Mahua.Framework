using Autofac;

namespace Newbe.Mahua.Plugins.Parrot
{
    /**
     * 此文件为了演示方便，将所有的类合并在同一个文件中，实际项目中可以根据要求分开放置
     */

    /// <summary>
    /// Ioc容器注册
    /// </summary>
    public class MahuaModule : IMahuaModule
    {
        public Module[] GetModules()
        {
            return new Module[] { new PluginModule(), };
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
