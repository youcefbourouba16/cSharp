namespace test2
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
            this.tb_L = new System.Windows.Forms.TextBox();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.calcul = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tb_L
            // 
            this.tb_L.Location = new System.Drawing.Point(246, 35);
            this.tb_L.Name = "tb_L";
            this.tb_L.Size = new System.Drawing.Size(100, 20);
            this.tb_L.TabIndex = 0;
            // 
            // tb_C
            // 
            this.tb_C.Location = new System.Drawing.Point(492, 35);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(100, 20);
            this.tb_C.TabIndex = 1;
            // 
            // calcul
            // 
            this.calcul.Location = new System.Drawing.Point(271, 106);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(75, 23);
            this.calcul.TabIndex = 2;
            this.calcul.Text = "CALCULATE";
            this.calcul.UseVisualStyleBackColor = true;
            this.calcul.Click += new System.EventHandler(this.calcul_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(352, 106);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ligne";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Collones";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(74, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 262);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calcul);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.tb_L);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_L;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

