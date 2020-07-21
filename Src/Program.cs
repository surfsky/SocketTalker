using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SocketTalker
{
    class Program
    {
        [STAThread]
        static void Main(string[] arg)
        {
            Application.Run(new FormMain());
        }
    }
}
