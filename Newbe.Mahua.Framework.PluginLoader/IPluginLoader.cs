using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Newbe.Mahua.Framework.Commands;

namespace Newbe.Mahua.Framework
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        void SendCommand(MahuaCommand command);
        void SendCommandWithResult(MahuaCommand command, out MahuaCommandResult mahuaCommandResult);
    }
}