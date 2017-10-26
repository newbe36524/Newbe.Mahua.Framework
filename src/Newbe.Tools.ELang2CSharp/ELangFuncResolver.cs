// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.ELangFuncResolver
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Newbe.Tools.ELang2CSharp
{
    public class ELangFuncResolver : IELangFuncResolver
    {
        IEnumerable<ELangFunc> IELangFuncResolver.Resolve(string content)
        {
            var dll命令 = ".DLL命令";
            return content.Split(new string[1]
                {
                    dll命令
                }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Contains(","))
                .Select(x => x.Replace(dll命令, string.Empty))
                .ToArray()
                .Select(x =>
                {
                    var array1 = x.Split(new string[1]
                    {
                        Environment.NewLine
                    }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var str1 = array1[0];
                    var elangFunc = new ELangFunc();
                    var strArray = str1.Split(',');
                    elangFunc.Name = strArray[3].Trim('"', ' ');
                    elangFunc.ReturnType = strArray[1].Trim();
                    elangFunc.Summary = strArray.Length > 4 ? strArray[5].Trim() : string.Empty;
                    if (array1.Length > 1)
                    {
                        var elangParameterList = new List<ELangParameter>();
                        for (var index = 1; index < array1.Length; ++index)
                        {
                            var str2 = array1[index].Replace(".参数", string.Empty);
                            var array2 = str2.Split(',').ToArray();
                            elangParameterList.Add(new ELangParameter
                            {
                                Name = array2[0].Trim(),
                                Type = array2[1].Trim(),
                                Summary = array2.Length > 2
                                    ? str2.Substring(array2[0].Length + array2[1].Length + 4).Trim()
                                    : string.Empty
                            });
                        }
                        elangFunc.ELangParameters = elangParameterList.ToArray();
                    }
                    return elangFunc;
                }).ToArray();
        }
    }
}