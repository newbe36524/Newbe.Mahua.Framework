using System.IO;
using System.Linq;
using NuGet;

namespace Newbe.Mahua.Msbuild.Packers
{
    public interface IMahuaPluginPacker
    {
        bool Pack(MahuaPluginPackContext context);
    }

    internal class CqpMahuaPluginPacker : IMahuaPluginPacker
    {
        private const string PkgName = "Newbe.Mahua.CQP";

        public bool Pack(MahuaPluginPackContext context)
        {
            var projectDirectory = context.ProjectDirectory;
            var targetPaths = new TargetPaths(Path.Combine(projectDirectory, "bin", "MPQ"), context.NewbePluginName);
            //清理并创建目标文件夹
            targetPaths.CleanAndCreateNew();
            //复制bin
            Helper.DirectoryCopy(
                Path.Combine(projectDirectory, "bin", context.Configuration),
                targetPaths.PluginDir,
                true);
            var npkPath = GetNpkPath(context.PackageDirectory, PkgName);
            //复制内容到平台插件目录
            var apiExporterDll = new FileInfo(Path.Combine(npkPath.ForPlugin, $"{PkgName}.dll"));
            apiExporterDll.CopyTo(Path.Combine(targetPaths.PlatformPluginsDir, $"{context.NewbePluginName}.dll"));
            //复制forPlugin文件夹内容
            Helper.DirectoryCopy(
                npkPath.ForPlugin,
                targetPaths.PluginDir,
                false);
            //复制forMain文件夹内容
            Helper.DirectoryCopy(
                npkPath.ForMain,
                targetPaths.Target,
                false);
            return true;
        }

        private static NpkPath GetNpkPath(string packageDir, string pkgName)
        {
            var repo = new LocalPackageRepository(packageDir);
            var pkgs = repo.GetPackages();
            var newbePk = pkgs.First(x => x.Id == pkgName && x.IsAbsoluteLatestVersion);
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
        }

        private class TargetPaths
        {
            public TargetPaths(string target, string pluginName)
            {
                Target = target;
                PluginDir = Path.Combine(target, pluginName);
                PlatformPluginsDir = Path.Combine(target, "app");
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