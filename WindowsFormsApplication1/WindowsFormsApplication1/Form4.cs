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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;//титульна
            groupBox2.Visible = true;//головне меню
            groupBox3.Visible = true;//налшт.форми
            groupBox4.Visible = true;//побуд. полей
            groupBox5.Visible = true;//веб-сайт
            groupBox6.Visible = true;//дод. анімація
            groupBox7.Visible = true;//відео
            groupBox8.Visible = true;//структ. проекту
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {//головне меню
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox1.Location = new Point(10, 10);
            //label1.Location = new Point(10, 10);
            groupBox1.Size = new Size(this.Width - 50, this.Height - 100);

        }

        private void menuItem6_Click(object sender, EventArgs e)
        {//побуд. полей
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {//веб-сайт
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {//дод. анімація
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {//відео
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = false;
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {//налшт.форми
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Головне меню";
            f.Show();
            this.Close();
        }
        int x, y,x1,y1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black, 1);
            x = groupBox1.Location.X + groupBox1.Width / 2;
            y = groupBox1.Location.Y + groupBox1.Height;
            x1 = groupBox2.Location.X + groupBox2.Width / 2;
            y1 = groupBox2.Location.Y;
            g.DrawLine(p, x, y, x1, y1);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);

            //
            x = groupBox2.Location.X;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox3.Location.X + groupBox3.Width / 2;
            y1 = groupBox3.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width / 5;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox4.Location.X + groupBox4.Width / 2;
            y1 = groupBox4.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width * 2 / 5;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox5.Location.X + groupBox5.Width / 2;
            y1 = groupBox5.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width * 3 / 5;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox6.Location.X + groupBox6.Width / 2;
            y1 = groupBox6.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width * 4 / 5;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox7.Location.X + groupBox7.Width / 2;
            y1 = groupBox7.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox8.Location.X + groupBox8.Width / 2;
            y1 = groupBox8.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox2.Location.X + groupBox2.Width / 2;
            y = groupBox2.Location.Y + groupBox2.Height;
            x1 = groupBox9.Location.X + groupBox9.Width / 2;
            y1 = groupBox9.Location.Y;
            g.DrawLine(p, x, y + 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y + 15, x, y);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y + 10);
            g.DrawLine(p, x, y, x - 5, y + 10);
            //
            x = groupBox4.Location.X;
            y = groupBox4.Location.Y;
            x1 = groupBox3.Location.X + groupBox3.Width;
            y1 = groupBox3.Location.Y + groupBox3.Height;
            g.DrawLine(p, x, y, x1, y1 + 15);
            g.DrawLine(p, x1, y1 + 15, x1, y1);
            g.DrawLine(p, x1, y1, x1 + 5, y1 + 10);
            g.DrawLine(p, x1, y1, x1 - 5, y1 + 10);
            //
            x = groupBox4.Location.X+groupBox4.Width;
            y = groupBox4.Location.Y;
            x1 = groupBox6.Location.X;
            y1 = groupBox6.Location.Y;
            g.DrawLine(p, x, y - 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y - 15, x, y);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            g.DrawLine(p, x, y, x + 5, y - 10);
            g.DrawLine(p, x, y, x - 5, y - 10);
            //
            x1 = groupBox5.Location.X;
            y1 = groupBox5.Location.Y;
            g.DrawLine(p, x, y - 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y - 15, x, y);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
            //
            x1 = groupBox7.Location.X;
            y1 = groupBox7.Location.Y;
            g.DrawLine(p, x, y - 15, x1, y1 - 15);
            g.DrawLine(p, x1, y1 - 15, x1, y1);
            g.DrawLine(p, x, y - 15, x, y);
            g.DrawLine(p, x1, y1, x1 + 5, y1 - 10);
            g.DrawLine(p, x1, y1, x1 - 5, y1 - 10);
        }
    }
}
