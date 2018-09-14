using System;
using System.IO;

namespace Newbe.Mahua.CQP.Native
{
    internal class CqpAuthCodeContainer : ICqpAuthCodeContainer
    {
        public int AuthCode { get; set; }

        private static readonly string TempFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "cqpcode.txt");
        public void Save()
        {
            File.WriteAllText(TempFileName, AuthCode.ToString());
        }

        public void Load()
        {
            if (File.Exists(TempFileName))
            {
                AuthCode = int.Parse(File.ReadAllText(TempFileName));
                File.Delete(TempFileName);
            }
        }
    }
}
