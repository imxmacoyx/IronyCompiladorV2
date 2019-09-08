using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;


namespace MACOY
{
    class Sintactico : Grammar
    {

        public static bool analizar(string cadena)
        {
            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(cadena);
            ParseTreeNode raiz = arbol.Root;

            if (raiz == null)
                return false;

            return true;
        }

        public static ParseTreeNode analizarArbol(string cadena)
        {
            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(cadena);
            ParseTreeNode raiz = arbol.Root;
            return arbol.Root;
        }

        public static Image getImage(ParseTreeNode raiz)
        {
            String grafoDOT = ControlDOT.getDOT(raiz);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToJPEG(grafoDOT);
            byte[] imageBytes = Convert.FromBase64String(img.ToBase64String());
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Image imagen = Image.FromStream(ms, true);
            return imagen;
        }




    }
}
