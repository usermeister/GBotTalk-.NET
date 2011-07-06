namespace GBotTalk
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtFill = new System.Windows.Forms.TextBox();
            this.btnListFill = new System.Windows.Forms.Button();
            this.jabberClient1 = new jabber.client.JabberClient(this.components);
            this.rosterManager1 = new jabber.client.RosterManager(this.components);
            this.presenceManager1 = new jabber.client.PresenceManager(this.components);
            this.btnPresenceManager = new System.Windows.Forms.Button();
            this.taskTimer = new System.Windows.Forms.Timer(this.components);
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(13, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtFill
            // 
            this.txtFill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFill.Location = new System.Drawing.Point(12, 73);
            this.txtFill.Multiline = true;
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(342, 319);
            this.txtFill.TabIndex = 1;
            // 
            // btnListFill
            // 
            this.btnListFill.Location = new System.Drawing.Point(142, 13);
            this.btnListFill.Name = "btnListFill";
            this.btnListFill.Size = new System.Drawing.Size(75, 23);
            this.btnListFill.TabIndex = 2;
            this.btnListFill.Text = "Fill list";
            this.btnListFill.UseVisualStyleBackColor = true;
            this.btnListFill.Click += new System.EventHandler(this.btnListFill_Click);
            // 
            // jabberClient1
            // 
            this.jabberClient1.AutoReconnect = 30F;
            this.jabberClient1.AutoStartCompression = true;
            this.jabberClient1.AutoStartTLS = true;
            this.jabberClient1.InvokeControl = this;
            this.jabberClient1.KeepAlive = 30F;
            this.jabberClient1.LocalCertificate = null;
            this.jabberClient1.Password = "l0zink4";
            this.jabberClient1.Server = "gmail.com";
            this.jabberClient1.User = "usermeister1@gmail.com";
            this.jabberClient1.OnPresence += new jabber.client.PresenceHandler(this.jabberClient1_OnPresence);
            this.jabberClient1.OnMessage += new jabber.client.MessageHandler(this.jabberClient1_OnMessage);
            this.jabberClient1.OnConnect += new jabber.connection.StanzaStreamHandler(this.jabberClient1_OnConnect);
            // 
            // rosterManager1
            // 
            this.rosterManager1.AutoSubscribe = true;
            this.rosterManager1.Stream = this.jabberClient1;
            this.rosterManager1.OnRosterEnd += new bedrock.ObjectHandler(this.rosterManager1_OnRosterEnd);
            // 
            // presenceManager1
            // 
            this.presenceManager1.CapsManager = null;
            this.presenceManager1.Stream = this.jabberClient1;
            // 
            // btnPresenceManager
            // 
            this.btnPresenceManager.Location = new System.Drawing.Point(279, 13);
            this.btnPresenceManager.Name = "btnPresenceManager";
            this.btnPresenceManager.Size = new System.Drawing.Size(75, 23);
            this.btnPresenceManager.TabIndex = 3;
            this.btnPresenceManager.Text = "Presence manager";
            this.btnPresenceManager.UseVisualStyleBackColor = true;
            this.btnPresenceManager.Click += new System.EventHandler(this.btnPresenceManager_Click);
            // 
            // taskTimer
            // 
            this.taskTimer.Interval = 60000;
            this.taskTimer.Tick += new System.EventHandler(this.taskTimer_Tick);
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(142, 43);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartTimer.TabIndex = 4;
            this.btnStartTimer.Text = "Start Timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 404);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.btnPresenceManager);
            this.Controls.Add(this.btnListFill);
            this.Controls.Add(this.txtFill);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtFill;
        private System.Windows.Forms.Button btnListFill;
        private jabber.client.JabberClient jabberClient1;
        private jabber.client.RosterManager rosterManager1;
        private jabber.client.PresenceManager presenceManager1;
        private System.Windows.Forms.Button btnPresenceManager;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Timer taskTimer;
    }
}

