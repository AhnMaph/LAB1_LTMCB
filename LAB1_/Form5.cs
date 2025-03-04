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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private bool check(string txt)
        {
            return txt.Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .All(x => double.TryParse(x, out double num) && num > 0&& num<11);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!check(textBox1.Text))
            {
                MessageBox.Show("List điểm không hợp lệ");
                return;
            }
            double[] arr = textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).ToArray();
            
            double avg = 0,min=11,max=0;
            foreach (double num in arr) {
                avg += num;
                if (num < min) min = num;
                if (num > max) max = num;
            }
            
            for (int i = 0;i<arr.Length;i++)
            {
                if(arr)
            }    
        }
    }
}
