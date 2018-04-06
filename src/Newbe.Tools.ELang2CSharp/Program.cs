// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.Program
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using CommandLine;
using System;
using System.Collections.Generic;
using System.IO;

namespace Newbe.Tools.ELang2CSharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CmdOptions cmdOptions = null;
            Parser.Default.ParseArguments<CmdOptions>(args)
                .WithParsed(options => cmdOptions = options)
                .WithNotParsed(errors => Console.ReadKey());
            if (cmdOptions == null)
            {
                Console.ReadKey();
                return;
            }
            var inputFile = cmdOptions.InputFile;
            if (string.IsNullOrEmpty(inputFile))
            {
                Console.WriteLine("请输入需要转换的易语言文档。");
            }
            else
            {
                var fileInfo = new FileInfo(inputFile);
                if (!fileInfo.Exists)
                {
                    Console.WriteLine("无法找到指定的易语言文档:{0}", inputFile);
                }
                else
                {
                    string end;
                    using (var streamReader = fileInfo.OpenText())
                    {
                        end = streamReader.ReadToEnd();
                    }
                    var elangFuncs1 =
                        ((IEType2CSharpType)new EType2CSharpType()).ChangeTypes(
                            ((IELangFuncResolver)new ELangFuncResolver()).Resolve(end));
                    var nativeMethod1 = new NativeMethod();
                    var dictionary = new Dictionary<string, object>();
                    var index1 = "elangFuncs";
                    var elangFuncs2 = elangFuncs1;
                    dictionary[index1] = elangFuncs2;
                    var index2 = "dllname";
                    var dllName = cmdOptions.DllName;
                    dictionary[index2] = dllName;
                    nativeMethod1.Session = dictionary;
                    var nativeMethod2 = nativeMethod1;
                    nativeMethod2.Initialize();
                    var contents = nativeMethod2.TransformText();
                    File.WriteAllText(cmdOptions.OutFile, contents);
                    Console.WriteLine("转换完毕！输出文件位置：{0}", cmdOptions.OutFile);
                }
            }
        }
    }
}
