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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 9);
            label1.Name = "label1";
            label1.Size = new Size(353, 60);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Điểm";
            // 
            // listView1
            // 
            listView1.Location = new Point(42, 205);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(772, 355);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(151, 26);
            label2.TabIndex = 2;
            label2.Text = "Dữ liệu điểm:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 114);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(622, 31);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(681, 151);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(133, 38);
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
            label3.Location = new Point(42, 160);
            label3.Name = "label3";
            label3.Size = new Size(492, 22);
            label3.TabIndex = 5;
            label3.Text = "*Lưu ý: Nhập với định dạng danh sách ví dụ: 9.5 8 7 6 5 10\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label4.Location = new Point(42, 572);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 6;
            label4.Text = "Điểm TB:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label5.Location = new Point(42, 617);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 7;
            label5.Text = "Điểm cao nhất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label6.Location = new Point(305, 572);
            label6.Name = "label6";
            label6.Size = new Size(130, 25);
            label6.TabIndex = 8;
            label6.Text = "Số môn đậu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label7.Location = new Point(305, 617);
            label7.Name = "label7";
            label7.Size = new Size(165, 25);
            label7.TabIndex = 9;
            label7.Text = "Điểm thấp nhất:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label8.Location = new Point(579, 572);
            label8.Name = "label8";
            label8.Size = new Size(194, 25);
            label8.TabIndex = 10;
            label8.Text = "Số môn không đậu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11F, FontStyle.Bold);
            label9.Location = new Point(579, 617);
            label9.Name = "label9";
            label9.Size = new Size(96, 25);
            label9.TabIndex = 11;
            label9.Text = "Xếp loại:";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 660);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}