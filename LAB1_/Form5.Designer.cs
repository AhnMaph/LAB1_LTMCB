namespace LAB1_
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            listView1 = new ListView();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            diemTB = new Label();
            diemMax = new Label();
            monPass = new Label();
            diemMin = new Label();
            monFail = new Label();
            rank = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(477, 79);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Điểm";
            // 
            // listView1
            // 
            listView1.Location = new Point(55, 262);
            listView1.Margin = new Padding(4, 3, 4, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(1002, 453);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(202, 36);
            label2.TabIndex = 2;
            label2.Text = "Dữ liệu điểm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 146);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(807, 39);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(885, 193);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(173, 49);
            button1.TabIndex = 4;
            button1.Text = "Xuất";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(55, 205);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(683, 31);
            label3.TabIndex = 5;
            label3.Text = "*Lưu ý: Nhập với định dạng danh sách ví dụ: 9.5 8 7 6 5 10\r\n";
            // 
            // diemTB
            // 
            diemTB.AutoSize = true;
            diemTB.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            diemTB.Location = new Point(55, 732);
            diemTB.Margin = new Padding(4, 0, 4, 0);
            diemTB.Name = "diemTB";
            diemTB.Size = new Size(140, 35);
            diemTB.TabIndex = 6;
            diemTB.Text = "Điểm TB:";
            // 
            // diemMax
            // 
            diemMax.AutoSize = true;
            diemMax.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            diemMax.Location = new Point(55, 790);
            diemMax.Margin = new Padding(4, 0, 4, 0);
            diemMax.Name = "diemMax";
            diemMax.Size = new Size(206, 35);
            diemMax.TabIndex = 7;
            diemMax.Text = "Điểm cao nhất:";
            // 
            // monPass
            // 
            monPass.AutoSize = true;
            monPass.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            monPass.Location = new Point(396, 732);
            monPass.Margin = new Padding(4, 0, 4, 0);
            monPass.Name = "monPass";
            monPass.Size = new Size(175, 35);
            monPass.TabIndex = 8;
            monPass.Text = "Số môn đậu:";
            // 
            // diemMin
            // 
            diemMin.AutoSize = true;
            diemMin.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            diemMin.Location = new Point(396, 790);
            diemMin.Margin = new Padding(4, 0, 4, 0);
            diemMin.Name = "diemMin";
            diemMin.Size = new Size(221, 35);
            diemMin.TabIndex = 9;
            diemMin.Text = "Điểm thấp nhất:";
            // 
            // monFail
            // 
            monFail.AutoSize = true;
            monFail.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            monFail.Location = new Point(753, 732);
            monFail.Margin = new Padding(4, 0, 4, 0);
            monFail.Name = "monFail";
            monFail.Size = new Size(260, 35);
            monFail.TabIndex = 10;
            monFail.Text = "Số môn không đậu:";
            // 
            // rank
            // 
            rank.AutoSize = true;
            rank.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            rank.Location = new Point(753, 790);
            rank.Margin = new Padding(4, 0, 4, 0);
            rank.Name = "rank";
            rank.Size = new Size(129, 35);
            rank.TabIndex = 11;
            rank.Text = "Xếp loại:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 845);
            Controls.Add(rank);
            Controls.Add(monFail);
            Controls.Add(diemMin);
            Controls.Add(monPass);
            Controls.Add(diemMax);
            Controls.Add(diemTB);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private Label diemTB;
        private Label diemMax;
        private Label monPass;
        private Label diemMin;
        private Label monFail;
        private Label rank;
    }
}