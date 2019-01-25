namespace Newbe.Mahua.CQP.Native
{
    internal class CqpAuthCodeContainer : ICqpAuthCodeContainer
    {
        public int AuthCode
        {
            get => StaticAuthCode;
        }

        public static int StaticAuthCode { get; set; }
    }
}