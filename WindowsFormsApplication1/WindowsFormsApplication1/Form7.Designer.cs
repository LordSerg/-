namespace WindowsFormsApplication1
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.доГоловногоМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.головногоМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняФормиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.побудовиПолейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webсайтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "(перелік сайтів)";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(18, 60);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(30, 31);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(777, 642);
            this.webBrowser1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "Вперед";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(381, 15);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 5;
            this.button4.Text = "Очистити";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доГоловногоМенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(672, 15);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(125, 31);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // доГоловногоМенюToolStripMenuItem
            // 
            this.доГоловногоМенюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.головногоМенюToolStripMenuItem,
            this.налаштуванняФормиToolStripMenuItem,
            this.побудовиПолейToolStripMenuItem,
            this.webсайтуToolStripMenuItem,
            this.відеоToolStripMenuItem,
            this.toolStripSeparator1,
            this.вихідToolStripMenuItem});
            this.доГоловногоМенюToolStripMenuItem.Name = "доГоловногоМенюToolStripMenuItem";
            this.доГоловногоМенюToolStripMenuItem.Size = new System.Drawing.Size(114, 25);
            this.доГоловногоМенюToolStripMenuItem.Text = "Перейти до...";
            // 
            // головногоМенюToolStripMenuItem
            // 
            this.головногоМенюToolStripMenuItem.Name = "головногоМенюToolStripMenuItem";
            this.головногоМенюToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.головногоМенюToolStripMenuItem.Text = "Головного меню";
            this.головногоМенюToolStripMenuItem.Click += new System.EventHandler(this.головногоМенюToolStripMenuItem_Click);
            // 
            // налаштуванняФормиToolStripMenuItem
            // 
            this.налаштуванняФормиToolStripMenuItem.Name = "налаштуванняФормиToolStripMenuItem";
            this.налаштуванняФормиToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.налаштуванняФормиToolStripMenuItem.Text = "Налаштування форми";
            this.налаштуванняФормиToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняФормиToolStripMenuItem_Click);
            // 
            // побудовиПолейToolStripMenuItem
            // 
            this.побудовиПолейToolStripMenuItem.Name = "побудовиПолейToolStripMenuItem";
            this.побудовиПолейToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.побудовиПолейToolStripMenuItem.Text = "Побудови полей";
            this.побудовиПолейToolStripMenuItem.Click += new System.EventHandler(this.побудовиПолейToolStripMenuItem_Click);
            // 
            // webсайтуToolStripMenuItem
            // 
            this.webсайтуToolStripMenuItem.Name = "webсайтуToolStripMenuItem";
            this.webсайтуToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.webсайтуToolStripMenuItem.Text = "Додаткокої анімації";
            this.webсайтуToolStripMenuItem.Click += new System.EventHandler(this.webсайтуToolStripMenuItem_Click);
            // 
            // відеоToolStripMenuItem
            // 
            this.відеоToolStripMenuItem.Name = "відеоToolStripMenuItem";
            this.відеоToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.відеоToolStripMenuItem.Text = "Відео";
            this.відеоToolStripMenuItem.Click += new System.EventHandler(this.відеоToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 720);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web-сайт";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem доГоловногоМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem головногоМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняФормиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem побудовиПолейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webсайтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відеоToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
    }
}