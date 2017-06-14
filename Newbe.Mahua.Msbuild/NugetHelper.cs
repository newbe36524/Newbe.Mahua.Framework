using System.IO;
using System.Linq;
using NuGet;

namespace Newbe.Mahua.Msbuild
{
    internal static class NugetHelper
    {
        internal static IPackage GetLastestVersionPackage(string packageDir, string packageId)
        {
            var repo = new LocalPackageRepository(Path.GetFullPath(packageDir));
            var pkgs = repo.GetPackages().ToArray();
            var targetPackages = pkgs.Where(x => x.Id == packageId).ToArray();
            var newbePk =
                targetPackages.First(x => x.Id == packageId && x.Version == targetPackages.Max(a => a.Version));
            return newbePk;
        }
    }
}