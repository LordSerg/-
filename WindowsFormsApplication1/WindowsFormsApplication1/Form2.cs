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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int r, g, b, a;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Icon = new Icon("ICO/globe.ico");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Icon = new Icon("ICO/15.ico");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Icon = new Icon("ICO/enjoying.ico");
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            numericUpDown1.Value = trackBar1.Value;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            numericUpDown2.Value = trackBar2.Value;
        }
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            numericUpDown3.Value = trackBar3.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Convert.ToInt32(numericUpDown2.Value);
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Convert.ToInt32(numericUpDown3.Value);
            BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Головне меню";
            f.Show();
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button2, "Іконка Землі");
            toolTip1.SetToolTip(this.button1, "Іконка серця");
            toolTip1.SetToolTip(this.button7, "Іконка смайлика");
            toolTip1.SetToolTip(this.trackBar1, "Червоний");
            toolTip1.SetToolTip(this.trackBar2, "Зелений");
            toolTip1.SetToolTip(this.trackBar3, "Синій");
            trackBar1.Value = 250;
            trackBar2.Value = 250;
            trackBar3.Value = 250;
            //timer1.Enabled = true;
            //timer1.Interval = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
