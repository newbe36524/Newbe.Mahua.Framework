using System;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    public class ApiHandlerGenerator : IApiHandlerGenerator
    {
        public SyntaxTree Generate(ApiHandlerGeneratorInput input)
        {
            var apiInterfaceName = input.NativeApiInfo.Name;
            var fieldInterfaceName = GetFieldInterfaceName(input.NativeApiInfo.Name);

            var sb = new StringBuilder();
            sb.Append(@"
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;

");
            sb.GenerateFileHead();
            sb.AppendLine($"namespace {input.Namespace}");
            sb.UsingCurlyBraces(() =>
            {
                sb.AppendLine($"public class {input.ApiHandlerClassName} : IPlatformMahuaApiHandler");
                sb.UsingCurlyBraces(() =>
                {
                    #region constructor and fields

                    if (string.IsNullOrEmpty(input.AuthCodeContainerInterfaceName))
                    {
                        var nativeApiVar = GetVarInterfaceName(input.NativeApiInfo.Name);
                        sb.AppendLine($@"        
private readonly IMahuaCenter _mahuaCenter;
private readonly {apiInterfaceName} {fieldInterfaceName};

public {input.ApiHandlerClassName}(
    IMahuaCenter mahuaCenter,
    {apiInterfaceName} {nativeApiVar})
{{
    _mahuaCenter = mahuaCenter;
    {fieldInterfaceName} = {nativeApiVar};
}}");
                    }
                    else
                    {
                        var nativeApiVar = GetVarInterfaceName(input.NativeApiInfo.Name);
                        var authCodeContainerVar = GetVarInterfaceName(input.AuthCodeContainerInterfaceName);
                        var authCodeContainerField = GetFieldInterfaceName(input.AuthCodeContainerInterfaceName);
                        sb.AppendLine($@"        
private readonly IMahuaCenter _mahuaCenter;
private readonly {apiInterfaceName} {fieldInterfaceName};
private readonly {input.AuthCodeContainerInterfaceName} {authCodeContainerField};

public {input.ApiHandlerClassName}(
    IMahuaCenter mahuaCenter,
    {apiInterfaceName} {nativeApiVar},
    {input.AuthCodeContainerInterfaceName} {authCodeContainerVar})
{{
    _mahuaCenter = mahuaCenter;
    {fieldInterfaceName} = {nativeApiVar};
    {authCodeContainerField} = {authCodeContainerVar};
}}");
                    }

                    #endregion

                    sb.AppendLine("public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)");
                    sb.UsingCurlyBraces(() =>
                    {
                        sb.AppendLine(@"switch (typeCode)");
                        sb.UsingCurlyBraces(() =>
                        {
                            foreach (var method in input.NativeApiInfo.Methods)
                            {
                                sb.AppendLine($"case \"{method.Name}\":");
                                if (!string.IsNullOrEmpty(method.ReturnType))
                                {
                                    sb.AppendLine($"var {GetApiResultVarName(method)} = ");
                                    sb.AppendLine($"{fieldInterfaceName}.{method.Name}({GetApiCallList(method)});");
                                    sb.AppendLine(
                                        $"return _mahuaCenter.{nameof(IMahuaCenter.HandleMahuaOutput)}(new {GetApiOutClassName(method)}");
                                    sb.AppendLine($"{{Result = {GetApiResultVarName(method)}}});");
                                }
                                else
                                {
                                    sb.AppendLine($"{fieldInterfaceName}.{method.Name}({GetApiCallList(method)});");
                                    sb.AppendLine("return Task.CompletedTask;");
                                }
                            }

                            sb.AppendLine(@"
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));");
                        });
                    });
                });

                foreach (var method in input.NativeApiInfo.Methods.Where(x => !string.IsNullOrEmpty(x.ReturnType)))
                {
                    sb.AppendSummaryComments($"api out of method {method.Name}");
                    sb.AppendLine($"public class {GetApiOutClassName(method)} : {input.ApiOutBaseName}");
                    sb.UsingCurlyBraces(() =>
                    {
                        sb.AppendLine($"public {method.ReturnType} Result {{get;set;}}");
                        sb.AppendLine($"public override string TypeCode => nameof({GetApiOutClassName(method)});");
                    });
                }
            });
            var tree = CSharpSyntaxTree.ParseText(sb.ToString());
            return tree;

            string GetApiOutClassName(NativeApiMethod apiMethod)
            {
                return $"{apiMethod.Name}ApiOut";
            }

            string GetApiCallList(NativeApiMethod apiMethod)
            {
                return string.Join(",", apiMethod.Arguments.Select(GetArgumentListItem));
            }

            string GetArgumentListItem(NativeApiArgument nativeApiArgument)
            {
                if (nativeApiArgument.Name == "AuthCode")
                {
                    var authCodeContainerField = GetFieldInterfaceName(input.AuthCodeContainerInterfaceName);
                    return $"{nativeApiArgument.Name}:{authCodeContainerField}.AuthCode";
                }

                switch (nativeApiArgument.DataType)
                {
                    case "string":
                        return $"{nativeApiArgument.Name}:data[\"{nativeApiArgument.Name}\"].ToString()";
                    case "int":
                        return $"{nativeApiArgument.Name}:Convert.ToInt32(data[\"{nativeApiArgument.Name}\"])";
                    case "long":
                        return $"{nativeApiArgument.Name}:Convert.ToInt64(data[\"{nativeApiArgument.Name}\"])";
                    case "bool":
                        return $"{nativeApiArgument.Name}:Convert.ToBoolean(data[\"{nativeApiArgument.Name}\"])";
                    case "byte[]":
                        return
                            $"{nativeApiArgument.Name}:Convert.FromBase64String(data[\"{nativeApiArgument.Name}\"].ToString())";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(nativeApiArgument),
                            $"type {nativeApiArgument.DataType} is not expected");
                }
            }

            string GetApiResultVarName(NativeApiMethod apiMethod)
            {
                return $"{apiMethod.Name}Result";
            }

            string GetVarInterfaceName(string interfaceName)
            {
                return $"{interfaceName[1].ToString().ToLowerInvariant()}{interfaceName.Substring(2)}";
            }

            string GetFieldInterfaceName(string interfaceName)
            {
                return $"_{interfaceName[1].ToString().ToLowerInvariant()}{interfaceName.Substring(2)}";
            }
        }
    }
}