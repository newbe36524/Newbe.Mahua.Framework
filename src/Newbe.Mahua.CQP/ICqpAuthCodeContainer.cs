namespace Newbe.Mahua.CQP
{
    public interface ICqpAuthCodeContainer
    {
        int AuthCode { get; set; }

        void Save();

        void Load();
    }
}
