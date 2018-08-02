namespace Newbe.Mahua.CQP.NativeApi
{
    public interface ICqpAuthCodeContainer
    {
        int AuthCode { get; set; }

        void Save();

        void Load();
    }
}
