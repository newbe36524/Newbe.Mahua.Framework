namespace Newbe.Mahua.Plugins.Parrot
{
    public class PluginInfo : IPluginInfo
    {
        public string Version { get; set; }
        public string Name { get; set; }
        public string Id { get; set; } = "Newbe.Mahua.Plugins.Parrot";
        public string Description { get; set; }
    }
}