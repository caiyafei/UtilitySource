using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketClient
{
    public partial class Frm_Chat : XtraForm
    {
        ClientWebSocket client;
        public Frm_Chat()
        {
            InitializeComponent();
            client = new ClientWebSocket();
            btnConnect.Click += BtnConnect_Click;
            btnDisconnect.Click += BtnDisconnect_Click;
            btnSend.Click += BtnSend_Click;
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            await Send(txtMsg.Text);
        }

        private async void BtnDisconnect_Click(object sender, EventArgs e)
        {
            if (client.State ==  WebSocketState.Open)
            {
                await client.CloseOutputAsync(WebSocketCloseStatus.NormalClosure, "", CancellationToken.None);
            }
        }

        private async void BtnConnect_Click(object sender, EventArgs e)
        {
            if (client == null)
                await ConnectToServer();
        }

        private async Task ConnectToServer()
        {
            if (client.State!= WebSocketState.Open)
            {
                client = new ClientWebSocket();
                await client.ConnectAsync(new Uri("wss://localhost:44322/ws"), CancellationToken.None);
                meContent.Text += "连接成功！\r\n";
                //var send = Receive();
                await Task.WhenAll(Receive(client));
            }
        }

        private async Task Send(string msg)
        {
            if(client.State== WebSocketState.Open)
            {
                var buffer = Encoding.UTF8.GetBytes(msg);
                await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, true, CancellationToken.None);
            }
        }

        private async Task Receive(ClientWebSocket client)
        {
            byte[] buffer = new byte[1024 * 4];
            while(true)
            {
                var result =await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                string msg = Encoding.UTF8.GetString(buffer, 0, result.Count);
                if(result.MessageType== WebSocketMessageType.Close)
                {
                    meContent.Text +="连接关闭！\r\n";
                    break;
                }
                meContent.Text += msg + "\r\n";
            }
        }
    }
}
