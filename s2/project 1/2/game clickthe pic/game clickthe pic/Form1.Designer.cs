namespace game_clickthe_pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Hard = new System.Windows.Forms.RadioButton();
            this.rb_medium = new System.Windows.Forms.RadioButton();
            this.rb_easy = new System.Windows.Forms.RadioButton();
            this.lb_timeLeft = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(28, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 406);
            this.panel1.TabIndex = 0;
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.Image = ((System.Drawing.Image)(resources.GetObject("btn_start.Image")));
            this.btn_start.Location = new System.Drawing.Point(655, 85);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(117, 100);
            this.btn_start.TabIndex = 1;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click_1);
            // 
            // btn_stop
            // 
            this.btn_stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.Location = new System.Drawing.Point(655, 243);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(117, 93);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Hard);
            this.groupBox1.Controls.Add(this.rb_medium);
            this.groupBox1.Controls.Add(this.rb_easy);
            this.groupBox1.Location = new System.Drawing.Point(632, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 46);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Level :";
            // 
            // rb_Hard
            // 
            this.rb_Hard.AutoSize = true;
            this.rb_Hard.Location = new System.Drawing.Point(131, 20);
            this.rb_Hard.Name = "rb_Hard";
            this.rb_Hard.Size = new System.Drawing.Size(48, 17);
            this.rb_Hard.TabIndex = 2;
            this.rb_Hard.Text = "Hard";
            this.rb_Hard.UseVisualStyleBackColor = true;
            // 
            // rb_medium
            // 
            this.rb_medium.AutoSize = true;
            this.rb_medium.Location = new System.Drawing.Point(63, 20);
            this.rb_medium.Name = "rb_medium";
            this.rb_medium.Size = new System.Drawing.Size(62, 17);
            this.rb_medium.TabIndex = 1;
            this.rb_medium.Text = "Medium";
            this.rb_medium.UseVisualStyleBackColor = true;
            // 
            // rb_easy
            // 
            this.rb_easy.AutoSize = true;
            this.rb_easy.Checked = true;
            this.rb_easy.Location = new System.Drawing.Point(7, 20);
            this.rb_easy.Name = "rb_easy";
            this.rb_easy.Size = new System.Drawing.Size(48, 17);
            this.rb_easy.TabIndex = 0;
            this.rb_easy.TabStop = true;
            this.rb_easy.Text = "Easy";
            this.rb_easy.UseVisualStyleBackColor = true;
            // 
            // lb_timeLeft
            // 
            this.lb_timeLeft.AutoSize = true;
            this.lb_timeLeft.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timeLeft.Location = new System.Drawing.Point(673, 28);
            this.lb_timeLeft.Name = "lb_timeLeft";
            this.lb_timeLeft.Size = new System.Drawing.Size(0, 28);
            this.lb_timeLeft.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(824, 434);
            this.Controls.Add(this.lb_timeLeft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Hit the Squirrel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Hard;
        private System.Windows.Forms.RadioButton rb_medium;
        private System.Windows.Forms.RadioButton rb_easy;
        private System.Windows.Forms.Label lb_timeLeft;
    }
}

