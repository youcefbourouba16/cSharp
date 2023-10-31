namespace _1
{
    partial class Login
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
            this.Connect = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.NewUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.NewUser1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilisateur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot De Passe :";
            // 
            // Connect
            // 
            this.Connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connect.BackColor = System.Drawing.Color.Turquoise;
            this.Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Connect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Connect.FlatAppearance.BorderSize = 5;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Connect.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Connect.Location = new System.Drawing.Point(152, 295);
            this.Connect.Margin = new System.Windows.Forms.Padding(0);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(179, 48);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connection";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            this.Connect.MouseLeave += new System.EventHandler(this.Connect_MouseLeave);
            this.Connect.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(289, 118);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(345, 29);
            this.UserName.TabIndex = 3;
            this.UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.Snow;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(289, 179);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(345, 29);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            // 
            // NewUser
            // 
            this.NewUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewUser.BackColor = System.Drawing.Color.Crimson;
            this.NewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewUser.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NewUser.Location = new System.Drawing.Point(363, 295);
            this.NewUser.Margin = new System.Windows.Forms.Padding(0);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(179, 48);
            this.NewUser.TabIndex = 5;
            this.NewUser.Text = "Fermer";
            this.NewUser.UseVisualStyleBackColor = false;
            this.NewUser.Click += new System.EventHandler(this.closee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(205, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "-Soyez Les Bienvenus-";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox1.Location = new System.Drawing.Point(594, 187);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "  ";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NewUser1
            // 
            this.NewUser1.Location = new System.Drawing.Point(594, 311);
            this.NewUser1.Name = "NewUser1";
            this.NewUser1.Size = new System.Drawing.Size(75, 23);
            this.NewUser1.TabIndex = 9;
            this.NewUser1.Text = "New User";
            this.NewUser1.UseVisualStyleBackColor = true;
            this.NewUser1.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 414);
            this.Controls.Add(this.NewUser1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserName_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button NewUser1;
    }
}

