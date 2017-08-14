using Newbe.Mahua.Commands;

namespace Newbe.Mahua
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        MahuaCommandResult SendCommandWithResult(MahuaCommand command);
    }
}
