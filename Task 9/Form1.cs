using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_9
{
    public partial class Form1 : Form
    {
        int Speed = 15;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnBrake_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Car2.Visible = false;
            Car3.Visible = false;
            Car4.Visible = false;
        }

        private void Car1_Click(object sender, EventArgs e){}
        private void Car3_Click(object sender, EventArgs e){}

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            Car1.Visible = true;
            Car2.Visible = false;
            Car3.Visible = false;
            Car4.Visible = false;
            Car1.Location = new Point(13, 352);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Car1.Location = new Point(Car1.Location.X + Speed, Car1.Location.Y);

            if (Car1.Location.X > 797)
            {
                Car1.Visible = false;
                Car2.Visible = true;
                timer2.Start();
                timer1.Stop();
                Car1.Location = new Point(13, 352);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Car2.Location = new Point(Car2.Location.X, Car2.Location.Y - Speed);

            if (Car2.Location.Y < 21)
            {
                Car2.Visible = false;
                Car3.Visible = true;
                timer3.Start();
                timer2.Stop();
                Car2.Location = new Point(797, 352);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Car3.Location = new Point(Car3.Location.X - Speed, Car3.Location.Y);

            if (Car3.Location.X < 12)
            {
                Car3.Visible = false;
                Car4.Visible = true;
                timer4.Start();
                timer3.Stop();
                Car3.Location = new Point(797, 21);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            Car4.Location = new Point(Car4.Location.X, Car4.Location.Y + Speed);

            if (Car4.Location.Y > 352)
            {
                Car4.Visible = false;
                Car1.Visible = true;
                timer1.Start();
                timer4.Stop();
                Car4.Location = new Point(12, 21);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGear1_Click(object sender, EventArgs e)
        {
            Speed = 20;
        }

        private void btnGear2_Click(object sender, EventArgs e)
        {
            Speed = 30;
        }

        private void btnGear3_Click(object sender, EventArgs e)
        {
            Speed = 40;
        }

        private void btnGear4_Click(object sender, EventArgs e)
        {
            Speed = 50;
        }
    }
}
