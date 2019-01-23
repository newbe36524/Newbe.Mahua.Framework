using System.Threading.Tasks;

namespace Newbe.Mahua
{
    /// <summary>
    /// 处理Mahua所有的传入和传出数据
    /// </summary>
    public interface IMahuaCenter
    {
        Task HandleMahuaOutput(IOutput output);

        Task HandleMahuaInput(IInput input);
    }
}