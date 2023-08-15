namespace creatTeamForm
{
    partial class CreatTeam_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatTeam_view));
            label3 = new Label();
            label1 = new Label();
            tb_teamName = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            firstName = new TextBox();
            lastName = new TextBox();
            email = new TextBox();
            phoneNum = new TextBox();
            CreatNumber = new Button();
            addMember = new Button();
            label8 = new Label();
            teamMemberList = new ListBox();
            creatTeam = new Button();
            deleteSelectedPlayer = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(13, 76);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 22);
            label3.TabIndex = 29;
            label3.Text = "Team Name :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(13, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 29);
            label1.TabIndex = 28;
            label1.Text = "Creat Team :";
            // 
            // tb_teamName
            // 
            tb_teamName.BorderStyle = BorderStyle.FixedSingle;
            tb_teamName.Location = new Point(17, 101);
            tb_teamName.Name = "tb_teamName";
            tb_teamName.Size = new Size(240, 23);
            tb_teamName.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(17, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(230, 22);
            label2.TabIndex = 31;
            label2.Text = "Select team MEMBER :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(18, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(230, 23);
            comboBox1.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(phoneNum);
            groupBox1.Controls.Add(email);
            groupBox1.Controls.Add(lastName);
            groupBox1.Controls.Add(firstName);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Candara", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(16, 279);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 175);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New member :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 32);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 19);
            label4.TabIndex = 34;
            label4.Text = "-First Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(5, 63);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 35;
            label5.Text = "-Last Name :";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(5, 98);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 36;
            label6.Text = "-Email   :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(10, 131);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 19);
            label7.TabIndex = 37;
            label7.Text = "-Phone Num :";
            // 
            // firstName
            // 
            firstName.BorderStyle = BorderStyle.FixedSingle;
            firstName.Location = new Point(152, 29);
            firstName.Name = "firstName";
            firstName.Size = new Size(161, 26);
            firstName.TabIndex = 34;
            // 
            // lastName
            // 
            lastName.BorderStyle = BorderStyle.FixedSingle;
            lastName.Location = new Point(152, 61);
            lastName.Name = "lastName";
            lastName.Size = new Size(161, 26);
            lastName.TabIndex = 38;
            // 
            // email
            // 
            email.BorderStyle = BorderStyle.FixedSingle;
            email.Location = new Point(152, 93);
            email.Name = "email";
            email.Size = new Size(161, 26);
            email.TabIndex = 39;
            // 
            // phoneNum
            // 
            phoneNum.BorderStyle = BorderStyle.FixedSingle;
            phoneNum.Location = new Point(152, 129);
            phoneNum.Name = "phoneNum";
            phoneNum.Size = new Size(161, 26);
            phoneNum.TabIndex = 40;
            // 
            // CreatNumber
            // 
            CreatNumber.BackColor = Color.Turquoise;
            CreatNumber.BackgroundImageLayout = ImageLayout.Stretch;
            CreatNumber.Cursor = Cursors.Hand;
            CreatNumber.FlatAppearance.BorderSize = 0;
            CreatNumber.FlatStyle = FlatStyle.Flat;
            CreatNumber.Font = new Font("Unispace", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            CreatNumber.ForeColor = Color.White;
            CreatNumber.Location = new Point(78, 471);
            CreatNumber.Name = "CreatNumber";
            CreatNumber.Size = new Size(183, 46);
            CreatNumber.TabIndex = 34;
            CreatNumber.Text = "ADD TEAM";
            CreatNumber.UseVisualStyleBackColor = false;
            // 
            // addMember
            // 
            addMember.BackColor = Color.DarkKhaki;
            addMember.BackgroundImageLayout = ImageLayout.Stretch;
            addMember.Cursor = Cursors.Hand;
            addMember.FlatAppearance.BorderSize = 0;
            addMember.FlatStyle = FlatStyle.Flat;
            addMember.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            addMember.ForeColor = Color.Black;
            addMember.Location = new Point(68, 219);
            addMember.Name = "addMember";
            addMember.Size = new Size(133, 33);
            addMember.TabIndex = 41;
            addMember.Text = " ADD Member";
            addMember.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(374, 28);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(241, 21);
            label8.TabIndex = 43;
            label8.Text = "Team player Memeber :";
            // 
            // teamMemberList
            // 
            teamMemberList.BorderStyle = BorderStyle.None;
            teamMemberList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            teamMemberList.ForeColor = Color.SteelBlue;
            teamMemberList.FormattingEnabled = true;
            teamMemberList.ItemHeight = 21;
            teamMemberList.Location = new Point(376, 63);
            teamMemberList.Name = "teamMemberList";
            teamMemberList.ScrollAlwaysVisible = true;
            teamMemberList.Size = new Size(380, 378);
            teamMemberList.TabIndex = 42;
            // 
            // creatTeam
            // 
            creatTeam.BackColor = Color.PaleGoldenrod;
            creatTeam.BackgroundImageLayout = ImageLayout.Stretch;
            creatTeam.Cursor = Cursors.Hand;
            creatTeam.FlatAppearance.BorderSize = 0;
            creatTeam.FlatStyle = FlatStyle.Flat;
            creatTeam.Font = new Font("Unispace", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            creatTeam.ForeColor = SystemColors.Desktop;
            creatTeam.Location = new Point(391, 462);
            creatTeam.Name = "creatTeam";
            creatTeam.Size = new Size(331, 60);
            creatTeam.TabIndex = 44;
            creatTeam.Text = "Creat Team";
            creatTeam.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPlayer
            // 
            deleteSelectedPlayer.BackColor = Color.RosyBrown;
            deleteSelectedPlayer.BackgroundImageLayout = ImageLayout.Stretch;
            deleteSelectedPlayer.Cursor = Cursors.Hand;
            deleteSelectedPlayer.FlatAppearance.BorderSize = 0;
            deleteSelectedPlayer.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayer.Font = new Font("Unispace", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            deleteSelectedPlayer.ForeColor = Color.White;
            deleteSelectedPlayer.Location = new Point(286, 118);
            deleteSelectedPlayer.Name = "deleteSelectedPlayer";
            deleteSelectedPlayer.Size = new Size(80, 63);
            deleteSelectedPlayer.TabIndex = 45;
            deleteSelectedPlayer.Text = "DELETE SELECTED";
            deleteSelectedPlayer.UseVisualStyleBackColor = false;
            // 
            // CreatTeam_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(774, 534);
            Controls.Add(deleteSelectedPlayer);
            Controls.Add(creatTeam);
            Controls.Add(label8);
            Controls.Add(teamMemberList);
            Controls.Add(addMember);
            Controls.Add(CreatNumber);
            Controls.Add(groupBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(tb_teamName);
            Controls.Add(label3);
            Controls.Add(label1);
            ForeColor = SystemColors.GradientInactiveCaption;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CreatTeam_view";
            Text = "Creat team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private TextBox tb_teamName;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox phoneNum;
        private TextBox email;
        private TextBox lastName;
        private TextBox firstName;
        private Button CreatNumber;
        private Button addMember;
        private Label label8;
        private ListBox teamMemberList;
        private Button creatTeam;
        private Button deleteSelectedPlayer;
    }
}