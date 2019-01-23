using FluentAssertions;
using Newbe.Mahua.NativeApiClassfy.Services;
using Newbe.Mahua.NativeApiClassfy.Services.Impl;
using Xunit;
using Xunit.Abstractions;

namespace Newbe.Mahua.NativeApiClassfy.Tests
{
    public class CqpApiHandlerGeneratorTests
    {
        public CqpApiHandlerGeneratorTests(
            ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        private readonly ITestOutputHelper _testOutputHelper;

        [Fact]
        public void CqpApiHandlerGeneratorTest()
        {
            var generator = new ApiHandlerGenerator();
            var re = generator.Generate(new ApiHandlerGeneratorInput
            {
                NativeApiInfo = new NativeApiInfo
                {
                    Name = "ICoolQApi",
                    Methods = new[]
                    {
                        MahuaApiModelHelper.ReturnTypeString2Arguments,
                        MahuaApiModelHelper.ReturnTypeVoid0Arguments,
                    }
                },
                Namespace = "Newbe.Mahua.CQP",
                ApiHandlerClassName = "CqpMahuaApiHandler",
                ApiOutBaseName = "CqpMahuaApiOut"
            });
            var code = CodeFormatter.FormatCode(re);
//            code.Should().Be(@"using System;
//
//namespace Newbe.Mahua
//{
//    ///<summary>ReturnTypeString2Arguments</summary>
//    public class ReturnTypeString2Arguments
//    {
//        ///<summary>Value1 ----</summary>
//        public string Value1 { get; set; }
//
//        ///<summary>Value2 ------</summary>
//        public long Value2 { get; set; }
//    }
//
//    ///<summary>ReturnTypeVoid0Arguments</summary>
//    public class ReturnTypeVoid0Arguments
//    {
//    }
//}");
            _testOutputHelper.WriteLine(code);
        }
    }
}