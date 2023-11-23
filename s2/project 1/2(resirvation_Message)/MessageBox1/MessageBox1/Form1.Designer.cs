namespace MessageBox1
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
            this.button2 = new System.Windows.Forms.Button();
            this.bnt_confirmation = new System.Windows.Forms.Button();
            this.btn_information = new System.Windows.Forms.Button();
            this.ignore_retry_abord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(35, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Input Messagebox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bnt_confirmation
            // 
            this.bnt_confirmation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bnt_confirmation.Location = new System.Drawing.Point(35, 137);
            this.bnt_confirmation.Name = "bnt_confirmation";
            this.bnt_confirmation.Size = new System.Drawing.Size(246, 36);
            this.bnt_confirmation.TabIndex = 4;
            this.bnt_confirmation.Text = "Confirmation";
            this.bnt_confirmation.UseVisualStyleBackColor = true;
            this.bnt_confirmation.Click += new System.EventHandler(this.bnt_confirmation_Click);
            // 
            // btn_information
            // 
            this.btn_information.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_information.Location = new System.Drawing.Point(35, 58);
            this.btn_information.Name = "btn_information";
            this.btn_information.Size = new System.Drawing.Size(246, 36);
            this.btn_information.TabIndex = 3;
            this.btn_information.Text = "Confirmation";
            this.btn_information.UseVisualStyleBackColor = true;
            this.btn_information.Click += new System.EventHandler(this.btn_information_Click);
            // 
            // ignore_retry_abord
            // 
            this.ignore_retry_abord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ignore_retry_abord.Location = new System.Drawing.Point(35, 218);
            this.ignore_retry_abord.Name = "ignore_retry_abord";
            this.ignore_retry_abord.Size = new System.Drawing.Size(246, 34);
            this.ignore_retry_abord.TabIndex = 6;
            this.ignore_retry_abord.Text = "ignore retry abord";
            this.ignore_retry_abord.UseVisualStyleBackColor = true;
            this.ignore_retry_abord.Click += new System.EventHandler(this.ignore_retry_abord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 454);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ignore_retry_abord);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bnt_confirmation);
            this.Controls.Add(this.btn_information);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bnt_confirmation;
        private System.Windows.Forms.Button btn_information;
        private System.Windows.Forms.Button ignore_retry_abord;
        private System.Windows.Forms.Button button1;
    }
}

