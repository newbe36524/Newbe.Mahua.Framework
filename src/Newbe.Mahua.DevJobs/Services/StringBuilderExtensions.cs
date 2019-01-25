using System;
using System.Text;

namespace Newbe.Mahua.NativeApiClassfy.Services
{
    public static class StringBuilderExtensions
    {
        public static void AppendSummaryComments(this StringBuilder sb, string summary)
        {
            sb.AppendLine("/// <summary>");
            sb.AppendLine($"/// {summary}");
            sb.AppendLine("/// </summary>");
        }

        public static void UsingCurlyBraces(this StringBuilder sb, Action action)
        {
            sb.AppendLine("{");
            action();
            sb.AppendLine("}");
        }

        public static void GenerateFileHead(this StringBuilder sb)
        {
            sb.AppendLine($@"
// this file is generate from tools, do not change this file
// generate time {DateTime.Today:yyyy/MM/dd} 
");
        }
    }
}