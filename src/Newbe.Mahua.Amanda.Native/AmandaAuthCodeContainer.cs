using Newbe.Mahua.Amanda.NativeApi;
using System;
using System.IO;

namespace Newbe.Mahua.Amanda.Native
{
    internal class AmandaAuthCodeContainer : IAmandaAuthCodeContainer
    {
        public string AuthCode { get; set; }

        private static readonly string TempFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "amandacode.txt");
        public void Save()
        {
            File.WriteAllText(TempFileName, AuthCode);
        }

        public void Load()
        {
            if (File.Exists(TempFileName))
            {
                AuthCode = File.ReadAllText(TempFileName);
                File.Delete(TempFileName);
            }
        }
    }
}
