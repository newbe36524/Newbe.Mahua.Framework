using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl.DotnetNew
{
    internal class MahuaApiCommandHandlerItemTemplateGenerator : IMahuaApiCommandHandlerItemTemplateGenerator
    {
        public string Generate(MahuaApiCommandInfo mahuaApiCommandInfo)
        {
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "ItemTemplate",
                "ApiCommandHandler");
            var dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(dir.FullName);
                Thread.Sleep(100);
            }

            var mahuaEventCs = new MahuaApiCommandHandlerCS
            {
                Session = new Dictionary<string, object>
                {
                    ["Des"] = mahuaApiCommandInfo
                }
            };
            mahuaEventCs.Initialize();
            var cs = mahuaEventCs.TransformText();
            var className = mahuaApiCommandInfo.CommandHandlerName;

            WriteFileWithUtf8Bom(cs, Path.Combine(dirPath, $"{className}.cs"), true);

            return $"{className}.cs";
        }

        public static void WriteFileWithUtf8Bom(string content, string filename, bool withBom)
        {
            var utf8WithBom = new System.Text.UTF8Encoding(withBom);
            File.WriteAllText(filename, content, utf8WithBom);
        }
    }
}