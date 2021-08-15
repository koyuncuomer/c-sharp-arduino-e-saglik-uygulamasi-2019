namespace arduinoBluetooth
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekibimizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projemizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControlN = new ZedGraph.ZedGraphControl();
            this.zedGraphControlO = new ZedGraph.ZedGraphControl();
            this.zedGraphControlS = new ZedGraph.ZedGraphControl();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Bağlanılacak Portu Seçiniz!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Henüz Bağlantı Yok!";
            // 
            // btnEkg
            // 
            this.btnEkg.Location = new System.Drawing.Point(79, 18);
            this.btnEkg.Name = "btnEkg";
            this.btnEkg.Size = new System.Drawing.Size(66, 46);
            this.btnEkg.TabIndex = 13;
            this.btnEkg.Text = "EKG Ölçümü";
            this.btnEkg.UseVisualStyleBackColor = true;
            this.btnEkg.Click += new System.EventHandler(this.btnEkg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnEkg);
            this.groupBox2.Location = new System.Drawing.Point(181, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 79);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 46);
            this.button2.TabIndex = 14;
            this.button2.Text = "Nabız Ölçümü";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(341, 34);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(84, 30);
            this.btnKes.TabIndex = 6;
            this.btnKes.Text = "Bağlantıyı Kes!";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 642);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekibimizToolStripMenuItem,
            this.projemizToolStripMenuItem});
            this.hakkımızdaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hakkımızdaToolStripMenuItem.Image")));
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // ekibimizToolStripMenuItem
            // 
            this.ekibimizToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ekibimizToolStripMenuItem.Image")));
            this.ekibimizToolStripMenuItem.Name = "ekibimizToolStripMenuItem";
            this.ekibimizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.ekibimizToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.ekibimizToolStripMenuItem.Text = "Ekibimiz";
            this.ekibimizToolStripMenuItem.Click += new System.EventHandler(this.ekibimizToolStripMenuItem_Click);
            // 
            // projemizToolStripMenuItem
            // 
            this.projemizToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("projemizToolStripMenuItem.Image")));
            this.projemizToolStripMenuItem.Name = "projemizToolStripMenuItem";
            this.projemizToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.projemizToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.projemizToolStripMenuItem.Text = "Projemiz";
            this.projemizToolStripMenuItem.Click += new System.EventHandler(this.projemizToolStripMenuItem_Click);
            // 
            // zedGraphControlN
            // 
            this.zedGraphControlN.Location = new System.Drawing.Point(6, 17);
            this.zedGraphControlN.Name = "zedGraphControlN";
            this.zedGraphControlN.ScrollGrace = 0D;
            this.zedGraphControlN.ScrollMaxX = 0D;
            this.zedGraphControlN.ScrollMaxY = 0D;
            this.zedGraphControlN.ScrollMaxY2 = 0D;
            this.zedGraphControlN.ScrollMinX = 0D;
            this.zedGraphControlN.ScrollMinY = 0D;
            this.zedGraphControlN.ScrollMinY2 = 0D;
            this.zedGraphControlN.Size = new System.Drawing.Size(380, 330);
            this.zedGraphControlN.TabIndex = 16;
            // 
            // zedGraphControlO
            // 
            this.zedGraphControlO.Location = new System.Drawing.Point(394, 17);
            this.zedGraphControlO.Name = "zedGraphControlO";
            this.zedGraphControlO.ScrollGrace = 0D;
            this.zedGraphControlO.ScrollMaxX = 0D;
            this.zedGraphControlO.ScrollMaxY = 0D;
            this.zedGraphControlO.ScrollMaxY2 = 0D;
            this.zedGraphControlO.ScrollMinX = 0D;
            this.zedGraphControlO.ScrollMinY = 0D;
            this.zedGraphControlO.ScrollMinY2 = 0D;
            this.zedGraphControlO.Size = new System.Drawing.Size(380, 330);
            this.zedGraphControlO.TabIndex = 17;
            // 
            // zedGraphControlS
            // 
            this.zedGraphControlS.Location = new System.Drawing.Point(780, 17);
            this.zedGraphControlS.Name = "zedGraphControlS";
            this.zedGraphControlS.ScrollGrace = 0D;
            this.zedGraphControlS.ScrollMaxX = 0D;
            this.zedGraphControlS.ScrollMaxY = 0D;
            this.zedGraphControlS.ScrollMaxY2 = 0D;
            this.zedGraphControlS.ScrollMinX = 0D;
            this.zedGraphControlS.ScrollMinY = 0D;
            this.zedGraphControlS.ScrollMinY2 = 0D;
            this.zedGraphControlS.Size = new System.Drawing.Size(380, 330);
            this.zedGraphControlS.TabIndex = 18;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(7, 86);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(600, 550);
            this.zedGraphControl1.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zedGraphControlS);
            this.groupBox3.Controls.Add(this.zedGraphControlN);
            this.groupBox3.Controls.Add(this.zedGraphControlO);
            this.groupBox3.Location = new System.Drawing.Point(2, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1166, 354);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nabız, SpO2, Sıcaklık";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "SpO2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Sıcaklık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nabız:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(498, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 96);
            this.groupBox4.TabIndex = 30;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "eSaglikNabiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ekibimizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projemizToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControlN;
        private ZedGraph.ZedGraphControl zedGraphControlO;
        private ZedGraph.ZedGraphControl zedGraphControlS;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}

