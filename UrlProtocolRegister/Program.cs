using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UrlProtocolRegister
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 frm = new Form1();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-p")
                    frm.ProtocolName = args[++i];
                else if (args[i] == "-P")
                    frm.Path = args[++i];
                else if (args[i] == "-u")
                {
                    string s = args[++i];
                    if (s.ToLower() == "yes")
                        frm.UseParam = true;
                    else if (s.ToLower() == "no")
                        frm.UseParam = false;
                }
            }

            Application.Run(frm);
        }
    }
}
