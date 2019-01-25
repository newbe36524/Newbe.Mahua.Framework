using System.Collections.Generic;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Newbe.Mahua.NativeApiClassfy.Services.Impl
{
    internal class NativeApiInfoResolver : INativeApiInfoResolver
    {
        public NativeApiInfo GetMahuaApiInfo(string mahuaApiSourceCode)
        {
            var tree = CSharpSyntaxTree.ParseText(mahuaApiSourceCode);
            var root = tree.GetCompilationUnitRoot();
            var methods = root.DescendantNodes().OfType<MethodDeclarationSyntax>().ToArray();
            var mahuaApiInfos = new List<NativeApiMethod>();
            foreach (var method in methods)
            {
                var arguments = new List<NativeApiArgument>();
                var returnType = method.ReturnType.ToString();
                mahuaApiInfos.Add(new NativeApiMethod
                {
                    Name = method.Identifier.ToString(),
                    Description = GetDescriptionContent(method.AttributeLists),
                    Arguments = arguments,
                    ReturnType = returnType == "void" ? string.Empty : returnType,
                });
                foreach (var arg in method.ParameterList.Parameters)
                {
                    arguments.Add(new NativeApiArgument
                    {
                        Name = arg.Identifier.ToString(),
                        Description = GetDescriptionContent(arg.AttributeLists),
                        DataType = arg.Type.ToString()
                    });
                }
            }

            return new NativeApiInfo
            {
                Methods = mahuaApiInfos,
                Name = root.DescendantNodes().OfType<InterfaceDeclarationSyntax>().Single().Identifier.ToString(),
            };
        }

        private static string GetDescriptionContent(SyntaxList<AttributeListSyntax> list)
        {
            var singleAttribute = list.Single();
            var descriptionAttribute = singleAttribute.Attributes.Single();
            var descriptionContent = descriptionAttribute.ArgumentList.Arguments.Single().ToString();
            return descriptionContent.Trim('"');
        }
    }
}