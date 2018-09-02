using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add("На головну");
            comboBox1.Items.Add("Використана он-лайн література");
            string cd = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/HTML/Start.html", cd));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cd = Directory.GetCurrentDirectory();
            //if(comboBox1.Text=="На головну")
            //{
            //    webBrowser1.Url = new Uri(String.Format("file:///{0}/HTML/Головна.html", cd));
            //}
            if (comboBox1.Text == "Використана он-лайн література")
            {
                webBrowser1.Url = new Uri(String.Format("file:///{0}/HTML/Використана_он-лайн_література.html", cd));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string cd = Directory.GetCurrentDirectory();
            webBrowser1.Url = new Uri(String.Format("file:///{0}/HTML/пуста_сторінка.html", cd));
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
            Form5 f = new Form5();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Додаткова анімація";
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
