using System.IO;
using System.Linq;
using NuGet;

namespace Newbe.Mahua.Msbuild.Packers
{
    internal class AmandaMahuaPluginPacker : IMahuaPluginPacker
    {
        private readonly ILog _log;

        public AmandaMahuaPluginPacker(ILog log)
        {
            _log = log;
        }

        private const string PkgName = "Newbe.Mahua.Amanda";

        public bool Pack(MahuaPluginPackContext context)
        {
            var projectDirectory = context.ProjectDirectory;
            var targetPaths = new TargetPaths(Path.Combine(projectDirectory, "bin", "Amanda"), context.NewbePluginName);
            //清理并创建目标文件夹
            targetPaths.CleanAndCreateNew();
            //复制bin
            DirectoryHelper.DirectoryCopy(
                Path.Combine(projectDirectory, "bin", context.Configuration),
                targetPaths.PluginDir,
                true);
            DirectoryHelper.DeleteOtherPlatformFile(targetPaths.PluginDir, MahuaPlatform.Amanda);
            var npkPath = GetNpkPath(context.PackageDirectory, PkgName);
            _log.Debug($"将使用{npkPath}中的插件平台包。");
            //复制内容到平台插件目录
            var apiExporterDll = new FileInfo(Path.Combine(npkPath.ForPlugin, $"{PkgName}.dll"));
            apiExporterDll.CopyTo(Path.Combine(targetPaths.PlatformPluginsDir,
                $"{context.NewbePluginName}.plugin.dll"));
            //复制forPlugin文件夹内容
            DirectoryHelper.DirectoryCopy(
                npkPath.ForPlugin,
                targetPaths.PluginDir,
                false);
            //复制forMain文件夹内容
            DirectoryHelper.DirectoryCopy(
                npkPath.ForMain,
                targetPaths.Target,
                false);
            return true;
        }

        private static NpkPath GetNpkPath(string packageDir, string pkgName)
        {
            var newbePk = NugetHelper.GetLastestVersionPackage(packageDir, pkgName);
            var npkPath = new NpkPath(Path.Combine(packageDir, $"{newbePk.Id}.{newbePk.Version.ToFullString()}"));
            return npkPath;
        }

        private class NpkPath
        {
            public NpkPath(string npkDirBase)
            {
                ForMain = Path.Combine(npkDirBase, "tools", nameof(ForMain));
                ForPlugin = Path.Combine(npkDirBase, "tools", nameof(ForPlugin));
            }

            public string ForMain { get; }
            public string ForPlugin { get; }

            public override string ToString()
            {
                return $"{nameof(ForMain)}: {ForMain}, {nameof(ForPlugin)}: {ForPlugin}";
            }
        }

        private class TargetPaths
        {
            public TargetPaths(string target, string pluginName)
            {
                Target = target;
                PluginDir = Path.Combine(target, pluginName);
                PlatformPluginsDir = Path.Combine(target, "plugin");
            }

            public string Target { get; set; }
            public string PlatformPluginsDir { get; set; }
            public string PluginDir { get; set; }

            public void CleanAndCreateNew()
            {
                if (Directory.Exists(Target))
                {
                    Directory.Delete(Target, true);
                }
                Directory.CreateDirectory(Target);
                Directory.CreateDirectory(PlatformPluginsDir);
                Directory.CreateDirectory(PluginDir);
            }
        }
    }
}