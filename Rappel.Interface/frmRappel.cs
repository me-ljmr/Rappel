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
    public partial class frmRappel : Form
    {
        private static frmRappel _singleinst;
        private string SelectedSchedule;
        string ListActionSelectionType = "DATE";
        public frmRappel()
        {
            InitializeComponent();
        }
        public static frmRappel Instance()
        {
            if (_singleinst == null)
            {
                _singleinst = new frmRappel();
                _singleinst.BringToFront();
            }
            return _singleinst;
        }
        private void LoadLists()
        {
            Rappel.BusinessLogic.ListsLogic rma = new BusinessLogic.ListsLogic();
            lstLists.DataSource = rma.GetLists();
            lstLists.DisplayMember = "rem_desc";
            lstLists.ValueMember = "rem_id";
            rma = null;
        }
        private void LoadBuiltInGroups()
        {
            Rappel.BusinessLogic.BuiltInGroupsLogic bgl = new BusinessLogic.BuiltInGroupsLogic();
            cboScheduleGroups.DataSource = bgl.GetBuiltInGroups();
            cboScheduleGroups.DisplayMember = "group_title";
            cboScheduleGroups.ValueMember = "group_type";
            bgl = null;
        }
        private void LoadListingActions()
        {
            Rappel.BusinessLogic.ListingActionsLogic bgl = new BusinessLogic.ListingActionsLogic();
            lstListActions.DataSource = bgl.GetListingActions();
            lstListActions.DisplayMember = "action_name";
            lstListActions.ValueMember = "action_flag";
            bgl = null;
        }
        private void TaskEditMode()
        {
            btnEditTask.Visible = false;
            btnDoneTasks.Visible = true;
            lvTasks.CheckBoxes = true;

        }
        private void TaskDoneMode()
        {
            btnEditTask.Visible = true;
            btnDoneTasks.Visible = false;
            lvTasks.CheckBoxes = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            lstListActions.Tag = "DONT";
            //lstReminders.Tag = "DONT";
            cboScheduleGroups.Tag = "DONT";
            LoadBuiltInGroups();
            LoadListingActions();
            LoadLists();
            
            //cboReminders.SelectedIndex = -1;
            lstListActions.SelectedIndex = -1;
            cboScheduleGroups.Tag = null;
            lstListActions.Tag = null;
            lstLists.Tag = null;
            //mcal.MinDate = DateTime.Today;
            mcal.SetDate(DateTime.Today);
            ListActionSelectionType = "DATE";
            SelectedSchedule = "REM";
            LoadDataList(SelectedSchedule,ListActionSelectionType);
            ChangeTaskColumnTitles();
            TaskDoneMode();
        }
        private void FillTaskGrid(DataTable datatbl)
        {
            long rownum = 0;
            string groupkey = string.Empty;
            string grouptext = string.Empty;
            ListViewGroup lgrp;
            if (datatbl != null)
            {
                foreach (DataRow row in datatbl.Rows)
                {
                    rownum++;

                    if (bool.Parse(row["remind_me"].ToString()) == true)
                    {
                        groupkey = string.Format("{0:yyyyMMdd}", DateTime.Parse(row["remind_ondate"].ToString()));
                        grouptext = string.Format("{0:" + Tools.Settings.LongDateFormat + "}", DateTime.Parse(row["remind_ondate"].ToString()));
                        lgrp = lvTasks.Groups[groupkey];
                        if (lgrp == null)
                        {
                            lgrp = lvTasks.Groups.Add(groupkey,grouptext);
                        }
                    }
                    else
                    {
                        groupkey = row["listed_in"].ToString();
                        grouptext = row["rem_desc"].ToString();
                        lgrp = lvTasks.Groups[groupkey];
                        if (lgrp == null)
                        {
                            lgrp = lvTasks.Groups.Add(groupkey, grouptext);
                        }
                    }
                    
                    DateTime dt = DateTime.Parse(row["remind_ondate"].ToString());
                    
                    ListViewItem item = new ListViewItem(row["task_title"].ToString());
                    item.ImageKey = "tasks";
                    item.Tag = row;
                    item.Group = lgrp;
                    if (bool.Parse(row["is_completed"].ToString()))
                    {
                        item.Font = new Font(lvTasks.Font, FontStyle.Strikeout);
                        item.Checked = true;
                    }
                    item.SubItems.Add(row["notes"].ToString());
                    if (dt < DateTime.Today)
                    {
                        item.ForeColor = Color.Red;
                    }
                    else if (dt.Day == DateTime.Today.Day && dt.Year == DateTime.Today.Year && dt.Month ==DateTime.Today.Month)
                    {
                        item.ForeColor = Color.Green;
                    }
                    lvTasks.Items.Add(item);
                }
            }

        }
        private void FilAppointments(DataTable datatbl)
        {
            long rownum = 0;
            string groupkey = string.Empty;
            string grouptext = string.Empty;
            ListViewGroup lgrp;
            if (datatbl != null)
            {
                foreach (DataRow row in datatbl.Rows)
                {
                    rownum++;


                    groupkey = string.Format("{0:yyyyMMdd}-{1:yyyyMMdd}", DateTime.Parse(row["app_startdate"].ToString()), DateTime.Parse(row["app_enddate"].ToString()));
                    grouptext = string.Format("{0:" + Tools.Settings.LongDateFormat + "} - {1:" + Tools.Settings.LongDateFormat + "}", DateTime.Parse(row["app_startdate"].ToString()), DateTime.Parse(row["app_enddate"].ToString()));
                    lgrp = lvTasks.Groups[groupkey];
                    if (lgrp == null)
                    {
                        lgrp = lvTasks.Groups.Add(groupkey, grouptext);
                    }
                   

                    DateTime dtfrom = DateTime.Parse(row["app_startdate"].ToString());
                    DateTime dttill = DateTime.Parse(row["app_enddate"].ToString());
                    ListViewItem item = new ListViewItem(row["app_title"].ToString());
                    item.ImageKey = "tasks";
                    item.Tag = row;
                    item.Group = lgrp;
                    if (bool.Parse(row["is_done"].ToString()))
                    {
                        item.Font = new Font(lvTasks.Font, FontStyle.Strikeout);
                        item.Checked = true;
                    }
                    item.SubItems.Add(row["with_whom"].ToString());
                    if (DateTime.Today>= dtfrom && DateTime.Today<=dttill )
                    {
                        item.ForeColor = Color.Green;
                    }
                    else if (DateTime.Today > dttill)
                    {
                        item.ForeColor = Color.Red;
                    }
                    lvTasks.Items.Add(item);
                }
            }
        }
        private void LoadDataList(string ScheduleName , string ListAction)
        {
            Rappel.BusinessLogic.ReminderLogic tl;
            Rappel.BusinessLogic.AppointmentLogic al;
            DataTable tbl = new DataTable();
            lvTasks.Items.Clear();
            // reminders
            if (ScheduleName == "REM")
            {
                tl = new BusinessLogic.ReminderLogic();
                if (ListAction == "DATE")
                {
                    DateTime dtparam = mcal.SelectionStart;
                    tbl = tl.GetCategorizedData(ScheduleName, ListAction, dtparam);
                }
                else if (ListAction == "REMINDERGROUP")
                {
                    long lparam = long.Parse(lblSelectedReminder.Tag.ToString());
                    tbl = tl.GetCategorizedData(ScheduleName, ListAction, lparam);
                }
                else
                {
                    tbl = tl.GetCategorizedData(ScheduleName, ListAction, null);
                }
                FillTaskGrid(tbl);
            }
                //appointments
            else if (ScheduleName == "APP")
            {
                al= new BusinessLogic.AppointmentLogic();
                if (ListAction == "DATE")
                {
                    DateTime dtparam = mcal.SelectionStart;
                    tbl = al.GetCategorizedData(ScheduleName, ListAction, dtparam);
                }
                else if (ListAction == "REMINDERGROUP")
                {
                    long lparam = long.Parse(lblSelectedReminder.Tag.ToString());
                    tbl = al.GetCategorizedData(ScheduleName, ListAction, lparam);
                }
                else
                {
                    tbl = al.GetCategorizedData(ScheduleName, ListAction, null);
                }
                FilAppointments(tbl);
            }
            tl = null;
            al = null;
            
        }

        
        private void mcal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
           
        }
        private void ExecuteAddButtonAction()
        {
            switch (SelectedSchedule)
            {
                case("REM"):
                    frmReminder tsk = new frmReminder();
                    Reminders tk;
                    tsk.TaskInfo.TaskDate = DateTime.Now;
                    tsk.TaskInfo.TaskType = SelectedSchedule;
                    switch (ListActionSelectionType )
                    {
                        case ("DATE"):
                            tsk.TaskInfo.RemindMe = true;
                            tsk.TaskInfo.RemindOn = mcal.SelectionStart;
                            tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                            break;
                        case ("REMINDERGROUP"):
                            tsk.TaskInfo.ReminderID = long.Parse(lblSelectedReminder.Tag.ToString());
                            tsk.TaskInfo.RemindMe = false;
                            tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                            break;
                        case "TODAY":
                            tsk.TaskInfo.RemindMe = true;
                            tsk.TaskInfo.RemindOn = DateTime.Now;
                            tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                            break;
                        case "TOMORROW":
                            tsk.TaskInfo.RemindMe = true;
                            tsk.TaskInfo.RemindOn = DateTime.Now.AddDays(1);
                            tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                            break;
                        case "NEXTWEEK":
                            tsk.TaskInfo.RemindMe  = true;
                            tsk.TaskInfo.RemindOn = DateTime.Now.AddDays(7);
                            tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                            break;

                    }
                    tsk.ShowDialog();
                    if (tsk.CancelPressed == false)
                    {
                        tk = tsk.TaskInfo;
                        BusinessLogic.ReminderLogic tlog = new BusinessLogic.ReminderLogic();
                        if (tlog.SaveReminders(tk))
                        {

                            MessageBox.Show("New Tasks saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataList(SelectedSchedule, ListActionSelectionType);
                        }
                        else
                        {
                            MessageBox.Show("Some error occurred", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        tlog = null;
                        tk = null;
                        tsk = null;
                    }
                    break;
                case("APP"):
                    frmAppointments fap = new frmAppointments();
                    Appointment app;
                    fap.AppInfo.StartDay=DateTime.Now;
                    fap.AppInfo.EndDay = DateTime.Now;
                    fap.AppInfo.RemindBeforeType = Enums.DateParts.None;
                    switch (ListActionSelectionType )
                    {
                        case ("DATE" ):
                            fap.AppInfo.StartDay = mcal.SelectionStart;
                            fap.AppInfo.EndDay= mcal.SelectionStart;
                            
                            break;
                        case ("REMINDERGROUP"):
                            fap.AppInfo.StartDay = mcal.SelectionStart;
                            fap.AppInfo.EndDay= mcal.SelectionStart;
                            fap.AppInfo.RemindBeforeType = Enums.DateParts.None;
                            break;
                        case "TODAY":
                            fap.AppInfo.StartDay = DateTime.Now;
                            fap.AppInfo.EndDay= DateTime.Now;
                            fap.AppInfo.RemindBeforeType = Enums.DateParts.None;
                            break;
                        case "TOMORROW":
                            fap.AppInfo.StartDay = DateTime.Now.AddDays(1);
                            fap.AppInfo.EndDay = DateTime.Now.AddDays(1);
                            fap.AppInfo.RemindBeforeType = Enums.DateParts.None;
                            break;
                        case "NEXTWEEK":
                            fap.AppInfo.StartDay = DateTime.Now.AddDays(7);
                            fap.AppInfo.EndDay = DateTime.Now.AddDays(7);
                            fap.AppInfo.RemindBeforeType = Enums.DateParts.None;
                            break;
                    }
                    fap.ShowDialog();
                    if (fap.CancelPressed == false)
                    {
                        app = fap.AppInfo;
                        BusinessLogic.AppointmentLogic tlog = new BusinessLogic.AppointmentLogic();
                        if (tlog.SaveNewAppointments(app))
                        {

                            MessageBox.Show("New Appointment saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataList(SelectedSchedule, ListActionSelectionType);
                        }
                        else
                        {
                            MessageBox.Show("Some error occurred", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        tlog = null;
                        app = null;
                        fap= null;
                    }

                    break;
            }
        }
        private void lstReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLists.Tag == null)
            {
                if (lstLists.SelectedIndex != -1 && lstLists.SelectedValue.GetType()!=typeof(System.Data.DataRowView))
                {
                    ListActionSelectionType = "REMINDERGROUP";
                    lblSelectedReminder.Text = lstLists.Text;
                    lblSelectedReminder.Tag = lstLists.SelectedValue;
                    LoadDataList(SelectedSchedule,ListActionSelectionType);
                    //LoadTasksFor(long.Parse(lstLists.SelectedValue.ToString()));
                }
            }
        }

        private void lstGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListActions.SelectedValue != null)
            {
                if (lstListActions.Tag == null)
                {
                    lblSelectedReminder.Text = lstListActions.Text;
                    lblSelectedReminder.Tag = lstListActions.Tag;
                    ListActionSelectionType = lstListActions.SelectedValue.ToString();
                    LoadDataList(SelectedSchedule,ListActionSelectionType);

                }
            }
        }

        private void mcal_DateSelected(object sender, DateRangeEventArgs e)
        {
            lblSelectedReminder.Text = mcal.SelectionStart.ToString(Tools.Settings.LongDateFormat) ;
            
            ListActionSelectionType = "DATE";
            LoadDataList(SelectedSchedule,ListActionSelectionType);

        }

        private void lstGroups_Leave(object sender, EventArgs e)
        {
            lstListActions.SelectedIndex = -1;
        }

        private void lstLists_Leave(object sender, EventArgs e)
        {
            lstLists.SelectedIndex = -1;
        }

        private void btnAddNewReminder_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.ShowDialog(this);
            if (frm.CancelPressed == false)
            {
                Lists addedreminder = frm.ReminderInfo;
                BusinessLogic.ListsLogic ract = new BusinessLogic.ListsLogic();
                if (ract.SaveLists(addedreminder.ReminderDescription))
                {

                    MessageBox.Show("New reminder successfully added to the list.", Application.ProductName, MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadLists();
                }
                else 
                {
                    MessageBox.Show("Some error occurred");
                }
            }
            
            frm = null;
        }

        private void lstLists_DoubleClick(object sender, EventArgs e)
        {
            if (lstLists.SelectedItem != null)
            {
                Lists rem = new Lists();
                rem.ReminderDescription = lstLists.Text;
                rem.ReminderID =long.Parse(lstLists.SelectedValue.ToString());
                frmList frm = new frmList();
                frm.ReminderInfo = rem;
                rem = null;
                frm.ShowDialog();
                if (frm.CancelPressed == false)
                {
                    rem = frm.ReminderInfo;
                    BusinessLogic.ListsLogic ract = new BusinessLogic.ListsLogic();
                    if (ract.SaveLists(rem.ReminderID, lstLists.SelectedIndex+1,rem.ReminderDescription))
                    {

                        MessageBox.Show("Reminder saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadLists();
                    }
                    else
                    {
                        MessageBox.Show("Some error occurred");
                    }
                    ract = null;
                }
            }
        }
        private void LoadDefaultValues(string scheduletype)
        {
            switch (scheduletype)
            {
                case ("REM"):

                    break;
            }
        }


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            ExecuteAddButtonAction();
            
        }
        /*
         * btn add code
         return;
            frmTask tsk = new frmTask();
            Task tk;
            tsk.TaskInfo.TaskDate = DateTime.Now;
            tsk.TaskInfo.TaskType = SelectedSchedule;
            switch(ListActionSelectionType)
            {
                case ("DATE"):
                    tsk.TaskInfo.RemindMe  = true;
                    tsk.TaskInfo.RemindOn = mcal.SelectionStart;
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;
                case ("REMINDERGROUP"):
                    tsk.TaskInfo.ReminderID = long.Parse(lblSelectedReminder.Tag.ToString());
                    tsk.TaskInfo.RemindMe = false;
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;
                case ("ALL"):
                    tsk.TaskInfo.RemindMe  = true;
                    tsk.TaskInfo.RemindOn = DateTime.Now;
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;
                case ("COMPLETED"):
                    break;
                case ("TODAY"):
                    tsk.TaskInfo.RemindMe  = true;
                    tsk.TaskInfo.RemindOn = DateTime.Now;
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;
                case ("TOMORROW"):
                    tsk.TaskInfo.RemindMe  = true;
                    tsk.TaskInfo.RemindOn = DateTime.Now.AddDays(1);
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;
                case ("NEXTWEEK"):
                    tsk.TaskInfo.RemindMe  = true;
                    tsk.TaskInfo.RemindOn = DateTime.Now.AddDays(7);
                    tsk.TaskInfo.RepeatType = Enums.AlarmRepeatType.None;
                    break;

                default:

                    break;
            }
            tsk.ShowDialog();
            if (tsk.CancelPressed == false)
            {
                tk = tsk.TaskInfo;
                BusinessLogic.TaskLogic tlog = new BusinessLogic.TaskLogic();
                if (tlog.SaveTasks(tk))
                {

                    MessageBox.Show("New Tasks saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (ListActionSelectionType == "DATE")
                        LoadTasksFor(mcal.SelectionStart);
                    else if (ListActionSelectionType == "REMINDERGROUP")
                        LoadTasksFor(long.Parse(lblSelectedReminder.Tag.ToString()));
                    else
                        LoadTasksFor(SelectedSchedule, ListActionSelectionType);
                }
                else
                {
                    MessageBox.Show("Some error occurred", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                tlog = null;
            }
         
         */
        private void lvTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void tstripDeleteTask_Click(object sender, EventArgs e)
        {
            long taskid=0;
            if (lvTasks.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this task?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow dr = (DataRow)lvTasks.SelectedItems[0].Tag;
                    taskid = long.Parse(dr["task_id"].ToString());
                    BusinessLogic.ReminderLogic tlog = new BusinessLogic.ReminderLogic();
                    if (tlog.DeleteReminders(taskid))
                    {
                        MessageBox.Show("Task deleted successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LoadDataList(SelectedSchedule,ListActionSelectionType);
                    }
                    tlog = null;
                    dr = null;
                }
            }
        }
        private void lvTasks_DoubleClick(object sender, EventArgs e)
        {
            
            if (lvTasks.SelectedItems.Count > 0 )
            {
                
                DataRow dr = (DataRow)lvTasks.SelectedItems[0].Tag;
                if (dr != null)
                {
                    switch(SelectedSchedule)
                    {
                        case ("REM"):
                            Reminders tk = new Reminders();
                            tk.TaskID = long.Parse(dr["task_id"].ToString());
                            tk.TaskType = SelectedSchedule;
                            tk.TaskTitle = dr["task_title"].ToString();
                            if (dr["task_date"].ToString()!="" )
                                tk.TaskDate = DateTime.Parse(dr["task_date"].ToString());

                            if (bool.Parse(dr["remind_me"].ToString()))
                            {
                                tk.RemindMe = true;
                                tk.RemindOn = DateTime.Parse(dr["remind_ondate"].ToString());
                                tk.RepeatType = (Enums.AlarmRepeatType)Enum.Parse(typeof(Enums.AlarmRepeatType), (dr["repeat_type"].ToString()));
                            }
                            else
                            {
                                tk.RemindMe = false;
                            }

                            tk.ReminderID = long.Parse(dr["listed_in"].ToString());
                            tk.TaskPriority = (Enums.Priority)Enum.Parse(typeof(Enums.Priority), (dr["priority"].ToString()));
                            tk.Notes = dr["notes"].ToString();
                            frmReminder task = new frmReminder();
                            task.TaskInfo = tk;
                            task.TopMost = true;
                            task.ShowDialog();
                            if (task.CancelPressed == false)
                            {
                                tk = task.TaskInfo;
                                BusinessLogic.ReminderLogic tlog = new BusinessLogic.ReminderLogic();
                                if (tlog.SaveReminders(tk.TaskID,tk))
                                {

                                    MessageBox.Show("Tasks saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoadDataList(SelectedSchedule,ListActionSelectionType);
                                }
                                else
                                {
                                    MessageBox.Show("Some error occurred", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                tlog = null;
                                tk = null;
                            }
                            break;
                        case ("APP"):
                            Appointment ap = new Appointment();
                            ap.AppointmentID = long.Parse(dr["app_id"].ToString());
                            ap.WithWhom = dr["with_whom"].ToString();
                            ap.Location= dr["location"].ToString();
                            ap.AppointmentTitle = dr["app_title"].ToString();
                            ap.StartDay = DateTime.Parse(dr["app_startdate"].ToString());
                            ap.StartTime = dr["app_starttime"].ToString();
                            ap.EndDay = DateTime.Parse(dr["app_enddate"].ToString());
                            ap.EndTime = dr["app_endtime"].ToString();
                            if (dr["listed_in"].ToString().Trim() != "")
                            {

                                ap.ListedIn = long.Parse(dr["listed_in"].ToString());
                            }
                            else
                            {
                                ap.ListedIn = 0;
                            }
                            ap.RemindBefore = int.Parse(dr["remind_before"].ToString());
                            ap.RemindBeforeType = (Enums.DateParts)Enum.Parse( typeof(Enums.DateParts),dr["remind_before_type"].ToString());
                            ap.MarkAsDone = bool.Parse(dr["is_done"].ToString());
                            ap.Notes = dr["notes"].ToString();

                            frmAppointments appform = new frmAppointments();
                            appform.AppInfo = ap;
                            appform.TopMost = true;
                            appform.ShowDialog();
                            if (appform.CancelPressed == false)
                            {
                                ap = appform.AppInfo;
                                BusinessLogic.AppointmentLogic tlog = new BusinessLogic.AppointmentLogic();
                                if (tlog.SaveAppointments( ap))
                                {

                                    MessageBox.Show("Appointments saved successfully.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        LoadDataList(SelectedSchedule,ListActionSelectionType);
                                }
                                else
                                {
                                    MessageBox.Show("Some error occurred", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                }
                                ap = null;
                                tlog = null;
                            }
                            break;
                    }
               }
            }
        }

        private void mcal_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnEditReminder_Click(object sender, EventArgs e)
        {

            
        }

        private void tmrProcessor_Tick(object sender, EventArgs e)
        {

        }

        private void btnDoneTasks_Click(object sender, EventArgs e)
        {
            BusinessLogic.ReminderLogic rl = new BusinessLogic.ReminderLogic();
            BusinessLogic.AppointmentLogic al = new BusinessLogic.AppointmentLogic();
            foreach (ListViewItem litm in lvTasks.Items)
            {
                if (litm.Checked == true)
                {
                    DataRow dr = (DataRow)litm.Tag;
                    if (SelectedSchedule == "REM")
                    {
                        rl.MarkAsComplete(long.Parse(dr["task_id"].ToString()), DateTime.Today);
                    }
                    else if (SelectedSchedule == "APP")
                    {
                        al.MarkAsDone(long.Parse(dr["app_id"].ToString()));
                    }
                    dr = null;
                }else{
                    DataRow dr = (DataRow)litm.Tag;
                    if (SelectedSchedule == "REM")
                    {
                        rl.MarkAsComplete(long.Parse(dr["task_id"].ToString()), DateTime.Today);
                    }
                    else if (SelectedSchedule == "APP")
                    {
                        al.MarkAsUndone(long.Parse(dr["app_id"].ToString()));
                    }
                    dr = null;
                }
            }
            al=null;
            rl = null;


            LoadDataList(SelectedSchedule, ListActionSelectionType);
            TaskDoneMode();
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            TaskEditMode();

                LoadDataList(SelectedSchedule, ListActionSelectionType);

        }

        private void lvTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void lvTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked  == true)
            { 
                e.Item.Font = new Font(lvTasks.Font, FontStyle.Strikeout);

            }
            else if (e.Item.Checked  == false)
            {
                e.Item.Font = new Font(lvTasks.Font, FontStyle.Regular);
            }
        }
        private void ChangeTaskColumnTitles()
        {
            if (SelectedSchedule == "REM")
            {
                colTaskName.Text = "Reminder Title";
                colNotes.Text = "Notes";
            }
            else if (SelectedSchedule == "APP")
            {
                colTaskName.Text = "Appointments";
                colNotes.Text = "Description";
            }
            else
            {
                
                colNotes.Text = "Title";
                colTaskName.Text = "Description";
            }
        }
        private void cboScheduleGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cboScheduleGroups.Tag==null )
            {
                SelectedSchedule = cboScheduleGroups.SelectedValue.ToString();
                LoadDataList(SelectedSchedule, ListActionSelectionType);
                ChangeTaskColumnTitles();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
        }

        

    }
}
