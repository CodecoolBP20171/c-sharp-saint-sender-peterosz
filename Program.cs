using System;
using System.Windows.Forms;

namespace SaintSender
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            GoogleAPIHandler googleAPI = new GoogleAPIHandler();
            foreach(string label in googleAPI.GetLabels())
            {
                Console.WriteLine(label);
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SaintSender());
        }
    }
}

