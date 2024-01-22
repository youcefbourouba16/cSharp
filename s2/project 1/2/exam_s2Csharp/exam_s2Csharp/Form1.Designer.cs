namespace exam_s2Csharp
{
    partial class frm_login
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
            this.tb_password = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_username = new MaterialSkin.Controls.MaterialTextBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.btn_connect = new MaterialSkin.Controls.MaterialButton();
            this.btn_logup = new MaterialSkin.Controls.MaterialButton();
            this.materialButton20 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.AnimateReadOnly = false;
            this.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_password.Depth = 0;
            this.tb_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_password.Hint = "Password";
            this.tb_password.LeadingIcon = null;
            this.tb_password.Location = new System.Drawing.Point(89, 174);
            this.tb_password.MaxLength = 50;
            this.tb_password.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_password.Multiline = false;
            this.tb_password.Name = "tb_password";
            this.tb_password.Password = true;
            this.tb_password.Size = new System.Drawing.Size(406, 50);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "";
            this.tb_password.TrailingIcon = null;
            // 
            // tb_username
            // 
            this.tb_username.AnimateReadOnly = false;
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.Depth = 0;
            this.tb_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_username.Hint = "Type here";
            this.tb_username.LeadingIcon = null;
            this.tb_username.Location = new System.Drawing.Point(89, 118);
            this.tb_username.MaxLength = 50;
            this.tb_username.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(406, 50);
            this.tb_username.TabIndex = 4;
            this.tb_username.Text = "";
            this.tb_username.TrailingIcon = null;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSwitch1.Location = new System.Drawing.Point(503, 181);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(96, 37);
            this.materialSwitch1.TabIndex = 12;
            this.materialSwitch1.Text = "show";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = false;
            this.btn_connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_connect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_connect.Depth = 0;
            this.btn_connect.HighEmphasis = true;
            this.btn_connect.Icon = null;
            this.btn_connect.Location = new System.Drawing.Point(163, 275);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_connect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_connect.Size = new System.Drawing.Size(168, 36);
            this.btn_connect.TabIndex = 13;
            this.btn_connect.Text = "Connect";
            this.btn_connect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_connect.UseAccentColor = false;
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_logup
            // 
            this.btn_logup.AutoSize = false;
            this.btn_logup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_logup.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_logup.Depth = 0;
            this.btn_logup.HighEmphasis = false;
            this.btn_logup.Icon = null;
            this.btn_logup.Location = new System.Drawing.Point(370, 275);
            this.btn_logup.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_logup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_logup.Name = "btn_logup";
            this.btn_logup.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_logup.Size = new System.Drawing.Size(106, 36);
            this.btn_logup.TabIndex = 17;
            this.btn_logup.Text = "LOG UP?";
            this.btn_logup.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_logup.UseAccentColor = false;
            this.btn_logup.UseVisualStyleBackColor = true;
            // 
            // materialButton20
            // 
            this.materialButton20.AutoSize = false;
            this.materialButton20.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton20.BackColor = System.Drawing.Color.Gray;
            this.materialButton20.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton20.Depth = 0;
            this.materialButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton20.HighEmphasis = false;
            this.materialButton20.Icon = null;
            this.materialButton20.Location = new System.Drawing.Point(163, 30);
            this.materialButton20.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton20.Name = "materialButton20";
            this.materialButton20.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton20.Size = new System.Drawing.Size(344, 59);
            this.materialButton20.TabIndex = 18;
            this.materialButton20.Text = "LOG IN";
            this.materialButton20.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.materialButton20.UseAccentColor = true;
            this.materialButton20.UseVisualStyleBackColor = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(705, 383);
            this.Controls.Add(this.materialButton20);
            this.Controls.Add(this.btn_logup);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Name = "frm_login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox tb_password;
        private MaterialSkin.Controls.MaterialTextBox tb_username;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialButton btn_connect;
        private MaterialSkin.Controls.MaterialButton btn_logup;
        private MaterialSkin.Controls.MaterialButton materialButton20;
    }
}

