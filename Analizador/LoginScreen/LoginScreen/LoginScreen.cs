using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACOY
{
    public partial class LoginScreen : Form
    {
        public LoginScreen() { 
            InitializeComponent();
            Animacion.Start();
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void Animacion_Tick(object sender, EventArgs e)
        {
            double var;
            
            if (panelBarra.Width < 600)
            {
                panelBarra.Width += 6;
                var = (panelBarra.Width * 100) / 600;
                lblCount.Text = var.ToString();
            }
            else
            {
                Animacion.Stop();
                
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                this.Close();
            }
                
        }


        private void LoginScreen_Load(object sender, EventArgs e)
        {
            Animacion.Start();
        }

        

        
    }
}
