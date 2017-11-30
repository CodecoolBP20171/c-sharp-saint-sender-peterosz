using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S22.Imap;
using System.Net.Mail;

namespace SaintSender
{
    public class IMAPGmailHandler
    {
        static string hostname = "imap.gmail.com";
        public string UserName{get; set;}
        public string Password { get; set; }
        public static string errorMsg = "";

        public IMAPGmailHandler(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public ImapClient ConnectToGmail()
        {
            ImapClient client = null;
            try
            {
                client = new ImapClient(hostname, 993, UserName, Password, AuthMethod.Login, true);
            }
            catch(InvalidCredentialsException ex)
            {
                errorMsg = "Username or password incorrect";
                Console.WriteLine(ex.Message);
            }   
            return client;
        }

        public IEnumerable<MailMessage> GetMails()
        {
            IEnumerable<MailMessage> messages;
            var connection = ConnectToGmail();
            if (connection == null)
            {
                errorMsg = "Username or password incorrect";
            }
            else
            {
                using (connection)
                {
                    IEnumerable<uint> uids = connection.Search(SearchCondition.All());
                    messages = connection.GetMessages(uids);
                }
                return messages;
            }
            return null;
        }

        public static void SendEmail(string subject, string body, string to, string username, string password)
        {
            SmtpClient smtpClient = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new System.Net.NetworkCredential(username, password),
                Timeout = 10000,
            };
            MailMessage newEmail = new MailMessage(username, to, subject, body);
            smtpClient.Send(newEmail);
        }
    }
}
