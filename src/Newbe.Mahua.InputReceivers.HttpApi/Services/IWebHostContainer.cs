using Microsoft.AspNetCore.Hosting;

namespace Newbe.Mahua.InputReceivers.HttpApi.Services
{
    public interface IWebHostContainer
    {
        IWebHost CreateInstance(HttpApiConfig config);
    }
}