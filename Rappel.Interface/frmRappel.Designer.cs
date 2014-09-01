namespace Rappel.Interface
{
    partial class frmRappel
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
                _singleinst = null;
                components.Dispose();
            }
            if (_singleinst  != null) _singleinst.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRappel));
            this.lstListActions = new System.Windows.Forms.ListBox();
            this.btnAddNewReminder = new System.Windows.Forms.Button();
            this.lstLists = new System.Windows.Forms.ListBox();
            this.mcal = new System.Windows.Forms.MonthCalendar();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.lblSelectedReminder = new System.Windows.Forms.Label();
            this.lvTasks = new System.Windows.Forms.ListView();
            this.colTaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mnutaskactions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tstripmarkcomplete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstripDeleteTask = new System.Windows.Forms.ToolStripMenuItem();
            this.img24x24 = new System.Windows.Forms.ImageList(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDoneTasks = new System.Windows.Forms.Button();
            this.mnumcalactions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newTaskReminderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboScheduleGroups = new System.Windows.Forms.ComboBox();
            this.mnutaskactions.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mnumcalactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstListActions
            // 
            this.lstListActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstListActions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListActions.FormattingEnabled = true;
            this.lstListActions.ItemHeight = 21;
            this.lstListActions.Location = new System.Drawing.Point(11, 108);
            this.lstListActions.Name = "lstListActions";
            this.lstListActions.Size = new System.Drawing.Size(228, 149);
            this.lstListActions.TabIndex = 0;
            this.lstListActions.SelectedIndexChanged += new System.EventHandler(this.lstGroups_SelectedIndexChanged);
            this.lstListActions.Leave += new System.EventHandler(this.lstGroups_Leave);
            // 
            // btnAddNewReminder
            // 
            this.btnAddNewReminder.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAddNewReminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddNewReminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddNewReminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewReminder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewReminder.Location = new System.Drawing.Point(205, 263);
            this.btnAddNewReminder.Name = "btnAddNewReminder";
            this.btnAddNewReminder.Size = new System.Drawing.Size(34, 29);
            this.btnAddNewReminder.TabIndex = 1;
            this.btnAddNewReminder.Text = "+";
            this.btnAddNewReminder.UseVisualStyleBackColor = false;
            this.btnAddNewReminder.Click += new System.EventHandler(this.btnAddNewReminder_Click);
            // 
            // lstLists
            // 
            this.lstLists.BackColor = System.Drawing.Color.DarkGray;
            this.lstLists.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstLists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLists.FormattingEnabled = true;
            this.lstLists.ItemHeight = 21;
            this.lstLists.Location = new System.Drawing.Point(11, 298);
            this.lstLists.Name = "lstLists";
            this.lstLists.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstLists.Size = new System.Drawing.Size(228, 128);
            this.lstLists.TabIndex = 2;
            this.lstLists.SelectedIndexChanged += new System.EventHandler(this.lstReminders_SelectedIndexChanged);
            this.lstLists.DoubleClick += new System.EventHandler(this.lstLists_DoubleClick);
            this.lstLists.Leave += new System.EventHandler(this.lstLists_Leave);
            // 
            // mcal
            // 
            this.mcal.BackColor = System.Drawing.Color.Silver;
            this.mcal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mcal.Location = new System.Drawing.Point(11, 434);
            this.mcal.MaxSelectionCount = 1;
            this.mcal.Name = "mcal";
            this.mcal.TabIndex = 2;
            this.mcal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcal_DateChanged);
            this.mcal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mcal_DateSelected);
            this.mcal.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.mcal_HelpRequested);
            // 
            // btnEditTask
            // 
            this.btnEditTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnEditTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnEditTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnEditTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTask.Location = new System.Drawing.Point(635, 12);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(62, 29);
            this.btnEditTask.TabIndex = 1;
            this.btnEditTask.Text = "Edit";
            this.btnEditTask.UseVisualStyleBackColor = false;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnAddTask.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAddTask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(703, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(32, 29);
            this.btnAddTask.TabIndex = 2;
            this.btnAddTask.Text = "+";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblSelectedReminder
            // 
            this.lblSelectedReminder.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedReminder.ForeColor = System.Drawing.Color.White;
            this.lblSelectedReminder.Location = new System.Drawing.Point(273, 11);
            this.lblSelectedReminder.Name = "lblSelectedReminder";
            this.lblSelectedReminder.Size = new System.Drawing.Size(356, 31);
            this.lblSelectedReminder.TabIndex = 3;
            // 
            // lvTasks
            // 
            this.lvTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTaskName,
            this.colNotes});
            this.lvTasks.ContextMenuStrip = this.mnutaskactions;
            this.lvTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTasks.FullRowSelect = true;
            this.lvTasks.GridLines = true;
            this.lvTasks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvTasks.Location = new System.Drawing.Point(252, 47);
            this.lvTasks.Name = "lvTasks";
            this.lvTasks.Size = new System.Drawing.Size(484, 549);
            this.lvTasks.SmallImageList = this.img24x24;
            this.lvTasks.TabIndex = 4;
            this.lvTasks.UseCompatibleStateImageBehavior = false;
            this.lvTasks.View = System.Windows.Forms.View.Details;
            this.lvTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvTasks_ItemCheck);
            this.lvTasks.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lvTasks_ItemChecked);
            this.lvTasks.SelectedIndexChanged += new System.EventHandler(this.lvTasks_SelectedIndexChanged);
            this.lvTasks.DoubleClick += new System.EventHandler(this.lvTasks_DoubleClick);
            // 
            // colTaskName
            // 
            this.colTaskName.Text = "Tasks";
            this.colTaskName.Width = 204;
            // 
            // colNotes
            // 
            this.colNotes.Text = "Notes";
            this.colNotes.Width = 267;
            // 
            // mnutaskactions
            // 
            this.mnutaskactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripmarkcomplete,
            this.toolStripMenuItem1,
            this.tstripDeleteTask});
            this.mnutaskactions.Name = "mnutaskactions";
            this.mnutaskactions.Size = new System.Drawing.Size(171, 54);
            // 
            // tstripmarkcomplete
            // 
            this.tstripmarkcomplete.Name = "tstripmarkcomplete";
            this.tstripmarkcomplete.Size = new System.Drawing.Size(170, 22);
            this.tstripmarkcomplete.Text = "Mark as Complete";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // tstripDeleteTask
            // 
            this.tstripDeleteTask.Name = "tstripDeleteTask";
            this.tstripDeleteTask.Size = new System.Drawing.Size(170, 22);
            this.tstripDeleteTask.Text = "Delete This Task";
            this.tstripDeleteTask.Click += new System.EventHandler(this.tstripDeleteTask_Click);
            // 
            // img24x24
            // 
            this.img24x24.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img24x24.ImageStream")));
            this.img24x24.TransparentColor = System.Drawing.Color.Transparent;
            this.img24x24.Images.SetKeyName(0, "tasks");
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 605);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(748, 24);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(733, 19);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "© 2013 - Designed by Gugu for Kitty";
            // 
            // btnDoneTasks
            // 
            this.btnDoneTasks.BackColor = System.Drawing.Color.IndianRed;
            this.btnDoneTasks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnDoneTasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnDoneTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoneTasks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneTasks.Location = new System.Drawing.Point(635, 12);
            this.btnDoneTasks.Name = "btnDoneTasks";
            this.btnDoneTasks.Size = new System.Drawing.Size(62, 29);
            this.btnDoneTasks.TabIndex = 7;
            this.btnDoneTasks.Text = "Done";
            this.btnDoneTasks.UseVisualStyleBackColor = false;
            this.btnDoneTasks.Click += new System.EventHandler(this.btnDoneTasks_Click);
            // 
            // mnumcalactions
            // 
            this.mnumcalactions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskReminderToolStripMenuItem,
            this.newAppointmentToolStripMenuItem,
            this.newEventToolStripMenuItem});
            this.mnumcalactions.Name = "mnumcalactions";
            this.mnumcalactions.Size = new System.Drawing.Size(180, 70);
            // 
            // newTaskReminderToolStripMenuItem
            // 
            this.newTaskReminderToolStripMenuItem.Name = "newTaskReminderToolStripMenuItem";
            this.newTaskReminderToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newTaskReminderToolStripMenuItem.Text = "New Task Reminder";
            // 
            // newAppointmentToolStripMenuItem
            // 
            this.newAppointmentToolStripMenuItem.Name = "newAppointmentToolStripMenuItem";
            this.newAppointmentToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newAppointmentToolStripMenuItem.Text = "New Appointment";
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.newEventToolStripMenuItem.Text = "New Event";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lists";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Schedules";
            // 
            // cboScheduleGroups
            // 
            this.cboScheduleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboScheduleGroups.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboScheduleGroups.FormattingEnabled = true;
            this.cboScheduleGroups.Location = new System.Drawing.Point(11, 39);
            this.cboScheduleGroups.Name = "cboScheduleGroups";
            this.cboScheduleGroups.Size = new System.Drawing.Size(229, 29);
            this.cboScheduleGroups.TabIndex = 8;
            this.cboScheduleGroups.SelectedIndexChanged += new System.EventHandler(this.cboScheduleGroups_SelectedIndexChanged);
            // 
            // frmRappel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(748, 629);
            this.Controls.Add(this.cboScheduleGroups);
            this.Controls.Add(this.btnDoneTasks);
            this.Controls.Add(this.lvTasks);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.lblSelectedReminder);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.mcal);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstLists);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddNewReminder);
            this.Controls.Add(this.lstListActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRappel";
            this.Text = "Rappel";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnutaskactions.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnumcalactions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListActions;
        private System.Windows.Forms.Button btnAddNewReminder;
        private System.Windows.Forms.ListBox lstLists;
        private System.Windows.Forms.MonthCalendar mcal;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Label lblSelectedReminder;
        private System.Windows.Forms.ListView lvTasks;
        private System.Windows.Forms.ColumnHeader colTaskName;
        private System.Windows.Forms.ContextMenuStrip mnutaskactions;
        private System.Windows.Forms.ToolStripMenuItem tstripDeleteTask;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader colNotes;
        private System.Windows.Forms.ImageList img24x24;
        private System.Windows.Forms.Button btnDoneTasks;
        private System.Windows.Forms.ContextMenuStrip mnumcalactions;
        private System.Windows.Forms.ToolStripMenuItem newTaskReminderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstripmarkcomplete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboScheduleGroups;
    }
}

