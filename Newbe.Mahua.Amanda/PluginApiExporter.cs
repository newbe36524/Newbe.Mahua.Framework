namespace Newbe.Mahua.Amanda
{
    public class PluginApiExporter : IPluginApiExporter
    {
        public MahuaPlatform MahuaPlatform { get; } = MahuaPlatform.Amanda;
    }
}