namespace Rappel.Interface
{
    partial class frmAppointments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppointmentTitle = new System.Windows.Forms.TextBox();
            this.txtWithWhom = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemindBeforeNum = new System.Windows.Forms.TextBox();
            this.cboRemindBeforeType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAddToList = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cboEndTime = new System.Windows.Forms.ComboBox();
            this.cboStartTime = new System.Windows.Forms.ComboBox();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.chkRemindMe = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Appointment Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "With Whom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "End Date";
            // 
            // txtAppointmentTitle
            // 
            this.txtAppointmentTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAppointmentTitle.Location = new System.Drawing.Point(153, 23);
            this.txtAppointmentTitle.Name = "txtAppointmentTitle";
            this.txtAppointmentTitle.Size = new System.Drawing.Size(197, 25);
            this.txtAppointmentTitle.TabIndex = 0;
            // 
            // txtWithWhom
            // 
            this.txtWithWhom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithWhom.Location = new System.Drawing.Point(153, 61);
            this.txtWithWhom.Name = "txtWithWhom";
            this.txtWithWhom.Size = new System.Drawing.Size(197, 25);
            this.txtWithWhom.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(153, 99);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(197, 25);
            this.txtLocation.TabIndex = 2;
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "dd/MM/yyyy";
            this.dtStart.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(152, 167);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(91, 25);
            this.dtStart.TabIndex = 5;
            // 
            // dtEnd
            // 
            this.dtEnd.CustomFormat = "dd/MM/yyyy";
            this.dtEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEnd.Location = new System.Drawing.Point(152, 203);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(91, 25);
            this.dtEnd.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Remind Me before";
            // 
            // txtRemindBeforeNum
            // 
            this.txtRemindBeforeNum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemindBeforeNum.Location = new System.Drawing.Point(174, 240);
            this.txtRemindBeforeNum.Name = "txtRemindBeforeNum";
            this.txtRemindBeforeNum.Size = new System.Drawing.Size(69, 25);
            this.txtRemindBeforeNum.TabIndex = 9;
            this.txtRemindBeforeNum.Text = "0";
            // 
            // cboRemindBeforeType
            // 
            this.cboRemindBeforeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRemindBeforeType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRemindBeforeType.FormattingEnabled = true;
            this.cboRemindBeforeType.Location = new System.Drawing.Point(248, 240);
            this.cboRemindBeforeType.Name = "cboRemindBeforeType";
            this.cboRemindBeforeType.Size = new System.Drawing.Size(102, 25);
            this.cboRemindBeforeType.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkRemindMe);
            this.groupBox2.Controls.Add(this.chkAddToList);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.cboEndTime);
            this.groupBox2.Controls.Add(this.cboStartTime);
            this.groupBox2.Controls.Add(this.cboList);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtRemindBeforeNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboRemindBeforeType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.txtAppointmentTitle);
            this.groupBox2.Controls.Add(this.txtLocation);
            this.groupBox2.Controls.Add(this.txtWithWhom);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 370);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // chkAddToList
            // 
            this.chkAddToList.AutoSize = true;
            this.chkAddToList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddToList.Location = new System.Drawing.Point(153, 137);
            this.chkAddToList.Name = "chkAddToList";
            this.chkAddToList.Size = new System.Drawing.Size(15, 14);
            this.chkAddToList.TabIndex = 3;
            this.chkAddToList.UseVisualStyleBackColor = true;
            this.chkAddToList.CheckedChanged += new System.EventHandler(this.chkAddToList_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.Location = new System.Drawing.Point(152, 278);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(198, 76);
            this.txtNotes.TabIndex = 11;
            // 
            // cboEndTime
            // 
            this.cboEndTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEndTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEndTime.FormatString = "hh:mm tt";
            this.cboEndTime.FormattingEnabled = true;
            this.cboEndTime.Location = new System.Drawing.Point(248, 203);
            this.cboEndTime.Name = "cboEndTime";
            this.cboEndTime.Size = new System.Drawing.Size(102, 25);
            this.cboEndTime.TabIndex = 8;
            // 
            // cboStartTime
            // 
            this.cboStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStartTime.FormatString = "hh:mm tt";
            this.cboStartTime.FormattingEnabled = true;
            this.cboStartTime.Location = new System.Drawing.Point(249, 167);
            this.cboStartTime.Name = "cboStartTime";
            this.cboStartTime.Size = new System.Drawing.Size(102, 25);
            this.cboStartTime.TabIndex = 6;
            this.cboStartTime.SelectedIndexChanged += new System.EventHandler(this.cboStartTime_SelectedIndexChanged);
            // 
            // cboList
            // 
            this.cboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboList.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(174, 132);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(176, 25);
            this.cboList.TabIndex = 4;
            this.cboList.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "List";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.YellowGreen;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(316, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 29);
            this.btnCancel.TabIndex = 11;
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
            this.btnDone.Location = new System.Drawing.Point(237, 389);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(62, 29);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // chkRemindMe
            // 
            this.chkRemindMe.AutoSize = true;
            this.chkRemindMe.Checked = true;
            this.chkRemindMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemindMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRemindMe.Location = new System.Drawing.Point(152, 245);
            this.chkRemindMe.Name = "chkRemindMe";
            this.chkRemindMe.Size = new System.Drawing.Size(15, 14);
            this.chkRemindMe.TabIndex = 12;
            this.chkRemindMe.UseVisualStyleBackColor = true;
            this.chkRemindMe.CheckedChanged += new System.EventHandler(this.chkRemindMe_CheckedChanged);
            // 
            // frmAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(390, 434);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.frmAppointments_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAppointmentTitle;
        private System.Windows.Forms.TextBox txtWithWhom;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemindBeforeNum;
        private System.Windows.Forms.ComboBox cboRemindBeforeType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox chkAddToList;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboEndTime;
        private System.Windows.Forms.ComboBox cboStartTime;
        private System.Windows.Forms.CheckBox chkRemindMe;
    }
}