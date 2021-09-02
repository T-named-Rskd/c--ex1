using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double x = 0;
        int y = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("输入");
            x = Convert.ToDouble(textBox1.Text);
            if (textBox2.Text != "") textBox3.Text = (x * y).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("输入");
            y = Convert.ToInt32(textBox2.Text);
            if (textBox1.Text != "") textBox3.Text = (x * y).ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
