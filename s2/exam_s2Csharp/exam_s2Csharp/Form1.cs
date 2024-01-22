using exam_s2Csharp.Data;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_s2Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Blue100, TextShade.WHITE);
        }
        SqlConnector cibd = new SqlConnector();
        private void Form1_Load(object sender, EventArgs e)
        {
            //cibd.remplireGV(dataGridView1, "select * from Employer");
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                materialTextBox2.Password = false;
            }
            else materialTextBox2.Password = true;
        }
    }
}
