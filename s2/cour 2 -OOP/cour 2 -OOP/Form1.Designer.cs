namespace cour_2__OOP
{
    partial class Form1
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
            CreatePerson = new Button();
            SuspendLayout();
            // 
            // CreatePerson
            // 
            CreatePerson.FlatStyle = FlatStyle.Popup;
            CreatePerson.Location = new Point(329, 236);
            CreatePerson.Name = "CreatePerson";
            CreatePerson.Size = new Size(137, 23);
            CreatePerson.TabIndex = 0;
            CreatePerson.Text = "New Person";
            CreatePerson.UseVisualStyleBackColor = true;
            CreatePerson.Click += CreatePerson_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CreatePerson);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CreatePerson;
    }
}