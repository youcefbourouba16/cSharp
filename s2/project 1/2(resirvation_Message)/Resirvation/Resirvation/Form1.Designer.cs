namespace Resirvation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ci = new System.Windows.Forms.RadioButton();
            this.rb_pass = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_buis = new System.Windows.Forms.RadioButton();
            this.rb_eco = new System.Windows.Forms.RadioButton();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_depart = new System.Windows.Forms.ComboBox();
            this.cb_Ariver = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_aller_retour = new System.Windows.Forms.RadioButton();
            this.rb_aller_simple = new System.Windows.Forms.RadioButton();
            this.btn_reserve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Depuis :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(326, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "A\' :";
            // 
            // tb_prenom
            // 
            this.tb_prenom.BackColor = System.Drawing.Color.White;
            this.tb_prenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_prenom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.Location = new System.Drawing.Point(340, 163);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 26);
            this.tb_prenom.TabIndex = 7;
            // 
            // tb_name
            // 
            this.tb_name.BackColor = System.Drawing.Color.White;
            this.tb_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(98, 162);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(100, 26);
            this.tb_name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(253, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(38, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(584, 62);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2023, 11, 1, 0, 0, 0, 0), new System.DateTime(2023, 11, 7, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.rb_ci);
            this.groupBox1.Controls.Add(this.rb_pass);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(42, 230);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Document de voyage :";
            // 
            // rb_ci
            // 
            this.rb_ci.AutoSize = true;
            this.rb_ci.ForeColor = System.Drawing.Color.Black;
            this.rb_ci.Location = new System.Drawing.Point(147, 19);
            this.rb_ci.Name = "rb_ci";
            this.rb_ci.Size = new System.Drawing.Size(45, 23);
            this.rb_ci.TabIndex = 1;
            this.rb_ci.TabStop = true;
            this.rb_ci.Text = "CI";
            this.rb_ci.UseVisualStyleBackColor = true;
            this.rb_ci.CheckedChanged += new System.EventHandler(this.rb_ci_CheckedChanged);
            // 
            // rb_pass
            // 
            this.rb_pass.AutoSize = true;
            this.rb_pass.ForeColor = System.Drawing.Color.Black;
            this.rb_pass.Location = new System.Drawing.Point(6, 19);
            this.rb_pass.Name = "rb_pass";
            this.rb_pass.Size = new System.Drawing.Size(99, 23);
            this.rb_pass.TabIndex = 0;
            this.rb_pass.TabStop = true;
            this.rb_pass.Text = "Passport";
            this.rb_pass.UseVisualStyleBackColor = true;
            this.rb_pass.CheckedChanged += new System.EventHandler(this.rb_pass_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.rb_buis);
            this.groupBox2.Controls.Add(this.rb_eco);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Classe :";
            // 
            // rb_buis
            // 
            this.rb_buis.AutoSize = true;
            this.rb_buis.ForeColor = System.Drawing.Color.Black;
            this.rb_buis.Location = new System.Drawing.Point(147, 19);
            this.rb_buis.Name = "rb_buis";
            this.rb_buis.Size = new System.Drawing.Size(108, 23);
            this.rb_buis.TabIndex = 1;
            this.rb_buis.TabStop = true;
            this.rb_buis.Text = "Business.";
            this.rb_buis.UseVisualStyleBackColor = true;
            // 
            // rb_eco
            // 
            this.rb_eco.AutoSize = true;
            this.rb_eco.ForeColor = System.Drawing.Color.Black;
            this.rb_eco.Location = new System.Drawing.Point(6, 19);
            this.rb_eco.Name = "rb_eco";
            this.rb_eco.Size = new System.Drawing.Size(126, 23);
            this.rb_eco.TabIndex = 0;
            this.rb_eco.TabStop = true;
            this.rb_eco.Text = "Economique.";
            this.rb_eco.UseVisualStyleBackColor = true;
            // 
            // tb_num
            // 
            this.tb_num.BackColor = System.Drawing.Color.White;
            this.tb_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_num.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tb_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_num.Location = new System.Drawing.Point(428, 248);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(323, 26);
            this.tb_num.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(292, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Num Pass\\CI :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(44, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date de delivrance :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(340, 372);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(189, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(44, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date D\'expiration Pass\\CI :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(44, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Bagage (Fournir une estimation) :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(356, 419);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(482, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Kg";
            // 
            // cb_depart
            // 
            this.cb_depart.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_depart.FormattingEnabled = true;
            this.cb_depart.Location = new System.Drawing.Point(118, 23);
            this.cb_depart.Name = "cb_depart";
            this.cb_depart.Size = new System.Drawing.Size(202, 27);
            this.cb_depart.TabIndex = 20;
            // 
            // cb_Ariver
            // 
            this.cb_Ariver.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Ariver.FormattingEnabled = true;
            this.cb_Ariver.Location = new System.Drawing.Point(377, 23);
            this.cb_Ariver.Name = "cb_Ariver";
            this.cb_Ariver.Size = new System.Drawing.Size(191, 27);
            this.cb_Ariver.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.rb_aller_retour);
            this.groupBox3.Controls.Add(this.rb_aller_simple);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox3.Location = new System.Drawing.Point(281, 62);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 58);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "A/R";
            // 
            // rb_aller_retour
            // 
            this.rb_aller_retour.AutoSize = true;
            this.rb_aller_retour.ForeColor = System.Drawing.Color.Black;
            this.rb_aller_retour.Location = new System.Drawing.Point(147, 19);
            this.rb_aller_retour.Name = "rb_aller_retour";
            this.rb_aller_retour.Size = new System.Drawing.Size(144, 23);
            this.rb_aller_retour.TabIndex = 1;
            this.rb_aller_retour.TabStop = true;
            this.rb_aller_retour.Text = "Aller retour.";
            this.rb_aller_retour.UseVisualStyleBackColor = true;
            // 
            // rb_aller_simple
            // 
            this.rb_aller_simple.AutoSize = true;
            this.rb_aller_simple.ForeColor = System.Drawing.Color.Black;
            this.rb_aller_simple.Location = new System.Drawing.Point(6, 19);
            this.rb_aller_simple.Name = "rb_aller_simple";
            this.rb_aller_simple.Size = new System.Drawing.Size(144, 23);
            this.rb_aller_simple.TabIndex = 0;
            this.rb_aller_simple.TabStop = true;
            this.rb_aller_simple.Text = "Aller simple.";
            this.rb_aller_simple.UseVisualStyleBackColor = true;
            // 
            // btn_reserve
            // 
            this.btn_reserve.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reserve.BackColor = System.Drawing.Color.Teal;
            this.btn_reserve.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_reserve.FlatAppearance.BorderSize = 2;
            this.btn_reserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_reserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_reserve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_reserve.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reserve.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reserve.Location = new System.Drawing.Point(130, 476);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(566, 54);
            this.btn_reserve.TabIndex = 22;
            this.btn_reserve.Text = "reserve (No paiment requered)";
            this.btn_reserve.UseVisualStyleBackColor = false;
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(825, 551);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cb_Ariver);
            this.Controls.Add(this.cb_depart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.tb_prenom);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_ci;
        private System.Windows.Forms.RadioButton rb_pass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_buis;
        private System.Windows.Forms.RadioButton rb_eco;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_depart;
        private System.Windows.Forms.ComboBox cb_Ariver;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_aller_retour;
        private System.Windows.Forms.RadioButton rb_aller_simple;
        private System.Windows.Forms.Button btn_reserve;
    }
}

