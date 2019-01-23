using Microsoft.CodeAnalysis;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public interface IHttpApiInputModelsGenerator
    {
        SyntaxTree Generate(HttpApiInputModelsGeneratorInput input);
    }
}