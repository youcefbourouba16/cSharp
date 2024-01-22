namespace exam_s2Csharp
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
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialSingleLineTextField2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialButton9 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton19 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton20 = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialTextBox2.Hint = "Password";
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(89, 174);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(406, 50);
            this.materialTextBox2.TabIndex = 5;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialSingleLineTextField2
            // 
            this.materialSingleLineTextField2.AnimateReadOnly = false;
            this.materialSingleLineTextField2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialSingleLineTextField2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.materialSingleLineTextField2.Depth = 0;
            this.materialSingleLineTextField2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialSingleLineTextField2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSingleLineTextField2.Hint = "Type here";
            this.materialSingleLineTextField2.LeadingIcon = null;
            this.materialSingleLineTextField2.Location = new System.Drawing.Point(89, 118);
            this.materialSingleLineTextField2.MaxLength = 50;
            this.materialSingleLineTextField2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialSingleLineTextField2.Multiline = false;
            this.materialSingleLineTextField2.Name = "materialSingleLineTextField2";
            this.materialSingleLineTextField2.Size = new System.Drawing.Size(406, 50);
            this.materialSingleLineTextField2.TabIndex = 4;
            this.materialSingleLineTextField2.Text = "";
            this.materialSingleLineTextField2.TrailingIcon = null;
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
            // materialButton9
            // 
            this.materialButton9.AutoSize = false;
            this.materialButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton9.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton9.Depth = 0;
            this.materialButton9.HighEmphasis = true;
            this.materialButton9.Icon = null;
            this.materialButton9.Location = new System.Drawing.Point(163, 275);
            this.materialButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton9.Name = "materialButton9";
            this.materialButton9.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton9.Size = new System.Drawing.Size(168, 36);
            this.materialButton9.TabIndex = 13;
            this.materialButton9.Text = "Connect";
            this.materialButton9.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton9.UseAccentColor = false;
            this.materialButton9.UseVisualStyleBackColor = true;
            // 
            // materialButton19
            // 
            this.materialButton19.AutoSize = false;
            this.materialButton19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton19.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton19.Depth = 0;
            this.materialButton19.HighEmphasis = false;
            this.materialButton19.Icon = null;
            this.materialButton19.Location = new System.Drawing.Point(370, 275);
            this.materialButton19.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton19.Name = "materialButton19";
            this.materialButton19.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton19.Size = new System.Drawing.Size(106, 36);
            this.materialButton19.TabIndex = 17;
            this.materialButton19.Text = "annuler";
            this.materialButton19.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton19.UseAccentColor = false;
            this.materialButton19.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(705, 383);
            this.Controls.Add(this.materialButton20);
            this.Controls.Add(this.materialButton19);
            this.Controls.Add(this.materialButton9);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialSingleLineTextField2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialSingleLineTextField2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialButton materialButton9;
        private MaterialSkin.Controls.MaterialButton materialButton19;
        private MaterialSkin.Controls.MaterialButton materialButton20;
    }
}

