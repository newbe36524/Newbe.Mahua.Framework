// Decompiled with JetBrains decompiler
// Type: Newbe.Tools.ELang2CSharp.NativeMethodBase
// Assembly: Newbe.Tools.ELang2CSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 62AA77D5-9712-46DA-939A-E91A7F96C1CF
// Assembly location: D:\Codes\新建文件夹\Newbe.Tools.ELang2CSharp.exe

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Newbe.Tools.ELang2CSharp
{
    [GeneratedCode("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public class NativeMethodBase
    {
        private bool endsWithNewline;
        private CompilerErrorCollection errorsField;

        private StringBuilder generationEnvironmentField;
        private List<int> indentLengthsField;

        protected StringBuilder GenerationEnvironment
        {
            get
            {
                if (generationEnvironmentField == null)
                    generationEnvironmentField = new StringBuilder();
                return generationEnvironmentField;
            }
            set => generationEnvironmentField = value;
        }

        public CompilerErrorCollection Errors
        {
            get
            {
                if (errorsField == null)
                    errorsField = new CompilerErrorCollection();
                return errorsField;
            }
        }

        private List<int> indentLengths
        {
            get
            {
                if (indentLengthsField == null)
                    indentLengthsField = new List<int>();
                return indentLengthsField;
            }
        }

        public string CurrentIndent { get; private set; } = "";

        public virtual IDictionary<string, object> Session { get; set; }

        public ToStringInstanceHelper ToStringHelper { get; } = new ToStringInstanceHelper();

        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
                return;
            if (GenerationEnvironment.Length == 0 || endsWithNewline)
            {
                GenerationEnvironment.Append(CurrentIndent);
                endsWithNewline = false;
            }
            if (textToAppend.EndsWith(Environment.NewLine, StringComparison.CurrentCulture))
                endsWithNewline = true;
            if (CurrentIndent.Length == 0)
            {
                GenerationEnvironment.Append(textToAppend);
            }
            else
            {
                textToAppend = textToAppend.Replace(Environment.NewLine, Environment.NewLine + CurrentIndent);
                if (endsWithNewline)
                    GenerationEnvironment.Append(textToAppend, 0,
                        textToAppend.Length - CurrentIndent.Length);
                else
                    GenerationEnvironment.Append(textToAppend);
            }
        }

        public void WriteLine(string textToAppend)
        {
            Write(textToAppend);
            GenerationEnvironment.AppendLine();
            endsWithNewline = true;
        }

        public void Write(string format, params object[] args)
        {
            Write(string.Format(CultureInfo.CurrentCulture, format, args));
        }

        public void WriteLine(string format, params object[] args)
        {
            WriteLine(string.Format(CultureInfo.CurrentCulture, format, args));
        }

        public void Error(string message)
        {
            Errors.Add(new CompilerError
            {
                ErrorText = message
            });
        }

        public void Warning(string message)
        {
            Errors.Add(new CompilerError
            {
                ErrorText = message,
                IsWarning = true
            });
        }

        public void PushIndent(string indent)
        {
            if (indent == null)
                throw new ArgumentNullException("indent");
            CurrentIndent = CurrentIndent + indent;
            indentLengths.Add(indent.Length);
        }

        public string PopIndent()
        {
            var str = "";
            if (indentLengths.Count > 0)
            {
                var indentLength = indentLengths[indentLengths.Count - 1];
                indentLengths.RemoveAt(indentLengths.Count - 1);
                if (indentLength > 0)
                {
                    str = CurrentIndent.Substring(CurrentIndent.Length - indentLength);
                    CurrentIndent =
                        CurrentIndent.Remove(CurrentIndent.Length - indentLength);
                }
            }
            return str;
        }

        public void ClearIndent()
        {
            indentLengths.Clear();
            CurrentIndent = "";
        }

        public class ToStringInstanceHelper
        {
            private IFormatProvider formatProviderField = CultureInfo.InvariantCulture;

            public IFormatProvider FormatProvider
            {
                get => formatProviderField;
                set
                {
                    if (value == null)
                        return;
                    formatProviderField = value;
                }
            }

            public string ToStringWithCulture(object objectToConvert)
            {
                if (objectToConvert == null)
                    throw new ArgumentNullException("objectToConvert");
                var method = objectToConvert.GetType().GetMethod("ToString", new Type[1]
                {
                    typeof(IFormatProvider)
                });
                if (method == null)
                    return objectToConvert.ToString();
                return (string) method.Invoke(objectToConvert, new object[1]
                {
                    formatProviderField
                });
            }
        }
    }
}