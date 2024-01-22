namespace lina
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_insert = new System.Windows.Forms.RadioButton();
            this.rb_widthraw = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_action = new System.Windows.Forms.Button();
            this.lb_oldSold = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_NewSold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(388, 361);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 37);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tb_money
            // 
            this.tb_money.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_money.Location = new System.Drawing.Point(169, 226);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(195, 30);
            this.tb_money.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(244, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "BANK SYSTEM";
            // 
            // rb_insert
            // 
            this.rb_insert.AutoSize = true;
            this.rb_insert.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_insert.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.rb_insert.Location = new System.Drawing.Point(388, 239);
            this.rb_insert.Name = "rb_insert";
            this.rb_insert.Size = new System.Drawing.Size(107, 29);
            this.rb_insert.TabIndex = 4;
            this.rb_insert.TabStop = true;
            this.rb_insert.Text = "insert ";
            this.rb_insert.UseVisualStyleBackColor = true;
            // 
            // rb_widthraw
            // 
            this.rb_widthraw.AutoSize = true;
            this.rb_widthraw.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_widthraw.ForeColor = System.Drawing.Color.Crimson;
            this.rb_widthraw.Location = new System.Drawing.Point(388, 204);
            this.rb_widthraw.Name = "rb_widthraw";
            this.rb_widthraw.Size = new System.Drawing.Size(118, 29);
            this.rb_widthraw.TabIndex = 5;
            this.rb_widthraw.TabStop = true;
            this.rb_widthraw.Text = "withdraw";
            this.rb_widthraw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "OLD SOLD:";
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_action.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_action.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_action.Location = new System.Drawing.Point(223, 352);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(130, 46);
            this.btn_action.TabIndex = 7;
            this.btn_action.Text = "ACTION";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // lb_oldSold
            // 
            this.lb_oldSold.AutoSize = true;
            this.lb_oldSold.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_oldSold.ForeColor = System.Drawing.Color.Crimson;
            this.lb_oldSold.Location = new System.Drawing.Point(108, 79);
            this.lb_oldSold.Name = "lb_oldSold";
            this.lb_oldSold.Size = new System.Drawing.Size(50, 20);
            this.lb_oldSold.TabIndex = 8;
            this.lb_oldSold.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "New SOLD :";
            // 
            // lb_NewSold
            // 
            this.lb_NewSold.AutoSize = true;
            this.lb_NewSold.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NewSold.ForeColor = System.Drawing.Color.ForestGreen;
            this.lb_NewSold.Location = new System.Drawing.Point(126, 109);
            this.lb_NewSold.Name = "lb_NewSold";
            this.lb_NewSold.Size = new System.Drawing.Size(63, 25);
            this.lb_NewSold.TabIndex = 10;
            this.lb_NewSold.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 438);
            this.Controls.Add(this.lb_NewSold);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_oldSold);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rb_widthraw);
            this.Controls.Add(this.rb_insert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_insert;
        private System.Windows.Forms.RadioButton rb_widthraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_action;
        private System.Windows.Forms.Label lb_oldSold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_NewSold;
    }
}

