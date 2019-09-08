using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MACOY
{
    public class Program : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public Program()
            : base(Microsoft.VisualBasic.ApplicationServices.AuthenticationMode.Windows)
        {
            this.IsSingleInstance = false;
            this.EnableVisualStyles = true;

            //Aqui esta el truco
            this.ShutdownStyle = Microsoft.VisualBasic.ApplicationServices.
                ShutdownMode.AfterAllFormsClose;
        }

        protected override void OnCreateMainForm()
        {
            this.MainForm = new LoginScreen();
            
        }

        [STAThread]
        internal static void Main(string[] Args)
        {
            string[] arg; arg = new string[0];
            new Program().Run(arg);
        }
    }
}