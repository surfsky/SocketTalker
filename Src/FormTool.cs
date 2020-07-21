using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTalker
{
    public partial class FormTool : Form
    {
        public FormTool()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Encoding encoding = this.encodingBox1.Encoding;
            this.tbText2.Bytes = encoding.GetBytes(this.tbText1.Text);
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            byte[] bytes = this.tbText2.Bytes;
            string key = this.tbXorKey.Text;
            Encoding encoding = this.encodingBox2.Encoding;
            byte[] keys = encoding.GetBytes(key);

            this.tbText3.SetEncoding(HexEncoding.Instance);
            this.tbText3.Bytes = Kingsoc.EncryptHelper.XOR(bytes, keys);
        }
    }
}
