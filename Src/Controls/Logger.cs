using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTalker.Controls
{
    /// <summary>
    /// 通讯日志UI控件
    /// </summary>
    public partial class Logger : UserControl
    {
        public Logger()
        {
            InitializeComponent();
        }

        private void Logger_Load(object sender, EventArgs e)
        {

        }


        // 日志
        /*
        public void Log(LogItem item)
        {
            Action<LogItem> action = (data) =>
            {
                this.lbLog.Items.Add(data);
            };
            this.Invoke(action, item);
        }
        */

        public void Log(string type, byte[] bytes, Encoding encoding, string remark, object tag)
        {
            LogItem item = new LogItem(type, bytes, encoding, remark, tag);
            Action<LogItem> action = (data) =>
            {
                this.lbLog.Items.Add(data);
            };
            this.Invoke(action, item);
        }

        //-----------------------------------------------
        // 显示日志详情
        //-----------------------------------------------
        // 清空日志
        private void btnClearLog_Click(object sender, EventArgs e)
        {
            this.lbLog.Items.Clear();
        }

        // 显示日志
        private void lbLog_SelectedIndexChanged(object sender, EventArgs e)
        {
            LogItem data = this.lbLog.SelectedItem as LogItem;
            tbText.SetEncoding(data.Encoding);
            ShowLogItem();
        }



        void ShowLogItem()
        {
            LogItem data = this.lbLog.SelectedItem as LogItem;
            tbText.Bytes = data.Bytes;
        }


    }
}
