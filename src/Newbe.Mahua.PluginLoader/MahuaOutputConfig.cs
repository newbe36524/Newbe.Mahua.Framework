using System.Collections.ObjectModel;

namespace Newbe.Mahua
{
    public class MahuaOutputConfig
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public ReadOnlyDictionary<string, object> Args { get; set; }
    }
}