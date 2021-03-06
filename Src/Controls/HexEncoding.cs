﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTalker
{
    /// <summary>
    /// 16 进制编码器
    /// </summary>
    public class HexEncoding : ASCIIEncoding
    {
        public static HexEncoding Instance = new HexEncoding();

        public override byte[] GetBytes(string s)
        {
            return Kingsoc.StringHelper.ToHexBytes(s);
        }

        public override string GetString(byte[] bytes)
        {
            return Kingsoc.StringHelper.ToHexString(bytes);
        }

        public override string EncodingName
        {
            get { return "HEX"; }
        }

        public override string ToString()
        {
            return "HEX";
        }
    }
}
