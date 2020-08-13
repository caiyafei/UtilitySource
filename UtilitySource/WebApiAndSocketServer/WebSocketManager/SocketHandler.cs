using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiAndSocketServer.WebSocketManager
{
    public abstract class SocketHandler
    {
        public ConnectionManager Connection;
        public SocketHandler(ConnectionManager connection)
        {
            Connection = connection;
        }

        public virtual void OnConnected(WebSocket socket)
        {
            Connection.AddWebSocket(socket);
        }

        public virtual void OnDisConnected(WebSocket socket)
        {
            Connection.RemoveWebSocket(Connection.GetWebSocketKey(socket));
        }

        public async Task SendMsg(WebSocket socket, string msg)
        {
            if (socket.State != WebSocketState.Open)
                return;
            byte[] buffer = Encoding.UTF8.GetBytes(msg);
            await socket.SendAsync(new ArraySegment<byte>(buffer, 0, buffer.Length), WebSocketMessageType.Text, true, CancellationToken.None);
        }

        public async Task SendMsgToAll(string msg)
        {
            foreach (var item in Connection.GetAllWebSocket())
            {
                await SendMsg(item.Value, msg);
            }
        }

        public abstract Task Receive(WebSocket socket, WebSocketReceiveResult result,byte[] buffer);
    }
}
