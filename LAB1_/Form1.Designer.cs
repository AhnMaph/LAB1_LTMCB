namespace LAB1_
{
    partial class Form1
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
            num1 = new Label();
            num2 = new Label();
            result = new Label();
            numBox1 = new TextBox();
            numBox2 = new TextBox();
            resBox = new TextBox();
            plusb = new Button();
            minusb = new Button();
            mulb = new Button();
            divb = new Button();
            reset = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(278, 21);
            label1.Name = "label1";
            label1.Size = new Size(329, 72);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TOÁN";
            label1.Click += label1_Click;
            // 
            // num1
            // 
            num1.AutoSize = true;
            num1.Font = new Font("Segoe UI", 12F);
            num1.Location = new Point(90, 178);
            num1.Name = "num1";
            num1.Size = new Size(139, 45);
            num1.TabIndex = 1;
            num1.Text = "Số thứ 1";
            // 
            // num2
            // 
            num2.AutoSize = true;
            num2.Font = new Font("Segoe UI", 12F);
            num2.Location = new Point(90, 300);
            num2.Name = "num2";
            num2.Size = new Size(139, 45);
            num2.TabIndex = 2;
            num2.Text = "Số thứ 2";
            // 
            // result
            // 
            result.AutoSize = true;
            result.Font = new Font("Segoe UI", 12F);
            result.Location = new Point(100, 436);
            result.Name = "result";
            result.Size = new Size(129, 45);
            result.TabIndex = 3;
            result.Text = "Kết quả";
            // 
            // numBox1
            // 
            numBox1.Font = new Font("Segoe UI", 10F);
            numBox1.Location = new Point(262, 185);
            numBox1.Name = "numBox1";
            numBox1.Size = new Size(471, 43);
            numBox1.TabIndex = 4;
            // 
            // numBox2
            // 
            numBox2.Font = new Font("Segoe UI", 10F);
            numBox2.Location = new Point(262, 307);
            numBox2.Name = "numBox2";
            numBox2.Size = new Size(471, 43);
            numBox2.TabIndex = 5;
            // 
            // resBox
            // 
            resBox.Font = new Font("Segoe UI", 10F);
            resBox.Location = new Point(262, 442);
            resBox.Name = "resBox";
            resBox.ReadOnly = true;
            resBox.Size = new Size(471, 43);
            resBox.TabIndex = 6;
            // 
            // plusb
            // 
            plusb.Location = new Point(152, 549);
            plusb.Name = "plusb";
            plusb.Size = new Size(77, 67);
            plusb.TabIndex = 7;
            plusb.Text = "+";
            plusb.UseVisualStyleBackColor = true;
            plusb.Click += button1_Click;
            // 
            // minusb
            // 
            minusb.Location = new Point(320, 549);
            minusb.Name = "minusb";
            minusb.Size = new Size(77, 67);
            minusb.TabIndex = 8;
            minusb.Text = "-";
            minusb.UseVisualStyleBackColor = true;
            minusb.Click += minusb_Click;
            // 
            // mulb
            // 
            mulb.Location = new Point(502, 549);
            mulb.Name = "mulb";
            mulb.Size = new Size(77, 67);
            mulb.TabIndex = 9;
            mulb.Text = "X";
            mulb.UseVisualStyleBackColor = true;
            mulb.Click += mulb_Click;
            // 
            // divb
            // 
            divb.Location = new Point(656, 549);
            divb.Name = "divb";
            divb.Size = new Size(77, 67);
            divb.TabIndex = 10;
            divb.Text = "/";
            divb.UseVisualStyleBackColor = true;
            divb.Click += divb_Click;
            // 
            // reset
            // 
            reset.Location = new Point(138, 673);
            reset.Name = "reset";
            reset.Size = new Size(259, 67);
            reset.TabIndex = 11;
            reset.Text = "Xóa";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // exit
            // 
            exit.Location = new Point(485, 673);
            exit.Name = "exit";
            exit.Size = new Size(259, 67);
            exit.TabIndex = 12;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 858);
            Controls.Add(exit);
            Controls.Add(reset);
            Controls.Add(divb);
            Controls.Add(mulb);
            Controls.Add(minusb);
            Controls.Add(plusb);
            Controls.Add(resBox);
            Controls.Add(numBox2);
            Controls.Add(numBox1);
            Controls.Add(result);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label num1;
        private Label num2;
        private Label result;
        private TextBox numBox1;
        private TextBox numBox2;
        private TextBox resBox;
        private Button plusb;
        private Button minusb;
        private Button mulb;
        private Button divb;
        private Button reset;
        private Button exit;
    }
}