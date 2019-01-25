using Microsoft.CodeAnalysis;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public interface IApiHandlerGenerator
    {
        SyntaxTree Generate(ApiHandlerGeneratorInput input);
    }

    public class ApiHandlerGeneratorInput
    {
        public NativeApiInfo NativeApiInfo { get; set; }
        public string Namespace { get; set; }
        public string ApiHandlerClassName { get; set; }
        public string ApiOutBaseName { get; set; }

        public string AuthCodeContainerInterfaceName { get; set; }
    }
}