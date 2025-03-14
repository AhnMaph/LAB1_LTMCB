namespace LAB1_
{
    partial class Form4
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            delButton = new Button();
            exitButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(47, 50);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(944, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(257, 219);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(450, 54);
            button1.TabIndex = 6;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button_start_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Decimal", "Hex", "Binary" });
            comboBox2.Location = new Point(529, 127);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(247, 40);
            comboBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 131);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 4;
            label3.Text = "Sang";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Decimal", "Hex", "Binary" });
            comboBox1.Location = new Point(173, 127);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 40);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 131);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 32);
            label2.TabIndex = 2;
            label2.Text = "Chọn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 74);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 1;
            label1.Text = "Nhập một số:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 70);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(741, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 429);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(741, 39);
            textBox2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(113, 429);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 32);
            label4.TabIndex = 7;
            label4.Text = "Kết quả:";
            // 
            // delButton
            // 
            delButton.Location = new Point(219, 501);
            delButton.Name = "delButton";
            delButton.Size = new Size(185, 46);
            delButton.TabIndex = 8;
            delButton.Text = "Xóa";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(644, 501);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(179, 46);
            exitButton.TabIndex = 9;
            exitButton.Text = "Thoát";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 576);
            Controls.Add(exitButton);
            Controls.Add(delButton);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label3;
        private Button button1;
        private Label label4;
        private Button delButton;
        private Button exitButton;
    }
}