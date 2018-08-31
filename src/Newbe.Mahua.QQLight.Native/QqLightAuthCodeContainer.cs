using Newbe.Mahua.QQLight.NativeApi;
using System;
using System.IO;

namespace Newbe.Mahua.QQLight.Native
{
    internal class QqLightAuthCodeContainer : IQqLightAuthCodeContainer
    {
        public string AuthCode { get; set; }

        private static readonly string TempFileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "qqlightcode.txt");
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
