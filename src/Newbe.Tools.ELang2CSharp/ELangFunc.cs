// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.ELangFunc
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System.Linq;

namespace Newbe.Tools.ELang2CSharp
{
    public class ELangFunc
    {
        public ELangParameter[] ELangParameters { get; set; } =
            Enumerable.Empty<ELangParameter>().ToArray();

        public string ReturnType { get; set; }

        public string Name { get; set; }

        public string Summary { get; set; }
    }
}