// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.CmdOptions
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using CommandLine;

namespace Newbe.Tools.ELang2CSharp
{
    public class CmdOptions
    {
        [Option('i', "input", DefaultValue = ".\\api.txt", HelpText = "易语言api定义文件")]
        public string InputFile { get; set; }

        [Option('o', "out", DefaultValue = ".\\api.cs", HelpText = "Api输出位置")]
        public string OutFile { get; set; }

        [Option('d', "dll", HelpText = "定义导入DLL名称，这将影响[DllImport(*DllName*)]", Required = true)]
        public string DllName { get; set; }
    }
}