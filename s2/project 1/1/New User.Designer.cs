namespace _1
{
    partial class ADDuser
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
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.saveFile = new System.Windows.Forms.Button();
            this.cb_male = new System.Windows.Forms.RadioButton();
            this.cb_female = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(133, 110);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(138, 20);
            this.tb_userName.TabIndex = 0;
            this.tb_userName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(133, 148);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(138, 20);
            this.tb_password.TabIndex = 1;
            this.tb_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mot de Passe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prenom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nom :";
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(133, 43);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(138, 20);
            this.tb_prenom.TabIndex = 6;
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(133, 4);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(138, 20);
            this.tb_nom.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adress Email :";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(133, 187);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(138, 20);
            this.tb_email.TabIndex = 9;
            // 
            // saveFile
            // 
            this.saveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveFile.BackColor = System.Drawing.Color.Turquoise;
            this.saveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveFile.FlatAppearance.BorderSize = 5;
            this.saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveFile.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.saveFile.Location = new System.Drawing.Point(56, 240);
            this.saveFile.Margin = new System.Windows.Forms.Padding(0);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(179, 48);
            this.saveFile.TabIndex = 11;
            this.saveFile.Text = "Connection";
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // cb_male
            // 
            this.cb_male.AutoSize = true;
            this.cb_male.Location = new System.Drawing.Point(133, 77);
            this.cb_male.Name = "cb_male";
            this.cb_male.Size = new System.Drawing.Size(48, 17);
            this.cb_male.TabIndex = 12;
            this.cb_male.TabStop = true;
            this.cb_male.Text = "Male";
            this.cb_male.UseVisualStyleBackColor = true;
            // 
            // cb_female
            // 
            this.cb_female.AutoSize = true;
            this.cb_female.Location = new System.Drawing.Point(212, 76);
            this.cb_female.Name = "cb_female";
            this.cb_female.Size = new System.Drawing.Size(59, 17);
            this.cb_female.TabIndex = 13;
            this.cb_female.TabStop = true;
            this.cb_female.Text = "Female";
            this.cb_female.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "sexe: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_userName);
            this.panel1.Controls.Add(this.cb_female);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.cb_male);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saveFile);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.tb_email);
            this.panel1.Controls.Add(this.tb_prenom);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 304);
            this.panel1.TabIndex = 15;
            // 
            // ADDuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 364);
            this.Controls.Add(this.panel1);
            this.Name = "ADDuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_User";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.RadioButton cb_male;
        private System.Windows.Forms.RadioButton cb_female;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}