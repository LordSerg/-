using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform.Windows;

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //1
        Vector3d []a0;
        Vector3d[] a1;
        Vector3d[] a2;
        Random R = new Random();
        int xo=0, zo=0, yo=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(Color.White);
            globe();
            GL.End();
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            GL.Rotate(trackBar1.Value, xo, yo, zo);
            //GL.Rotate(1, R.NextDouble(), R.NextDouble(), R.NextDouble());
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            a0 = new Vector3d[720];
            a1 = new Vector3d[720];
            a2 = new Vector3d[720];
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            label11.BackColor = Color.FromArgb(255, 192, 192);
            c2 = 192;
            timer5.Enabled = true;
            timer5.Interval = 10;
            timer4.Interval = 1;
        }
        int c2 = 192;
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (c2 < 255)
            {
                label11.BackColor = Color.FromArgb(255, c2, c2);
                c2++;
            }
            else if(c2>191)
            {
                c2 = 192;
                //timer5.Enabled = false;
            }
        }

        void globe()
        {
            double r = 0.8;
            for (int i = 0; i < 720; i++)
            {
                a0[i].X = (r * Math.Cos(i * Math.PI / 180));
                a0[i].Y = (r * Math.Sin(i * Math.PI / 1));
                a0[i].Z = (r * Math.Sin(i * Math.PI / 180));
            }
            for (int i = 0; i < 720; i++)
            {
                a1[i].X = (r * Math.Cos(i * Math.PI / 180));
                a1[i].Y = (r * Math.Sin(i * Math.PI / 180));
                a1[i].Z = (r * Math.Sin(i * Math.PI / 1));
            }
            for (int i = 0; i < 720; i++)
            {
                a2[i].X = (r * Math.Sin(i * Math.PI / 1));
                a2[i].Y = (r * Math.Cos(i * Math.PI / 180));
                a2[i].Z = (r * Math.Sin(i * Math.PI / 180));
            }
            for (int i = 0; i< 720;i++)
            {
                //GL.Color3(Color.Red);
                GL.Vertex3(a0[i]);
                //GL.Color3(Color.Green);
                GL.Vertex3(a1[i]);
                //GL.Color3(Color.Blue);
                GL.Vertex3(a2[i]);
            }
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (xo == 0)
            {
                xo = 1;
                timer1.Enabled = true;
            }
            else
                xo = 0;
            if(xo==0&&yo==0&&zo==0)
            {
                timer1.Enabled = false;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (yo == 0)
            {
                yo = 1;
                timer1.Enabled = true;
            }
            else
                yo = 0;
            if (xo == 0 && yo == 0 && zo == 0)
            {
                timer1.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (zo == 0)
            {
                zo = 1;
                timer1.Enabled = true;
            }
            else
                zo = 0;
            if (xo == 0 && yo == 0 && zo == 0)
            {
                timer1.Enabled = false;
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
        private void побудовиПолейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Побудова полей";
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
        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //2
        Vector3d []s;
        int n;
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            n = Convert.ToInt32(textBox1.Text);
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            s = new Vector3d[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                s[i].X = 0.001 * r.Next(-1000, 2000);
                s[i].Y = 0.001 * r.Next(-1000, 2000);
                s[i].Z = 0.001 * r.Next(-1000, 2000);
                GL.Begin(PrimitiveType.Points);
                GL.Color3(Color.Red);
                GL.Vertex3(s[i]);
                GL.Flush();
                GL.End();
            }
            glControl1.SwapBuffers();
            timer2.Enabled = !timer2.Enabled;
            timer2.Interval = 1;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            double x = this.Location.X - MousePosition.X + glControl1.Width / 2+glControl1.Location.X;
            double y = this.Location.Y - MousePosition.Y + glControl1.Height / 2 + glControl1.Location.Y;
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Begin(PrimitiveType.Lines);
            stars_1(x,y);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }
        private void stars_1(double x, double y)
        {
            int q = 5000;

            for (int i = 0; i < n; i++)
            {
                if (y <= 0)
                {
                    if (x <= 0)
                    {
                        if ((s[i].Y < -1) || (s[i].X > 1))
                        {
                            s[i].Y = -s[i].Y;
                            s[i].X = -s[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(s[i]);
                            s[i].Y -= Math.Abs(y / q);
                            s[i].X += Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(s[i]);
                        }
                    }
                    else
                    {
                        if ((s[i].Y < -1) || (s[i].X < -1))
                        {
                            s[i].Y = -s[i].Y;
                            s[i].X = -s[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(s[i]);
                            s[i].Y -= Math.Abs(y / q);
                            s[i].X -= Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(s[i]);
                        }
                    }
                }
                if (y > 0)
                {
                    if (x <= 0)
                    {
                        if ((s[i].Y > 1) || (s[i].X > 1))
                        {
                            s[i].Y = -s[i].Y;
                            s[i].X = -s[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(s[i]);
                            s[i].Y += Math.Abs(y / q);
                            s[i].X += Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(s[i]);
                        }
                    }

                    else
                    {
                        if ((s[i].Y > 1) || (s[i].X < -1))
                        {
                            s[i].Y = -s[i].Y;
                            s[i].X = -s[i].X;
                        }
                        else
                        {
                            GL.Color3(Color.FromArgb(0, 0, Convert.ToInt32(Math.Sqrt(Math.Abs((x * x / 100) + (y * y / 100))))))/*, Convert.ToInt32(Math.Sqrt(Math.Abs(x * x / 100)))))*/;
                            GL.Vertex3(s[i]);
                            s[i].Y += Math.Abs(y / q);
                            s[i].X -= Math.Abs(x / q);
                            GL.Color3(Color.White);
                            GL.Vertex3(s[i]);
                        }
                    }
                }
            }
        }
        //3
        Vector3d a, b, c, d, a11, b1, c1, d1;
        int x0 = 0, z0 = 0, y0 = 0;


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar2.Value.ToString();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (z0 == 0)
            {
                z0 = 1;
                timer3.Enabled = true;
            }
            else
                z0 = 0;
            if (x0 == 0 && y0 == 0 && z0 == 0)
            {
                timer3.Enabled = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (x0 == 0)
            {
                x0 = 1;
                timer3.Enabled = true;
            }
            else
                x0 = 0;
            if (x0 == 0 && y0 == 0 && z0 == 0)
            {
                timer3.Enabled = false;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (y0 == 0)
            {
                y0 = 1;
                timer3.Enabled = true;
            }
            else
                y0 = 0;
            if (x0 == 0 && y0 == 0 && z0 == 0)
            {
                timer3.Enabled = false;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            Values();
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            Lines();
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            GL.Rotate(trackBar2.Value, x0, y0, z0);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }
        void Values()
        {
            a.X = -0.01 * ((double)numericUpDown1.Value);
            a.Y = 0.01 * ((double)numericUpDown1.Value);
            a.Z = 0;
            b.X = 0.01 * ((double)numericUpDown1.Value);
            b.Y = 0.01 * ((double)numericUpDown1.Value);
            b.Z = 0;
            c.X = 0.01 * ((double)numericUpDown1.Value);
            c.Y = -0.01 * ((double)numericUpDown1.Value);
            c.Z = 0;
            d.X = -0.01 * ((double)numericUpDown1.Value);
            d.Y = -0.01 * ((double)numericUpDown1.Value);
            d.Z = 0;

            a11.X = -0.01 * ((double)numericUpDown2.Value);
            a11.Y = 0.01 * ((double)numericUpDown2.Value);
            a11.Z = 0.02 * ((double)numericUpDown3.Value);
            b1.X = 0.01 * ((double)numericUpDown2.Value);
            b1.Y = 0.01 * ((double)numericUpDown2.Value);
            b1.Z = 0.02 * ((double)numericUpDown3.Value);
            c1.X = 0.01 * ((double)numericUpDown2.Value);
            c1.Y = -0.01 * ((double)numericUpDown2.Value);
            c1.Z = 0.02 * ((double)numericUpDown3.Value);
            d1.X = -0.01 * ((double)numericUpDown2.Value);
            d1.Y = -0.01 * ((double)numericUpDown2.Value);
            d1.Z = 0.02 * ((double)numericUpDown3.Value);
        }
        void Poligon()
        {
            //GL.Enable(EnableCap.Blend);
            //GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.Vertex3(d);
            GL.End();

            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(a11);
            GL.Vertex3(b1);
            GL.Vertex3(c1);
            GL.Vertex3(d1);
            GL.End();

            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(a);
            GL.Vertex3(d);
            GL.Vertex3(d1);
            GL.Vertex3(a11);
            GL.End();

            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(b1);
            GL.Vertex3(a11);
            GL.End();

            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.Vertex3(c1);
            GL.Vertex3(b1);
            GL.End();

            GL.Begin(PrimitiveType.Polygon);
            GL.Color3(Color.White);
            GL.Vertex3(d);
            GL.Vertex3(c);
            GL.Vertex3(c1);
            GL.Vertex3(d1);
            GL.End();
        }
        void Lines()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.White);
            GL.Vertex3(a);
            GL.Vertex3(b);
            GL.Vertex3(b);
            GL.Vertex3(c);
            GL.Vertex3(c);
            GL.Vertex3(d);
            GL.Vertex3(d);
            GL.Vertex3(a);
            GL.Vertex3(a);
            GL.Vertex3(a11);
            GL.Vertex3(a11);
            GL.Vertex3(b1);
            GL.Vertex3(b1);
            GL.Vertex3(b);
            GL.Vertex3(b1);
            GL.Vertex3(c1);
            GL.Vertex3(c1);
            GL.Vertex3(c);
            GL.Vertex3(c1);
            GL.Vertex3(d1);
            GL.Vertex3(d1);
            GL.Vertex3(d);
            GL.Vertex3(d1);
            GL.Vertex3(a11);
            GL.End();
        }
        
        //private void toolStripMenuItem3_Click(object sender, EventArgs e)
        //{
        //    //groupBox3.Visible = true;
        //    //groupBox2.Visible = false;
        //    //groupBox4.Visible = false;
        //    //timer1.Enabled = false;
        //    //timer2.Enabled = false;
        //    //timer3.Enabled = false;
        //    //x0 = 0;
        //    //z0 = 0;
        //    //y0 = 0;
        //}
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            x0 = 0;
            z0 = 0;
            y0 = 0;
        }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            timer5.Enabled = false;
            groupBox4.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            x0 = 0;
            z0 = 0;
            y0 = 0;
        }
        //Qween
        Vector3d []qween;
        //private void qweenToolStripMenuItem_Click(object sender, EventArgs e)
        //{/*
        //    groupBox3.Visible = false;
        //    groupBox2.Visible = false;
        //    groupBox4.Visible = false;
        //    timer1.Enabled = false;
        //    timer2.Enabled = false;
        //    timer3.Enabled = false;
        //    timer4.Enabled = true;
        //    x0 = 0;
        //    z0 = 0;
        //    y0 = 0;
        //    qween = new Vector3d[10000];*/
        //}
        private void timer4_Tick(object sender, EventArgs e)
        {
            /*GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            draw();
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            GL.Rotate(1, x0, y0, z0);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
            x0 = 1;*/
        }
        /*void draw()
        {
            double r= 0.4;
            GL.Begin(PrimitiveType.Lines);
            for (int i = 0; i < 360; i++)
            {
                qween[i].X = (r * Math.Cos(i * Math.PI / 90));
                qween[i].Y = (r * Math.Sin(i * Math.PI / 1)) - 0.6;
                qween[i].Z = (r * Math.Sin(i * Math.PI / 90));
                if (i < 359)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[0]);
                }
            }
            for (int i = 360; i < 720; i++)
            {
                qween[i].X = (r * Math.Cos(i * Math.PI / 90));
                qween[i].Y = (r * Math.Sin(i * Math.PI / 1)) - 0.8;
                qween[i].Z = (r * Math.Sin(i * Math.PI / 90));
                if (i < 719)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[360]);
                }
            }
            r = 0.2;
            for (int i = 720; i < 1080; i++)
            {
                qween[i].X = (r * Math.Cos(i * Math.PI / 90));
                qween[i].Y = (r * Math.Sin(i * Math.PI / 1)) - 0.2;
                qween[i].Z = (r * Math.Sin(i * Math.PI / 90));
                if (i < 1079)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[720]);
                }
            }
            r = 0.05;
            for (int i = 1080; i < 1440; i++)
            {
                qween[i].X = (r * Math.Cos(i * Math.PI / 90));
                qween[i].Y = (r * Math.Sin(i * Math.PI / 1))-0.1;
                qween[i].Z = (r * Math.Sin(i * Math.PI / 90));
                if (i < 1439)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[1080]);
                }
            }
            r = 0.1;
            for (int i = 1080; i < 1440; i++)
            {
                qween[i].X = (r * Math.Cos(i * Math.PI / 90));
                qween[i].Y = (r * Math.Sin(i * Math.PI / 1))-0.15;
                qween[i].Z = (r * Math.Sin(i * Math.PI / 90));
                if (i < 1439)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[1080]);
                }
            }
            //
            for (int i = 0; i < 360; i++)
            {
                if (i < 359)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 360 + 1]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[0]);
                }
                if (i < 719)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 720 ]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[0]);
                }
            }
            for (int i = 360; i < 720; i++)
            {
                if (i < 359)
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[i + 360]);
                }
                else
                {
                    GL.Vertex3(qween[i]);
                    GL.Vertex3(qween[360]);
                }
            }
            GL.End();

        }
        */
    }
}