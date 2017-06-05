using System.IO;
using System.Linq;
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NuGet;

namespace Newbe.Mahua.Msbuild.Packers
{
    /// <summary>
    /// Mahua插件打包任务
    /// </summary>
    public class MahuaPackTask : Task
    {
        /// <summary>
        /// 项目文件夹
        /// </summary>
        [Required]
        public string ProjectDirectory { get; set; }

        /// <summary>
        /// 生成配置
        /// </summary>
        [Required]
        public string Configuration { get; set; }

        /// <summary>
        /// 插件名称
        /// </summary>
        [Required]
        public string NewbePluginName { get; set; }

        /// <summary>
        /// Package文件夹
        /// </summary>
        [Required]
        public string PackageDirectory { get; set; }

        public override bool Execute()
        {
            var repo = new LocalPackageRepository(PackageDirectory);
            var pkgs = repo.GetPackages();
            var newbePk = pkgs.First(x => x.Id == "Newbe.MPQ.Framework" && x.IsAbsoluteLatestVersion);
            var forMain = new DirectoryInfo(Path.Combine(PackageDirectory,
                $"{newbePk.Id}.{newbePk.Version.ToFullString()}", "tools",
                "Newbe.MPQ.Framework", "ForMain"));
            var forPlugin = new DirectoryInfo(Path.Combine(PackageDirectory,
                $"{newbePk.Id}.{newbePk.Version.ToFullString()}", "tools",
                "Newbe.MPQ.Framework", "ForPlugin"));
            var apiExporterDllFilename = $"{NewbePluginName}.xx.dll";
            var apiExporterDllFullname = new FileInfo(Path.Combine(forPlugin.FullName, apiExporterDllFilename));
            //如果没有改名的ApiExporter.dll则使用未改名的文件进行复制
            if (!apiExporterDllFullname.Exists)
            {
                apiExporterDllFullname =
                    new FileInfo(Path.Combine(forPlugin.FullName, "Newbe.MPQ.Framework.ApiExporter.dll"));
            }
            var buildResultDir = new DirectoryInfo(Path.Combine(ProjectDirectory, "bin", Configuration));
            var targetDir = new DirectoryInfo(Path.Combine(ProjectDirectory, "bin", "MPQ"));
            //清理上次生成结果
            if (targetDir.Exists)
            {
                targetDir.Delete(true);
            }
            targetDir.Create();
            //复制bin
            DirectoryCopy(buildResultDir.FullName, Path.Combine(targetDir.FullName, NewbePluginName), true);
            var app = new DirectoryInfo(Path.Combine(targetDir.FullName, "Plugin"));
            app.Create();
            //复制forPlugin文件夹内容
            apiExporterDllFullname.CopyTo(Path.Combine(app.FullName, apiExporterDllFilename));
            //复制forMain文件夹内容
            foreach (var maindll in Directory.GetFiles(forMain.FullName, "*.dll"))
            {
                var fileInfo = new FileInfo(maindll);
                fileInfo.CopyTo(Path.Combine(targetDir.FullName, fileInfo.Name));
            }
            return true;
        }

        /// <summary>
        /// 地柜复制文件夹内容
        /// </summary>
        /// <param name="sourceDirName"></param>
        /// <param name="destDirName"></param>
        /// <param name="copySubDirs"></param>
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            var dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            var dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            var files = dir.GetFiles();
            foreach (var file in files)
            {
                var temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (var subdir in dirs)
                {
                    var temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, true);
                }
            }
        }
    }
}