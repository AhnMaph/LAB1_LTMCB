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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private bool IsValidNumber(string num, int baseFrom)
        {
            string validChars = baseFrom == 2 ? "01" :
                                baseFrom == 10 ? "0123456789" :
                                baseFrom == 16 ? "0123456789ABCDEFabcdef" : "";

            foreach (char c in num)
            {
                if (!validChars.Contains(c))
                    return false;
            }
            return true;
        }
        private int GetBase(string text)
        {
            switch (text)
            {
                case "Decimal": return 10;
                case "Hex": return 16;
                case "Binary": return 2;
                default: return 0;
            }
        }
        private string ConvertBase(string number, int baseFrom, int baseTo)
        {
            int decimalValue = Convert.ToInt32(number, baseFrom); // Chuyển về thập phân
            return Convert.ToString(decimalValue, baseTo).ToUpper(); // Chuyển sang hệ mới
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            if(comboBox1.Text.Length == 0 ||
                comboBox2.Text.Length == 0 ||
                textBox1.Text.Length == 0)
                { 
                return; }
            int baseFrom = GetBase(comboBox1.Text);
            int baseTo = GetBase(comboBox2.Text);
            if (!IsValidNumber(num,baseFrom))    
            {
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                    return;
            }    
            
            
            string ans = ConvertBase(num,baseFrom, baseTo);
            
            textBox2.Text = ans;
            return;
        }
    }
}
