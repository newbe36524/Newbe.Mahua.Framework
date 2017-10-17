namespace Newbe.Mahua
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        string Handle(string commandJson, string cmdTypeFullName, string resultTypeFullName);
        void Handle(string commandJson, string cmdTypeFullName);
    }
}
