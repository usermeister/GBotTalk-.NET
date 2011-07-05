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

        public Form1()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            jabberClient1.Connect();
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {
            Connect();
        }

        private void btnListFill_Click(object sender, System.EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {;
        }

        private void jabberClient1_OnMessage(object sender, jabber.protocol.client.Message msg)
        {
            jabber.protocol.client.Message reply = new jabber.protocol.client.Message(jabberClient1.Document);
            reply.Body = "Hello!";
            reply.To = msg.From;
            jabberClient1.Write(reply);
            txtFill.Text = msg.Body;
        }

        private void jabberClient1_OnConnect(object sender, jabber.connection.StanzaStream stream)
        {
            txtFill.Text = "Connect";
        }	

    }
}
