namespace LAB1_
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            numBox = new TextBox();
            resBox = new TextBox();
            readb = new Button();
            clearb = new Button();
            closeb = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold);
            label1.Location = new Point(835, 83);
            label1.Name = "label1";
            label1.Size = new Size(342, 90);
            label1.TabIndex = 0;
            label1.Text = "ĐỌC SỐ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label2.Location = new Point(130, 269);
            label2.Name = "label2";
            label2.Size = new Size(157, 45);
            label2.TabIndex = 1;
            label2.Text = "Nhập số";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
            label3.Location = new Point(130, 410);
            label3.Name = "label3";
            label3.Size = new Size(155, 45);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // numBox
            // 
            numBox.Font = new Font("Times New Roman", 13F);
            numBox.Location = new Point(320, 276);
            numBox.Name = "numBox";
            numBox.Size = new Size(1480, 47);
            numBox.TabIndex = 3;
            // 
            // resBox
            // 
            resBox.Font = new Font("Times New Roman", 13F);
            resBox.Location = new Point(320, 417);
            resBox.Name = "resBox";
            resBox.ReadOnly = true;
            resBox.Size = new Size(1480, 47);
            resBox.TabIndex = 4;
            // 
            // readb
            // 
            readb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            readb.Location = new Point(689, 596);
            readb.Name = "readb";
            readb.Size = new Size(150, 46);
            readb.TabIndex = 5;
            readb.Text = "Đọc";
            readb.UseVisualStyleBackColor = true;
            readb.Click += readb_Click;
            // 
            // clearb
            // 
            clearb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            clearb.Location = new Point(928, 596);
            clearb.Name = "clearb";
            clearb.Size = new Size(150, 46);
            clearb.TabIndex = 6;
            clearb.Text = "Xóa";
            clearb.UseVisualStyleBackColor = true;
            // 
            // closeb
            // 
            closeb.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            closeb.Location = new Point(1171, 596);
            closeb.Name = "closeb";
            closeb.Size = new Size(150, 46);
            closeb.TabIndex = 7;
            closeb.Text = "Thoát";
            closeb.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1968, 795);
            Controls.Add(closeb);
            Controls.Add(clearb);
            Controls.Add(readb);
            Controls.Add(resBox);
            Controls.Add(numBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox numBox;
        private TextBox resBox;
        private Button readb;
        private Button clearb;
        private Button closeb;
    }
}