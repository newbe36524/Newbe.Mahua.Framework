using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public static class CodeFormatter
    {
        private static readonly Workspace Workspace = new AdhocWorkspace();

        public static string FormatCode(SyntaxTree compilationUnitSyntax)
        {
            var syntaxNode = Formatter.Format(compilationUnitSyntax.GetRoot(), Workspace);
            return syntaxNode.ToString();
        }
    }
}