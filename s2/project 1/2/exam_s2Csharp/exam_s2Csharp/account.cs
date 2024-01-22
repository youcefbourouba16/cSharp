using exam_s2Csharp.Data;
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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnector cib=new SqlConnector();
        private void account_Load(object sender, EventArgs e)
        {
            cib.remplireGV(dataGridView1, "select * from person");
        }
    }
}
