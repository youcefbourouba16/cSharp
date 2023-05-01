namespace tableux
{
    partial class Form2
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
            label1 = new Label();
            tb1 = new TextBox();
            btaffich = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "donner N";
            // 
            // tb1
            // 
            tb1.Location = new Point(222, 62);
            tb1.Name = "tb1";
            tb1.Size = new Size(100, 23);
            tb1.TabIndex = 1;
            // 
            // btaffich
            // 
            btaffich.Location = new Point(490, 61);
            btaffich.Name = "btaffich";
            btaffich.Size = new Size(75, 23);
            btaffich.TabIndex = 2;
            btaffich.Text = "affiche";
            btaffich.UseVisualStyleBackColor = true;
            btaffich.Click += btaffich_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(31, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 357);
            panel1.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 485);
            Controls.Add(panel1);
            Controls.Add(btaffich);
            Controls.Add(tb1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb1;
        private Button btaffich;
        private Panel panel1;
    }
}