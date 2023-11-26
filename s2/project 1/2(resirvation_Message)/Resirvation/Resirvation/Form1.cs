using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resirvation
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_depart.SelectedText = "--- select";
            cb_depart.SelectedItem = null;
            cb_depart.SelectedIndex = -1;
            string[] wilaya = { "adrar", "Alger", "ghardaya", "chlef" };
            cb_depart.Items.AddRange(wilaya);
            
            cb_Ariver.SelectedText = "--- select";
            cb_Ariver.SelectedItem = null;
            cb_Ariver.SelectedIndex = -1;
            cb_Ariver.Items.AddRange(wilaya);
        }

        private void btn_reserve_Click(object sender, EventArgs e)
        {
            if (cb_Ariver.SelectedItem != null || cb_depart.SelectedItem != null)
            {

            }
            else MessageBox.Show("Veuillez sélectionner la wilaya de départ et la destination.",
                "Ivalid Distination",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }

}
