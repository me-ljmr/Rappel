namespace Rappel.Interface
{
    partial class frmReminder
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.chkAddToList = new System.Windows.Forms.CheckBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRepeatType = new System.Windows.Forms.ComboBox();
            this.lblRepeat = new System.Windows.Forms.Label();
            this.chkRemindMe = new System.Windows.Forms.CheckBox();
            this.dtRemindOn = new System.Windows.Forms.DateTimePicker();
            this.lblRemindMe = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(339, 342);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 29);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnDone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(257, 342);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(62, 29);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // chkAddToList
            // 
            this.chkAddToList.AutoSize = true;
            this.chkAddToList.Location = new System.Drawing.Point(139, 181);
            this.chkAddToList.Name = "chkAddToList";
            this.chkAddToList.Size = new System.Drawing.Size(15, 14);
            this.chkAddToList.TabIndex = 5;
            this.chkAddToList.UseVisualStyleBackColor = true;
            this.chkAddToList.CheckedChanged += new System.EventHandler(this.chkAddToList_CheckedChanged);
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(139, 208);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(234, 76);
            this.txtNotes.TabIndex = 7;
            // 
            // cboList
            // 
            this.cboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(160, 173);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(213, 25);
            this.cboList.TabIndex = 6;
            this.cboList.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(24, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Notes";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "List";
            // 
            // cboPriority
            // 
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(139, 143);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(123, 25);
            this.cboPriority.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Priority";
            // 
            // cboRepeatType
            // 
            this.cboRepeatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRepeatType.Enabled = false;
            this.cboRepeatType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRepeatType.FormattingEnabled = true;
            this.cboRepeatType.Location = new System.Drawing.Point(139, 105);
            this.cboRepeatType.Name = "cboRepeatType";
            this.cboRepeatType.Size = new System.Drawing.Size(123, 25);
            this.cboRepeatType.TabIndex = 20;
            // 
            // lblRepeat
            // 
            this.lblRepeat.AutoSize = true;
            this.lblRepeat.Enabled = false;
            this.lblRepeat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepeat.ForeColor = System.Drawing.Color.White;
            this.lblRepeat.Location = new System.Drawing.Point(24, 108);
            this.lblRepeat.Name = "lblRepeat";
            this.lblRepeat.Size = new System.Drawing.Size(49, 17);
            this.lblRepeat.TabIndex = 21;
            this.lblRepeat.Text = "Repeat";
            // 
            // chkRemindMe
            // 
            this.chkRemindMe.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkRemindMe.BackColor = System.Drawing.Color.DarkGray;
            this.chkRemindMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemindMe.Location = new System.Drawing.Point(139, 68);
            this.chkRemindMe.Name = "chkRemindMe";
            this.chkRemindMe.Size = new System.Drawing.Size(39, 26);
            this.chkRemindMe.TabIndex = 1;
            this.chkRemindMe.Text = "OFF";
            this.chkRemindMe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRemindMe.UseVisualStyleBackColor = false;
            this.chkRemindMe.CheckedChanged += new System.EventHandler(this.chkRemindMe_CheckedChanged);
            // 
            // dtRemindOn
            // 
            this.dtRemindOn.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
            this.dtRemindOn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRemindOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtRemindOn.Location = new System.Drawing.Point(184, 68);
            this.dtRemindOn.Name = "dtRemindOn";
            this.dtRemindOn.Size = new System.Drawing.Size(189, 25);
            this.dtRemindOn.TabIndex = 3;
            this.dtRemindOn.Visible = false;
            // 
            // lblRemindMe
            // 
            this.lblRemindMe.AutoSize = true;
            this.lblRemindMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemindMe.ForeColor = System.Drawing.Color.White;
            this.lblRemindMe.Location = new System.Drawing.Point(24, 72);
            this.lblRemindMe.Name = "lblRemindMe";
            this.lblRemindMe.Size = new System.Drawing.Size(75, 17);
            this.lblRemindMe.TabIndex = 15;
            this.lblRemindMe.Text = "Remind Me";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskTitle.Location = new System.Drawing.Point(139, 30);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(234, 25);
            this.txtTaskTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(99, 17);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Reminder Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAddToList);
            this.groupBox1.Controls.Add(this.txtTaskTitle);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.cboList);
            this.groupBox1.Controls.Add(this.lblRemindMe);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtRemindOn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkRemindMe);
            this.groupBox1.Controls.Add(this.cboPriority);
            this.groupBox1.Controls.Add(this.lblRepeat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboRepeatType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 314);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // frmReminder
            // 
            this.AcceptButton = this.btnDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(413, 390);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.frmTask_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox chkAddToList;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRepeatType;
        private System.Windows.Forms.Label lblRepeat;
        private System.Windows.Forms.CheckBox chkRemindMe;
        private System.Windows.Forms.DateTimePicker dtRemindOn;
        private System.Windows.Forms.Label lblRemindMe;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}