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
    public partial class frmList : Form
    {
        public Lists ReminderInfo { get { return _rem; } set { _rem = value; } }
        private Lists _rem=new Lists();
        public bool CancelPressed = true;

        public frmList()
        {
            InitializeComponent();
        }

        private void frmNewReminder_Load(object sender, EventArgs e)
        {
            if (_rem != null)
            {
                txtReminderTitle.Text = _rem.ReminderDescription;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _rem = null;
            CancelPressed = true;
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            _rem.ReminderDescription = txtReminderTitle.Text;
            
            _rem.ReminderType = "";
            CancelPressed = false;
            this.Close();
        }
    }
}
