namespace windowsTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 0;
            label1.Text = "Click Me";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(100, 100);
            label2.Name = "label2";
            label2.Size = new Size(150, 150);
            label2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ActiveBorder;
            textBox1.Location = new Point(325, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 35);
            textBox1.TabIndex = 1;
            textBox1.Text = "回车输入";
            textBox1.Click += textBox1_Click;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(473, 151);
            button1.Name = "button1";
            button1.Size = new Size(142, 39);
            button1.TabIndex = 2;
            button1.Text = "显示最大的";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(376, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Enabled = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
    }
}