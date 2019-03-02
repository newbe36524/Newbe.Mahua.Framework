using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using Newbe.Mahua.Logging;

namespace Newbe.Mahua.IpcShared.WebsocketApi
{
    /// <summary>
    /// manage websocket client.
    /// NOTICE: using static class and fields , because it have to share instance between web ioc container and mahua ioc container.
    /// You can find register as singleton in Startup.cs and MahuaModule.cs , but they are different instance, because they are in different container. so using static fields to share instance.
    /// </summary>
    public class MahuaWebsocketClientManager : IMahuaWebsocketClientManager
    {
        private static readonly ConcurrentDictionary<long, IMahuaWebsocketClient>
            Clients = new ConcurrentDictionary<long, IMahuaWebsocketClient>();

        private static readonly ILog Logger = LogProvider.For<MahuaWebsocketClientManager>();

        private static Task StartNew(IMahuaWebsocketClient websocketClient)
        {
            Clients.TryAdd(DateTimeOffset.Now.ToUnixTimeMilliseconds(), websocketClient);
            return websocketClient.Start();
        }

        private static Task SendOutput(IOutput output)
        {
            return Task.WhenAll(Clients.Select(x => SendCore(x.Key, x.Value)));

            async Task SendCore(long key, IMahuaWebsocketClient client)
            {
                try
                {
                    await client.SendOutput(output);
                }
                catch (Exception e)
                {
                    // ignore all exception
                    Logger.WarnException("throw a exception when sending output", e);
                    Clients.TryRemove(key, out _);
                }
            }
        }

        Task IMahuaWebsocketClientManager.SendOutput(IOutput output)
        {
            return SendOutput(output);
        }

        Task IMahuaWebsocketClientManager.StartNew(IMahuaWebsocketClient websocketClient)
        {
            return StartNew(websocketClient);
        }
    }
}