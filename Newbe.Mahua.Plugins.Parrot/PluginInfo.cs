namespace Newbe.Mahua.Plugins.Parrot
{
    public class PluginInfo : IPluginInfo
    {
        public string Version { get; set; } = "1.0.0";
        public string Name { get; set; } = "鹦鹉学舌";
        public string Author { get; set; } = nameof(Newbe);
        public string Id { get; set; } = "Newbe.Mahua.Plugins.Parrot";
        public string Description { get; set; } = "鹦鹉学舌";
    }
}