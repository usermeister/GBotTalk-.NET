using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            DataClassesTestDBDataContext dc = new DataClassesTestDBDataContext();
            var q = from u in dc.Users
                    select u;
            foreach (var u in q)
            {
                txtQuery.Text += u.username.Trim() + ": " + u.JID.Trim() + Environment.NewLine;
            }

            dataGridView1.DataSource = dc.Contacts;
        }
    }
}
