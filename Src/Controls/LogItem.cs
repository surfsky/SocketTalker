using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTalker.Controls
{
    /// <summary>
    /// Socket 通讯日志项
    /// </summary>
    public class LogItem
    {
        public DateTime Time { get; set; }
        public string Type { get; set; }
        public Byte[] Bytes { get; set; }
        public Encoding Encoding { get; set; }
        public string Info { get; set; }
        public object Tag { get; set; }


        public int Length
        {
            get { return Bytes==null ? 0 : Bytes.Length; }
        }

        public String Text
        {
            get { return Bytes==null ? "" : this.Encoding.GetString(this.Bytes); }
            set { this.Bytes = this.Encoding.GetBytes(value); }
        }


        public LogItem(string type, byte[] bytes, Encoding encoding, string info, object tag)
        {
            this.Type = type;
            this.Tag = tag;
            this.Time = DateTime.Now;
            this.Bytes = bytes;
            this.Encoding = encoding;
            this.Info = info;
        }

        public override string ToString()
        {
            return string.Format("{0:HH:mm:ss} {1} [{2}] ({3:000}) : {4} {5}",
                this.Time,
                this.Type,
                this.Tag,
                this.Length,
                this.Text,
                this.Info
                );
        }
    }

}
