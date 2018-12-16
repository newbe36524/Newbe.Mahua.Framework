using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl.DotnetNew
{
    internal class MahuaEventItemTemplateGenerator : IMahuaEventItemTemplateGenerator
    {
        public string Generate(MahuaEventInfo mahuaEventInfo)
        {
            var dirPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "ItemTemplate",
                "MahuaEvent");
            var dir = new DirectoryInfo(dirPath);
            if (!dir.Exists)
            {
                Directory.CreateDirectory(dir.FullName);
                Thread.Sleep(100);
            }

            var mahuaEventCs = new MahuaEventCS
            {
                Session = new Dictionary<string, object>
                {
                    ["Des"] = mahuaEventInfo
                }
            };
            mahuaEventCs.Initialize();
            var cs = mahuaEventCs.TransformText();
            var className = mahuaEventInfo.Name.Substring(1);
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