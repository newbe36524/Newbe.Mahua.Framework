using System.Threading.Tasks;

namespace Newbe.Mahua.IpcShared.WebsocketApi
{
    public interface IMahuaWebsocketClient
    {
        Task Start();
        Task SendOutput(IOutput output);
    }
}