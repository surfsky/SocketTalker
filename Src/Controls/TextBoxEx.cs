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
    /// 基于二进制字节，可切换编码展示方式的文本框
    /// </summary>
    public partial class TextBoxEx : UserControl
    {
        protected byte[] bytes;
        public byte[] Bytes {
            get { return bytes; }
            set { this.bytes = value; ShowText(); }
        }

        public TextBoxEx()
        {
            InitializeComponent();
        }

        public void SetEncoding(Encoding encoding)
        {
            this.encodingBox.Encoding = encoding;
        }

        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowText();
        }

        protected void ShowText()
        {
            Encoding encoding = this.encodingBox.Encoding;
            if (encoding != null && Bytes != null)
                this.tbLog.Text = encoding.GetString(this.Bytes);
        }
    }
}
