using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_IP_Test
{
    public partial class Form_help : Form
    {
        public Form_help()
        {
            InitializeComponent();
        }

        private void Form_help_Load(object sender, EventArgs e)
        {
            var newline = Environment.NewLine;
            textBox_help.ReadOnly = true;
            textBox_help.Text = textBox_help.Text + "Guilde"+newline;
            textBox_help.Text = textBox_help.Text + "" + newline;
            textBox_help.Text = textBox_help.Text + "1. Enter a Host link to a TCP/IP HOST" + newline;
            textBox_help.Text = textBox_help.Text + "2. Click Start" + newline;

        }
    }
}
