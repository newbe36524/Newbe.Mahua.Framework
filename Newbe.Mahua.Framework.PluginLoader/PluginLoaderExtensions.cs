using System.Web.Script.Serialization;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework
{
    public static class PluginLoaderExtensions
    {
        private static readonly JavaScriptSerializer JavaScriptSerializer = new JavaScriptSerializer();

        private static TResult ConvertType<TResult>(MahuaCommandResult crossDomainCommandResult)
        {
            var serialize = JavaScriptSerializer.Serialize(crossDomainCommandResult);
            var re = JavaScriptSerializer.Deserialize<TResult>(serialize);
            return re;
        }

        public static TResult SendCommand<TResult>(this IPluginLoader pluginLoader, MahuaCommand command)
            where TResult : MahuaCommandResult, new()
        {
            MahuaCommandResult result;
            pluginLoader.SendCommandWithResult(command, out result);
            var re = ConvertType<TResult>(result);
            return re;
        }
    }
}