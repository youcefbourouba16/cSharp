namespace FormExoCpn
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
            this.c = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.TextBox();
            this.n1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c.Location = new System.Drawing.Point(27, 111);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(163, 153);
            this.c.TabIndex = 0;
            this.c.Text = "C";
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(139, 88);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(25, 25);
            this.p.TabIndex = 1;
            this.p.Text = "P";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n.Location = new System.Drawing.Point(139, 264);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(26, 25);
            this.n.TabIndex = 2;
            this.n.Text = "N";
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(170, 88);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 20);
            this.p1.TabIndex = 4;
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(179, 262);
            this.n1.Name = "n1";
            this.n1.Size = new System.Drawing.Size(100, 20);
            this.n1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(422, 179);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(86, 31);
            this.results.TabIndex = 6;
            this.results.Text = "label1";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(605, 317);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(35, 13);
            this.labelP.TabIndex = 7;
            this.labelP.Text = "label1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.results);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.n1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.n);
            this.Controls.Add(this.p);
            this.Controls.Add(this.c);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.TextBox p1;
        private System.Windows.Forms.TextBox n1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Label labelP;
    }
}