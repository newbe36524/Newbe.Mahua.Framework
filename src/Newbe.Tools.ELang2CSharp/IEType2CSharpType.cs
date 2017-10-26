// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.IEType2CSharpType
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System.Collections.Generic;

namespace Newbe.Tools.ELang2CSharp
{
    public interface IEType2CSharpType
    {
        IEnumerable<ELangFunc> ChangeTypes(IEnumerable<ELangFunc> funcs);
    }
}