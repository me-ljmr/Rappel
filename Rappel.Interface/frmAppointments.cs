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
    public partial class frmAppointments : Form
    {
        public bool CancelPressed=true;
        public Appointment AppInfo { get { return _appinfo; } set { _appinfo = value; } }
        private Appointment _appinfo = new Appointment();
        public frmAppointments()
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
            Rappel.BusinessLogic.AppointmentLogic  llg = new BusinessLogic.AppointmentLogic();
            cboStartTime.DataSource = llg.Times();
            
            cboEndTime.DataSource = llg.Times();
            llg = null;
        }
        private void LoadCombos()
        {
            //cboRemindBeforeType.DataSource = Enum.GetValues(typeof(Enums.DateParts));
            cboRemindBeforeType.DataSource = Enums.EnumHelper.ToList(typeof(Enums.DateParts));
            cboRemindBeforeType.DisplayMember = "Value";
            cboRemindBeforeType.ValueMember = "Key";
        }
        private void LoadAppointmentInfo()
        {

            txtAppointmentTitle.Text = _appinfo.AppointmentTitle;
            txtLocation.Text = _appinfo.Location;
            txtWithWhom.Text = _appinfo.WithWhom;
            dtStart.Value = _appinfo.StartDay;
            dtEnd.Value = _appinfo.EndDay;
            if (_appinfo.StartTime != null)
            {
                cboStartTime.Text = _appinfo.StartTime;
                cboEndTime.Text = _appinfo.EndTime;
            }
            txtNotes.Text = _appinfo.Notes;
            txtRemindBeforeNum.Text = _appinfo.RemindBefore.ToString();
            cboRemindBeforeType.SelectedValue = _appinfo.RemindBeforeType;
            chkAddToList.Checked = (_appinfo.ListedIn==0?false:true);


        }
        private void frmAppointments_Load(object sender, EventArgs e)
        {
            LoadLists();
            LoadCombos();
            cboStartTime.SelectedIndex =1;
            if (_appinfo != null)
            {
                LoadAppointmentInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelPressed = true;
            _appinfo = null;
            this.Close();
        }
        private void ReloadAppVariable()
        {

            _appinfo.AppointmentTitle = txtAppointmentTitle.Text;
            _appinfo.Location = txtLocation.Text;
            _appinfo.RemindBefore =int.Parse( txtRemindBeforeNum.Text);
            _appinfo.WithWhom = txtWithWhom.Text;
            _appinfo.StartDay = dtStart.Value;
            _appinfo.EndDay = dtEnd.Value;
            _appinfo.StartTime = cboStartTime.Text;
            _appinfo.EndTime = cboEndTime.Text;
            _appinfo.ListedIn = chkAddToList.Checked == true ? long.Parse(cboList.SelectedValue.ToString()) : 0;
            _appinfo.Notes = txtNotes.Text;
            _appinfo.RemindBeforeType = (Enums.DateParts)cboRemindBeforeType.SelectedValue;

        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            ReloadAppVariable();
            CancelPressed = false;
            this.Close();
        }

        private void chkAddToList_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            cboList.Visible = chk.Checked;
        }

        private void cboStartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStartTime.Text != "")
            {
                Rappel.BusinessLogic.AppointmentLogic llg = new BusinessLogic.AppointmentLogic();
                
                cboEndTime.DataSource = llg.Times(cboStartTime.Text);
                llg = null;
            }
        }

        private void chkRemindMe_CheckedChanged(object sender, EventArgs e)
        {
            txtRemindBeforeNum.Enabled=(chkRemindMe.Checked);
            cboRemindBeforeType.Enabled=(chkRemindMe.Checked);
        }
    }
}
