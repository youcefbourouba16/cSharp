namespace tableux
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
            tbCollone = new TextBox();
            tbLigne = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            bt1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 39);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "nbr de ligne";
            label1.Click += label1_Click;
            // 
            // tbCollone
            // 
            tbCollone.Location = new Point(170, 72);
            tbCollone.Name = "tbCollone";
            tbCollone.Size = new Size(100, 23);
            tbCollone.TabIndex = 1;
            tbCollone.KeyPress += tb1_KeyPress;
            // 
            // tbLigne
            // 
            tbLigne.Location = new Point(170, 36);
            tbLigne.Name = "tbLigne";
            tbLigne.Size = new Size(100, 23);
            tbLigne.TabIndex = 2;
            tbLigne.KeyPress += tbLigne_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 75);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 3;
            label2.Text = "nbr de collone";
            // 
            // panel1
            // 
            panel1.Location = new Point(81, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(909, 493);
            panel1.TabIndex = 4;
            // 
            // bt1
            // 
            bt1.Location = new Point(523, 39);
            bt1.Name = "bt1";
            bt1.Size = new Size(75, 23);
            bt1.TabIndex = 5;
            bt1.Text = "affiche";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 644);
            Controls.Add(bt1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(tbLigne);
            Controls.Add(tbCollone);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCollone;
        private TextBox tbLigne;
        private Label label2;
        private Panel panel1;
        private Button bt1;
    }
}