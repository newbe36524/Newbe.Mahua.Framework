using System;

namespace Newbe.Mahua.Framework.CQP.NativeApi
{
    public interface ICqpAuthCodeContainer
    {
        int AuthCode { get; set; }
    }

    internal class CqpAuthCodeContainer : ICqpAuthCodeContainer
    {
        public int AuthCode { get; set; }
    }
}