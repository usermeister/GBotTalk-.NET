using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GTalk_Reminder_Bot
{
    public partial class Form1 : Form
    {
        public static string bodyText { get; set; }

        ReminderDBClassDataContext dataContext = new ReminderDBClassDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            // Username field check
            if (txtGTalkUsername.Text.Length <= 0)
            {
                lblUsernameStatus.ForeColor = Color.Red;
                lblUsernameStatus.Text = "Enter your email address.";
                lblPasswordStatus.Text = "";
                return;
            }
            // Password field check
            if (txtGTalkPassword.Text.Length <= 0)
            {
                lblUsernameStatus.ForeColor = Color.DarkGray;
                lblUsernameStatus.Text = "ex: example@gmail.com";
                lblPasswordStatus.ForeColor = Color.Red;
                lblPasswordStatus.Text = "Enter your password.";
                return;
            }

            jabberClient.User = txtGTalkUsername.Text;
            jabberClient.Password = txtGTalkPassword.Text;
            jabberClient.Connect();

            lblConnectionStatus.Text = "Status: Signing in...";
            btnSignIn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUsernameStatus.ForeColor = Color.DarkGray;
            lblUsernameStatus.Text = "ex: example@gmail.com";
            lblPasswordStatus.ForeColor = Color.Red;
            lblPasswordStatus.Text = "";
            lblConnectionStatus.Text = "Status: Signed out.";

        }

        private void GetTasksAndSendMessages()
        {
            var tasks = from t in dataContext.Tasks select t;
            foreach (var task in tasks)
            {
                DateTime tmpTime = task.startTime;
                DateTime nowTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 
                                                DateTime.Now.Hour, DateTime.Now.Minute, 0);
                
                TimeSpan ts = TimeSpan.Parse(task.interval);
                while (tmpTime < task.endTime)
                {
                    tmpTime = tmpTime.Add(ts);
                    if (tmpTime == nowTime)
                    {
                        jabber.protocol.client.Message msg = new jabber.protocol.client.Message(jabberClient.Document);
                        msg.Type = jabber.protocol.client.MessageType.chat;
                        msg.Body = task.message;
                        string[] recipients = task.recipients.Split(' '); // recipient mails are stored in a string separated with space.

                        if (recipients.Length > 0)
                        {
                            foreach (var r in recipients)
                            {
                                msg.To = r;
                                jabberClient.Write(msg);
                                txtActivity.Text += "Msg sent. " +
                                                    " DateTime.now: " + DateTime.Now.ToString() +
                                                    " tmpTime: " + tmpTime.ToString() +
                                                    " taskID: " + task.taskID.ToString() +
                                                    Environment.NewLine;
                            }
                        }

                        //if (presenceManager.IsAvailable(userJID))                        
                    }
                }
            }
        }

        private void jabberClient_OnConnect(object sender, jabber.connection.StanzaStream stream)
        {
            lblConnectionStatus.Text = "Status: Connected.";

        }

        private void jabberClient_OnAuthError(object sender, System.Xml.XmlElement rp)
        {
            lblConnectionStatus.ForeColor = Color.Red;
            lblConnectionStatus.Text = "Status: Incorrect login data.";
            btnSignIn.Enabled = true;
        }

        private void jabberClient_OnAuthenticate(object sender)
        {
            lblConnectionStatus.ForeColor = Color.DarkGreen;
            lblConnectionStatus.Text = "Status: Signed in.";
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            dataContext = new ReminderDBClassDataContext();
            GetTasksAndSendMessages();
        }


    }
}
