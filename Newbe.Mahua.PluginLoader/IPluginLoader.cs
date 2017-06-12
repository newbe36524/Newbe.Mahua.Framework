using Newbe.Mahua.Commands;

namespace Newbe.Mahua
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        void SendCommand(MahuaCommand command);
        void SendCommandWithResult(MahuaCommand command, out MahuaCommandResult mahuaCommandResult);
    }
}