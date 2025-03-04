namespace LAB1_
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox2 = new GroupBox();
            textBoxMax = new TextBox();
            textBoxMin = new TextBox();
            label5 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 10);
            label1.Name = "label1";
            label1.Size = new Size(705, 63);
            label1.TabIndex = 0;
            label1.Text = "Tìm Số Lớn Nhất, Nhỏ Nhất";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(192, 0, 0);
            groupBox1.Location = new Point(33, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Các giá trị";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(653, 53);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 34);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(393, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 34);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 34);
            textBox1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(534, 53);
            label4.Name = "label4";
            label4.Size = new Size(103, 28);
            label4.TabIndex = 2;
            label4.Text = "Số thứ ba";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(278, 53);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 1;
            label3.Text = "Số thứ hai";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(19, 53);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 0;
            label2.Text = "Số thứ nhất";
            // 
            // button1
            // 
            button1.Location = new Point(111, 252);
            button1.Name = "button1";
            button1.Size = new Size(136, 38);
            button1.TabIndex = 2;
            button1.Text = "Tìm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clickBoxAns;
            // 
            // button2
            // 
            button2.Location = new Point(357, 252);
            button2.Name = "button2";
            button2.Size = new Size(136, 38);
            button2.TabIndex = 3;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += clickBoxDel;
            // 
            // button3
            // 
            button3.Location = new Point(620, 252);
            button3.Name = "button3";
            button3.Size = new Size(136, 38);
            button3.TabIndex = 4;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            button3.Click += clickBoxOut;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxMax);
            groupBox2.Controls.Add(textBoxMin);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.DodgerBlue;
            groupBox2.Location = new Point(33, 345);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(808, 106);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kết quả";
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(553, 53);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.Size = new Size(221, 34);
            textBoxMax.TabIndex = 4;
            // 
            // textBoxMin
            // 
            textBoxMin.Location = new Point(148, 53);
            textBoxMin.Name = "textBoxMin";
            textBoxMin.Size = new Size(218, 34);
            textBoxMin.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Black;
            label5.Location = new Point(423, 59);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 2;
            label5.Text = "Số lớn nhất";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(19, 53);
            label7.Name = "label7";
            label7.Size = new Size(113, 28);
            label7.TabIndex = 0;
            label7.Text = "Số bé nhất";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 504);
            Controls.Add(groupBox2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
        private GroupBox groupBox2;
        private TextBox textBoxMax;
        private TextBox textBoxMin;
        private Label label5;
        private Label label7;
    }
}