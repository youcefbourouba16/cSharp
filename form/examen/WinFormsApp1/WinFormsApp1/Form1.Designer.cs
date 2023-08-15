namespace WinFormsApp1
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            tbL = new TextBox();
            tbC = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            tbL2 = new TextBox();
            tbC2 = new TextBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 22);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "nombre de ligne";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 97);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "nbr de collones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(417, 73);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 2;
            label3.Text = "la ligne ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(411, 124);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "la ligne 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(135, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // tbL
            // 
            tbL.Location = new Point(471, 70);
            tbL.Name = "tbL";
            tbL.Size = new Size(100, 23);
            tbL.TabIndex = 6;
            tbL.KeyPress += tbL_KeyPress;
            // 
            // tbC
            // 
            tbC.Location = new Point(688, 65);
            tbC.Name = "tbC";
            tbC.Size = new Size(100, 23);
            tbC.TabIndex = 7;
            tbC.KeyPress += tbL_KeyPress;
            // 
            // panel1
            // 
            panel1.Location = new Point(40, 163);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 275);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Location = new Point(462, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(326, 275);
            panel2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(627, 70);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 10;
            label5.Text = "collone 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(627, 124);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 11;
            label6.Text = "collone 2";
            // 
            // tbL2
            // 
            tbL2.Location = new Point(471, 121);
            tbL2.Name = "tbL2";
            tbL2.Size = new Size(100, 23);
            tbL2.TabIndex = 12;
            tbL2.KeyPress += tbL_KeyPress;
            // 
            // tbC2
            // 
            tbC2.Location = new Point(688, 121);
            tbC2.Name = "tbC2";
            tbC2.Size = new Size(100, 23);
            tbC2.TabIndex = 13;
            tbC2.KeyPress += tbL_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(268, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "affich";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(431, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(688, 23);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(94, 19);
            radioButton2.TabIndex = 16;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(559, 23);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(68, 19);
            radioButton3.TabIndex = 17;
            radioButton3.Text = "les deux";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(tbC2);
            Controls.Add(tbL2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tbC);
            Controls.Add(tbL);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            KeyPress += tbL_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tbL;
        private TextBox tbC;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label6;
        private TextBox tbL2;
        private TextBox tbC2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}