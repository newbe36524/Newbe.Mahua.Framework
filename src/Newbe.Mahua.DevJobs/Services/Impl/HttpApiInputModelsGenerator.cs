using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    public class HttpApiInputModelsGenerator : IHttpApiInputModelsGenerator
    {
        private readonly IClock _clock;

        public HttpApiInputModelsGenerator(
            IClock clock)
        {
            _clock = clock;
        }

        public SyntaxTree Generate(HttpApiInputModelsGeneratorInput input)
        {
            var sb = new StringBuilder();
            sb.AppendLine($@"
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
");
            sb.GenerateFileHead(_clock);
            sb.AppendLine(
                $"namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.{input.MahuaPlatform:G}");

            sb.UsingCurlyBraces(() =>
            {
                sb.Append($"[Route(\"api/v1/{input.MahuaPlatform:G}\")]");
                sb.AppendLine($"public class {input.MahuaPlatform:G}Controller : Controller");
                sb.UsingCurlyBraces(() =>
                {
                    sb.AppendLine($@"
        private readonly IMahuaCenter _mahuaCenter;

        public {input.MahuaPlatform:G}Controller(
            IMahuaCenter mahuaCenter)
        {{
            _mahuaCenter = mahuaCenter;
        }}");
                    foreach (var method in input.NativeApiInfo.Methods)
                    {
                        sb.AppendSummaryComments(method.Description);
                        sb.AppendLine($"[HttpPost(\"{method.Name}\")]");
                        sb.AppendLine($"public Task {method.Name}([FromBody] {GetHttpInputName(method)} input)");
                        sb.UsingCurlyBraces(() =>
                        {
                            sb.AppendLine("var httpInput = new HttpInput");
                            sb.UsingCurlyBraces(() =>
                            {
                                sb.AppendLine($"TypeCode = nameof({method.Name}),");
                                sb.AppendLine($"MahuaPlatform = MahuaPlatform.{input.MahuaPlatform:G},");
                                sb.AppendLine(
                                    "Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>");
                                sb.UsingCurlyBraces(() =>
                                {
                                    foreach (var argument in method.Arguments)
                                    {
                                        if (input.SkipProperties?.Contains(argument.Name) == true)
                                        {
                                            continue;
                                        }

                                        sb.AppendLine($"{{nameof(input.{argument.Name}), input.{argument.Name}}},");
                                    }
                                });
                                sb.AppendLine(")");
                            });
                            sb.AppendLine(";");
                            sb.AppendLine("return _mahuaCenter.HandleMahuaInput(httpInput);");
                        });

                        sb.AppendSummaryComments(method.Description);
                        sb.AppendLine($"public class {GetHttpInputName(method)}");
                        sb.UsingCurlyBraces(() =>
                        {
                            foreach (var argument in method.Arguments)
                            {
                                if (input.SkipProperties?.Contains(argument.Name) == true)
                                {
                                    continue;
                                }

                                sb.AppendSummaryComments(argument.Description);
                                sb.AppendLine(
                                    $"public {TransformDataType(argument.DataType)} {argument.Name} {{get;set;}}");
                            }
                        });
                    }
                });
            });


            var tree = CSharpSyntaxTree.ParseText(sb.ToString());
            return tree;

            string GetHttpInputName(NativeApiMethod method)
            {
                return $"{input.MahuaPlatform:G}{method.Name}HttpInput";
            }
            
            string TransformDataType(string dataType)
            {
                switch (dataType)
                {
                    case "byte[]":
                        return "string";
                    default:
                        return dataType;
                }
            }
        }
    }
}