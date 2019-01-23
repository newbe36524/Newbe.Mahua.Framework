namespace Newbe.Mahua.QQLight.Native
{
    internal class QqLightAuthCodeContainer : IQqLightAuthCodeContainer
    {
        public string AuthCode
        {
            get => StaticAuthCode;
        }

        public static string StaticAuthCode { get; set; }
    }
}