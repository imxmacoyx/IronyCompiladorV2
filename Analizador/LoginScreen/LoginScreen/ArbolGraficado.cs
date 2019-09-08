using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Irony.Parsing;
using Irony.Ast;


namespace MACOY
{
    public partial class ArbolGraficado : Form
    {
        public ArbolGraficado()
        {
            InitializeComponent();
            Dashboard dh = new Dashboard();
            ParseTreeNode resultado = Sintactico.analizarArbol(dh.txtCodigo.Text);
            if (resultado != null)
                pictureBox1.Image = Sintactico.getImage(resultado);
        }


        private void ArbolGraficado_Load(object sender, EventArgs e)
        {
            Dashboard dh = new Dashboard();
            ParseTreeNode resultado = Sintactico.analizarArbol(dh.txtCodigo.Text);
            if (resultado != null)
                pictureBox1.Image = Sintactico.getImage(resultado);
        }
    }
}
