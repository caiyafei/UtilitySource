using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;

namespace WebApiAndSocketServer.WebSocketManager
{
    public class ConnectionManager
    {
        private Dictionary<string, WebSocket> websockets = new Dictionary<string, WebSocket>();

        public WebSocket GetWebSocketByKey(string key)
        {
            return websockets.FirstOrDefault(s => s.Key == key).Value;
        }

        public Dictionary<string, WebSocket> GetAllWebSocket()
        {
            return websockets;
        }

        public string GetWebSocketKey(WebSocket webSocket)
        {
            return websockets.FirstOrDefault(s => s.Value == webSocket).Key;
        }

        public void RemoveWebSocket(string key)
        {
            websockets.Remove(key, out WebSocket socket);
            socket.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "连接关闭", CancellationToken.None);
        }

        public void AddWebSocket(WebSocket socket)
        {
            websockets.TryAdd(GetDictionaryKey(), socket);
        }

        private string GetDictionaryKey()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
