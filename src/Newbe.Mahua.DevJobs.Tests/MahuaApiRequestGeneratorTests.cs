using System;
using FluentAssertions;
using Microsoft.CodeAnalysis.CSharp;
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
            var generator = new HttpApiInputModelsGenerator(MockHelper.CreateClock(DateTime.Parse("2019/01/31")));
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
            var expected = CSharpSyntaxTree.ParseText(@"using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


// this file is generate from tools, do not change this file
// generate time 2019/01/31 

namespace Newbe.Mahua.InputReceivers.HttpApi.Services.Controllers.Cqp
{
    [Route(""api/v1/Cqp"")]
    public class CqpController : Controller
    {

        private readonly IMahuaCenter _mahuaCenter;

        public CqpController(
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
        }
        /// <summary>
        /// ReturnTypeString2Arguments
        /// </summary>
        [HttpPost(""ReturnTypeString2Arguments"")]
        public Task ReturnTypeString2Arguments([FromBody] CqpReturnTypeString2ArgumentsHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(ReturnTypeString2Arguments),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
{
{nameof(input.Value1), input.Value1},
{nameof(input.Value2), input.Value2},
}
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// ReturnTypeString2Arguments
        /// </summary>
        public class CqpReturnTypeString2ArgumentsHttpInput
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
        [HttpPost(""ReturnTypeVoid0Arguments"")]
        public Task ReturnTypeVoid0Arguments([FromBody] CqpReturnTypeVoid0ArgumentsHttpInput input)
        {
            var httpInput = new HttpInput
            {
                TypeCode = nameof(ReturnTypeVoid0Arguments),
                MahuaPlatform = MahuaPlatform.Cqp,
                Data = new ReadOnlyDictionary<string, object>(new Dictionary<string, object>
                {
                }
            )
            }
            ;
            return _mahuaCenter.HandleMahuaInput(httpInput);
        }
        /// <summary>
        /// ReturnTypeVoid0Arguments
        /// </summary>
        public class CqpReturnTypeVoid0ArgumentsHttpInput
        {
        }
    }
}
");
            re.IsEquivalentTo(expected).Should().BeTrue();
            _testOutputHelper.WriteLine(CodeFormatter.FormatCode(re));
        }
    }
}