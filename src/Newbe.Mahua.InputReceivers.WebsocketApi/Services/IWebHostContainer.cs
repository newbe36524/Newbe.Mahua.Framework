using Microsoft.AspNetCore.Hosting;

namespace Newbe.Mahua.InputReceivers.WebsocketApi.Services
{
    public interface IWebHostContainer
    {
        IWebHost CreateInstance(WebsocketApiConfig config);
    }
}