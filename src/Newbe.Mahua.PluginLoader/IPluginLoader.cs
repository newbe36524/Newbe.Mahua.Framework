namespace Newbe.Mahua
{
    public interface IPluginLoader : IMahuaCenter
    {
        void LoadPlugin(string pluginEntryPointDllFullFilename);
    }
}