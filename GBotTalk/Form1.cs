using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GBotTalk
{
    public partial class Form1 : Form
    {

        public static string userJID { get; set; }
        public static string bodyText { get; set; }

        public Form1()
        {
            InitializeComponent();
            btnListFill.Enabled = false;
        }

        private void Connect()
        {
            jabberClient1.Connect();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            Connect();
            btnConnect.Enabled = false;
        }

        private void jabberClient1_OnMessage(object sender, jabber.protocol.client.Message msg)
        {
            jabber.protocol.client.Message reply = new jabber.protocol.client.Message(jabberClient1.Document);
            reply.Body = "Hello!";
            reply.To = msg.From;
            jabberClient1.Write(reply);
            txtFill.Text = msg.Body;
        }

        private void btnListFill_Click(object sender, System.EventArgs e)
        {
            foreach (var item in rosterManager1.Container.Components)
            {
                txtFill.Text += "Item:" + Environment.NewLine + item.ToString() + Environment.NewLine + Environment.NewLine;
            } 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userJID = "botuly@gmail.com";
            bodyText = "--== Default GBotTalk .NET message ==--";
        }


        private void jabberClient1_OnConnect(object sender, jabber.connection.StanzaStream stream)
        {
            txtFill.Text = "Connect" + Environment.NewLine;
        }

        private void rosterManager1_OnRosterEnd(object sender)
        {
            btnListFill.Enabled = true;
        }

        private void btnPresenceManager_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            jabber.protocol.client.Message msg = new jabber.protocol.client.Message(jabberClient1.Document);
            msg.Type = jabber.protocol.client.MessageType.chat;
            msg.Body = bodyText;
            msg.To = userJID;

            if (presenceManager1.IsAvailable(userJID))
                txtFill.Text += "Sent online msg: '";
            else
                txtFill.Text += "Sent offline msg: '";

            txtFill.Text += msg.Body + "'" + Environment.NewLine;
            jabberClient1.Write(msg);
        }


        private void jabberClient1_OnPresence(object sender, jabber.protocol.client.Presence pres)
        {
            jabberClient1.GetRoster();
        }


    }
}
