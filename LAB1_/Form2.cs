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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private bool checkInt(string num, ref Int32 num1)
        {
            bool b1 = Int32.TryParse(num, out num1);
            if (!b1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên");
                return false;
            }
            return true;
        }
        private void clickBoxAns(object sender, EventArgs e)
        {
            Int32 num1 = 0, num2 = 0, num3 = 0;
            if(!checkInt(textBox1.Text,ref num1) ||
                !checkInt(textBox2.Text, ref num2)||
                !checkInt(textBox3.Text, ref num3))
                return;
            Int32 max_ans = Math.Max(num1, Math.Max(num2,num3));
            Int32 min_ans = Math.Min(num1, Math.Min(num2, num3));
            textBoxMin.Text = min_ans.ToString();
            textBoxMax.Text = max_ans.ToString();
        }
        private void clickBoxDel(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBoxMin.Clear();
            textBoxMax.Clear();
        }
        private void clickBoxOut(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
