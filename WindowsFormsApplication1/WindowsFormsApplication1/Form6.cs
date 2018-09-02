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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "Анимація шахмат.mkv";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            label1.Text = axWindowsMediaPlayer1.URL;
        }

        private void вибратиВідеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            
        }


        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Location = new Point(axWindowsMediaPlayer1.Location.X, 27-vScrollBar1.Value);
            label1.Location = new Point(label1.Location.X,  this.Height-vScrollBar1.Value);
        }

        private void доГоловногоМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Головне меню";
            f.Show();
            this.Close();
        }
        private void додатковоїАнімаціїToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Ддаткова анімація";
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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
