using FluentAssertions;
using Newbe.Mahua.NativeApiClassfy.Services;
using Newbe.Mahua.NativeApiClassfy.Services.Impl;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.NativeApiClassfy.Tests
{
    public class MahuaApiRequestGeneratorTests
    {
        public MahuaApiRequestGeneratorTests(
            ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        private readonly ITestOutputHelper _testOutputHelper;

        [Fact]
        public void PlatformApiRequestModelGenerateTest()
        {
            var generator = new HttpApiInputModelsGenerator();
            var re = generator.Generate(new HttpApiInputModelsGeneratorInput
            {
                MahuaPlatform = MahuaPlatform.Cqp,
                NativeApiInfo = new NativeApiInfo
                {
                    Methods = new[]
                    {
                        MahuaApiModelHelper.ReturnTypeString2Arguments,
                        MahuaApiModelHelper.ReturnTypeVoid0Arguments,
                    }
                },
            });
            var code = CodeFormatter.FormatCode(re);
            code.Should().Be(@"using System;

namespace Newbe.Test
{
    /// <summary>
    /// ReturnTypeString2Arguments
    /// </summary>
    public class ReturnTypeString2Arguments
    {
        /// <summary>
        /// Value1 ----
        /// </summary>
        public string Value1 { get; set; }
        /// <summary>
        /// Value2 ------
        /// </summary>
        public long Value2 { get; set; }
    }
    /// <summary>
    /// ReturnTypeVoid0Arguments
    /// </summary>
    public class ReturnTypeVoid0Arguments
    {
    }
}
");
            _testOutputHelper.WriteLine(code);
        }
    }
}