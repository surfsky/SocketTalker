using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Kingsoc.Net.SocketKit;

namespace SocketTalker
{
    public partial class FormServer : Form
    {
        SocketServer _server = new SocketServer();  // Socket服务器组件
        Encoding _encoding = Encoding.UTF8;         // 传输文本时用的编码器

        //------------------------------------------------
        // 构造析构
        //------------------------------------------------
        public FormServer()
        {
            InitializeComponent();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {
            ShowCurrentIP(this.cmbServerIP);
            InitServer();
            this.groupSend.Enabled = false;
        }

        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            _server.StopListen();
        }

        //------------------------------------------------
        // 窗体事件
        //------------------------------------------------
        // 编码变更
        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._encoding = this.cmbCoding.Encoding;
        }

        // 开始监听
        private void btnStartListen_Click(object sender, EventArgs e)
        {
            string ip = this.cmbServerIP.SelectedItem.ToString();
            int port = int.Parse(this.tbServerPort.Text);
            _server.Listen(ip, port);
            this.groupSend.Enabled = true;
        }

        // 停止监听
        private void btnStopListen_Click(object sender, EventArgs e)
        {
            _server.StopListen();
            this.groupSend.Enabled = false;
        }

        // 发送消息
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.tbText.Text == "") return;
            if (lbClients.SelectedItems.Count == 0)
            {
                MessageBox.Show(this, "请先选择一个客户端");
                return;
            }

            foreach (SocketInfo item in lbClients.SelectedItems)
            {
                _server.SendToClient(item.Index, this._encoding.GetBytes(this.tbText.Text));
            }
        }

        //------------------------------------------------
        // 辅助
        //------------------------------------------------
        // 显示当前IP地址
        void ShowCurrentIP(ComboBox cmb)
        {
            cmb.DataSource = GetIPs();
            cmb.SelectedIndex = 0;
        }

        // 获取当前电脑IP地址列表
        public static List<string> GetIPs()
        {
            List<string> arr = new List<string>();
            arr.Add("127.0.0.1");
            IPAddress[] ips = Dns.Resolve(Dns.GetHostName()).AddressList;
            foreach (IPAddress ip in ips)
                arr.Add(ip.ToString());
            return arr;
        }

        // 初始化服务器
        void InitServer()
        {
            _server.OnError     += (a) => logger.Log("Error", null, this._encoding, a.Msg, a.Index);
            _server.OnSended    += (a) => logger.Log("Send", a.Bytes, this._encoding, "", a.Index);
            _server.OnReceived  += (a) => logger.Log("Receive", a.Bytes, this._encoding, "", a.Index);
            _server.OnListening += (a) => logger.Log("Listening", null, this._encoding, a.Addr, "");
            _server.OnClosed += () =>
            {
                ShowClients();
                logger.Log("Closed", null, this._encoding, "", "");
            };
            _server.OnClientAccepted += (a) =>
            {
                ShowClients();
                logger.Log("AcceptClient", null, this._encoding, a.Addr, a.Index);
            };
            _server.OnClientClosed += (a) =>
           {
               ShowClients();
               logger.Log("CloseClient", null, this._encoding, "", a.Index);
           };
        }

        // 显示所有客户端
        void ShowClients()
        {
            this.Invoke((Action)delegate ()
            {
                lbClients.Items.Clear();
                foreach (SocketInfo si in _server.SocketAccepts)
                {
                    lbClients.Items.Add(si);
                }
            });
        }


    }
}
