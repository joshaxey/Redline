using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace RedlineTest
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TestForm());
        }
    }
}