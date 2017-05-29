using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Newbe.Mahua.Framework
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        void SendCommand(MahuaCommand command);
        void SendCommandWithResult(MahuaCommand command, out MahuaCommandResult mahuaCommandResult);
    }

    public static class PluginLoaderExtensions
    {
        public static TResult SendCommand<TResult>(this IPluginLoader pluginLoader, MahuaCommand command)
            where TResult : MahuaCommandResult, new()
        {
            MahuaCommandResult result;
            pluginLoader.SendCommandWithResult(command, out result);
            //todo  赋值存在异常，需要修复
            var re = new TResult();
            foreach (var propertyInfo in typeof(TResult).GetProperties())
            {
                var value = propertyInfo.GetValue(result);
                propertyInfo.SetValue(re, value);
            }
            return re;
        }
    }

    public abstract class MahuaCommandResult : MarshalByRefObject
    {
    }
}