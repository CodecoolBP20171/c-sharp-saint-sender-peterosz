﻿using System;
using System.Windows.Forms;

namespace SaintSender
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SaintSender());
        }
    }
}

