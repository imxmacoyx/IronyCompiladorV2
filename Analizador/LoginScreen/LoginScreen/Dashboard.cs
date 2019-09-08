using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MACOY.Properties;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using Irony.Parsing;

namespace MACOY
{

    

    public partial class Dashboard : Form
    {

        string rutaArchivo = string.Empty;
        RegexLexer csLexer = new RegexLexer();
        
        List<string> palabrasReservadas;
        List<string> tiposdeDatos;
        bool load;
        int CARACTER;

        public Dashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Timer1.Interval = 10;
            Timer1.Start();
           
            using (StreamReader sr = new StreamReader(@"..\..\RegexLexer.cs"))
            {

                csLexer.AddTokenRule(@"\t+", "TABULACION");//esme
                csLexer.AddTokenRule(@"\s+", "ESPACIO", true);
                csLexer.AddTokenRule("\".*?\"", "CADENA");
                csLexer.AddTokenRule(@"'\\.'|'[^\\]'", "CARACTER");
                csLexer.AddTokenRule("//[^\r\n]*", "COMENTARIOLINEA");
                csLexer.AddTokenRule("/[*].*?[*]/", "COMENTARIOBLOQUE");
                csLexer.AddTokenRule(@"\d+\.\d+","DECIMAL");//ESME
                csLexer.AddTokenRule(@"\d*\.?\d+", "NUMERO");
                csLexer.AddTokenRule(@"\b[_a-zA-Z][\w]*\.?\b[_a-zA-Z][\w]*\b", "IDENTIFICADOR_FUNCIONAL");//ESME
                csLexer.AddTokenRule(@"[\(\)\{\}\[\];,]", "DELIMITADOR");
                csLexer.AddTokenRule(@"[\.=\+\-/*%]", "OPERADOR");
                csLexer.AddTokenRule(@">|<|==|>=|<=|!|!=", "COMPARADOR");
                csLexer.AddTokenRule(@"\b[_a-zA-Z][\w]*\b", "IDENTIFICADOR");
                csLexer.AddTokenRule(@"\+\+|\-\-", "OPERADOR_INC_O_DEC");//esme
                csLexer.AddTokenRule(@"\+=|\-=|\*=|/=", "OPERADOR_ASIGNACION");//esme
                csLexer.AddTokenRule(@"[\.=\+\-/*%}|\^]", "OPERADOR");
                csLexer.AddTokenRule(@"\&\&|\|\||\!\=", "OPERADOR_LOGICO");//esme

                // csLexer.AddTokenRule();
                //listas  macoy
                palabrasReservadas = new List<string>() { "abstract","assert","boolean","break","byte", "case", "catch",
                    "char","class","const","continue","default","do","double","else","enum","extends","final","finally",
                    "float","for","goto","if","implements","import","instanceof","int","interface","long","native","new",
                    "package","private","protected","public","return","short","static","stricftp","super","switch","synchronized",
                    "this","throw","throws","transient","try","void","volatile","while"
                };
                //Listas esme
                //List<string> reservadasCiclos;
                //List<string> tipoDeDato;
                //List<string> ambitoNivelDeAcceso;
                //List<string> palabrasReservadas;
                //reservadasCiclos = new List<string>()
                //{
                //     "while","do","for","foreach","if"
                //};
                //tipoDeDato = new List<string>()
                //{
                //    "int","float","double","long","bool","byte", "char",
                //    "decimal", "dynamic","sbyte", "short",
                //    "string", "uint", "ulong", "ushort", "var"
                //};
                //ambitoNivelDeAcceso = new List<string>()
                //{
                //    "public","private", "protected","internal"
                //};
                //palabrasReservadas = new List<string>() {
                //    "abstract","as","async","await","checked",
                //    "const", "continue", "default", "delegate",
                //    "base", "break", "case","else", "enum","event",
                //    "explicit", "extern", "false", "finally",
                //    "fixed","goto","implicit","in", "interface",
                //    "is", "lock", "new","null", "operator",
                //    "catch","out", "override","params","readonly",
                //    "ref", "return", "sealed", "sizeof",
                //    "stackalloc", "static","switch", "this",
                //    "throw","true", "try", "typeof", "namespace",
                //    "unchecked","unsafe", "virtual", "void",
                //    "object","get", "set", "new","partial", "yield",
                //    "add", "remove", "value","alias", "ascending",
                //    "descending", "from","group", "into", "orderby",
                //    "select", "where","join", "equals", "using",
                //     "class", "struct" };
                csLexer.Compile(RegexOptions.Compiled | RegexOptions.Singleline | RegexOptions.ExplicitCapture);

                
                analizaCodigo();
                load = true;
                txtCodigo.Focus();
            }
                
        }
        
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            CARACTER = 0;
            int ALTURA = txtCodigo.GetPositionFromCharIndex(0).Y - 1;
            if (txtCodigo.Lines.Length > 0)

                for (int i = 0; i < txtCodigo.Lines.Length; i++)
                {

                    e.Graphics.DrawString(Convert.ToString(i + 1), txtCodigo.Font, Brushes.Aqua, pictureBox8.Width - (e.Graphics.MeasureString(Convert.ToString(i + 1), txtCodigo.Font).Width + 10), ALTURA);

                    CARACTER = CARACTER + txtCodigo.Lines[i].Length + 1;

                    ALTURA = txtCodigo.GetPositionFromCharIndex(CARACTER).Y;

                }
            else
            {

                e.Graphics.DrawString("1", txtCodigo.Font, Brushes.Aqua, pictureBox8.Width - (e.Graphics.MeasureString("1", txtCodigo.Font).Width + 10), ALTURA);

            }
        }
        

        private void panelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tabContenedor.Visible)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere cerrar el Script actual?", "Mensaje importante", MessageBoxButtons.YesNo);
                if(resultado == DialogResult.Yes)
                {
                    txtCodigo.Clear();
                    //   txtConsola.Clear();
                }
            }
            else
            {
                tabContenedor.Visible = true;
            }
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (tabContenedor.Visible)
            {
                txtCodigo.ZoomFactor += 1;
                //  txtConsola.ZoomFactor += 1;
            }

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (tabContenedor.Visible)
            {
                if(txtCodigo.ZoomFactor > 1 )
                {
                    txtCodigo.ZoomFactor -= 1;
                    //   txtConsola.ZoomFactor -= 1;
                }
            }

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (tabContenedor.Visible)
            {
                txtCodigo.ZoomFactor = 1;
                //  txtConsola.ZoomFactor = 1;
            }

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (tabContenedor.Visible)
            {
                DialogResult resultado = MessageBox.Show("¿Esta seguro que quiere cerrar el Script actual?", "Mensaje importante", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    txtCodigo.Clear();
                    //    txtConsola.Clear();
                    tabContenedor.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay ningun Script abierto");
            }
        }

        private void picCerrarListaDeErrores_Click(object sender, EventArgs e)
        {
            if(dgvListaDeErrores.Height == 114)
            {
                dgvListaDeErrores.Height = 0;
                picCerrarListaDeErrores.Image = Resources.icons8_Up_Squared_50px;
                picCerrarListaDeErrores.BackColor = Color.Transparent;
                panelErrores.Height = 25;
            }
            else
            {
                picCerrarListaDeErrores.Image = Resources.icons8_Drop_Down_50px;
                picCerrarListaDeErrores.BackColor = Color.Transparent;
                dgvListaDeErrores.Height = 114;
                panelErrores.Height = 139;
            }
            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            DialogResult result = ColorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCodigo.ForeColor = ColorPicker.Color;
               // txtConsola.ForeColor = ColorPicker.Color;
            }
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            DialogResult result = ColorPicker.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCodigo.BackColor = ColorPicker.Color;
                //  txtConsola.BackColor = ColorPicker.Color;
            }
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            // Save.ShowDialog();

            if (tabContenedor.Visible)
            {
                
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "java|*.java";
                guardar.Title = "Guardar Script";
                guardar.FileName = "Script";
                var resultado = guardar.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    rutaArchivo = guardar.FileName;
                    StreamWriter escribir = new StreamWriter(guardar.FileName);
                    foreach (object line in txtCodigo.Lines)
                        escribir.WriteLine(line);

                    escribir.Close();
                }
            }



        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Open.ShowDialog();
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "java|*.java";
            abrir.Title = "Abrir Script";
            abrir.FileName = "Script";
            
            var resultado = abrir.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                txtCodigo.Clear();
                rutaArchivo = abrir.FileName;
                StreamReader leer = new StreamReader(abrir.FileName);
                txtCodigo.Text = leer.ReadToEnd();
                leer.Close();

            }

            if (!tabContenedor.Visible)
                tabContenedor.Visible = true;

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            //Compilación



            string comando = "ipconfig";
            string comando2 = "javac " + rutaArchivo;
            string comando3 = "java "+ rutaArchivo;


            Process process = new Process();
            process.StartInfo.FileName = "cmd";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.StandardInput.WriteLine(comando);

            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            Console.WriteLine(process.StandardOutput.ReadToEnd());




        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (load) //agregado por ESMERALDA RUIZ BARRON

             analizaCodigo();
         

        }

        public void analizaCodigo()
        {
            dgvTokens.Rows.Clear();
            dgvListaDeErrores.Rows.Clear();

            int n = 0, errores = 0;
            int i = 0;
            int j = 0;

            foreach (var tk in csLexer.GetTokens(txtCodigo.Text))
            {
                if (tk.Name == "ERROR")
                {
                    errores++;
                    dgvListaDeErrores.Rows.Insert(j, tk.Name, tk.Lexema, tk.Linea);
                  //  txtCodigo.ForeColor = Color.Red;
                    j++;
                }
                else 
                if (tk.Name == "IDENTIFICADOR")
                {
                    txtCodigo.ForeColor = Color.White;
                    if (palabrasReservadas.Contains(tk.Lexema))
                    {
                        tk.Name = "RESERVADO";
                      //  txtCodigo.ForeColor = Color.White;
                    }
                }

                if(!(tk.Name == "ERROR"))
                {
                    dgvTokens.Rows.Insert(i, tk.Name, tk.Lexema, tk.Linea);
                    i++;
                }

                n++;
                
            }
            
            tokens.Text = n.ToString();
            lblerror.Text = errores.ToString();

          bool resultado = Sintactico.analizar(txtCodigo.Text);
            if (resultado)
            {
                if(dgvListaDeErrores.Rows.Count>0)
                    txtCodigo.ForeColor = Color.White;
                else
                {
                    txtCodigo.ForeColor = Color.Red;
                }
            }     
            else{

                txtCodigo.ForeColor = Color.Red;

            }
                

        
        }

        
        private void tokens_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click_1(object sender, EventArgs e)
        {
            ParseTreeNode resultado = Sintactico.analizarArbol(txtCodigo.Text);
            if (resultado != null)
                pictureBox7.Image = Sintactico.getImage(resultado);

        }

        private void TxtCodigo_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            pictureBox8.Refresh();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

    }
}
