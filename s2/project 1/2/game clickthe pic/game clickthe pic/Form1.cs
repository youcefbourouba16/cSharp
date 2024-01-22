using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace game_clickthe_pic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setTextsToPanel();
            btn_stop.Enabled = false;

        }
        // for the time of button inside the panel
        private readonly System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        //for times left 
        private readonly System.Windows.Forms.Timer timer10sec = new System.Windows.Forms.Timer();

        Image image = Image.FromFile("C:\\dev study\\matlab\\n tier resources\\5392325 (1).png");
        int totalSecond;
        int currentsecond = 0;
        int score = 0;
      
        private void set_Deficulty()
        {
            currentsecond = 0;
            if (rb_easy.Checked)
            {
                timer.Interval = 1000; // Set the timer interval to 1000 milliseconds (1 second)
                totalSecond = 10;
            }
            else if (rb_medium.Checked)
            {
                timer.Interval = 500;
                totalSecond = 20;
            }else
            {
                timer.Interval = 250;
                totalSecond = 40;
            }
        }
        private void Timer_Tick(object sender, EventArgs e) {
            if (currentsecond<totalSecond-1)
            {
                squerlAprears();
                currentsecond++;
            }else
            {
                timer.Stop();
                MessageBox.Show($"you Score is : {score}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_start.Enabled = true;
                panel1.Controls.Clear();
                setTextsToPanel();
                groupBox1.Enabled = true;
                return;
            }

        }
        int timesLeft = 10;
        
        private void Timer10sec_Tick(object sender, EventArgs e)
        {
            
            timesLeft--;
            lb_timeLeft.Text= $"00:0{timesLeft}";
            if (timesLeft==5)
            {
                lb_timeLeft.ForeColor = Color.Red;
            }
            if (true) if (timesLeft == 0) {
                    lb_timeLeft.ForeColor = Color.Black;
                    lb_timeLeft.Text= lb_timeLeft.Text = "";
                    timesLeft = 10;
                    timer10sec.Stop();
                } 

        }
        private void setTextsToPanel()
        { 
            //add label
            Label label = new Label();
            label.Text = "Welcome to  THE SQUIRREL Game !";
            label.ForeColor = Color.Red;
            label.Size = new Size(600, 40);
            label.Font = new Font("cascadia code", 20, FontStyle.Bold);
            label.Location = new Point(50, 110);
            panel1.Controls.Add(label);

            //// add label 1
            Label label1 = new Label();
            label1.Text = "-Press (Let's Go) To start .";
            label1.Size = new Size(400, 40);
            label1.Font = new Font("cascadia code", 10, FontStyle.Bold);
            label1.Location = new Point(285, 160);
            panel1.Controls.Add(label1);

        }

        private void squerlAprears()
        {
            Button btn_squell = new Button();
            panel1.Controls.Clear();
            Random ran = new Random();
            int i = ran.Next(0, 550);
            int j = ran.Next(0, 350);
            
            btn_squell.Size = new Size(30, 30);
            btn_squell.Image = image;
            btn_squell.ImageAlign = ContentAlignment.MiddleLeft;
            btn_squell.Location = new Point(i, j);
            panel1.Controls.Add(btn_squell);
            //// button click counter

            btn_squell.MouseEnter += (sender, e) => {
                if (btn_squell.Enabled)
                {
                    score++;
                    btn_squell.Enabled = false;
                }
            };
        }
        
        private void btn_start_Click_1(object sender, EventArgs e)
        {
            timer.Stop();
            set_Deficulty();
            // for panel time 
            timer.Tick -= Timer_Tick;
            timer.Tick += Timer_Tick;
            // for label left time 
            timer10sec.Interval = 1000;
            timer10sec.Tick -= Timer10sec_Tick;
            timer10sec.Tick += Timer10sec_Tick;
            btn_start.Enabled = false;
            groupBox1.Enabled= false;
            timer.Start();
            timer10sec.Start();
            score = 0;
            setTextsToPanel();
            btn_stop.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer10sec.Stop();
            lb_timeLeft.Text = "";
            timesLeft = 10;
            panel1.Controls.Clear();
            setTextsToPanel();
            btn_start.Enabled = true;
            score = 0;
            btn_stop.Enabled = false;
            groupBox1.Enabled = true;
        }

        
        
    }
}
