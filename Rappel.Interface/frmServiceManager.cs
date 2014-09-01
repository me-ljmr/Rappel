using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rappel.BusinessLogic;
using Rappel.NotificationWindow;
using System.Threading;
using System.Media;
namespace Rappel.Interface
{
    public partial class frmServiceManager : Form
    {


        ReminderLogic rlg;     
        AppointmentLogic alg;
        DateTime servertime;
        DateTime timeofday, alerttime;
        DateTime remservertime;
        DateTime remtimeofday,remalerttime;
        DateTime appservertime;
        DateTime apptimeofday, appalerttime;


        DataTable getreminders=null;
        DataTable getappointments=null;
        byte _minindex=100;
        public frmServiceManager()
        {
            InitializeComponent();
        }


        public static System.Diagnostics.Process RunningInstance()
        {
            System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
            System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);

            //Loop through the running processes in with the same name 
            foreach (System.Diagnostics.Process process in processes)
            {
                //Ignore the current process 
                if (process.Id != current.Id)
                {
                    //Make sure that the process is running from the exe file. 
                    if (System.Reflection.Assembly.GetExecutingAssembly().Location.
                         Replace("/", "\\") == current.MainModule.FileName)
                    {
                        //Return the other process instance.  
                        return process;

                    }
                }
            }
            //No other instance was found, return null.  
            return null;
        }
        private void btnOpenRappel_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmRappel frm = frmRappel.Instance();
            frm.TopMost = true;
            frm.Show();
        }
        private void StartedButtonState()
        {
            btnStart.BackColor = Color.Beige;
            btnStop.BackColor = Color.IndianRed;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            menuStartService.Enabled = false;
            menuStopService.Enabled = true;
            tstripStatus.Text = "Ready";
        }
        private void StartService()
        {
            tmrProcessor.Enabled = true;
            tmrProcessor.Start();
            StartedButtonState();
            
        }
        private void StopService()
        {
            getappointments = null;
            getreminders = null;
            tmrProcessor.Enabled = false;
            tmrProcessor.Stop();
            StoppedButtonState();

        }
        private void StoppedButtonState()
        {
            btnStart.BackColor = Color.DarkKhaki;
            btnStop.BackColor = Color.MistyRose;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            menuStartService.Enabled = true;
            menuStopService.Enabled = false;
            tstripStatus.Text = "Service Stopped";
        }

        private void frmServiceManager_Load(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopService();
        }
        private void pop_Click(object sender, EventArgs e)
        {
            
        }
        private void ShowNotification(string notetitle,string notedesc)
        {
            notifyme.BalloonTipTitle = notetitle + " ";
            notifyme.BalloonTipText = notedesc + " ";
            notifyme.BalloonTipIcon = ToolTipIcon.Info;
            notifyme.ShowBalloonTip(1000);
            PopupNotifier pop = new PopupNotifier();
            pop.TitleText = notetitle;
            pop.Click+=new EventHandler(pop_Click);
            pop.ContentText = notedesc;
            pop.ContentFont= this.Font;
            pop.TitleFont =  this.Font;
            pop.BodyColor = this.BackColor;
            pop.TitleColor = this.ForeColor;
            pop.Popup();

            using (var soundPlayer = new SoundPlayer(Tools.Settings.AlertSoundFile))
            {
                soundPlayer.Play(); // can also use soundPlayer.PlaySync()
            }
            pop = null;

        }
        private TimeSpan getintervaltimespan(int intervalval, Enums.DateParts dpinterval)
        {
            TimeSpan result;
            switch (dpinterval)
            {
                case Enums.DateParts.None: result = new TimeSpan(0,0,0); break;
                case Enums.DateParts.Seconds: result = new TimeSpan(0,0,intervalval); break;
                case Enums.DateParts.Minutes: result = new TimeSpan(0, intervalval, 0); break;
                case Enums.DateParts.Hours: result = new TimeSpan(intervalval, 0, 0); break;
                case Enums.DateParts.Days: result = new TimeSpan(intervalval,0, 0, 0);  break;
                case Enums.DateParts.Weeks: result = new TimeSpan(7 * intervalval,0, 0, 0); break;
                case Enums.DateParts.Months: result = new TimeSpan(30*intervalval, 0, 0, 0); break;
                case Enums.DateParts.Years: result = new TimeSpan(365*intervalval,0, 0, 0); break;
                default: result = new TimeSpan(0,0,0); break;
            }
            return result;
        }
        private string getintervalname(Enums.DateParts dpinterval)
        {
            string result = string.Empty;
            switch(dpinterval)
            {
                case Enums.DateParts.None: result ="";break;
                case Enums.DateParts.Seconds: result = "ss"; break;
                case Enums.DateParts.Minutes: result = "mm"; break;
                case Enums.DateParts.Hours: result = "hh"; break;
                case Enums.DateParts.Days: result = "dd"; break;
                case Enums.DateParts.Weeks: result = "ww"; break;
                case Enums.DateParts.Months: result = "MM"; break;
                case Enums.DateParts.Years: result = "yy"; break;
                default: result = ""; break; 
            }
            return result;
        }
        private void ReminderCheck()
        {
            bool generatetoday = false;
            bool generatenow = false;
            bool oneweekgen = false;
            bool twoweekgen = false;
            bool onemonthgen = false;
            bool oneyeargen = false;
            rlg = new ReminderLogic();
            remservertime = DateTime.Now;
            if (getreminders == null)
            {
                getreminders = rlg.GetRemindableTasks(remservertime);
                _minindex = byte.Parse(remservertime.Minute.ToString());
            }
            else
            {

                if (remservertime.Minute % Tools.Settings.ReloadInterval == 0 && _minindex != remservertime.Minute)
                {
                    _minindex = byte.Parse(remservertime.Minute.ToString());
                    getreminders = rlg.GetRemindableTasks(remservertime);
                }
            }
            foreach (DataRow rems in getreminders.Rows)
            {

                remtimeofday = DateTime.Parse(rems["remind_ondate"].ToString());
                generatetoday = (remtimeofday.Day == remservertime.Day && remtimeofday.Month == remservertime.Month && remtimeofday.Year == remservertime.Year);
                generatenow = (remtimeofday.Hour == remservertime.Hour && remtimeofday.Minute == remservertime.Minute && remtimeofday.Second == remservertime.Second);
                oneweekgen = (remservertime.Subtract(remtimeofday).Days % 7 == 0);
                twoweekgen = (remservertime.Subtract(remtimeofday).Days % 14 == 0);
                onemonthgen = (remservertime.Day == remtimeofday.Day);
                oneyeargen = (remservertime.Day == remtimeofday.Day && remservertime.Month == remtimeofday.Month);
                if (generatetoday && generatenow)
                {
                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                }
                else
                {
                    switch (int.Parse(rems["repeat_type"].ToString()))
                    {
                        case 0:
                            // none 

                            break;
                        case 1:
                            if (generatenow)
                            {
                                ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                            }
                            // every day
                            break;
                        case 2:
                            // every week
                            if (oneweekgen && generatenow)
                            {
                                ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                            }
                            break;
                        case 3:
                            // every 2 weeks
                            if (twoweekgen && generatenow)
                            {
                                ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                            }
                            break;
                        case 4:
                            // every month
                            if (onemonthgen && generatenow)
                            {
                                ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                            }
                            break;
                        case 5:
                            // every year
                            if (oneyeargen && generatenow)
                            {
                                ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
                            }
                            break;


                    }
                }
                Thread.Sleep(1);
            }
            rlg = null;
        }
        private void AppointmentCheck()
        {
            bool generatetoday = false;
            bool generatenow = false;
            alg = new AppointmentLogic();
            servertime = DateTime.Now;
            if (getappointments == null)
            {
                
                getappointments = alg.GetRemindableAppointments(servertime);
                _minindex = byte.Parse(servertime.Minute.ToString());
            }
            else
            {

                if (servertime.Minute % Tools.Settings.ReloadInterval == 0 && _minindex != servertime.Minute)
                {
                    _minindex = byte.Parse(servertime.Minute.ToString());
                    getappointments = alg.GetRemindableAppointments(servertime);
                }
            }
            foreach (DataRow aps in getappointments.Rows)
            {
                Enums.DateParts rembeforetype = (Enums.DateParts)aps["remind_before_type"];
                timeofday = DateTime.Parse(string.Format("{0:" + Tools.Settings.ShortDateFormat + "} {1:" + Tools.Settings.TimeFormat + "}", DateTime.Parse(aps["app_startdate"].ToString()), DateTime.Parse(aps["app_starttime"].ToString())));
                alerttime = timeofday.Subtract(getintervaltimespan(int.Parse(aps["remind_before"].ToString()), rembeforetype));
                generatetoday = (alerttime.Day == servertime.Day && alerttime.Month == servertime.Month && alerttime.Year == servertime.Year);
                generatenow = (alerttime.Hour == servertime.Hour && alerttime.Minute == servertime.Minute && alerttime.Second == servertime.Second);


                string interval = getintervalname(rembeforetype);
                if (generatenow && generatetoday)
                {
                    ShowNotification("Appointment Notification", string.Format("{0} " + Environment.NewLine + "With {1}" + Environment.NewLine + "Time: {2} till {3}", aps["app_title"].ToString(), aps["with_whom"].ToString(), aps["app_starttime"].ToString(), aps["app_endtime"].ToString()));// aps["app_title"].ToString());
                }
                Thread.Sleep(1);

            }
            alg = null;
        }

        private void tmrProcessor_Tick(object sender, EventArgs e)
        {
            /*
            Thread rem = new Thread(new ThreadStart(ReminderCheck));
            Thread app = new Thread(new ThreadStart(AppointmentCheck));
            rem.Start();
            app.Start();
            try
            {
                rem.Join();
                app.Join();
            }
            catch
            {

            }
             * */
            ReminderCheck();
            AppointmentCheck();
            //// below code has been commented by gugu 
            // rlg = new ReminderLogic();
            // alg = new AppointmentLogic();
            //servertime = DateTime.Now;
            //if (getreminders == null)
            //{
            //    getreminders = rlg.GetRemindableTasks(servertime);
            //    getappointments = alg.GetRemindableAppointments(servertime);
            //    _minindex = byte.Parse(servertime.Minute.ToString());
            //}
            //else 
            //{
                
            //    if (servertime.Minute % Tools.Settings.ReloadInterval == 0 && _minindex != servertime.Minute)
            //    {
            //        _minindex = byte.Parse(servertime.Minute.ToString());
            //        getreminders = rlg.GetRemindableTasks(servertime);
            //        getappointments = alg.GetRemindableAppointments(servertime);
            //    }
            //}
            //bool generatetoday = false;
            //bool generatenow = false;
            //bool oneweekgen = false;
            //bool twoweekgen = false;
            //bool onemonthgen = false;
            //bool oneyeargen = false;
            //foreach (DataRow aps in getappointments.Rows)
            //{
            //    Enums.DateParts rembeforetype = (Enums.DateParts)aps["remind_before_type"];
            //    timeofday = DateTime.Parse(string.Format("{0:" + Tools.Settings.ShortDateFormat + "} {1:" + Tools.Settings.TimeFormat + "}", DateTime.Parse(aps["app_startdate"].ToString()), DateTime.Parse(aps["app_starttime"].ToString())));
            //    alerttime = timeofday.Subtract(getintervaltimespan(int.Parse(aps["remind_before"].ToString()), rembeforetype));
            //    generatetoday = (alerttime.Day == servertime.Day && alerttime.Month == servertime.Month && alerttime.Year == servertime.Year);
            //    generatenow = (alerttime.Hour == servertime.Hour && alerttime.Minute == servertime.Minute && alerttime.Second == servertime.Second);
                
                
            //    string interval = getintervalname(rembeforetype);
            //    if (generatenow && generatetoday)
            //    {
            //        ShowNotification("Appointment Notification",string.Format("{0} " + Environment.NewLine + "With {1}" + Environment.NewLine + "Time: {2} till {3}" ,aps["app_title"].ToString(),aps["with_whom"].ToString(),aps["app_starttime"].ToString(),aps["app_endtime"].ToString()));// aps["app_title"].ToString());
            //    }

            //}
            //foreach (DataRow rems in getreminders.Rows)
            //{
            //    timeofday = DateTime.Parse(rems["remind_ondate"].ToString());
            //    generatetoday = (timeofday.Day == servertime.Day && timeofday.Month == servertime.Month && timeofday.Year== servertime.Year);
            //    generatenow = (timeofday.Hour == servertime.Hour && timeofday.Minute == servertime.Minute && timeofday.Second == servertime.Second);
            //    oneweekgen = (servertime.Subtract(timeofday).Days % 7==0);
            //    twoweekgen = (servertime.Subtract(timeofday).Days % 14 == 0);
            //    onemonthgen = (servertime.Day == timeofday.Day);
            //    oneyeargen = (servertime.Day == timeofday.Day && servertime.Month == timeofday.Month);
            //    if (generatetoday && generatenow)
            //    {
            //        ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //    }else{
            //        switch (int.Parse(rems["repeat_type"].ToString()))
            //        {
            //            case 0:
            //                // none 

            //                break;
            //            case 1:
            //                if (generatenow)
            //                {
            //                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //                }
            //                // every day
            //                break;
            //            case 2:
            //                // every week
            //                if (oneweekgen && generatenow)
            //                {
            //                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //                }
            //                break;
            //            case 3:
            //                // every 2 weeks
            //                if (twoweekgen  && generatenow)
            //                {
            //                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //                }
            //                break;
            //            case 4:
            //                // every month
            //                if (onemonthgen && generatenow)
            //                {
            //                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //                }
            //                break;
            //            case 5:
            //                // every year
            //                if (oneyeargen && generatenow)
            //                {
            //                    ShowNotification(rems["task_title"].ToString(), rems["notes"].ToString());
            //                }
            //                break;
                        

            //        }
            //    }
            //}
            ////getreminders = null;
            //rlg = null;
            //alg = null;
        }

        private void notifyme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.TopMost = true;
        }


        private void menuStartService_Click(object sender, EventArgs e)
        {
            StartService();
        }

        private void menuStopService_Click(object sender, EventArgs e)
        {
            StopService();
        }

        private void tstripOpenRappel_Click(object sender, EventArgs e)
        {

            frmRappel frm = frmRappel.Instance();

            frm.Show();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmServiceManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tmrProcessor.Enabled == true)
            {
                this.Hide();
                e.Cancel = true;
                notifyme.ShowBalloonTip(1000,"Still Working","You can find the application here.",ToolTipIcon.Info);
            }
        }

        private void menuOpenServiceManager_Click(object sender, EventArgs e)
        {
            this.Show();
        }
    }

}
