namespace exam_s2Csharp
{
    partial class frm_etudian
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_dn = new System.Windows.Forms.DateTimePicker();
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_mat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sexe = new System.Windows.Forms.ComboBox();
            this.btn_fermer = new MaterialSkin.Controls.MaterialButton();
            this.btn_Ajoute = new MaterialSkin.Controls.MaterialButton();
            this.dgv_etudiant = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_dn);
            this.panel1.Controls.Add(this.tb_prenom);
            this.panel1.Controls.Add(this.tb_nom);
            this.panel1.Controls.Add(this.tb_mat);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_sexe);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 202);
            this.panel1.TabIndex = 0;
            // 
            // dtp_dn
            // 
            this.dtp_dn.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dn.Location = new System.Drawing.Point(120, 167);
            this.dtp_dn.MinDate = new System.DateTime(1960, 1, 25, 0, 0, 0, 0);
            this.dtp_dn.Name = "dtp_dn";
            this.dtp_dn.Size = new System.Drawing.Size(256, 23);
            this.dtp_dn.TabIndex = 9;
            // 
            // tb_prenom
            // 
            this.tb_prenom.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_prenom.Location = new System.Drawing.Point(116, 82);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(100, 26);
            this.tb_prenom.TabIndex = 8;
            // 
            // tb_nom
            // 
            this.tb_nom.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nom.Location = new System.Drawing.Point(116, 51);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 26);
            this.tb_nom.TabIndex = 7;
            // 
            // tb_mat
            // 
            this.tb_mat.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_mat.Location = new System.Drawing.Point(116, 14);
            this.tb_mat.Name = "tb_mat";
            this.tb_mat.Size = new System.Drawing.Size(100, 26);
            this.tb_mat.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date Nais :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mat :";
            // 
            // cb_sexe
            // 
            this.cb_sexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_sexe.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sexe.Location = new System.Drawing.Point(116, 123);
            this.cb_sexe.Name = "cb_sexe";
            this.cb_sexe.Size = new System.Drawing.Size(121, 29);
            this.cb_sexe.TabIndex = 0;
            this.cb_sexe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_sexe_KeyPress);
            // 
            // btn_fermer
            // 
            this.btn_fermer.AutoSize = false;
            this.btn_fermer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_fermer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_fermer.Depth = 0;
            this.btn_fermer.HighEmphasis = false;
            this.btn_fermer.Icon = null;
            this.btn_fermer.Location = new System.Drawing.Point(625, 85);
            this.btn_fermer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_fermer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_fermer.Size = new System.Drawing.Size(106, 36);
            this.btn_fermer.TabIndex = 19;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btn_fermer.UseAccentColor = false;
            this.btn_fermer.UseVisualStyleBackColor = true;
            // 
            // btn_Ajoute
            // 
            this.btn_Ajoute.AutoSize = false;
            this.btn_Ajoute.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Ajoute.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Ajoute.Depth = 0;
            this.btn_Ajoute.HighEmphasis = true;
            this.btn_Ajoute.Icon = null;
            this.btn_Ajoute.Location = new System.Drawing.Point(437, 85);
            this.btn_Ajoute.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Ajoute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Ajoute.Name = "btn_Ajoute";
            this.btn_Ajoute.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Ajoute.Size = new System.Drawing.Size(168, 36);
            this.btn_Ajoute.TabIndex = 18;
            this.btn_Ajoute.Text = "Ajoute";
            this.btn_Ajoute.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Ajoute.UseAccentColor = false;
            this.btn_Ajoute.UseVisualStyleBackColor = true;
            this.btn_Ajoute.Click += new System.EventHandler(this.btn_Ajoute_Click);
            // 
            // dgv_etudiant
            // 
            this.dgv_etudiant.AllowUserToAddRows = false;
            this.dgv_etudiant.AllowUserToDeleteRows = false;
            this.dgv_etudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_etudiant.Location = new System.Drawing.Point(2, 220);
            this.dgv_etudiant.Name = "dgv_etudiant";
            this.dgv_etudiant.ReadOnly = true;
            this.dgv_etudiant.Size = new System.Drawing.Size(603, 260);
            this.dgv_etudiant.TabIndex = 20;
            // 
            // frm_etudian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 492);
            this.Controls.Add(this.dgv_etudiant);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_Ajoute);
            this.Controls.Add(this.panel1);
            this.Name = "frm_etudian";
            this.Text = "frm_etudian";
            this.Load += new System.EventHandler(this.frm_etudian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_etudiant)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_dn;
        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_mat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_sexe;
        private MaterialSkin.Controls.MaterialButton btn_fermer;
        private MaterialSkin.Controls.MaterialButton btn_Ajoute;
        private System.Windows.Forms.DataGridView dgv_etudiant;
    }
}