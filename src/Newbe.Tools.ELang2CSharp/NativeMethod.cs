// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.NativeMethod
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Newbe.Tools.ELang2CSharp
{
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class NativeMethod : NativeMethodBase
    {
        private IEnumerable<ELangFunc> elangFuncs { get; set; }

        private string dllname { get; set; }

        public virtual string TransformText()
        {
            Write($"// generate at {DateTimeOffset.UtcNow}");
            Write("\r\npublic interface IApi{\r\n");
            foreach (var elangFunc in elangFuncs)
            {
                Write(ToStringHelper.ToStringWithCulture(GetFuncSummary(elangFunc)));
                Write(ToStringHelper.ToStringWithCulture(GetFuncDescription(elangFunc)));
                Write(ToStringHelper.ToStringWithCulture(elangFunc.ReturnType));
                Write(" ");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.Name));
                Write(ToStringHelper.ToStringWithCulture(
                    GetParametersWithType(elangFunc.ELangParameters)));
                Write(";\r\n");
            }
            Write("}\r\npublic class ApiImpl:IApi{\r\n\r\n ");
            foreach (var elangFunc in elangFuncs)
            {
                Write("\t\t");
                Write(ToStringHelper.ToStringWithCulture(GetFuncSummary(elangFunc)));
                Write("\r\n\r\n         ");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.ReturnType));
                Write("  IApi.");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.Name));
                Write(ToStringHelper.ToStringWithCulture(
                    GetParametersWithType(elangFunc.ELangParameters)));
                Write("\r\n\t\t =>NativeMethods.");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.Name));
                Write(ToStringHelper.ToStringWithCulture(
                    GetParameters(elangFunc.ELangParameters)));
                Write(";\r\n\t\t ");
            }
            Write("private static class NativeMethods\r\n        {\r\n        ");
            foreach (var elangFunc in elangFuncs)
            {
                Write("\t\t\t");
                Write(ToStringHelper.ToStringWithCulture(GetFuncSummary(elangFunc)));
                Write("\r\n\t\t  [DllImport(\"");
                Write(ToStringHelper.ToStringWithCulture(dllname));
                Write("\")]\r\n          public static extern ");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.ReturnType));
                Write(" ");
                Write(ToStringHelper.ToStringWithCulture(elangFunc.Name));
                Write(ToStringHelper.ToStringWithCulture(
                    GetParametersWithType(elangFunc.ELangParameters)));
                Write(";\r\n\t\t ");
            }
            Write("        }\r\n}\r\n");
            return GenerationEnvironment.ToString();
        }

        public string GetFuncSummary(ELangFunc func)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("/// <summary>");
            stringBuilder.AppendLine(string.Format("/// {0}", func.Summary));
            stringBuilder.AppendLine("/// </summary>");
            foreach (var elangParameter in func.ELangParameters)
                stringBuilder.AppendLine(string.Format("/// <param name=\"{0}\">{1}</param>",
                    elangParameter.Name, elangParameter.Summary));
            stringBuilder.AppendLine("/// <returns></returns>");
            return stringBuilder.ToString();
        }

        public string GetFuncDescription(ELangFunc func)
        {
            return $"[Description(\"{func.Summary}\")]";
        }

        public string GetParameters(ELangParameter[] ps)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("(");
            foreach (var p in ps)
            {
                stringBuilder.Append(p.Name);
                if (ps.Last().Name != p.Name)
                    stringBuilder.Append(",");
            }
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        public string GetParametersWithType(ELangParameter[] ps)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("(");
            foreach (var p in ps)
            {
                stringBuilder.AppendFormat("[Description(\"{2}\")] {0} {1}", p.Type, p.Name,p.Summary);
                if (ps.Last().Name != p.Name)
                    stringBuilder.Append(",");
            }
            stringBuilder.Append(")");
            return stringBuilder.ToString();
        }

        public virtual void Initialize()
        {
            if (Errors.HasErrors)
                return;
            var flag1 = false;
            if (Session.ContainsKey("elangFuncs"))
            {
                elangFuncs = (IEnumerable<ELangFunc>) Session["elangFuncs"];
                flag1 = true;
            }
            if (!flag1)
            {
                var data = CallContext.LogicalGetData("elangFuncs");
                if (data != null)
                    elangFuncs = (IEnumerable<ELangFunc>) data;
            }
            var flag2 = false;
            if (Session.ContainsKey("dllname"))
            {
                dllname = (string) Session["dllname"];
                flag2 = true;
            }
            if (!flag2)
            {
                var data = CallContext.LogicalGetData("dllname");
                if (data != null)
                    dllname = (string) data;
            }
        }
    }
}