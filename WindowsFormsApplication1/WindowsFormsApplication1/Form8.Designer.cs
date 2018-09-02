namespace WindowsFormsApplication1
{
    partial class Form8
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.доГоловногоМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.головногоМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.налаштуванняФормиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.побудовиПолейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webсайтуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.доГоловногоМенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(603, 599);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(125, 31);
            this.menuStrip1.TabIndex = 39;
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
            this.побудовиПолейToolStripMenuItem.Text = "Додаткової анімації";
            this.побудовиПолейToolStripMenuItem.Click += new System.EventHandler(this.побудовиПолейToolStripMenuItem_Click);
            // 
            // webсайтуToolStripMenuItem
            // 
            this.webсайтуToolStripMenuItem.Name = "webсайтуToolStripMenuItem";
            this.webсайтуToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.webсайтуToolStripMenuItem.Text = "Web-сайту";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 438);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(12, 599);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 40;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 645);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem доГоловногоМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem головногоМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняФормиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem побудовиПолейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webсайтуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відеоToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}