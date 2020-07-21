using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SocketTalker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            new FormServer().Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            new FormClient().Show();
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            new FormTool().Show();
        }

        private void lnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://surfsky.cnblogs.com");
        }

    }
}
