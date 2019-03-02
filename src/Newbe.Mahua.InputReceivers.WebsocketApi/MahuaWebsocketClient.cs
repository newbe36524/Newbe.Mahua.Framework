using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.IO;
using Newbe.Mahua.IpcShared.WebsocketApi;
using Newtonsoft.Json;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    internal class MahuaWebsocketClient : IMahuaWebsocketClient
    {
        public delegate MahuaWebsocketClient Factory(WebSocket webSocket);

        private readonly IMahuaCenter _mahuaCenter;
        private readonly WebSocket _webSocket;

        public MahuaWebsocketClient(
            WebSocket webSocket,
            IMahuaCenter mahuaCenter)
        {
            _mahuaCenter = mahuaCenter;
            _webSocket = webSocket;
        }

        public async Task Start()
        {
            var buffer = new byte[1024 * 4];
            var recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();
            WebSocketReceiveResult result = null;
            do
            {
                string inputString;
                using (var stream = recyclableMemoryStreamManager.GetStream())
                {
                    do
                    {
                        result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                        await stream.WriteAsync(buffer, 0, result.Count);
                    } while (!result.EndOfMessage);

                    inputString = Encoding.UTF8.GetString(stream.ToArray());
                }

                if (!string.IsNullOrEmpty(inputString))
                {
                    var input = JsonConvert.DeserializeObject<WebsocketInput>(inputString);
                    await _mahuaCenter.HandleMahuaInput(input);
                }
            } while (!result.CloseStatus.HasValue);


            await _webSocket.CloseAsync(result.CloseStatus.Value, result.CloseStatusDescription,
                CancellationToken.None);
        }

        public Task SendOutput(IOutput output)
        {
            var json = JsonConvert.SerializeObject(output);
            var bytes = Encoding.UTF8.GetBytes(json);
            return _webSocket.SendAsync(new ArraySegment<byte>(bytes), 0, true, CancellationToken.None);
        }
    }
}