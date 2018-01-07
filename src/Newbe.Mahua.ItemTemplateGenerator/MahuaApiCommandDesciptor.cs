namespace Newbe.Mahua.ItemTemplateGenerator
{
    public class MahuaApiCommandDesciptor
    {
        public string Summary { get; set; }

        public string CommandName { get; set; }

        public string CommandHandlerName { get; set; }

        public string CommandResultName { get; set; }

        public bool HasResult => !string.IsNullOrEmpty(CommandResultName);
    }
}
