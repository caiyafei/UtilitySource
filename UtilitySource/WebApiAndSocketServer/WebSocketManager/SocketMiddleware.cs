using Microsoft.AspNetCore.Http;
using System;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiAndSocketServer.WebSocketManager
{
    public class SocketMiddleware
    {
        private readonly RequestDelegate _next;
        private SocketHandler Handler { get; set; }
        public SocketMiddleware(RequestDelegate next, SocketHandler handler)
        {
            _next = next;
            Handler = handler;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.WebSockets.IsWebSocketRequest)
                return;
            else
            {
                WebSocket socket = await context.WebSockets.AcceptWebSocketAsync();
                Handler.OnConnected(socket);
                await Receive(socket,async (result, buffer) => 
                {
                    if(result.MessageType== WebSocketMessageType.Text)
                    {
                        await Handler.Receive(socket, result,buffer);
                    }
                    else if(result.MessageType== WebSocketMessageType.Close)
                    {
                        Handler.OnDisConnected(socket);
                    }
                });
            }
        }

        public async Task Receive(WebSocket socket,Action<WebSocketReceiveResult,byte[]> action)
        {
            var buffer = new byte[1024 * 4];
            while(socket.State== WebSocketState.Open)
            {
                var result =await socket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                action(result, buffer);
            }
        }
    }

    public class WebSocketHandler : SocketHandler
    {
        public WebSocketHandler(ConnectionManager connection) : base(connection)
        {
        }

        public override async Task Receive(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            //具体实现服务端接收消息后的操作
            var key = Connection.GetWebSocketKey(socket);
            var msg = key+":"+ Encoding.UTF8.GetString(buffer, 0, result.Count);
            await SendMsg(socket, msg);
        }
    }
}
