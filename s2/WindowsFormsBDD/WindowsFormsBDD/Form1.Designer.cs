namespace WindowsFormsBDD
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvEmployes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_struct = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerDN = new System.Windows.Forms.DateTimePicker();
            this.textBoxConpass = new System.Windows.Forms.TextBox();
            this.labelCONPASS = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUSER = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEMAIL = new System.Windows.Forms.Label();
            this.labelDATENAISS = new System.Windows.Forms.Label();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.labelPRENOM = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.labelNOM = new System.Windows.Forms.Label();
            this.btn_DeleteEmp = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.tb_Filtre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Filter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployes
            // 
            this.dgvEmployes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEmployes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployes.Location = new System.Drawing.Point(0, 224);
            this.dgvEmployes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployes.Name = "dgvEmployes";
            this.dgvEmployes.RowHeadersWidth = 51;
            this.dgvEmployes.RowTemplate.Height = 24;
            this.dgvEmployes.Size = new System.Drawing.Size(926, 295);
            this.dgvEmployes.TabIndex = 0;
            this.dgvEmployes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployes_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_struct);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePickerDN);
            this.panel1.Controls.Add(this.textBoxConpass);
            this.panel1.Controls.Add(this.labelCONPASS);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPASSWORD);
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.labelUSER);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelEMAIL);
            this.panel1.Controls.Add(this.labelDATENAISS);
            this.panel1.Controls.Add(this.textBoxPrenom);
            this.panel1.Controls.Add(this.labelPRENOM);
            this.panel1.Controls.Add(this.textBoxNom);
            this.panel1.Controls.Add(this.labelNOM);
            this.panel1.Location = new System.Drawing.Point(8, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 190);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Struct";
            // 
            // tb_struct
            // 
            this.tb_struct.Location = new System.Drawing.Point(64, 32);
            this.tb_struct.Name = "tb_struct";
            this.tb_struct.Size = new System.Drawing.Size(111, 20);
            this.tb_struct.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(393, 138);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerDN
            // 
            this.dateTimePickerDN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDN.Location = new System.Drawing.Point(79, 122);
            this.dateTimePickerDN.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDN.Name = "dateTimePickerDN";
            this.dateTimePickerDN.Size = new System.Drawing.Size(97, 20);
            this.dateTimePickerDN.TabIndex = 16;
            // 
            // textBoxConpass
            // 
            this.textBoxConpass.Location = new System.Drawing.Point(263, 91);
            this.textBoxConpass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConpass.Name = "textBoxConpass";
            this.textBoxConpass.Size = new System.Drawing.Size(111, 20);
            this.textBoxConpass.TabIndex = 15;
            // 
            // labelCONPASS
            // 
            this.labelCONPASS.AutoSize = true;
            this.labelCONPASS.Location = new System.Drawing.Point(213, 93);
            this.labelCONPASS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCONPASS.Name = "labelCONPASS";
            this.labelCONPASS.Size = new System.Drawing.Size(53, 13);
            this.labelCONPASS.TabIndex = 14;
            this.labelCONPASS.Text = "conpass :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(263, 59);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(111, 20);
            this.textBoxPassword.TabIndex = 13;
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.Location = new System.Drawing.Point(209, 60);
            this.labelPASSWORD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(59, 13);
            this.labelPASSWORD.TabIndex = 12;
            this.labelPASSWORD.Text = "Password :";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(263, 31);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(111, 20);
            this.textBoxUser.TabIndex = 11;
            // 
            // labelUSER
            // 
            this.labelUSER.AutoSize = true;
            this.labelUSER.Location = new System.Drawing.Point(224, 34);
            this.labelUSER.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUSER.Name = "labelUSER";
            this.labelUSER.Size = new System.Drawing.Size(35, 13);
            this.labelUSER.TabIndex = 10;
            this.labelUSER.Text = "User :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(64, 158);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(111, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelEMAIL
            // 
            this.labelEMAIL.AutoSize = true;
            this.labelEMAIL.Location = new System.Drawing.Point(20, 160);
            this.labelEMAIL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEMAIL.Name = "labelEMAIL";
            this.labelEMAIL.Size = new System.Drawing.Size(38, 13);
            this.labelEMAIL.TabIndex = 8;
            this.labelEMAIL.Text = "Email :";
            // 
            // labelDATENAISS
            // 
            this.labelDATENAISS.AutoSize = true;
            this.labelDATENAISS.Location = new System.Drawing.Point(14, 125);
            this.labelDATENAISS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDATENAISS.Name = "labelDATENAISS";
            this.labelDATENAISS.Size = new System.Drawing.Size(65, 13);
            this.labelDATENAISS.TabIndex = 6;
            this.labelDATENAISS.Text = "Date Naiss :";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(64, 91);
            this.textBoxPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(111, 20);
            this.textBoxPrenom.TabIndex = 5;
            // 
            // labelPRENOM
            // 
            this.labelPRENOM.AutoSize = true;
            this.labelPRENOM.Location = new System.Drawing.Point(14, 93);
            this.labelPRENOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPRENOM.Name = "labelPRENOM";
            this.labelPRENOM.Size = new System.Drawing.Size(49, 13);
            this.labelPRENOM.TabIndex = 4;
            this.labelPRENOM.Text = "Prenom :";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(64, 57);
            this.textBoxNom.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(111, 20);
            this.textBoxNom.TabIndex = 3;
            // 
            // labelNOM
            // 
            this.labelNOM.AutoSize = true;
            this.labelNOM.Location = new System.Drawing.Point(28, 59);
            this.labelNOM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNOM.Name = "labelNOM";
            this.labelNOM.Size = new System.Drawing.Size(35, 13);
            this.labelNOM.TabIndex = 2;
            this.labelNOM.Text = "Nom :";
            // 
            // btn_DeleteEmp
            // 
            this.btn_DeleteEmp.Location = new System.Drawing.Point(127, 46);
            this.btn_DeleteEmp.Name = "btn_DeleteEmp";
            this.btn_DeleteEmp.Size = new System.Drawing.Size(106, 32);
            this.btn_DeleteEmp.TabIndex = 22;
            this.btn_DeleteEmp.Text = "supprimer Emp";
            this.btn_DeleteEmp.UseVisualStyleBackColor = true;
            this.btn_DeleteEmp.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(3, 46);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(104, 32);
            this.btn_edit.TabIndex = 21;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // tb_Filtre
            // 
            this.tb_Filtre.Location = new System.Drawing.Point(3, 20);
            this.tb_Filtre.Name = "tb_Filtre";
            this.tb_Filtre.Size = new System.Drawing.Size(230, 20);
            this.tb_Filtre.TabIndex = 2;
            this.tb_Filtre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FIND :";
            // 
            // panel_Filter
            // 
            this.panel_Filter.Controls.Add(this.tb_Filtre);
            this.panel_Filter.Controls.Add(this.btn_DeleteEmp);
            this.panel_Filter.Controls.Add(this.label2);
            this.panel_Filter.Controls.Add(this.btn_edit);
            this.panel_Filter.Location = new System.Drawing.Point(593, 90);
            this.panel_Filter.Name = "panel_Filter";
            this.panel_Filter.Size = new System.Drawing.Size(242, 83);
            this.panel_Filter.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(929, 521);
            this.Controls.Add(this.panel_Filter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployes);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FormEmployes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Filter.ResumeLayout(false);
            this.panel_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxConpass;
        private System.Windows.Forms.Label labelCONPASS;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUSER;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEMAIL;
        private System.Windows.Forms.Label labelDATENAISS;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.Label labelPRENOM;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label labelNOM;
        private System.Windows.Forms.DateTimePicker dateTimePickerDN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_struct;
        private System.Windows.Forms.TextBox tb_Filtre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_DeleteEmp;
        private System.Windows.Forms.Panel panel_Filter;
    }
}

