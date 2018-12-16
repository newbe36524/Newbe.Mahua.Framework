using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Newbe.Mahua.ItemTemplateGenerator.Impl.VsExtensions
{
    internal class MahuaApiCommandHandlerItemTemplateGenerator : IMahuaApiCommandHandlerItemTemplateGenerator
    {
        public string Generate(MahuaApiCommandInfo mahuaApiCommandInfo)
        {
            var className = mahuaApiCommandInfo.CommandHandlerName;
            var dirPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                className);
            var dir = new DirectoryInfo(dirPath);
            if (dir.Exists)
            {
                dir.Delete(true);
                Thread.Sleep(100);
            }
            Directory.CreateDirectory(dir.FullName);

            var mahuaEventCs = new MahuaApiCommandHandlerCS
            {
                Session = new Dictionary<string, object>
                {
                    ["Des"] = mahuaApiCommandInfo
                }
            };
            mahuaEventCs.Initialize();
            var cs = mahuaEventCs.TransformText();
            WriteFileWithUtf8Bom(cs, Path.Combine(dirPath, $"{className}.cs"), true);


            var mahuaEventMyTemplateXml = new MahuaApiCommandHandlerMyTemplateXml
            {
                Session = new Dictionary<string, object>
                {
                    ["Des"] = mahuaApiCommandInfo
                }
            };
            mahuaEventMyTemplateXml.Initialize();
            var xml = mahuaEventMyTemplateXml.TransformText();
            WriteFileWithUtf8Bom(xml, Path.Combine(dirPath, "MyTemplate.vstemplate"), false);

            File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"), Path.Combine(dirPath, "__TemplateIcon.png"));
            File.Copy(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logo.png"), Path.Combine(dirPath, "__PreviewImage.png"));

            Process.Start("7z.exe", $"a {className}.zip .\\{className}\\*");
            return $"{className}.zip";
        }

        public static void WriteFileWithUtf8Bom(string content, string filename, bool withBom)
        {
            var utf8WithBom = new System.Text.UTF8Encoding(withBom);
            File.WriteAllText(filename, content, utf8WithBom);
        }
    }
}
