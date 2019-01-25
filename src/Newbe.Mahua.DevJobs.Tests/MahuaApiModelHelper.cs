using System.Collections.Generic;
using Newbe.Mahua.NativeApiClassfy.Services;

namespace Newbe.Mahua.NativeApiClassfy.Tests
{
    public static class MahuaApiModelHelper
    {
        public static readonly NativeApiMethod ReturnTypeString2Arguments = new NativeApiMethod
        {
            Description = nameof(ReturnTypeString2Arguments),
            Name = nameof(ReturnTypeString2Arguments),
            ReturnType = "string",
            Arguments = new[]
            {
                new NativeApiArgument
                {
                    Description = "Value1 ----",
                    Name = "Value1",
                    DataType = "string"
                },
                new NativeApiArgument
                {
                    Description = "Value2 ------",
                    Name = "Value2",
                    DataType = "long"
                }
            }
        };

        public static readonly NativeApiMethod ReturnTypeVoid0Arguments = new NativeApiMethod
        {
            Description = nameof(ReturnTypeVoid0Arguments),
            Name = nameof(ReturnTypeVoid0Arguments),
            Arguments = new List<NativeApiArgument>()
        };
    }
}