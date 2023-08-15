namespace WinFormsApp2
{
    partial class CreatTour_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatTour_form));
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            touramentName = new TextBox();
            entryFee_val = new TextBox();
            round_list = new ComboBox();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            btn_addTeam = new Button();
            btn_addPrize = new Button();
            matchupListBox = new ListBox();
            deleteSelectedTeam = new Button();
            deleteSelectedPrize = new Button();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
            btn_addTourament = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 29);
            label1.TabIndex = 1;
            label1.Text = "Creat Tourament :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(13, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(186, 22);
            label3.TabIndex = 3;
            label3.Text = "Tourament Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(13, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 22);
            label2.TabIndex = 4;
            label2.Text = "Entry fee :";
            // 
            // touramentName
            // 
            touramentName.BorderStyle = BorderStyle.FixedSingle;
            touramentName.Location = new Point(206, 74);
            touramentName.Name = "touramentName";
            touramentName.Size = new Size(329, 29);
            touramentName.TabIndex = 5;
            // 
            // entryFee_val
            // 
            entryFee_val.BorderStyle = BorderStyle.FixedSingle;
            entryFee_val.Location = new Point(206, 117);
            entryFee_val.Name = "entryFee_val";
            entryFee_val.Size = new Size(98, 29);
            entryFee_val.TabIndex = 6;
            entryFee_val.Text = "0";
            // 
            // round_list
            // 
            round_list.FlatStyle = FlatStyle.Flat;
            round_list.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            round_list.FormattingEnabled = true;
            round_list.Location = new Point(170, 164);
            round_list.Name = "round_list";
            round_list.Size = new Size(220, 29);
            round_list.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(13, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(153, 21);
            label4.TabIndex = 8;
            label4.Text = "SELECT TEAM :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(396, 168);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(98, 21);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Creat Team ?";
            // 
            // btn_addTeam
            // 
            btn_addTeam.BackColor = Color.Turquoise;
            btn_addTeam.BackgroundImageLayout = ImageLayout.Stretch;
            btn_addTeam.Cursor = Cursors.Hand;
            btn_addTeam.FlatAppearance.BorderSize = 0;
            btn_addTeam.FlatStyle = FlatStyle.Flat;
            btn_addTeam.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addTeam.Location = new Point(39, 214);
            btn_addTeam.Name = "btn_addTeam";
            btn_addTeam.Size = new Size(183, 46);
            btn_addTeam.TabIndex = 20;
            btn_addTeam.Text = "ADD TEAM";
            btn_addTeam.UseVisualStyleBackColor = false;
            // 
            // btn_addPrize
            // 
            btn_addPrize.BackColor = Color.DarkKhaki;
            btn_addPrize.BackgroundImageLayout = ImageLayout.Stretch;
            btn_addPrize.Cursor = Cursors.Hand;
            btn_addPrize.FlatAppearance.BorderSize = 0;
            btn_addPrize.FlatStyle = FlatStyle.Flat;
            btn_addPrize.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addPrize.ForeColor = Color.White;
            btn_addPrize.Location = new Point(255, 214);
            btn_addPrize.Name = "btn_addPrize";
            btn_addPrize.Size = new Size(183, 46);
            btn_addPrize.TabIndex = 21;
            btn_addPrize.Text = "ADD PRIZE";
            btn_addPrize.UseVisualStyleBackColor = false;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.None;
            matchupListBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            matchupListBox.ForeColor = Color.SteelBlue;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 21;
            matchupListBox.Location = new Point(41, 314);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.ScrollAlwaysVisible = true;
            matchupListBox.Size = new Size(245, 189);
            matchupListBox.TabIndex = 22;
            // 
            // deleteSelectedTeam
            // 
            deleteSelectedTeam.BackColor = Color.RosyBrown;
            deleteSelectedTeam.BackgroundImageLayout = ImageLayout.Stretch;
            deleteSelectedTeam.Cursor = Cursors.Hand;
            deleteSelectedTeam.FlatAppearance.BorderSize = 0;
            deleteSelectedTeam.FlatStyle = FlatStyle.Flat;
            deleteSelectedTeam.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedTeam.Location = new Point(310, 370);
            deleteSelectedTeam.Name = "deleteSelectedTeam";
            deleteSelectedTeam.Size = new Size(80, 63);
            deleteSelectedTeam.TabIndex = 23;
            deleteSelectedTeam.Text = "DELETE SELECTED";
            deleteSelectedTeam.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrize
            // 
            deleteSelectedPrize.BackColor = Color.RosyBrown;
            deleteSelectedPrize.BackgroundImageLayout = ImageLayout.Stretch;
            deleteSelectedPrize.Cursor = Cursors.Hand;
            deleteSelectedPrize.FlatAppearance.BorderSize = 0;
            deleteSelectedPrize.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrize.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPrize.Location = new Point(822, 148);
            deleteSelectedPrize.Name = "deleteSelectedPrize";
            deleteSelectedPrize.Size = new Size(80, 63);
            deleteSelectedPrize.TabIndex = 25;
            deleteSelectedPrize.Text = "DELETE SELECTED";
            deleteSelectedPrize.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.ForeColor = Color.DarkKhaki;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(565, 81);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(245, 189);
            listBox1.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(39, 279);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 26;
            label5.Text = "TEAM / PLAYERS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkKhaki;
            label6.Location = new Point(565, 48);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 27;
            label6.Text = "Prize LIST";
            // 
            // btn_addTourament
            // 
            btn_addTourament.BackColor = Color.PaleGoldenrod;
            btn_addTourament.BackgroundImageLayout = ImageLayout.Stretch;
            btn_addTourament.Cursor = Cursors.Hand;
            btn_addTourament.FlatAppearance.BorderSize = 0;
            btn_addTourament.FlatStyle = FlatStyle.Flat;
            btn_addTourament.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addTourament.Location = new Point(441, 393);
            btn_addTourament.Name = "btn_addTourament";
            btn_addTourament.Size = new Size(455, 61);
            btn_addTourament.TabIndex = 28;
            btn_addTourament.Text = "ADD SCORE";
            btn_addTourament.UseVisualStyleBackColor = false;
            // 
            // CreatTour_form
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(928, 552);
            Controls.Add(btn_addTourament);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(deleteSelectedPrize);
            Controls.Add(listBox1);
            Controls.Add(deleteSelectedTeam);
            Controls.Add(matchupListBox);
            Controls.Add(btn_addPrize);
            Controls.Add(btn_addTeam);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(round_list);
            Controls.Add(entryFee_val);
            Controls.Add(touramentName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "CreatTour_form";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox touramentName;
        private TextBox entryFee_val;
        private ComboBox round_list;
        private Label label4;
        private LinkLabel linkLabel1;
        private Button btn_addTeam;
        private Button btn_addPrize;
        private ListBox matchupListBox;
        private Button deleteSelectedTeam;
        private Button deleteSelectedPrize;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private Button btn_addTourament;
    }
}