using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using Cheng.TXT16.Forms;

namespace Cheng.TXT16
{

    public static class Program
    {


        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            Control.CheckForIllegalCrossThreadCalls = false;

            using (MainForm form = new MainForm(args))
            {
                Application.Run(form);
            }
        }

    }

}
