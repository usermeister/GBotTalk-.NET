namespace GTalk_Reminder_Bot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.txtGTalkUsername = new System.Windows.Forms.TextBox();
            this.txtGTalkPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsernameStatus = new System.Windows.Forms.Label();
            this.jabberClient = new jabber.client.JabberClient(this.components);
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblPasswordStatus = new System.Windows.Forms.Label();
            this.rosterManager = new jabber.client.RosterManager(this.components);
            this.presenceManager = new jabber.client.PresenceManager(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPasswordStatus);
            this.groupBox1.Controls.Add(this.lblConnectionStatus);
            this.groupBox1.Controls.Add(this.lblUsernameStatus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGTalkPassword);
            this.groupBox1.Controls.Add(this.txtGTalkUsername);
            this.groupBox1.Controls.Add(this.btnSignIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign in with your Google Account";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(70, 118);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(56, 23);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtGTalkUsername
            // 
            this.txtGTalkUsername.Location = new System.Drawing.Point(70, 26);
            this.txtGTalkUsername.Name = "txtGTalkUsername";
            this.txtGTalkUsername.Size = new System.Drawing.Size(189, 20);
            this.txtGTalkUsername.TabIndex = 1;
            // 
            // txtGTalkPassword
            // 
            this.txtGTalkPassword.Location = new System.Drawing.Point(70, 73);
            this.txtGTalkPassword.Name = "txtGTalkPassword";
            this.txtGTalkPassword.PasswordChar = '*';
            this.txtGTalkPassword.Size = new System.Drawing.Size(189, 20);
            this.txtGTalkPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // lblUsernameStatus
            // 
            this.lblUsernameStatus.AutoSize = true;
            this.lblUsernameStatus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsernameStatus.Location = new System.Drawing.Point(73, 49);
            this.lblUsernameStatus.Name = "lblUsernameStatus";
            this.lblUsernameStatus.Size = new System.Drawing.Size(121, 13);
            this.lblUsernameStatus.TabIndex = 5;
            this.lblUsernameStatus.Text = "ex: example@gmail.com";
            // 
            // jabberClient
            // 
            this.jabberClient.AutoReconnect = 30F;
            this.jabberClient.AutoStartCompression = true;
            this.jabberClient.AutoStartTLS = true;
            this.jabberClient.InvokeControl = this;
            this.jabberClient.KeepAlive = 30F;
            this.jabberClient.LocalCertificate = null;
            this.jabberClient.Password = null;
            this.jabberClient.Server = "gmail.com";
            this.jabberClient.User = null;
            this.jabberClient.OnAuthError += new jabber.protocol.ProtocolHandler(this.jabberClient_OnAuthError);
            this.jabberClient.OnAuthenticate += new bedrock.ObjectHandler(this.jabberClient_OnAuthenticate);
            this.jabberClient.OnConnect += new jabber.connection.StanzaStreamHandler(this.jabberClient_OnConnect);
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(132, 123);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(43, 13);
            this.lblConnectionStatus.TabIndex = 6;
            this.lblConnectionStatus.Text = "Status: ";
            // 
            // lblPasswordStatus
            // 
            this.lblPasswordStatus.AutoSize = true;
            this.lblPasswordStatus.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordStatus.Location = new System.Drawing.Point(73, 96);
            this.lblPasswordStatus.Name = "lblPasswordStatus";
            this.lblPasswordStatus.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordStatus.TabIndex = 7;
            // 
            // rosterManager
            // 
            this.rosterManager.Stream = this.jabberClient;
            // 
            // presenceManager
            // 
            this.presenceManager.CapsManager = null;
            this.presenceManager.Stream = this.jabberClient;
            // 
            // timer
            // 
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtActivity
            // 
            this.txtActivity.Enabled = false;
            this.txtActivity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtActivity.Location = new System.Drawing.Point(16, 201);
            this.txtActivity.Multiline = true;
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(411, 169);
            this.txtActivity.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Activity:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(294, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 157);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GTalk Reminder Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsernameStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGTalkPassword;
        private System.Windows.Forms.TextBox txtGTalkUsername;
        private System.Windows.Forms.Button btnSignIn;
        private jabber.client.JabberClient jabberClient;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Label lblPasswordStatus;
        private jabber.client.RosterManager rosterManager;
        private jabber.client.PresenceManager presenceManager;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

