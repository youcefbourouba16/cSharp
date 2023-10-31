namespace form2
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
            tbA = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbB = new TextBox();
            tbC = new TextBox();
            label4 = new Label();
            tbX1 = new TextBox();
            tbX2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnCal = new Button();
            btnClear = new Button();
            lbR = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 0;
            label1.Text = "A^2";
            // 
            // tbA
            // 
            tbA.Location = new Point(124, 56);
            tbA.Name = "tbA";
            tbA.Size = new Size(56, 23);
            tbA.TabIndex = 1;
            tbA.KeyPress += tbB_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(186, 54);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 2;
            label2.Text = "+B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(297, 51);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 3;
            label3.Text = "+C";
            // 
            // tbB
            // 
            tbB.Location = new Point(226, 56);
            tbB.Name = "tbB";
            tbB.Size = new Size(56, 23);
            tbB.TabIndex = 4;
            tbB.KeyPress += tbB_KeyPress;
            // 
            // tbC
            // 
            tbC.Location = new Point(340, 54);
            tbC.Name = "tbC";
            tbC.Size = new Size(56, 23);
            tbC.TabIndex = 5;
            tbC.KeyPress += tbB_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(416, 56);
            label4.Name = "label4";
            label4.Size = new Size(25, 25);
            label4.TabIndex = 6;
            label4.Text = "=";
            // 
            // tbX1
            // 
            tbX1.Location = new Point(503, 228);
            tbX1.Name = "tbX1";
            tbX1.Size = new Size(56, 23);
            tbX1.TabIndex = 7;
            // 
            // tbX2
            // 
            tbX2.Location = new Point(503, 273);
            tbX2.Name = "tbX2";
            tbX2.Size = new Size(56, 23);
            tbX2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(441, 226);
            label5.Name = "label5";
            label5.Size = new Size(35, 25);
            label5.TabIndex = 9;
            label5.Text = "X1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(441, 274);
            label6.Name = "label6";
            label6.Size = new Size(35, 25);
            label6.TabIndex = 10;
            label6.Text = "X2";
            // 
            // btnCal
            // 
            btnCal.Location = new Point(105, 226);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(75, 23);
            btnCal.TabIndex = 11;
            btnCal.Text = "calculer";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(105, 273);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lbR
            // 
            lbR.AutoSize = true;
            lbR.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            lbR.Location = new Point(297, 143);
            lbR.Name = "lbR";
            lbR.Size = new Size(61, 25);
            lbR.TabIndex = 13;
            lbR.Text = "label7";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbR);
            Controls.Add(btnClear);
            Controls.Add(btnCal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbX2);
            Controls.Add(tbX1);
            Controls.Add(label4);
            Controls.Add(tbC);
            Controls.Add(tbB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbA);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += tbB_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbA;
        private Label label2;
        private Label label3;
        private TextBox tbB;
        private TextBox tbC;
        private Label label4;
        private TextBox tbX1;
        private TextBox tbX2;
        private Label label5;
        private Label label6;
        private Button btnCal;
        private Button btnClear;
        private Label lbR;
    }
}