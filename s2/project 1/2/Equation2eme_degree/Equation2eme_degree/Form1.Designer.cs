namespace Equation2eme_degree
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
            this.rb_first_degree = new System.Windows.Forms.RadioButton();
            this.rd_second_deg = new System.Windows.Forms.RadioButton();
            this.btn_calcu = new System.Windows.Forms.Button();
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_C = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rb_first_degree
            // 
            this.rb_first_degree.AutoSize = true;
            this.rb_first_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_first_degree.Location = new System.Drawing.Point(158, 70);
            this.rb_first_degree.Name = "rb_first_degree";
            this.rb_first_degree.Size = new System.Drawing.Size(134, 29);
            this.rb_first_degree.TabIndex = 0;
            this.rb_first_degree.TabStop = true;
            this.rb_first_degree.Text = "1er degree";
            this.rb_first_degree.UseVisualStyleBackColor = true;
            this.rb_first_degree.CheckedChanged += new System.EventHandler(this.rb_first_degree_CheckedChanged);
            // 
            // rd_second_deg
            // 
            this.rd_second_deg.AutoSize = true;
            this.rd_second_deg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_second_deg.Location = new System.Drawing.Point(381, 70);
            this.rd_second_deg.Name = "rd_second_deg";
            this.rd_second_deg.Size = new System.Drawing.Size(156, 29);
            this.rd_second_deg.TabIndex = 1;
            this.rd_second_deg.TabStop = true;
            this.rd_second_deg.Text = "2eme degree";
            this.rd_second_deg.UseVisualStyleBackColor = true;
            this.rd_second_deg.CheckedChanged += new System.EventHandler(this.rd_second_deg_CheckedChanged);
            // 
            // btn_calcu
            // 
            this.btn_calcu.Location = new System.Drawing.Point(266, 267);
            this.btn_calcu.Name = "btn_calcu";
            this.btn_calcu.Size = new System.Drawing.Size(184, 58);
            this.btn_calcu.TabIndex = 2;
            this.btn_calcu.Text = "btn_Calculer";
            this.btn_calcu.UseVisualStyleBackColor = true;
            this.btn_calcu.Click += new System.EventHandler(this.btn_calcu_Click);
            // 
            // tb_A
            // 
            this.tb_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_A.Location = new System.Drawing.Point(101, 162);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(100, 29);
            this.tb_A.TabIndex = 3;
            this.tb_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_A_KeyPress);
            // 
            // tb_B
            // 
            this.tb_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_B.Location = new System.Drawing.Point(306, 160);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(100, 29);
            this.tb_B.TabIndex = 4;
            this.tb_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_A_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "+  Bx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "A.X^2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(612, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "=   0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "+  C";
            // 
            // tb_C
            // 
            this.tb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_C.Location = new System.Drawing.Point(491, 157);
            this.tb_C.Name = "tb_C";
            this.tb_C.Size = new System.Drawing.Size(100, 29);
            this.tb_C.TabIndex = 8;
            this.tb_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_A_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_C);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Controls.Add(this.btn_calcu);
            this.Controls.Add(this.rd_second_deg);
            this.Controls.Add(this.rb_first_degree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rb_first_degree;
        private System.Windows.Forms.RadioButton rd_second_deg;
        private System.Windows.Forms.Button btn_calcu;
        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_C;
        private System.Windows.Forms.Button button1;
    }
}

