using System;
using System.IO;
using System.Linq;
using FluentAssertions;
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

        //集成测试[Fact]
        public void GetNewestVersion()
        {
            var npk = NugetHelper.GetLastestVersionPackage(Path.GetFullPath("../../pkgs"), "Package");
            npk.Version.ToString().Should().Be("3.0.0-pre");
            _testOutputHelper.WriteLine(npk.Version.ToString());
        }


        //集成测试[Fact]
        public void IntergationTest()
        {
            var npk = NugetHelper.GetLastestVersionPackage(@"D:\Codes\Repos\Newbe.Mahua.Framework\packages",
                "Newbe.Mahua.CQP");
            npk.Version.ToFullString().Should().Be("1.0.1.2");
            _testOutputHelper.WriteLine(npk.Version.ToString());
        }
    }
}