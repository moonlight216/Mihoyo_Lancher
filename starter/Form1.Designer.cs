namespace starter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            more_ys = new Button();
            ys = new Button();
            pictureBox1 = new PictureBox();
            tabPage2 = new TabPage();
            more_xqtd = new Button();
            xqtd = new Button();
            pictureBox2 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.RightToLeft = RightToLeft.No;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1583, 925);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(more_ys);
            tabPage1.Controls.Add(ys);
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 33);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1575, 888);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "原神";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // more_ys
            // 
            more_ys.Location = new Point(1442, 752);
            more_ys.Name = "more_ys";
            more_ys.Size = new Size(44, 70);
            more_ys.TabIndex = 2;
            more_ys.Text = "三";
            more_ys.UseVisualStyleBackColor = true;
            more_ys.Click += more_ys_Click;
            // 
            // ys
            // 
            ys.Enabled = false;
            ys.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ys.Location = new Point(1268, 752);
            ys.Name = "ys";
            ys.Size = new Size(175, 70);
            ys.TabIndex = 1;
            ys.Text = "开始游戏";
            ys.UseVisualStyleBackColor = true;
            ys.Click += ys_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.ys;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1569, 882);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(more_xqtd);
            tabPage2.Controls.Add(xqtd);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Location = new Point(4, 33);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1575, 888);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "崩坏·星穹铁道";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // more_xqtd
            // 
            more_xqtd.Location = new Point(1442, 752);
            more_xqtd.Name = "more_xqtd";
            more_xqtd.Size = new Size(44, 70);
            more_xqtd.TabIndex = 3;
            more_xqtd.Text = "三";
            more_xqtd.UseVisualStyleBackColor = true;
            more_xqtd.Click += more_xqtd_Click;
            // 
            // xqtd
            // 
            xqtd.Enabled = false;
            xqtd.Font = new Font("微软雅黑", 14F, FontStyle.Regular, GraphicsUnit.Point);
            xqtd.Location = new Point(1268, 752);
            xqtd.Name = "xqtd";
            xqtd.Size = new Size(175, 70);
            xqtd.TabIndex = 2;
            xqtd.Text = "开始游戏";
            xqtd.UseVisualStyleBackColor = true;
            xqtd.Click += xqtd_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.td;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1569, 882);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(243, 127);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(242, 30);
            toolStripMenuItem1.Text = "选择游戏启动器目录";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(242, 30);
            toolStripMenuItem3.Text = "重置配置文件";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(242, 30);
            toolStripMenuItem2.Text = "软件信息";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 925);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "启动器";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button ys;
        private PictureBox pictureBox1;
        private TabPage tabPage2;
        private Button more_ys;
        private Button more_xqtd;
        private Button xqtd;
        private PictureBox pictureBox2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}