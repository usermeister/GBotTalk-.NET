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
            this.txtFill.Location = new System.Drawing.Point(12, 42);
            this.txtFill.Multiline = true;
            this.txtFill.Name = "txtFill";
            this.txtFill.Size = new System.Drawing.Size(458, 179);
            this.txtFill.TabIndex = 1;
            // 
            // btnListFill
            // 
            this.btnListFill.Location = new System.Drawing.Point(94, 13);
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
            this.jabberClient1.OnMessage += new jabber.client.MessageHandler(this.jabberClient1_OnMessage);
            this.jabberClient1.OnConnect += new jabber.connection.StanzaStreamHandler(this.jabberClient1_OnConnect);
            // 
            // rosterManager1
            // 
            this.rosterManager1.AutoSubscribe = true;
            this.rosterManager1.Stream = this.jabberClient1;
            this.rosterManager1.OnRosterEnd += new bedrock.ObjectHandler(this.rosterManager1_OnRosterEnd);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 398);
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
    }
}

