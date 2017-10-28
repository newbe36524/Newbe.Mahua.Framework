namespace Newbe.Mahua
{
    public interface IPluginLoader
    {
        string Message { get; }
        bool LoadPlugin(string pluginEntryPointDllFullFilename);
        byte[] Handle(byte[] cmd, string cmdTypeFullName, string resultTypeFullName);
        void Handle(byte[] cmd, string cmdTypeFullName);
    }
}
