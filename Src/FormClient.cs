using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kingsoc.Net.SocketKit;

namespace SocketTalker
{
    public partial class FormClient : Form
    {
        SocketClient _client = new SocketClient();  // Socket客户端组件
        Encoding _encoding = Encoding.UTF8;         // 传输文本时用的编码器


        //------------------------------------------------
        // 构造析构
        //------------------------------------------------
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            InitClient();
            this.groupSend.Enabled = false;
        }

        private void FormClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Disconnect();
        }

        //------------------------------------------------
        // 窗体事件
        //------------------------------------------------
        // 设置传输文本用的编码
        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._encoding = this.cmbCoding.Encoding;
        }

        // 连接
        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            _client.Connect(this.tbServerIP.Text, int.Parse(this.tbServerPort.Text));
            this.groupSend.Enabled = true;
        }

        // 断开
        private void btnDisconnect_Click(object sender, System.EventArgs e)
        {
            _client.Disconnect();
            this.groupSend.Enabled = false;
        }

        // 发送
        private void btnSend_Click(object sender, System.EventArgs e)
        {
            if (this.tbText.Text == "") return;
            _client.SendToServer(this._encoding.GetBytes(this.tbText.Text));
        }

        //------------------------------------------------
        // 辅助
        //------------------------------------------------
        // 初始化客户端
        void InitClient()
        {
            _client.OnError        += (a) => logger.Log("Error", null, this._encoding, a.Msg, a.Index);
            _client.OnReceived     += (a) => logger.Log("Receive", a.Bytes, this._encoding, "", a.Index);
            _client.OnSended       += (a) => logger.Log("Send", a.Bytes, this._encoding, "", a.Index);
            _client.OnConnected    += (a) => logger.Log("Connected", null, this._encoding, a.Addr, "");
            _client.OnDisconnected += ()  => logger.Log("Disconnected", null, this._encoding, "", "");
        }
    }
}
