using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTalker.Controls
{
    /// <summary>
    /// 显示和获取Encoding的UI组件
    /// </summary>
    public partial class EncodingBox : ComboBox
    {
        public EncodingBox()
        {
            InitializeComponent();
        }

        public EncodingBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ShowEncodings(this);
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Encoding Encoding
        {
            get { return GetEncoding(this); }
            set { SetEncoding(this, value); }
        }


        //-------------------------------------------------
        // 显示支持的字符集编码
        public static void ShowEncodings(ComboBox cmb)
        {
            //var encodings = Encoding.GetEncodings();
            //cmb.DataSource = encodings;
            cmb.Items.Clear();
            cmb.Items.Add("UTF-8");
            cmb.Items.Add("Unicode");
            cmb.Items.Add("GB2312");
            cmb.Items.Add("ASCII");
            cmb.Items.Add("HEX");

            cmb.SelectedIndex = 0;
        }

        // 获取当前选择的字符集编码
        public static Encoding GetEncoding(ComboBox cmb)
        {
            var obj = cmb.SelectedItem;
            var txt = obj.ToString();
            switch (txt)
            {
                case "UTF-8": return Encoding.UTF8;
                case "Unicode": return Encoding.Unicode;
                case "GB2312": return Encoding.GetEncoding("GB2312");
                case "ASCII": return Encoding.ASCII;
                case "HEX": return HexEncoding.Instance;
                default: return Encoding.UTF8;
            }
        }

        public static void SetEncoding(ComboBox cmb, Encoding encoding)
        {
            string txt = GetEncodingName(encoding);
            for (int i = 0; i < cmb.Items.Count; i++)
            {
                string enc = cmb.Items[i] as string;
                if (enc == txt)
                {
                    cmb.SelectedIndex = i;
                    return;
                }
            }
        }

        public static string GetEncodingName(Encoding encoding)
        {
            if (encoding == Encoding.UTF8) return "UTF-8";
            if (encoding == Encoding.Unicode) return "Unicode";
            if (encoding == Encoding.GetEncoding("GB2312")) return "GB2312";
            if (encoding == Encoding.ASCII) return "ASCII";
            if (encoding == HexEncoding.Instance) return "HEX";
            return "UTF-8";
        }
    }
}
