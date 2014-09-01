using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rappel.DataStructure;
namespace Rappel.Interface
{
    public partial class frmReminder : Form
    {
        public bool CancelPressed = true;
        public Reminders TaskInfo { get { return _task; } set { _task = value; } }
        private Reminders _task=new Reminders();
        public frmReminder()
        {
            InitializeComponent();
        }
        private void LoadLists()
        {
            Rappel.BusinessLogic.ListsLogic rma = new BusinessLogic.ListsLogic();
            cboList.DataSource = rma.GetLists();
            cboList.DisplayMember = "rem_desc";
            cboList.ValueMember = "rem_id";
            rma = null;
        }
        private void chkRemindMe_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if (chk.Checked == true)
            {
                chkRemindMe.Text = "ON";
                chkRemindMe.BackColor = Color.Turquoise;
                dtRemindOn.Visible = true;
                lblRepeat.Enabled = true;
                cboRepeatType.Enabled = true;
            }
            else 
            {
                chkRemindMe.Text = "OFF";
                chkRemindMe.BackColor = Color.DarkGray;
                dtRemindOn.Visible = false;
                lblRepeat.Enabled = false;
                cboRepeatType.Enabled = false;
            }
        }
        private void LoadCombos()
        {
            cboRepeatType.DataSource = Enums.EnumHelper.ToList(typeof(Enums.AlarmRepeatType));
            cboRepeatType.DisplayMember = "Value";
            cboRepeatType.ValueMember = "Key";
            cboPriority.DataSource = Enum.GetValues(typeof(Enums.Priority)); 

        }
        private void ReloadTaskVariable()
        {
             _task.TaskTitle = txtTaskTitle.Text;
             if (chkRemindMe.Checked == true)
             {
                 _task.RemindMe = true;
                 _task.RemindOn = dtRemindOn.Value;
                 _task.RepeatType = (Enums.AlarmRepeatType)cboRepeatType.SelectedValue;
             }
             else
             {
                 _task.RemindMe = false;
                 _task.RepeatType = Enums.AlarmRepeatType.None;
             }
             if (chkAddToList.Checked == true)
             {
                 _task.ReminderID =long.Parse( cboList.SelectedValue.ToString());
             }
             else
             {
                 _task.ReminderID = 0;
             }
             _task.TaskPriority = (Enums.Priority)cboPriority.SelectedValue;
             _task.Notes = txtNotes.Text;
        }
        private void LoadTaskInfo()
        {
            txtTaskTitle.Text = _task.TaskTitle;
            if (_task.RemindMe == true)
            {
                chkRemindMe.Checked = true;
                dtRemindOn.Value = _task.RemindOn;
                cboRepeatType.SelectedValue = _task.RepeatType;
            }
            else
            {
                chkRemindMe.Checked = false;
            }
            if (_task.ReminderID != 0)
            {
                chkAddToList.Checked = true;
                cboList.SelectedValue = _task.ReminderID;
            }
            else {
                chkAddToList.Checked = false;
            }
            cboPriority.SelectedIndex = (int)_task.TaskPriority;
            txtNotes.Text = _task.Notes;
        }
        private void frmTask_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadLists();
            if (_task != null)
            {
                LoadTaskInfo();
            }
            txtTaskTitle.Focus();
        }
        private void chkAddToList_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            cboList.Visible = chk.Checked;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            _task = null;
            CancelPressed = true;
            this.Close();
        }
        private void btnDone_Click(object sender, EventArgs e)
        {

            if (!chkAddToList.Checked && !chkRemindMe.Checked)
            {
                MessageBox.Show("Either select a listing group or enable the task reminder.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtTaskTitle.Text.Trim() == "")
            {
                MessageBox.Show("Reminder title cannot be empty",Application.ProductName,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                ReloadTaskVariable();
                CancelPressed = false;
                this.Close();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
