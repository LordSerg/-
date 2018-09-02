using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        int z = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled==true)
            {
                timer1.Enabled = false;
                button2.BackgroundImage = Properties.Resources.Play_1;
            }
            else
            {
                timer1.Enabled = true;
                button2.BackgroundImage = Properties.Resources.Pause_1;
            }
        }
        int t = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(pictureBox1.Location.X<this.Width-pictureBox1.Width-20&&z==0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                if(t == 1)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._1;
                }
                if (t == 2)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._2;
                }
                if (t == 3)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._3;
                }
                if (t == 4)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._4;
                }
                if (t == 5)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._5;
                }
                if (t == 6)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._6;
                }
                if (t == 7)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._7;
                }
            }
            else if(z==0)
            {
                t++;
                z = 1;
                if (t > 7)
                    t = 1;
            }
            if (pictureBox1.Location.X > 20 && z == 1)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
                if (t == 1)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._1;
                }
                if (t == 2)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._2;
                }
                if (t == 3)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._3;
                }
                if (t == 4)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._4;
                }
                if (t == 5)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._5;
                }
                if (t == 6)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._6;
                }
                if (t == 7)
                {
                    pictureBox1.BackgroundImage = Properties.Resources._7;
                }
            }
            else if(z==1)
            {
                t++;
                z = 0;
                if (t > 7)
                    t = 1;
            }
        }

        private void головногоМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Головне меню";
            f.Show();
            this.Close();
        }
        private void налаштуванняФормиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Налаштування форми";
            f.Show();
            this.Close();
        }
        private void побудовиПолейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Побудова полей";
            f.Show();
            this.Close();
        }
        private void webсайтуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Web-сайт";
            f.Show();
            this.Close();
        }
        private void відеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Відео";
            f.Show();
            this.Close();
        }
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
