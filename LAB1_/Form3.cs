using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool checkInt(string txt, string num)
        {
            long n;
            bool res = Int64.TryParse(txt, out n);
            if (!res)
            {
                MessageBox.Show("Vui lòng nhập số");
                return false;
            }
            return true;
        }

        private string xuLyBlock(string block, int cBlock, int mBlock)
        {
            string[] so = ["không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín", "mười"];
            string[] donvi = ["trăm", "mươi", ""];
            
            if (block[0] =='0' && block[1] == '0' && block[2] == '0') return "";

            string res = "";
            for (int j = 0; j < block.Length; j++)
            {
                if (block[j] == '0')
                {
                    if (cBlock == mBlock || j != 0)
                        continue;
                    else
                        res += "không trăm ";
                }
                else
                    if (j == 1 && block[j] == '1')
                    {
                        res += "mười ";
                    }
                    else if (j == 2 && (block[j - 1] == '0' || block[j - 2] == '0'))
                    {
                        if (cBlock == mBlock)
                        {
                            if (block[j - 1] == '0' && block[j - 2] != '0')
                                res += "lẻ " + so[block[j] - '0'] + " ";
                            else if (block[j - 1] == '0' && block[j - 2] == '0')
                                res += so[block[j] - '0'] + " ";
                            else
                                 if (block[j - 1] != '0')
                                    {
                                        if (block[j] == '5')
                                            res += "lăm ";
                                        else if (block[j] == '1'&& block[j - 1] != '1')
                                            res += "mốt ";
                                        else
                                            res += so[block[j] - '0'] + " ";
                                    }
                        }
                        else
                        {
                            if (block[j - 1] == '0')
                            {
                                res += "lẻ " + so[block[j] - '0'] + " ";
                            }
                            else
                            {
                                if (block[j] == '5')
                                    res += "lăm ";
                            else if (block[j] == '1'&& block[j-1]!='1')
                                res += "mốt -";
                            else
                                    res += so[block[j] - '0'] + " ";
                            }
                        }
                    }
                    else
                    {
                        if (j==2 && block[j] == '1' && block[j-1] != '1') 
                            res += "mốt ";
                        else
                        {
                            res += so[block[j] - '0'] + " ";
                            if (donvi[j] != "")
                                res += donvi[j] + " ";
                        }
                    }
            }
            return res;
        }

        private void readb_Click(object sender, EventArgs e)
        {
            string[] donvi = ["trăm", "nghìn", "triệu", "tỷ"];
            // 101 -> 1 trăm lẻ 1
            // 111 -> 1 trăm mười 1
            // 100
            // 1000 1 ngìn
            // 1001 1 ngìn lẻ 1
            // 1100 1 ngìn 100 trăm

            string num = numBox.Text;

            bool check = checkInt(num, num);
            if (!check)
                return;

            int cBlock = 0;
            while(num[0] == '0' && num.Length > 1)
            {
                num = num.Substring(1);
            }
            while (num.Length % 3 != 0)
            {
                num = "0" + num;
            }

            for (int i = 0; i < num.Length; i += 3)
                cBlock += 1;

            string res = "";
            int mBlock = cBlock;

            for (int i = 0; i < num.Length; i += 3)
            {
                string block = num.Substring(i, 3);
                if (cBlock == 0)
                    break;

                res += xuLyBlock(block, cBlock, mBlock);
                if (cBlock > 1)
                    res += donvi[cBlock - 1] + " ";

                cBlock -= 1;
            }

            if (res == "")
                res = "Không";

            res = res.Substring(0, 1).ToUpper() + res.Substring(1);
            resBox.Text = res;

        }

        private void clearb_Click(object sender, EventArgs e)
        {
            numBox.Clear();
            resBox.Clear();
        }

        private void closeb_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

