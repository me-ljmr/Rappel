namespace Rappel.Interface
{
    partial class frmServiceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceManager));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutoStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnOpenRappel = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyme = new System.Windows.Forms.NotifyIcon(this.components);
            this.rtClickTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuOpenServiceManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripOpenRappel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStartService = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStopService = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrProcessor = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.rtClickTrayIcon.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutoStartWithWindows);
            this.groupBox1.Controls.Add(this.btnOpenRappel);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(191, 214);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Manager";
            // 
            // chkAutoStartWithWindows
            // 
            this.chkAutoStartWithWindows.AutoSize = true;
            this.chkAutoStartWithWindows.Enabled = false;
            this.chkAutoStartWithWindows.Location = new System.Drawing.Point(100, 267);
            this.chkAutoStartWithWindows.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chkAutoStartWithWindows.Name = "chkAutoStartWithWindows";
            this.chkAutoStartWithWindows.Size = new System.Drawing.Size(225, 21);
            this.chkAutoStartWithWindows.TabIndex = 4;
            this.chkAutoStartWithWindows.Text = "Auto Start Service When OS Starts";
            this.chkAutoStartWithWindows.UseVisualStyleBackColor = true;
            this.chkAutoStartWithWindows.Visible = false;
            // 
            // btnOpenRappel
            // 
            this.btnOpenRappel.BackColor = System.Drawing.Color.White;
            this.btnOpenRappel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenRappel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenRappel.ForeColor = System.Drawing.Color.Black;
            this.btnOpenRappel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenRappel.Location = new System.Drawing.Point(21, 157);
            this.btnOpenRappel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpenRappel.Name = "btnOpenRappel";
            this.btnOpenRappel.Size = new System.Drawing.Size(152, 39);
            this.btnOpenRappel.TabIndex = 5;
            this.btnOpenRappel.Text = "Open Rappel";
            this.btnOpenRappel.UseVisualStyleBackColor = false;
            this.btnOpenRappel.Click += new System.EventHandler(this.btnOpenRappel_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.IndianRed;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.ImageKey = "stop";
            this.btnStop.Location = new System.Drawing.Point(21, 108);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(152, 39);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop Service";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.ImageKey = "start";
            this.btnStart.Location = new System.Drawing.Point(21, 60);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Service";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actions:";
            // 
            // notifyme
            // 
            this.notifyme.ContextMenuStrip = this.rtClickTrayIcon;
            this.notifyme.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyme.Icon")));
            this.notifyme.Visible = true;
            this.notifyme.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyme_MouseDoubleClick);
            // 
            // rtClickTrayIcon
            // 
            this.rtClickTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenServiceManager,
            this.tstripOpenRappel,
            this.toolStripMenuItem3,
            this.menuStartService,
            this.menuStopService,
            this.toolStripMenuItem1,
            this.menuExit});
            this.rtClickTrayIcon.Name = "rtClickTrayIcon";
            this.rtClickTrayIcon.Size = new System.Drawing.Size(202, 126);
            // 
            // menuOpenServiceManager
            // 
            this.menuOpenServiceManager.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuOpenServiceManager.Name = "menuOpenServiceManager";
            this.menuOpenServiceManager.Size = new System.Drawing.Size(201, 22);
            this.menuOpenServiceManager.Text = "Open Service Manager";
            this.menuOpenServiceManager.Click += new System.EventHandler(this.menuOpenServiceManager_Click);
            // 
            // tstripOpenRappel
            // 
            this.tstripOpenRappel.Name = "tstripOpenRappel";
            this.tstripOpenRappel.Size = new System.Drawing.Size(201, 22);
            this.tstripOpenRappel.Text = "Open Rappel";
            this.tstripOpenRappel.Click += new System.EventHandler(this.tstripOpenRappel_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(198, 6);
            // 
            // menuStartService
            // 
            this.menuStartService.Name = "menuStartService";
            this.menuStartService.Size = new System.Drawing.Size(201, 22);
            this.menuStartService.Text = "Start";
            this.menuStartService.Click += new System.EventHandler(this.menuStartService_Click);
            // 
            // menuStopService
            // 
            this.menuStopService.Name = "menuStopService";
            this.menuStopService.Size = new System.Drawing.Size(201, 22);
            this.menuStopService.Text = "Stop";
            this.menuStopService.Click += new System.EventHandler(this.menuStopService_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(198, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(201, 22);
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // tmrProcessor
            // 
            this.tmrProcessor.Interval = 1000;
            this.tmrProcessor.Tick += new System.EventHandler(this.tmrProcessor_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(218, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstripStatus
            // 
            this.tstripStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstripStatus.ForeColor = System.Drawing.Color.White;
            this.tstripStatus.Name = "tstripStatus";
            this.tstripStatus.Size = new System.Drawing.Size(200, 17);
            this.tstripStatus.Spring = true;
            this.tstripStatus.Text = "Stopped";
            this.tstripStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmServiceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(218, 270);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServiceManager";
            this.ShowInTaskbar = false;
            this.Text = "Service Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServiceManager_FormClosing);
            this.Load += new System.EventHandler(this.frmServiceManager_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.rtClickTrayIcon.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAutoStartWithWindows;
        private System.Windows.Forms.Button btnOpenRappel;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyme;
        private System.Windows.Forms.ContextMenuStrip rtClickTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem menuOpenServiceManager;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuStartService;
        private System.Windows.Forms.ToolStripMenuItem menuStopService;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.Timer tmrProcessor;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstripStatus;
        private System.Windows.Forms.ToolStripMenuItem tstripOpenRappel;
    }
}