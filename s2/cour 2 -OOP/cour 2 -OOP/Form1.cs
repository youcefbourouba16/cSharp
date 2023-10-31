
namespace cour_2__OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            Person p1 = new Person(1002,"Bourouba","youcef",DateTime.Today);
            Person p2 = new Person(1002, "koko", "lo", DateTime.Today);

        }
    }
}