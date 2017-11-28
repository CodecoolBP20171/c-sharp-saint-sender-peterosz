using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSender : Form
    {
        GoogleAPIHandler googleAPI = new GoogleAPIHandler();
            

        public SaintSender()
        {
            InitializeComponent();
        }

        private void SaintSender_Load(object sender, EventArgs e)
        {
            foreach (var msg in googleAPI.ListMessages())
            {
                mailList.Rows.Add(
                    googleAPI.GetMessage(msg.Id).Payload.Headers[5].Value + "\n" +
                    googleAPI.GetMessage(msg.Id).Payload.Headers[6].Value
                    );

            }
        }
    }
}
