using Newbe.Mahua.Commands;
using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    public static class PluginLoaderExtensions
    {
        public static TResult SendCommand<TCommand, TResult>(this IPluginLoader pluginLoader, TCommand command)
            where TResult : MahuaCommandResult, new() where TCommand : MahuaCommand<TResult>
        {
            var reJson = pluginLoader.Handle(GlobalCache.JavaScriptSerializer.Serialize(command),
                typeof(TCommand).FullName, typeof(TResult).FullName);
            var re = GlobalCache.JavaScriptSerializer.Deserialize<TResult>(reJson);
            return re;
        }

        public static void SendCommand(this IPluginLoader pluginLoader, MahuaCommand command)
        {
            pluginLoader.Handle(GlobalCache.JavaScriptSerializer.Serialize(command),
                command.GetType().FullName);
        }
    }
}
