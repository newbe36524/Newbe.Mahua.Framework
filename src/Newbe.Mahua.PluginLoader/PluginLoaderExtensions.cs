using Newbe.Mahua.Commands;
using Newbe.Mahua.Internals;

namespace Newbe.Mahua
{
    public static class PluginLoaderExtensions
    {
        public static TResult SendCommand<TCommand, TResult>(this IPluginLoader pluginLoader, TCommand command)
            where TResult : MahuaCommandResult, new() where TCommand : MahuaCommand<TResult>
        {
            var cmdType = typeof(TCommand);
            var resultType = typeof(TResult);
            var reJson = pluginLoader
                .Handle(GlobalCache.CrossDoaminSerializer.Serialize(command, cmdType), cmdType.FullName, resultType.FullName);
            var re = GlobalCache.CrossDoaminSerializer.Deserialize(reJson, resultType);
            return (TResult)re;
        }

        public static void SendCommand<TMahuaCommand>(this IPluginLoader pluginLoader, TMahuaCommand command)
        {
            var cmdTypeFullName = command.GetType().FullName;
            var serializeCmd = GlobalCache.CrossDoaminSerializer.Serialize(command, typeof(TMahuaCommand));
            pluginLoader.Handle(serializeCmd, cmdTypeFullName);
        }
    }
}
