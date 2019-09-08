using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;


namespace MACOY
{
    class Gramatica: Grammar
    {
        public Gramatica() : base(caseSensitive: true)
        {
            IdentifierTerminal id = new IdentifierTerminal("id");
            RegexBasedTerminal numeroentero = new RegexBasedTerminal("[0-9]+");
            RegexBasedTerminal numerodecimal = new RegexBasedTerminal("[0-9]+[.][0-9]");
            StringLiteral STRING = new StringLiteral("STRING", "\"", StringOptions.IsTemplate);

            

            CommentTerminal comentarioenlinea = new CommentTerminal("comentario linea", "//", "\n", "\r\n");
            CommentTerminal comentariobloque = new CommentTerminal("comentario bloque", "/*", "*/");
            base.NonGrammarTerminals.Add(comentarioenlinea);
            base.NonGrammarTerminals.Add(comentariobloque);

            #region TERMINALES
            var reservadaclass = "class";
            var reservadapublic = "public";
            var reservadaprivate = "private";
            var reservadaabstract = "abstract";
            var reservadaassert = "assert";
            var reservadaboolean = "boolean";
            var reservadabreak = "break";
            var reservadabyte = "byte";
            var reservadacase = "case";
            var reservadacatch = "catch";
            var reservadachar = "char";
            var reservadaconst = "const";
            var reservadacontinue = "continue";
            var reservadadefault = "default";
            var reservadado = "do";
            var reservadadouble = "double";
            var reservadaelse = "else";
            var reservadaenum = "enum";
            var reservadaextends = "extends";
            var reservadafinal = "final";
            var reservadafinally = "finally";
            var reservadapackage = "package";
            var reservadaprotected = "protected";
            var reservadareturn = "return";
            var reservadashort = "short";
            var reservadastatic = "static";
            var reservadastricftp = "stricftp";
            var reservadasuper = "super";
            var reservadaswitch = "switch";
            var reservadasynchronized = "synchronized";
            var reservadathis = "this";
            var reservadathrow = "throw";
            var reservadathrows = "throws";
            var reservadatransient = "transient";
            var reservadatry = "try";
            var reservadavoid = "void";
            var reservadavolatile = "volatile";
            var reservadawhile = "while";
            var reservadafloat = "float";
            var reservadafor = "for";
            var reservadagoto = "goto";
            var reservadaif = "if";
            var reservadaimplements = "implements";
            var reservadaimport = "import";
            var reservadainstanceof = "instanceof";
            var reservadaint = "int";
            var reservadalong = "long";
            var reservadanative = "native";
            var reservadanew = "new";
            var reservadastring = "string";
            var reservadallaveabrir = "{";
            var reservadallavecerrar = "}";
            var reservadapuntoycoma = ";";
            var reservadadospuntos = ":";
            var reservadaparentesisabrir = "(";
            var reservadaparentesiscerrar = ")";
            var reservadastringargs = "String [] args";
            var reservadamayorque = ">";
            var reservadamenorque = "<";
            var reservadamayorigual = ">=";
            var reservadamenorigual = "<=";
            var reservadaigualigual = "==";
            var reservadaigual = "=";
            var reservadadiferente = "!=";
            var mas = ToTerm("+");
            var menos = ToTerm("-");
            var multiplicacion = ToTerm("*");
            var division = ToTerm("/");
            var and = ToTerm("&&");
            var or = ToTerm("||");
            var reservadamain = "main";
            var incremento = ToTerm("++");
            var decremento = ToTerm("--");
            var reservadavector = "[]";
            var reservadamatriz = "[][]";
            var reservadacorcheteabrir = "[";
            var reservadacorchetecerrar = "]";
            #endregion

            NonTerminal TIPO = new NonTerminal("TIPO");
            NonTerminal VISIBILIDAD = new NonTerminal("VISIBILIDAD");
            NonTerminal INICIO = new NonTerminal("INICIO");
            NonTerminal MAIN = new NonTerminal("MAIN");
            NonTerminal SENTENCIAS = new NonTerminal("SENTENCIAS");
            NonTerminal MENSAJE = new NonTerminal("MENSAJE");
            NonTerminal WHILE = new NonTerminal("WHILE");
            NonTerminal IF = new NonTerminal("IF");
            NonTerminal E = new NonTerminal("E");
            NonTerminal R = new NonTerminal("R");
            NonTerminal FOR = new NonTerminal("FOR");
            NonTerminal SWITCH = new NonTerminal("SWITCH");
            NonTerminal CASE = new NonTerminal("CASE");
            NonTerminal DECLARACION = new NonTerminal("DECLARACION");

            TIPO.Rule = TIPO
                | reservadashort
                | reservadafloat
                | reservadastring
                | reservadaint
                | reservadalong
                | reservadachar
                | reservadabyte
                | reservadaboolean
                | reservadadouble
                | reservadashort;


            VISIBILIDAD.Rule = Empty
                | reservadapublic
                | reservadaprivate
                | reservadaprotected;

            SENTENCIAS.Rule = SENTENCIAS + MENSAJE
                | SENTENCIAS + WHILE
                | SENTENCIAS + IF
                | SENTENCIAS + FOR
                | SENTENCIAS + SWITCH
                | SENTENCIAS + DECLARACION
                | FOR
                | MENSAJE
                | WHILE
                | SWITCH
                | DECLARACION
                | IF
                | Empty;


            INICIO.Rule = VISIBILIDAD + reservadaclass + id + reservadallaveabrir + MAIN + reservadallavecerrar;

            

            INICIO.Rule = VISIBILIDAD + ToTerm("class") + id + ToTerm("{") + MAIN + ToTerm("}")
            | VISIBILIDAD + ToTerm("class") + id + ToTerm("{") + Empty + ToTerm("}");
            INICIO.ErrorRule = SyntaxError + Eof;


            MAIN.Rule = ToTerm("public static void main(String []args){") + SENTENCIAS + ToTerm("}");
            MAIN.ErrorRule = SyntaxError + ToTerm("}");
            

            MENSAJE.Rule = ToTerm("System.out.println") + ToTerm("(") + STRING + ToTerm(");");
            MENSAJE.ErrorRule = SyntaxError + ToTerm(";");

            WHILE.Rule = ToTerm("while") + ToTerm("(") + R + ToTerm(")") + ToTerm("{") + SENTENCIAS + ToTerm("}");
            WHILE.ErrorRule = SyntaxError + ToTerm("}");

            IF.Rule = ToTerm("if") + ToTerm("(") + R + ToTerm(")") + ToTerm("{") + SENTENCIAS + ToTerm("}")
            | ToTerm("if") + ToTerm("(") + R + ToTerm(")") + ToTerm("{") + SENTENCIAS + ToTerm("}else{") + SENTENCIAS + ToTerm("}");
            IF.ErrorRule = SyntaxError + ToTerm("}");

            FOR.Rule = ToTerm("for(int i=0;i<10;i++){") + SENTENCIAS + ToTerm("}");
            FOR.ErrorRule = SyntaxError + ToTerm("}");

            SWITCH.Rule = ToTerm("switch") + ToTerm("(") + R + ToTerm(")") + ToTerm("{") + CASE +ToTerm("}");
            SWITCH.ErrorRule = SyntaxError + ToTerm("}");

            CASE.Rule = CASE + ToTerm("case") + id + ToTerm(":") + SENTENCIAS + ToTerm("break;")
                | ToTerm("case") + ToTerm(":") + SENTENCIAS + ToTerm("break;")
                | Empty;
            CASE.ErrorRule = SyntaxError + ToTerm(";");

            DECLARACION.Rule =
              TIPO + id + ToTerm("=") + STRING + ToTerm(";")
            | TIPO + id + reservadaigual + numeroentero + reservadapuntoycoma
            | TIPO + id + reservadaigual + numerodecimal + reservadapuntoycoma
            | TIPO + id + ToTerm(";")
            | Empty;
            DECLARACION.ErrorRule = SyntaxError + ToTerm(";");

            R.Rule = E + ToTerm("<") + E
                | E + ToTerm(">") + E
                | E + ToTerm(">=") + E
                | E + ToTerm("<=") + E
                | E + ToTerm("==") + E
                | E + ToTerm("!=") + E;

            E.Rule = E + ToTerm("+") + E
                    | E + ToTerm("-") + E
                    | E + ToTerm("*") + E
                    | E + ToTerm("/") + E
                    | E + ToTerm("%") + E
                    | (E)
                    | id
                    | numeroentero
                    | numerodecimal;

            this.Root = INICIO; //RAIZ DE INICIO



            #region PALABRAS RESERVADAS
            //Palabras reservadas.
            this.MarkReservedWords(reservadaabstract, reservadaassert, reservadaboolean, reservadabreak, reservadabyte, reservadacase, reservadacatch, reservadachar, reservadaclass, reservadaconst, reservadacontinue, reservadadefault, reservadado, reservadadouble, reservadaelse, reservadaenum, reservadaextends, reservadafinal, reservadafinally, reservadafloat, reservadafor, reservadagoto, reservadaif, reservadaimplements, reservadaimport, reservadainstanceof, reservadaint, reservadalong, reservadamain, reservadamatriz, reservadanative, reservadanew, reservadapackage, reservadaprivate, reservadaprotected, reservadapublic, reservadareturn, reservadashort, reservadastatic, reservadastricftp, reservadastring, reservadastringargs, reservadasuper, reservadaswitch, reservadasynchronized, reservadathis, reservadathrow, reservadathrows, reservadatransient, reservadatry, reservadavector, reservadavoid, reservadavolatile, reservadawhile);
            #endregion


        }


    }
}
