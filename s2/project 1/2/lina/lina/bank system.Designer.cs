namespace lina
{
    partial class bank_system
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
            this.tb_money = new System.Windows.Forms.TextBox();
            this.rb_widthraw = new System.Windows.Forms.RadioButton();
            this.rb_insert = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_newsold = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_money.Location = new System.Drawing.Point(255, 234);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(100, 26);
            this.tb_money.TabIndex = 0;
            // 
            // rb_widthraw
            // 
            this.rb_widthraw.AutoSize = true;
            this.rb_widthraw.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_widthraw.Location = new System.Drawing.Point(402, 223);
            this.rb_widthraw.Name = "rb_widthraw";
            this.rb_widthraw.Size = new System.Drawing.Size(109, 25);
            this.rb_widthraw.TabIndex = 1;
            this.rb_widthraw.TabStop = true;
            this.rb_widthraw.Text = "widthdraw";
            this.rb_widthraw.UseVisualStyleBackColor = true;
            // 
            // rb_insert
            // 
            this.rb_insert.AutoSize = true;
            this.rb_insert.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_insert.Location = new System.Drawing.Point(402, 246);
            this.rb_insert.Name = "rb_insert";
            this.rb_insert.Size = new System.Drawing.Size(82, 25);
            this.rb_insert.TabIndex = 2;
            this.rb_insert.TabStop = true;
            this.rb_insert.Text = "insert";
            this.rb_insert.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "OLD SOLD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "0.00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "new SOLD :";
            // 
            // lb_newsold
            // 
            this.lb_newsold.AutoSize = true;
            this.lb_newsold.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_newsold.Location = new System.Drawing.Point(152, 95);
            this.lb_newsold.Name = "lb_newsold";
            this.lb_newsold.Size = new System.Drawing.Size(46, 21);
            this.lb_newsold.TabIndex = 6;
            this.lb_newsold.Text = "0.00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "BANK SYSTem";
            // 
            // bank_system
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.rb_widthraw);
            this.Controls.Add(this.rb_insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_newsold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bank_system";
            this.Text = "bank_system";
            this.Load += new System.EventHandler(this.bank_system_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.RadioButton rb_widthraw;
        private System.Windows.Forms.RadioButton rb_insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_newsold;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}