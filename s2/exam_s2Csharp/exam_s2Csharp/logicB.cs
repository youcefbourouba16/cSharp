using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_s2Csharp
{
    public  class logicB
    {
        public static bool verifierTbInPanel(Panel p)
        {
            Boolean b = false;
            foreach (Control c in p.Controls)
            {
                if (c is TextBox)
                {
                    if (c.Text == "") { b = true; }
                }
                if (b) break;
            }
            return b;
        }
        public static  void messageboxAffich(string message, string caption)
        {
            MessageBox.Show(message, caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

    }
}
