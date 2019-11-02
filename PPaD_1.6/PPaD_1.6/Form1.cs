using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPaD_1._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = BinaryHelper.ToBinary(Convert.ToInt32(textBox1.Text));
            }
            if (radioButton2.Checked)
            {
                label2.Text = BinaryHelper.ToBinary(Convert.ToInt32(textBox1.Text));
            }
            if (radioButton3.Checked)
            {
                label2.Text = BinaryHelper.ToDopBinary(Convert.ToInt32(textBox1.Text));
            }
            if (radioButton4.Checked)
            {
                label2.Text = BinaryHelper.ToIEEE754(Convert.ToInt32(textBox1.Text)).ToString();
            }
            if (radioButton5.Checked)
            {
                label2.Text = BinaryHelper.ToIEEE754(Convert.ToInt32(textBox1.Text)).ToString();
            }
        }
    }
}
