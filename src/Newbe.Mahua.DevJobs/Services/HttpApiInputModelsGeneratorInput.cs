namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public class HttpApiInputModelsGeneratorInput
    {
        public NativeApiInfo NativeApiInfo { get; set; }
        public MahuaPlatform MahuaPlatform { get; set; }
        public string[] SkipProperties { get; set; }
    }
}