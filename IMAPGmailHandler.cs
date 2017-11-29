using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using S22.Imap;
using System.Net.Mail;

namespace SaintSender
{
    class IMAPGmailHandler
    {
        static string hostname = "imap.gmail.com";
        static string username = "peterdevenv@gmail.com";
        static string password = "";
        static ImapClient connection = ConnectToGmail();

        static ImapClient ConnectToGmail()
        {
            ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true);
            return client;
        }

        public static IEnumerable<MailMessage> GetMails()
        {
            IEnumerable<MailMessage> messages;
            using (connection)
            {
                IEnumerable<uint> uids = connection.Search(SearchCondition.All());
                messages = connection.GetMessages(uids);
            }
            return messages;
        }
    }
}
