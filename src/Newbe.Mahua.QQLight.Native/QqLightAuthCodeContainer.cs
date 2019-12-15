namespace Newbe.Mahua.QQLight.Native
{
    internal class QqLightAuthCodeContainer : IQqLightAuthCodeContainer
    {
        public int AuthCode
        {
            get => StaticAuthCode;
        }

        public static int StaticAuthCode { get; set; }
    }
}