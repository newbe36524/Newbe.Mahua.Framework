// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.EType2CSharpType
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System.Collections.Generic;
using System.Linq;

namespace Newbe.Tools.ELang2CSharp
{
    internal class EType2CSharpType : IEType2CSharpType
    {
        private static readonly IDictionary<string, string> TypeMapper;

        static EType2CSharpType()
        {
            var dictionary = new Dictionary<string, string>();
            var index1 = "文本型";
            var str1 = "string";
            dictionary[index1] = str1;
            var index2 = "逻辑型";
            var str2 = "bool";
            dictionary[index2] = str2;
            var index3 = "长整数型";
            var str3 = "long";
            dictionary[index3] = str3;
            var index4 = "整数型";
            var str4 = "int";
            dictionary[index4] = str4;
            var index5 = "字节集";
            var str5 = "byte[]";
            dictionary[index5] = str5;
            var index6 = "";
            var str6 = "void";
            dictionary[index6] = str6;
            TypeMapper = dictionary;
        }

        IEnumerable<ELangFunc> IEType2CSharpType.ChangeTypes(IEnumerable<ELangFunc> funcs)
        {
            return funcs.Select(
                func => new ELangFunc
                {
                    Summary = func.Summary,
                    Name = func.Name,
                    ReturnType = TypeMapper[func.ReturnType],
                    ELangParameters = func.ELangParameters
                        .Select(
                            per => new ELangParameter
                            {
                                Summary = per.Summary,
                                Name = per.Name,
                                Type = TypeMapper[per.Type]
                            }).ToArray()
                }).ToArray();
        }
    }
}