namespace Newbe.Mahua.QQLight.NativeApi
{
    public interface IQqLightAuthCodeContainer
    {
        string AuthCode { get; set; }

        void Save();

        void Load();
    }
}
