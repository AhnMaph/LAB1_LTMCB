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
            return txt.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .All(x => double.TryParse(x, out double num) && num > 0 && num < 11);
        }

        private string getRank(double avg, double[] mark)
        {
            // Count subjects which have mark < key in Dictionary
            Dictionary<double, int> under_score = new Dictionary<double, int>();
            under_score.Add(2, 0);
            under_score.Add(3.5, 0);
            under_score.Add(5, 0);
            under_score.Add(6.5, 0);

            foreach (double num in mark)
            {
                foreach (double key in under_score.Keys)
                {
                    if (num < key)
                    {
                        under_score[key]++;
                    }
                }
            }

            if (avg >= 8)
            {
                if (under_score[6.5] == 0) return "Giỏi";
            }

            if (avg >= 6.5)
            {
                if (under_score[5] == 0) return "Khá";
            }

            if (avg >= 5)
            {
                if (under_score[3.5] == 0) return "Trung Bình";
            }

            if (avg >= 3.5)
            {
                if (under_score[2] == 0) return "Yếu";
            }

            return "Kém";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear list view every time button is clicked
            listView1.Items.Clear();

            if (!check(textBox1.Text))
            {
                MessageBox.Show("List điểm không hợp lệ");
                return;
            }
            double[] arr = textBox1.Text.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x)).ToArray();

            listView1.View = View.List;

            for (int i = 0; i < arr.Length; i++)
            {
                ListViewItem item = new ListViewItem("Môn " + (i + 1) + ": " + arr[i]);
                Font itemFont = new Font("Times New Roman", 11, FontStyle.Bold);
                item.Font = itemFont;
                listView1.Items.Add(item);
            }

            double avg = 0;

            Array.Sort(arr);

            double min = arr[0];
            double max = arr[arr.Length - 1];

            foreach (double num in arr)
            {
                avg += num;
            }

            avg /= arr.Length;

            int subPass = 0, subFail = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 5) subPass++;
                else subFail++;
            }

            diemTB.Text = "Điểm: " + Math.Round(avg, 2);
            diemMax.Text = "Điểm cao nhất: " + max;
            diemMin.Text = "Điểm thấp nhất: " + min;
            monPass.Text = "Số môn đậu: " + subPass;
            monFail.Text = "Số môn không đậu: " + subFail;
            rank.Text = "Xếp loại: " + getRank(avg, arr);

        }
    }
}
