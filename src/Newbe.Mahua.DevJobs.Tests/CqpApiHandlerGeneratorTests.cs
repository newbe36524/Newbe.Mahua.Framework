using System;
using FluentAssertions;
using Microsoft.CodeAnalysis.CSharp;
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
            var generator = new ApiHandlerGenerator(MockHelper.CreateClock(DateTime.Parse("2019/01/30")));
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
            var expected = CSharpSyntaxTree.ParseText(@"using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newbe.Mahua.NativeApi;


// this file is generate from tools, do not change this file
// generate time 2019/01/30 

namespace Newbe.Mahua.CQP
{
    public class CqpMahuaApiHandler : IPlatformMahuaApiHandler
    {

        private readonly IMahuaCenter _mahuaCenter;
        private readonly ICoolQApi _coolQApi;

        public CqpMahuaApiHandler(
            IMahuaCenter mahuaCenter,
            ICoolQApi coolQApi)
        {
            _mahuaCenter = mahuaCenter;
            _coolQApi = coolQApi;
        }
        public Task Run(string typeCode, IReadOnlyDictionary<string, object> data)
        {
            switch (typeCode)
            {
                case ""ReturnTypeString2Arguments"":
                    var ReturnTypeString2ArgumentsResult =
                    _coolQApi.ReturnTypeString2Arguments(Value1: data[""Value1""].ToString(), Value2: Convert.ToInt64(data[""Value2""]));
                    return _mahuaCenter.HandleMahuaOutput(new ReturnTypeString2ArgumentsApiOut
                    { Result = ReturnTypeString2ArgumentsResult });
                case ""ReturnTypeVoid0Arguments"":
                    _coolQApi.ReturnTypeVoid0Arguments();
                    return Task.CompletedTask;

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeCode));
            }
        }
    }
    /// <summary>
    /// api out of method ReturnTypeString2Arguments
    /// </summary>
    public class ReturnTypeString2ArgumentsApiOut : CqpMahuaApiOut
    {
        public string Result { get; set; }
        public override string TypeCode => nameof(ReturnTypeString2ArgumentsApiOut);
    }
}
");
            re.IsEquivalentTo(expected).Should().BeTrue();
            _testOutputHelper.WriteLine(CodeFormatter.FormatCode(re));
        }
    }
}