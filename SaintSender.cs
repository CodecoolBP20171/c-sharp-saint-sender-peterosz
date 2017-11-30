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
        LoginForm login;
        public static IMAPGmailHandler gmail;
        string mailSubject;

        public SaintSender()
        {
            InitializeComponent();
        }

        private void SaintSender_Load(object sender, EventArgs e)
        {
            UserLogInPopUp();
        }

        void UserLogInPopUp(string errorMessage = "")
        {
            login = new LoginForm();
            login.errorMessage = errorMessage;
            login.Show();
            login.FormClosed += new FormClosedEventHandler(LoginFormClosed);
        }

        private void LoginFormClosed(object sender, EventArgs e)
        {
            if (login.UserName != "")
            {
                gmail = new IMAPGmailHandler(login.UserName, login.Password);
                if (gmail.ConnectToGmail() != null)
                {
                    PopulateMails();
                }
                else
                {
                    UserLogInPopUp(IMAPGmailHandler.errorMsg);
                }
            }
            
        }

        void PopulateMails()
        {
            mailList.Rows.Clear();
            List<MailMessage> allMails = new List<MailMessage>(gmail.GetMails());
            allMails.Reverse();
            int rowcount = 0;
            foreach (MailMessage msg in allMails)
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
            MailMessage msg;
            int selected = e.RowIndex;
            if (selected > 0)
            {
                msg = (MailMessage)mailList.Rows[selected].Tag;
            }
            else
            {
                msg = (MailMessage)mailList.Rows[0].Tag;
            }
            displayMail.Text = msg.Body;
            string from = "" + msg.From;
            mailSubject = msg.Subject;
            string email;
            if (from.Contains('<'))
            {
                email = from.Substring(from.IndexOf('<')).Trim('<').Trim('>');
            }
            else
            {
                email = from;
            }
            txtBoxToFrom.Text = email;
        }

        private void switchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserLogInPopUp();
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            SendMail sendMail = new SendMail();
            sendMail.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            PopulateMails();
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            string subject = "RE: " + mailSubject;
            string body = replyMail.Text;
            string adress = txtBoxToFrom.Text;
            string username = gmail.UserName;
            string password = gmail.Password;
            IMAPGmailHandler.SendEmail(subject, body, adress, username, password);
            replyMail.Text = "";
        }
    }
}
