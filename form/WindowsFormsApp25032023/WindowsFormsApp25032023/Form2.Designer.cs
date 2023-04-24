namespace WindowsFormsApp25032023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbResultat = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.btCal = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbA.Location = new System.Drawing.Point(135, 70);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(45, 25);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "x²+";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbB.Location = new System.Drawing.Point(271, 71);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(37, 25);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "x+";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbC.Location = new System.Drawing.Point(401, 75);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(45, 25);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "= 0";
            this.lbC.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbResultat
            // 
            this.lbResultat.AutoSize = true;
            this.lbResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultat.Location = new System.Drawing.Point(63, 285);
            this.lbResultat.Name = "lbResultat";
            this.lbResultat.Size = new System.Drawing.Size(0, 20);
            this.lbResultat.TabIndex = 3;
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(46, 75);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(83, 20);
            this.tbA.TabIndex = 4;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(186, 75);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(83, 20);
            this.tbB.TabIndex = 5;
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(314, 75);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(81, 20);
            this.tbC.TabIndex = 6;
            // 
            // btCal
            // 
            this.btCal.Image = ((System.Drawing.Image)(resources.GetObject("btCal.Image")));
            this.btCal.Location = new System.Drawing.Point(67, 162);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(129, 38);
            this.btCal.TabIndex = 7;
            this.btCal.Text = "Calculer";
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // btDel
            // 
            this.btDel.BackColor = System.Drawing.SystemColors.Highlight;
            this.btDel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDel.Location = new System.Drawing.Point(276, 162);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(129, 38);
            this.btDel.TabIndex = 7;
            this.btDel.Text = "Effacer";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 340);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbResultat);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbResultat;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btDel;
    }
}