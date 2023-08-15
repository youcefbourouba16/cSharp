namespace touramentDashboard
{
    partial class touramentDashBoeard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(touramentDashBoeard));
            label1 = new Label();
            touramentList = new ComboBox();
            label5 = new Label();
            loadTorament = new Button();
            creatTourament = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(135, 151);
            label1.Name = "label1";
            label1.Size = new Size(446, 60);
            label1.TabIndex = 1;
            label1.Text = "Tourament Tracker";
            // 
            // touramentList
            // 
            touramentList.BackColor = SystemColors.Window;
            touramentList.FormattingEnabled = true;
            touramentList.Location = new Point(418, 260);
            touramentList.Name = "touramentList";
            touramentList.Size = new Size(189, 23);
            touramentList.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(49, 258);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(361, 23);
            label5.TabIndex = 76;
            label5.Text = "-Load Existing tourament  :";
            // 
            // loadTorament
            // 
            loadTorament.BackColor = Color.DarkKhaki;
            loadTorament.BackgroundImageLayout = ImageLayout.Stretch;
            loadTorament.Cursor = Cursors.Hand;
            loadTorament.FlatAppearance.BorderSize = 0;
            loadTorament.FlatStyle = FlatStyle.Flat;
            loadTorament.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            loadTorament.ForeColor = Color.Black;
            loadTorament.Location = new Point(293, 296);
            loadTorament.Name = "loadTorament";
            loadTorament.Size = new Size(133, 33);
            loadTorament.TabIndex = 77;
            loadTorament.Text = "LOAD";
            loadTorament.UseVisualStyleBackColor = false;
            // 
            // creatTourament
            // 
            creatTourament.BackColor = Color.Gray;
            creatTourament.BackgroundImageLayout = ImageLayout.Stretch;
            creatTourament.Cursor = Cursors.Hand;
            creatTourament.FlatAppearance.BorderSize = 0;
            creatTourament.FlatStyle = FlatStyle.Flat;
            creatTourament.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            creatTourament.ForeColor = Color.Black;
            creatTourament.Location = new Point(172, 359);
            creatTourament.Name = "creatTourament";
            creatTourament.Size = new Size(385, 58);
            creatTourament.TabIndex = 78;
            creatTourament.Text = "ADD TEAM";
            creatTourament.UseVisualStyleBackColor = false;
            // 
            // touramentDashBoeard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(700, 450);
            Controls.Add(creatTourament);
            Controls.Add(loadTorament);
            Controls.Add(label5);
            Controls.Add(touramentList);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "touramentDashBoeard";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox touramentList;
        private Label label5;
        private Button loadTorament;
        private Button creatTourament;
    }
}