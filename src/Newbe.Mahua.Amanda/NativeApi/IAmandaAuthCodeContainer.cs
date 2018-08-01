namespace Newbe.Mahua.Amanda.NativeApi
{
    public interface IAmandaAuthCodeContainer
    {
        string AuthCode { get; set; }

        void Save();

        void Load();
    }
}
