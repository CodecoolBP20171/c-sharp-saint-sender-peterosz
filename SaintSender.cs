using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSender : Form
    {

        public SaintSender()
        {
            InitializeComponent();
        }

        private void SaintSender_Load(object sender, EventArgs e)
        {
            int rowcount = 0;
            foreach (MailMessage msg in IMAPGmailHandler.GetMails())
            {
                mailList.Rows.Add(
                    "Subject: " + msg.Subject + "\n" + 
                    "From: " + msg.From                   
                    );
                mailList.Rows[rowcount].Tag = msg;
                rowcount++;

            }
        }

        private void mailList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            MailMessage msg = (MailMessage)mailList.Rows[selected].Tag;
            displayMail.Text = msg.Body;
            string from = "" + msg.From;
            string email = from.Substring(from.IndexOf('<')).Trim('<').Trim('>');
            txtBoxToFrom.Text = email;
        }
    }
}
