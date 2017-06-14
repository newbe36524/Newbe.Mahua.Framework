using System;
using System.IO;
using System.Linq;
using NuGet;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.Msbuild.Tests
{
    public class NugetTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public NugetTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void GetNewestVersion()
        {
            var repo = new LocalPackageRepository(Path.GetFullPath("../../pkgs"));
            var pkgs = repo.GetPackages().ToList();
            var newbePk = pkgs.First(x => x.Id == "Package" && x.IsAbsoluteLatestVersion);
            _testOutputHelper.WriteLine(newbePk.Version.ToString());
        }
    }
}