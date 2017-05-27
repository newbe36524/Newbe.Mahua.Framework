namespace Newbe.Mahua.Framework
{
    public interface IPluginInfo
    {
        string Version { get; set; }
        string Name { get; set; }
        string Id { get; set; }
        string Description { get; set; }
    }
}