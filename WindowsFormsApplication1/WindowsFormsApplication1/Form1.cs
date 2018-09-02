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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this, "Натисніть на 'Меню' лівою кнопкою миші");
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Розстановка королев";
            f.Show();
            this.Hide();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Структура проекту";
            f.Show();
            this.Hide();
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Додаткова анімація";
            f.Show();
            this.Hide();
        }

        private void налаштуванняФормToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Налаштування";
            f.Show();
            this.Hide();
        }

        private void відеоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Відео";
            f.Show();
            this.Hide();
        }

        private void webсайтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Web-сайт";
            f.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void слайдШоуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Слайд шоу";
            f.Show();
            this.Hide();
        }
    }
}
