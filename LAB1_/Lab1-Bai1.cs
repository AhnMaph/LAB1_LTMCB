using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkInt(ref Int32 num1, ref Int32 num2)
        {
            bool b1 = Int32.TryParse(numBox1.Text, out num1);
            bool b2 = Int32.TryParse(numBox2.Text, out num2);
            if (!b1 || !b2)
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 num1 = 0;
            Int32 num2 = 0;

            if (!checkInt(ref num1, ref num2))
            {
                return;
            }

            double total = 0;
            total = total + num1 + num2;

            resBox.Text = total.ToString();

        }

        private void minusb_Click(object sender, EventArgs e)
        {
            Int32 num1 = 0;
            Int32 num2 = 0;

            if (!checkInt(ref num1, ref num2))
            {
                return;
            }

            double total = 0;
            total = total + num1 - num2;

            resBox.Text = total.ToString();
        }

        private void mulb_Click(object sender, EventArgs e)
        {
            Int32 num1 = 0;
            Int32 num2 = 0;

            if (!checkInt(ref num1, ref num2))
            {
                return;
            }

            double total = 0;
            total = (total + num1) * num2;

            resBox.Text = total.ToString();
        }

        private void divb_Click(object sender, EventArgs e)
        {
            Int32 num1 = 0;
            Int32 num2 = 0;

            if (!checkInt(ref num1, ref num2))
            {
                return;
            }

            if (num2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0");
                return;
            }

            double total = 0;
            total = (total + num1) / num2;


            resBox.Text = total.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            numBox1.Text = "";
            numBox2.Text = "";
            resBox.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
