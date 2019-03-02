using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newbe.Mahua.IpcShared.WebsocketApi;

namespace Newbe.Mahua.InputReceivers.WebsocketApi
{
    public class MahuaMiddleware : IMiddleware
    {
        private readonly IMahuaWebsocketClientManager _mahuaWebsocketClientManager;
        private readonly IMahuaCenter _mahuaCenter;

        public MahuaMiddleware(
            IMahuaWebsocketClientManager mahuaWebsocketClientManager,
            IMahuaCenter mahuaCenter)
        {
            _mahuaWebsocketClientManager = mahuaWebsocketClientManager;
            _mahuaCenter = mahuaCenter;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Path == "/ws")
            {
                if (context.WebSockets.IsWebSocketRequest)
                {
                    var webSocket = await context.WebSockets.AcceptWebSocketAsync();
                    var websocketClient = new MahuaWebsocketClient(webSocket, _mahuaCenter);
                    await _mahuaWebsocketClientManager.StartNew(websocketClient);
                }
                else
                {
                    context.Response.StatusCode = 400;
                }
            }
            else
            {
                await next(context);
            }
        }
    }
}