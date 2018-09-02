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

using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int x, n;//размеры поля

        private void Form3_Load(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);
            timer1.Interval = 1;
            timer1.Enabled = false;
            timer2.Interval = 1;
            timer2.Enabled = false;
            timer3.Interval = 1;
            timer3.Enabled = false;
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
            Form5 f = new Form5();
            f.Icon = this.Icon;
            f.BackColor = this.BackColor;
            f.Text = "Додаткова анімація";
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
        int[][,,] all_var;
        int[][,,] z;//массив, в который записывается все комбинации королев
        private void timer1_Tick(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            zz1(all_var);
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            if (!(trackBar1.Value == 0 && trackBar2.Value == 0 && trackBar3.Value == 0))
                GL.Rotate(1, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }
        void zz1(int[][,,] all_var)
        {

            Vector3d[,,][] q;
            q = new Vector3d[n, n, x][];
            for (int u = 0; u < x; u++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (all_var[Convert.ToInt32(comboBox1.Text) - 1][i, j, u] == 0)
                        {
                            GL.Color3(Color.FromArgb(50, 50, 50));
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                        }
                        else
                        {
                            GL.Color3(Color.White);
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                            q[i, j, u] = new Vector3d[8];
                            f2(i, j, u, q);
                        }
                    }
                }
            }
        }
        void zz2(int[][,,] max_var)
        {

            Vector3d[,,][] q;
            q = new Vector3d[n, n, x][];
            for (int u = 0; u < x; u++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (max_var[Convert.ToInt32(comboBox2.Text) - 1][i, j, u] == 0)
                        {
                            GL.Color3(Color.FromArgb(50, 50, 50));
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                        }
                        else
                        {
                            GL.Color3(Color.White);
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                            q[i, j, u] = new Vector3d[8];
                            f2(i, j, u, q);
                        }
                    }
                }
            }
        }
        void zz3(int[][,,] min_var)
        {

            Vector3d[,,][] q;
            q = new Vector3d[n, n, x][];
            for (int u = 0; u < x; u++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (min_var[Convert.ToInt32(comboBox3.Text) - 1][i, j, u] == 0)
                        {
                            GL.Color3(Color.FromArgb(50, 50, 50));
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                        }
                        else
                        {
                            GL.Color3(Color.White);
                            q[i, j, u] = new Vector3d[1440];
                            f1(n, x, i, j, u, q[i, j, u]);
                            q[i, j, u] = new Vector3d[8];
                            f2(i, j, u, q);
                        }
                    }
                }
            }
        }
        void draw(int i, int j, int u, Vector3d[,,][] q)
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.White);
            GL.Vertex3(q[i, j, u][0]);
            GL.Vertex3(q[i, j, u][1]);
            GL.Vertex3(q[i, j, u][1]);
            GL.Vertex3(q[i, j, u][2]);
            GL.Vertex3(q[i, j, u][2]);
            GL.Vertex3(q[i, j, u][3]);
            GL.Vertex3(q[i, j, u][3]);
            GL.Vertex3(q[i, j, u][0]);
            GL.Vertex3(q[i, j, u][0]);
            GL.Vertex3(q[i, j, u][4]);
            GL.Vertex3(q[i, j, u][4]);
            GL.Vertex3(q[i, j, u][5]);
            GL.Vertex3(q[i, j, u][5]);
            GL.Vertex3(q[i, j, u][1]);
            GL.Vertex3(q[i, j, u][5]);
            GL.Vertex3(q[i, j, u][6]);
            GL.Vertex3(q[i, j, u][6]);
            GL.Vertex3(q[i, j, u][2]);
            GL.Vertex3(q[i, j, u][6]);
            GL.Vertex3(q[i, j, u][7]);
            GL.Vertex3(q[i, j, u][7]);
            GL.Vertex3(q[i, j, u][3]);
            GL.Vertex3(q[i, j, u][7]);
            GL.Vertex3(q[i, j, u][4]);
            GL.End();

        }
        void f1(int n, int x, int i, int j, int u, Vector3d[] q)
        {

            double r = 0.1;
            GL.Begin(PrimitiveType.Points);
            for (int i1 = 0; i1 < 480; i1++)
            {
                q[i1].X = ((n / 2 - i)) * 3 * r + (r * Math.Cos(i1 * Math.PI / 120));
                q[i1].Y = ((n / 2 - j)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 1));
                q[i1].Z = ((x / 2 - u)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 120));
                GL.Vertex3(q[i1]);
            }
            for (int i1 = 480; i1 < 960; i1++)
            {
                q[i1].X = ((n / 2 - i)) * 3 * r + (r * Math.Cos(i1 * Math.PI / 120));
                q[i1].Y = ((n / 2 - j)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 120));
                q[i1].Z = ((x / 2 - u)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 1));
                GL.Vertex3(q[i1]);
            }
            for (int i1 = 960; i1 < 1440; i1++)
            {
                q[i1].X = ((n / 2 - i)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 1));
                q[i1].Y = ((n / 2 - j)) * 3 * r + (r * Math.Cos(i1 * Math.PI / 120));
                q[i1].Z = ((x / 2 - u)) * 3 * r + (r * Math.Sin(i1 * Math.PI / 120));
                GL.Vertex3(q[i1]);
            }

            GL.End();


        }
        void f2(int i, int j, int u, Vector3d[,,][] q)
        {
            double r = 0.1, r2 = -r / 2;
            q[i, j, u][0].X = (((n / 2) - i) * 3 * r) - r / 2;
            q[i, j, u][0].Y = (((n / 2) - j) * 3 * r) + r / 2;
            q[i, j, u][0].Z = ((x / 2) - u) * 3 * r + r2;
            q[i, j, u][1].X = (((n / 2) - i) * 3 * r) + r / 2;
            q[i, j, u][1].Y = (((n / 2) - j) * 3 * r) + r / 2;
            q[i, j, u][1].Z = ((x / 2) - u) * 3 * r + r2;
            q[i, j, u][2].X = (((n / 2) - i) * 3 * r) + r / 2;
            q[i, j, u][2].Y = (((n / 2) - j) * 3 * r) - r / 2;
            q[i, j, u][2].Z = ((x / 2) - u) * 3 * r + r2;
            q[i, j, u][3].X = (((n / 2) - i) * 3 * r) - r / 2;
            q[i, j, u][3].Y = (((n / 2) - j) * 3 * r) - r / 2;
            q[i, j, u][3].Z = ((x / 2) - u) * 3 * r + r2;

            q[i, j, u][4].X = q[i, j, u][0].X;
            q[i, j, u][4].Y = q[i, j, u][0].Y;
            q[i, j, u][4].Z = q[i, j, u][0].Z + r;
            q[i, j, u][5].X = q[i, j, u][1].X;
            q[i, j, u][5].Y = q[i, j, u][1].Y;
            q[i, j, u][5].Z = q[i, j, u][1].Z + r;
            q[i, j, u][6].X = q[i, j, u][2].X;
            q[i, j, u][6].Y = q[i, j, u][2].Y;
            q[i, j, u][6].Z = q[i, j, u][2].Z + r;
            q[i, j, u][7].X = q[i, j, u][3].X;
            q[i, j, u][7].Y = q[i, j, u][3].Y;
            q[i, j, u][7].Z = q[i, j, u][3].Z + r;
            draw(i, j, u, q);
        }

        int c = 0;
        int[][,,] max_var;
        int[][,,] min_var;
        private void button1_Click(object sender, EventArgs e)
        {
            /* 0.вводим данные о поле + вводим txt файл -
            * 1.ставим королеву на первое место + ее ходы -
            * 2.находим пустые места (укда можно располложить еще одну королеву) -
            * 3.запоминаем расположение королев, как в (1.) и заполняем пустые места по очереди -
            * 4.если пустых мест нету, тогда очищаем все массивы -
            * 5. ...и начинаем с пункта (1.) до момента прохождения первых королев на каждой позиции всего поля -
            */

            //0.
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox2.Visible = true;
            comboBox2.Items.Clear();
            comboBox3.Visible = true;
            comboBox3.Items.Clear();
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            trackBar1.Visible = true;
            trackBar2.Visible = true;
            trackBar3.Visible = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            c = 0;
            n = Convert.ToInt32(textBox1.Text);
            x = Convert.ToInt32(textBox2.Text);
            int t = 0, p = -1;
            z = new int[1][,,];
            //длинна и ширина поля
            n = Convert.ToInt32(textBox1.Text);
            //Высота поля
            x = Convert.ToInt32(textBox2.Text);
            int[,,] aa;
            aa = new int[n, n, x];


            int[][][,,] bb;
            bb = new int[(n + 1) + ((x + 1) / 2)][][,,];
            for (int v = 0; v < (n + 1) + ((x + 1) / 2); v++)
            {
                bb[v] = new int[n*n][,,];
                for (int y = 0; y < n*n; y++)
                {
                    bb[v][y] = new int[n, n, x];
                    for (int u = 0; u < x; u++)
                        for (int j = 0; j < n; j++)
                            for (int i = 0; i < n; i++)
                            {
                                bb[v][y][i, j, u] = 5;
                            }
                }
            }
            for (int u = 0; u < x; u++)
                for (int j = 0; j < n; j++)
                    for (int i = 0; i < n; i++)
                    {
                        aa[i, j, u] = 0;
                    }
            for (int u = 0; u < (x + 1) / 2; u++)
            {
                for (int j = 0; j < (n + 1) / 2; j++)
                {
                    for (int i = j; i < (n + 1) / 2; i++)
                    {
                        p++;
                        bb[p][t] = Q(i, j, u, n, x, aa);
                        tryQ(n, x, bb[p], t);
                    }
                }
            }
            //сокращение вариантов
            //int[][,,] all_var;
            all_var = new int[c][,,];
            all_var[0] = new int[n, n, x];
            int variant = 0;
            for (int u1 = 0; u1 < x; u1++)
            {
                for (int j1 = 0; j1 < n; j1++)
                {
                    for (int i1 = 0; i1 < n; i1++)
                    {
                        all_var[0][i1, j1, u1] = z[0][i1, j1, u1];
                    }
                }
            }
            variant++;
            if (c != 1)
                all_var[variant] = new int[n, n, x];
            comboBox1.Items.Add(variant);
            for (int i = 1; i < c; i++)
            {
                if (is_same(variant,i) == false)
                {
                    for (int u1 = 0; u1 < x; u1++)
                    {
                        for (int j1 = 0; j1 < n; j1++)
                        {
                            for (int i1 = 0; i1 < n; i1++)
                            {
                                all_var[variant][i1, j1, u1] = z[i][i1, j1, u1];
                            }
                        }
                    }
                    variant++;
                    all_var[variant] = new int[n, n, x];
                    comboBox1.Items.Add(variant);
                }
            }
            //найбольшее количество королев
            int max =0;
            for ( int i = 0;i<variant;i++)
            {

                if (max < count(all_var[i]))
                {
                    max = count(all_var[i]);
                }
            }
            max_var = new int[variant][,,];
            int k = -1;
            for(int i=0;i<variant;i++)
            {

                if(count(all_var[i])==max)
                {
                    k++;
                    max_var[k] = new int[n, n, x];
                    
                    for (int u1 = 0; u1 < x; u1++)
                        for (int j1 = 0; j1 < n; j1++)
                            for (int i1 = 0; i1 < n; i1++)
                            {
                                max_var[k][i1, j1, u1] = all_var[i][i1, j1, u1];
                            }
                    comboBox2.Items.Add(k+1);
                }
            }
            //найменьшее количество королев
            int min = 1000;
            for (int i = 0; i < variant; i++)
            {
                if (all_var[i] != null)
                    if (min > count(all_var[i]))
                    {
                        min = count(all_var[i]);
                    }
            }
            k = -1;
            min_var = new int[variant][,,];
            for (int i = 0; i < variant; i++)
            {
                if (all_var[i] != null)
                    if (count(all_var[i]) == min)
                    {
                        k++;
                        min_var[k] = new int[n, n, x];

                        for (int u1 = 0; u1 < x; u1++)
                            for (int j1 = 0; j1 < n; j1++)
                                for (int i1 = 0; i1 < n; i1++)
                                {
                                    min_var[k][i1, j1, u1] = all_var[i][i1, j1, u1];
                                }
                        comboBox3.Items.Add(k + 1);
                    }
            }
            comboBox1.Text = "Вибрати";
            comboBox2.Text = "Вибрати";
            comboBox3.Text = "Вибрати";
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Flush();
            glControl1.SwapBuffers();
        }
        public void tryQ(int n, int x, int[][,,] b, int t)
        {
            if (free_place(n, x, b[t]) == true/*есть пустые ячейки?*/)
            {
                /*
                 [да];
                 */
                //1.Сохраняем незаполненный массив;
                //2.дополняем его одной королевой;
                int[,,] coord;
                coord = new int[n, n, x];
                for (int u = 0; u < x; u++)
                    for (int j = 0; j < n; j++)
                        for (int i = 0; i < n; i++)
                            coord[i, j, u] = 0;
                //накодим кол-во пустых ячеек + их координаты
                int k = 0;
                for (int u = 0; u < x; u++)
                    for (int j = 0; j < n; j++)
                        for (int i = 0; i < n; i++)
                        {
                            if (b[t][i, j, u] == 0)
                            {
                                k++;
                                coord[i, j, u] = 1;
                            }
                        }
                int[][][,,] b1;
                b1 = new int[k][][,,];
                for (int v = 0; v < k; v++)
                    for (int y = 0; y < n*n; y++)
                        for (int u = 0; u < x; u++)
                            for (int j = 0; j < n; j++)
                                for (int i = 0; i < n; i++)
                                {
                                    b1[v] = new int[n*n][,,];
                                    b1[v][y] = new int[n, n, x];
                                    b1[v][y][i, j, u] = 0;
                                }
                int k2 = -1, w = 0;
                for (int u = 0; u < x; u++)
                    for (int j = 0; j < n; j++)
                        for (int i = 0; i < n; i++)
                            if (coord[i, j, u] == 1)
                            {
                                k2++;
                                b1[k2][w] = Q(i, j, u, n, x, b[t]);
                            }

                for (int r = 0; r < k; r++)
                {
                    tryQ(n, x, b1[r], w);
                }
            }
            else
            {
                /*
                [нет]
                */
                //IncreaseLength(ref z, 1);

                Array.Resize(ref z, c + 1);
                z[c] = new int[n, n, x];
                for (int u1 = 0; u1 < x; u1++)
                {
                    for (int j1 = 0; j1 < n; j1++)
                    {
                        for (int i1 = 0; i1 < n; i1++)
                        {
                            if (b[t][i1, j1, u1] == 1)
                                z[c][i1, j1, u1] = 0;//ходы королевы
                            if (b[t][i1, j1, u1] == 2)
                                z[c][i1, j1, u1] = 1;//королева
                        }
                    }
                }
                c++;
                //comboBox1.Items.Add(c);
            }
        }
        public static void IncreaseLength(ref int[][,,] z, int delta)
        {
            int[][,,] tmp = new int[z.Length + delta][,,];
            Array.Copy(z, 0, tmp, 0, z.Length);
            z = tmp;
        }
        public static int[,,] Q(int i, int j, int u, int n, int x, int[,,] q)
        {
            int[,,] a;
            a = new int[n, n, x];
            for (int u2 = 0; u2 < x; u2++)
                for (int j2 = 0; j2 < n; j2++)
                    for (int i2 = 0; i2 < n; i2++)
                    {
                        a[i2, j2, u2] = q[i2, j2, u2];
                    }
            int z = 0;
            int i1 = i, j1 = j, u1 = u;
            for (i1 = i + 1; i1 < n; i1++)
            {
                a[i1, j, u] = 1;
            }
            for (j1 = j + 1; j1 < n; j1++)
            {
                a[i, j1, u] = 1;
            }
            for (i1 = i - 1; i1 > -1; i1--)
            {
                a[i1, j, u] = 1;
            }
            for (j1 = j - 1; j1 > -1; j1--)
            {
                a[i, j1, u] = 1;
            }
            i1 = i;
            j1 = j;
            while ((j1 + 1 < n + 1) && (i1 + 1 < n + 1))
            {
                a[i1, j1, u] = 1;
                i1++;
                j1++;
            }
            i1 = i;
            j1 = j;
            while ((i1 - 1 > -2) && (j1 - 1 > -2))
            {
                a[i1, j1, u] = 1;
                i1--;
                j1--;
            }
            i1 = i;
            j1 = j;
            while ((i1 + 1 < n + 1) && (j1 - 1 > -2))
            {
                a[i1, j1, u] = 1;
                i1++;
                j1--;
            }
            i1 = i;
            j1 = j;
            while ((i1 - 1 > -2) && (j1 + 1 < n + 1))
            {
                a[i1, j1, u] = 1;
                i1--;
                j1++;
            }
            i1 = i;
            j1 = j;

            for (u1 = u - 1; u1 > -1; u1--)//вверх+диагонали
            {
                z++;
                a[i, j, u1] = 1;
                if (((j - z) > -1) && ((i + z) < n))
                {
                    a[i + z, j - z, u1] = 1;
                }
                if (((j + z) < n) && ((i - z) > -1))
                {
                    a[i - z, j + z, u1] = 1;
                }
                if (((j - z) > -1) && ((i - z) > -1))
                {
                    a[i - z, j - z, u1] = 1;
                }
                if (((j + z) < n) && ((i + z) < n))
                {
                    a[i + z, j + z, u1] = 1;
                }
                if ((j - z) > -1)
                {
                    a[i, j - z, u1] = 1;
                }
                if ((i - z) > -1)
                {
                    a[i - z, j, u1] = 1;
                }
                if ((i + z) < n)
                {
                    a[i + z, j, u1] = 1;
                }
                if ((j + z) < n)
                {
                    a[i, j + z, u1] = 1;
                }
            }
            z = 0;
            for (u1 = u + 1; u1 < x; u1++)//вниз+диагонали
            {
                z++;
                a[i, j, u1] = 1;
                if (((j - z) > -1) && ((i + z) < n))
                {
                    a[i + z, j - z, u1] = 1;
                }
                if (((j + z) < n) && ((i - z) > -1))
                {
                    a[i - z, j + z, u1] = 1;
                }
                if (((j - z) > -1) && ((i - z) > -1))
                {
                    a[i - z, j - z, u1] = 1;
                }
                if (((j + z) < n) && ((i + z) < n))
                {
                    a[i + z, j + z, u1] = 1;
                }
                if ((j - z) > -1)
                {
                    a[i, j - z, u1] = 1;
                }
                if ((i - z) > -1)
                {
                    a[i - z, j, u1] = 1;
                }
                if ((i + z) < n)
                {
                    a[i + z, j, u1] = 1;
                }
                if ((j + z) < n)
                {
                    a[i, j + z, u1] = 1;
                }
            }
            a[i, j, u] = 2;
            return a;
        }
        private static bool free_place(int n, int x, int[,,] b)
        {
            bool bl = true;
            int kk = 0;
            for (int u = 0; u < x; u++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (b[i, j, u] == 0)
                        {
                            kk++;
                        }
                    }
                }
            }
            if (kk == 0)
                bl = false;//не осталось места
            else
                bl = true;//остались места
            return bl;
        }
        int count(int [,,]allvar)
        {
            int k=0;
            for(int u=0;u<x;u++)
                for(int j=0;j<n;j++)
                    for(int i=0;i<n;i++)
                    {
                        if (allvar[i, j, u] == 1)
                            k++;
                    }
            return k;
        }
        bool is_same(int variant,int zi)
        {
            bool l = false;
            for (int y1 = 0; y1 < variant; y1++)
                for (int u = 0; u < x; u++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int i = j; i < n; i++)
                        {
                            if (all_var[y1][i, j, u] != z[zi][i, j, u])
                            {
                                l = false;
                                break;
                            }
                            else
                                l = true;
                        }
                    }
                }
            return l;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "Вибрати")
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = !timer1.Enabled;
            //if ( == true)
            //    button2.Text = "Припинити обертання";
            //else
            //    button2.Text = "Почати обертання";
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //button2.Visible = true;
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //button2.Visible = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text != "Вибрати")//max
                timer2.Enabled = true;
            else
                timer2.Enabled = false;
            timer1.Enabled = false;
            timer3.Enabled = false;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            zz2(max_var);
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            if (!(trackBar1.Value == 0 && trackBar2.Value == 0 && trackBar3.Value == 0))
                GL.Rotate(1, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text != "Вибрати")//min
                timer3.Enabled = true;
            else
                timer3.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            zz3(min_var);
            GL.Begin(PrimitiveType.Patches);
            GL.Color3(Color.White);
            if (!(trackBar1.Value == 0 && trackBar2.Value == 0 && trackBar3.Value == 0))
                GL.Rotate(1, trackBar1.Value, trackBar2.Value, trackBar3.Value);
            GL.End();
            GL.Flush();
            glControl1.SwapBuffers();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            //button2.Visible = true;
        }
    }
}
