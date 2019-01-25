using System.Collections.ObjectModel;

namespace Newbe.Mahua
{
    /// <summary>
    /// Mahua 传入参数
    /// </summary>
    public interface IInput
    {
        string TypeCode { get; }
        MahuaPlatform MahuaPlatform { get; }
        ReadOnlyDictionary<string, object> Data { get; }
    }
}