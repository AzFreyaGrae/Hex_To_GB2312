using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hex_To_GB2312
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // GB2312转换成16进制
            string gb2312Str = richTextBox1.Text;
            byte[] gb2312Bytes = System.Text.Encoding.GetEncoding("GB2312").GetBytes(gb2312Str);
            string hexStr = BitConverter.ToString(gb2312Bytes);
            richTextBox2.Text = hexStr;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 16进制转换成GB2312
            string hexStr = richTextBox1.Text;
            string[] hexStrs = hexStr.Split('-');
            byte[] hexBytes = new byte[hexStrs.Length];
            for (int i = 0; i < hexStrs.Length; i++)
            {
                hexBytes[i] = Convert.ToByte(hexStrs[i], 16);
            }
            string gb2312Str = System.Text.Encoding.GetEncoding("GB2312").GetString(hexBytes);
            richTextBox2.Text = gb2312Str;
        }
    }
}
