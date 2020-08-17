using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi
{
    public class NodoToken
    {
        public int token;
        public string lexema;
        public int linea;
    }

    public enum TipoNodoArbol
    {
        Expresion,
        Sentencia
    }
    public enum TipoSentencia
    {
        If,
        For,
        Asignacion,
        Expresion,
        Leer,
        Escribir,
        Nada
    }
    public enum TipoExpresion
    {
        Constante,
        Identificador,
        Operador,
        Nada
    }
    public enum TipoValorNodo
    {
        Entero,
        Flotante,
        Booleano,
        Caracter,
        Cadena,
        Nada,
        Objeto
    }
    public enum Operaciones
    {
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Nada,
        MOD
    }
    class Arboles
    {
        public string lexema;
        public TablaSimbolos ts;
        public string claseActiva;
        public string metodoActivo;
        public string codigoP;
        public string codigoP2;
        public string codigoP3;
        public string codigoP4;

        public Arboles HijoIzquierdo;
        public Arboles HijoDerecho;
        public Arboles HijoCentro;
        public Arboles Hermano;

        public TipoNodoArbol soyTipoNodo;


        public TipoSentencia soySentenciaTipo;

        public TipoExpresion soyExpresionTipo;
        public Operaciones soyOperacion;
        public TipoValorNodo soyValorTipo;

        //Para comprobacion de tipos
        public TipoValorNodo tipoValorHijoIzquierdo;
        public TipoValorNodo tipoValorHijoDerecho;
        public TipoValorNodo tipoValorHermano;

        public string valorNodo;

        //lista temporal de los tokens
        public int puntero;
        public List<Token> miListaTokenTemporal;

        public Arboles(List<Token> miListaToken)
        {
            puntero = 0;
            this.miListaTokenTemporal = miListaToken;
        }
        public Arboles(List<Token> miListaToken, TablaSimbolos ts, string claseActiva, string metodoActivo)
        {
            puntero = 0;
            this.miListaTokenTemporal = miListaToken;
            this.ts = ts;
            this.claseActiva = claseActiva;
            this.metodoActivo = metodoActivo;
        }
        public Arboles()
        { }
        public Arboles SentenciaAssignacion()
        {
            return new Arboles();
        }

        #region Arbol de Expresion
        public Arboles SecuenciaSentencias()
        {
            Arboles t = Sentencia();
            puntero++;
            while (puntero < miListaTokenTemporal.Count - 1)
            {
                t = insertarNodo(t, Sentencia());
                puntero++;
            }
            return t;
        }
        public Arboles insertarNodo(Arboles padre, Arboles hijo)
        {


            Arboles q = padre;
            if (q.Hermano == null)
            {
                q.Hermano = hijo;
            }
            else
            {
                bool insertado = false;
                while (!insertado)
                {
                    Arboles n = q.Hermano;

                    if (n.Hermano == null)
                    {
                        n.Hermano = hijo;
                        insertado = true;
                    }
                    q = n;
                }
            }

            return padre;
        }
        public int ObtenerIndexIfFinal(List<Token> lista)
        {
            int curlyBraces = 0;
            int index = 0;
            while (lista[index].lexema != "{")
            {
                index++;
            }
            index++;
            curlyBraces++;

            for (; index < lista.Count; index++)
            {
                if (lista[index].lexema == "{")
                {
                    curlyBraces++;
                }
                else if (lista[index].lexema == "}")
                {
                    curlyBraces--;
                }
                if (curlyBraces == 0)
                {
                    return index;
                }
            }
            return -1;
        }

        private Arboles Sentencia()
        {
            Arboles nodoRaiz = new Arboles();
            bool secuencia = true;
            switch (miListaTokenTemporal[puntero].estado)
            {
                case -124:
                    nodoRaiz = SentenciaIf();
                    break;

                case -121:
                    nodoRaiz = SenteciaFor();
                    break;

                case -158:
                    nodoRaiz = SentenciaWrite(true);
                    break;
            }
            if (puntero < miListaTokenTemporal.Count - 1 && miListaTokenTemporal[puntero + 1].estado == -4)
            {
                puntero++;
                
                nodoRaiz = SentenciaAsignacion();
                
            }
            if (puntero < miListaTokenTemporal.Count - 1 && miListaTokenTemporal[puntero].estado == -4)
            {
                nodoRaiz = SentenciaAsignacion();
            }
            return nodoRaiz;
        }
        public Arboles Expresion()
        {
            var sentenciaExpresion = NuevoNodoSentencia(TipoSentencia.Expresion);
            string comparador = ObtenerLexamaComparador(miListaTokenTemporal);
            sentenciaExpresion.lexema = comparador;
            string codigoP = ObtenerComparadorCodigoP(comparador);
            sentenciaExpresion.codigoP = codigoP;
            sentenciaExpresion.HijoIzquierdo = SimpleExpresion();
            puntero++;
            sentenciaExpresion.HijoDerecho = SimpleExpresion();
            return sentenciaExpresion;
        }
        public string ObtenerComparadorCodigoP(string comparador)
        {
            switch (comparador)
            {
                case "<":
                    return "grt";
                case ">":
                    return "lst";
                case "==":
                    return "equ";
                case "<=":
                    return "grt";
                case ">=":
                    return "lst";
                case "!=":
                    return "neq";
                default:
                    return null;
            }
        }
        public string ObtenerLexamaComparador(List<Token> lista)
        {
            for (int index = 0; index < lista.Count; index++)
            {
                string lexema = lista[index].lexema;
                switch (lexema)
                {
                    case "<":
                        return lexema;
                    case ">":
                        return lexema;
                    case "==":
                        return lexema;
                    case "<=":
                        return lexema;
                    case ">=":
                        return lexema;
                    case "!=":
                        return lexema;
                }
            }
            return null;

        }
        public Arboles SentenciaRead()
        {
            var sentenciaRead = NuevoNodoSentencia(TipoSentencia.Leer);
            sentenciaRead.lexema = miListaTokenTemporal[puntero - 2].lexema;
            sentenciaRead.codigoP2 = "rd " + sentenciaRead.lexema;
            return sentenciaRead;

        }
        public Arboles SentenciaRead(string lexema)
        {
            var sentenciaRead = NuevoNodoSentencia(TipoSentencia.Leer);
            sentenciaRead.lexema = lexema;
            sentenciaRead.codigoP2 = "rd " + lexema;
            return sentenciaRead;
        }
        public Arboles SentenciaRead(int index)
        {
            var sentenciaRead = NuevoNodoSentencia(TipoSentencia.Leer);
            sentenciaRead.lexema = miListaTokenTemporal[index].lexema;
            sentenciaRead.codigoP = "rd " + sentenciaRead.lexema;
            return sentenciaRead;
        }
        public Arboles SentenciaWrite()
        {
            var sentenciaWrite = NuevoNodoSentencia(TipoSentencia.Escribir);
            sentenciaWrite.HijoIzquierdo = SimpleExpresion();
            sentenciaWrite.codigoP = "wri";
            return sentenciaWrite;
        }

        public Arboles SentenciaWrite(bool sentencia)
        {
            var sentenciaWrite = NuevoNodoSentencia(TipoSentencia.Escribir);

            int iTemp = puntero;
            while (miListaTokenTemporal[iTemp].lexema != "endl")
            {
                iTemp++;
            }
            puntero += 2;
            
            sentenciaWrite.HijoIzquierdo = SimpleExpresion();
            sentenciaWrite.codigoP = "wri";
            puntero++;
            return sentenciaWrite;
        }

        public Arboles SentenciaIf()
        {
            var sentenciaIf = NuevoNodoSentencia(TipoSentencia.If);
            int finIf = ObtenerIndexIfFinal(miListaTokenTemporal);
            sentenciaIf.codigoP = "fjp L" + ts.numeroEtiqueta;
            sentenciaIf.codigoP2 = "lab L" + ts.numeroEtiqueta;
            ts.numeroEtiqueta++;
            puntero += 2;
            sentenciaIf.HijoIzquierdo = Expresion();
            puntero += 2;
            List<Token> copiaLista = miListaTokenTemporal;
            miListaTokenTemporal = miListaTokenTemporal.GetRange(0, finIf + 1);
            sentenciaIf.HijoCentro = SecuenciaSentencias();
            if (miListaTokenTemporal.Count < copiaLista.Count)    // Else exists
            {
                sentenciaIf.codigoP3 = "ujp L" + ts.numeroEtiqueta;

                sentenciaIf.codigoP4 = "lab L" + ts.numeroEtiqueta;
                if (copiaLista[copiaLista.Count - 1].estado == -38 || copiaLista[copiaLista.Count - 1].estado == -35)
                {
                    return sentenciaIf;
                }
                miListaTokenTemporal = copiaLista;

                puntero = finIf + 3;
                sentenciaIf.HijoDerecho = SecuenciaSentencias();
            }
            return sentenciaIf;
        }

        public Arboles SenteciaFor()
        {
            var sentenciaFor = NuevoNodoSentencia(TipoSentencia.For);
            puntero += 3;
            sentenciaFor.HijoIzquierdo = SentenciaAsignacion();
            puntero += 3;
            sentenciaFor.HijoDerecho = Expresion();
            puntero -= 1;
            List<Token> forlist = ObtenerListaContenidoFor(miListaTokenTemporal);
            List<Token> miListaTokenTemporalOriginal = miListaTokenTemporal;
            miListaTokenTemporal = forlist;
            int punteroTemp = puntero;
            puntero = 0;
            sentenciaFor.HijoCentro = SecuenciaSentencias();
            puntero = punteroTemp + forlist.Count + 4;
            miListaTokenTemporal = miListaTokenTemporalOriginal;
            return sentenciaFor;
        }

        public List<Token> ObtenerListaContenidoFor(List<Token> lista)
        {
            //Obtener operacion de for
            int inicio = puntero;
            int index = puntero;
            while (lista[index].lexema != ")")
            {
                index++;
            }
            List<Token> listaOperacion = miListaTokenTemporal.GetRange(inicio, index - inicio);

            inicio = index + 2;
            int curlyBraces = 0;
            while (lista[index].lexema != "{")
            {
                index++;
            }
            index++;
            curlyBraces++;

            for (; index < lista.Count; index++)
            {
                if (lista[index].lexema == "{")
                {
                    curlyBraces++;
                }
                else if (lista[index].lexema == "}")
                {
                    curlyBraces--;
                }
                if (curlyBraces == 0)
                {
                    List<Token> listaOperaciones = miListaTokenTemporal.GetRange(inicio, index - inicio);
                    listaOperaciones.AddRange(listaOperacion);
                    return listaOperaciones;
                }
            }
            return null;
        }

        public Arboles SentenciaAsignacion()
        {
            var sentenciaAsignacion = NuevoNodoSentencia(TipoSentencia.Asignacion);
            if (miListaTokenTemporal[puntero + 1].lexema == "++" || miListaTokenTemporal[puntero + 1].lexema == "--")
            {
                sentenciaAsignacion.lexema = miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP = "lda " + miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP2 = "sto";
                Arboles i = NuevoNodoExpresion(TipoExpresion.Identificador);
                i.soyValorTipo = TipoValorNodo.Objeto;
                i.lexema = miListaTokenTemporal[puntero].lexema;

                Arboles d = NuevoNodoExpresion(TipoExpresion.Constante);
                d.soyValorTipo = TipoValorNodo.Entero;
                d.lexema = "1";

                Arboles op = NuevoNodoExpresion(TipoExpresion.Operador);
                if (miListaTokenTemporal[puntero + 1].lexema.Substring(0, 1) == "+")
                {
                    op.lexema = "+";
                    op.soyOperacion = Operaciones.Suma;
                }
                else
                {
                    op.lexema = "-";
                    op.soyOperacion = Operaciones.Resta;
                }

                op.HijoIzquierdo = i;
                op.HijoDerecho = d;

                sentenciaAsignacion.HijoIzquierdo = op;
                return sentenciaAsignacion;
            }
            else
            {
                if (puntero != 0 && new[] { -103, -107, -120, -126, -160}.Contains(miListaTokenTemporal[puntero - 1].estado))
                {
                    //insertar variable en tabla de simbolos
                    NodoVariables miVariable = new NodoVariables();
                    miVariable.Lexema = miListaTokenTemporal[puntero].lexema;
                    miVariable.MiTipo = TipoDato.Int;
                    miVariable.TipoVariable = TipoVariable.Primitive;

                    Estado estadoMetodo = ts.InsertarNodoVariable(miVariable, ts.ObtenerNodoClase(this.claseActiva), this.metodoActivo);
                    if (estadoMetodo == Estado.Duplicado)
                    {
                        //MessageBox.Show("Variable duplicada:'" + miListaTokenTemporal[puntero].lexema + "'. ", "Error  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Application.Exit();
                    }
                }

                sentenciaAsignacion.lexema = miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP = "lda " + miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP2 = "sto";

                puntero += 2;
                if (miListaTokenTemporal[puntero].lexema == "cin")
                {
                    sentenciaAsignacion.HijoIzquierdo = sentenciaAsignacion.SentenciaRead(sentenciaAsignacion.lexema);
                }
                else
                {
                    sentenciaAsignacion.HijoIzquierdo = SimpleExpresion();
                }

                return sentenciaAsignacion;
            }
        }
        public Arboles SentenciaAsignacion(bool soloAtributo)
        {
            var sentenciaAsignacion = NuevoNodoSentencia(TipoSentencia.Asignacion);
            if (miListaTokenTemporal[puntero + 1].lexema == "++" || miListaTokenTemporal[puntero + 1].lexema == "--")
            {
                sentenciaAsignacion.lexema = miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP = "lda " + miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP2 = "sto";

                Arboles i = NuevoNodoExpresion(TipoExpresion.Identificador);
                i.soyValorTipo = TipoValorNodo.Objeto;
                i.lexema = miListaTokenTemporal[puntero].lexema;

                Arboles d = NuevoNodoExpresion(TipoExpresion.Constante);
                d.soyValorTipo = TipoValorNodo.Entero;
                d.lexema = "1";

                Arboles op = NuevoNodoExpresion(TipoExpresion.Operador);
                if (miListaTokenTemporal[puntero + 1].lexema.Substring(0, 1) == "+")
                {
                    op.lexema = "+";
                    op.soyOperacion = Operaciones.Suma;
                }
                else
                {
                    op.lexema = "-";
                    op.soyOperacion = Operaciones.Resta;
                }

                op.HijoIzquierdo = i;
                op.HijoDerecho = d;

                sentenciaAsignacion.HijoIzquierdo = op;
                return sentenciaAsignacion;
            }
            else if (new[] { -103,-107,-120,-126,-160 }.Contains(miListaTokenTemporal[puntero].estado))
            {
                Arboles variable = new Arboles();
                variable.soyExpresionTipo = TipoExpresion.Nada;
                variable.soyOperacion = Operaciones.Nada;
                variable.soySentenciaTipo = TipoSentencia.Nada;
                variable.soyValorTipo = conversionLexemaTipo(miListaTokenTemporal[puntero].lexema);
                variable.tipoValorHijoDerecho = TipoValorNodo.Nada;
                variable.tipoValorHijoIzquierdo = TipoValorNodo.Nada;
                variable.lexema = miListaTokenTemporal[puntero + 1].lexema;
                return variable;
            }
            else
            {
                sentenciaAsignacion.lexema = miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP = "lda " + miListaTokenTemporal[puntero].lexema;
                sentenciaAsignacion.codigoP2 = "sto";

                puntero += 2;
                if (miListaTokenTemporal[puntero].lexema == "read")
                {
                    sentenciaAsignacion.HijoIzquierdo = SentenciaRead(sentenciaAsignacion.lexema);
                }
                else
                {
                    sentenciaAsignacion.HijoIzquierdo = SimpleExpresion();

                }
                return sentenciaAsignacion;
            }
        }

        public TipoValorNodo conversionLexemaTipo(string lexema)
        {
            switch (lexema)
            {
                case "int":
                    return TipoValorNodo.Entero;
                case "string":
                    return TipoValorNodo.Cadena;
                case "char":
                    return TipoValorNodo.Caracter;
                case "float":
                    return TipoValorNodo.Flotante;
                case "boolean":
                    return TipoValorNodo.Booleano;
                

                default:
                    //MessageBox.Show("Tipo invalido. ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return TipoValorNodo.Nada;
            }

        }

        public Arboles SimpleExpresion()
        {
            Arboles nodoRaiz = Termino();
            while (miListaTokenTemporal[puntero].lexema.Equals("+")
                || miListaTokenTemporal[puntero].lexema.Equals("-"))
            {
                Arboles nodoTemp = NuevoNodoExpresion(TipoExpresion.Operador);
                nodoTemp.HijoIzquierdo = nodoRaiz;
                nodoTemp.soyOperacion =
                    miListaTokenTemporal[puntero].lexema.Equals("+")
                    ? Operaciones.Suma
                    : Operaciones.Resta;
                nodoTemp.codigoP =
                    miListaTokenTemporal[puntero].lexema.Equals("+")
                    ? "add"
                    : "sbi";
                nodoTemp.lexema = miListaTokenTemporal[puntero].lexema;
                nodoRaiz = nodoTemp;
                puntero++;
                nodoRaiz.HijoDerecho = Termino();
            }

            return nodoRaiz;
        }
        public Arboles Termino()
        {
            Arboles t = Factor();
            while (miListaTokenTemporal[puntero].lexema.Equals("*")
                 || miListaTokenTemporal[puntero].lexema.Equals("/"))
            {
                Arboles p = NuevoNodoExpresion(TipoExpresion.Operador);
                p.HijoIzquierdo = t;
                p.soyOperacion = miListaTokenTemporal[puntero].lexema.Equals("*")
                    ? Operaciones.Multiplicacion
                    : Operaciones.Division;
                p.lexema = miListaTokenTemporal[puntero].lexema.Equals("*")
                    ? "*"
                    : "/";
                p.codigoP = miListaTokenTemporal[puntero].lexema.Equals("*")
                    ? "mpi"
                    : "div";
                //t.lexema = miListaTokenTemporal[puntero].Lexema;
                t = p;
                puntero++;
                t.HijoDerecho = Factor();
            }
            return t;
        }
        public Arboles Factor()
        {
            Arboles t = new Arboles();
            t.ts = ts;
            t.claseActiva = this.claseActiva;
            t.metodoActivo = this.metodoActivo;

            if (miListaTokenTemporal[puntero].estado == -1)
            {
                
                t = NuevoNodoExpresion(TipoExpresion.Constante);
                t.codigoP = "ldc " + miListaTokenTemporal[puntero].lexema;
                t.soyValorTipo = TipoValorNodo.Entero;
                t.lexema = miListaTokenTemporal[puntero].lexema;
                puntero++;
            }
            if (miListaTokenTemporal[puntero].estado == -2)
            {
                t = NuevoNodoExpresion(TipoExpresion.Constante);
                t.codigoP = "ldc " + miListaTokenTemporal[puntero].lexema;
                t.lexema = miListaTokenTemporal[puntero].lexema;
                t.soyValorTipo = TipoValorNodo.Flotante;
                puntero++;
            }
            if (miListaTokenTemporal[puntero].estado == -5)
            {
                t = NuevoNodoExpresion(TipoExpresion.Constante);
                
                t.lexema = miListaTokenTemporal[puntero].lexema;
                t.codigoP = "ldc " + miListaTokenTemporal[puntero].lexema;
                t.soyValorTipo = TipoValorNodo.Cadena;
                puntero += 2;
            }
            else if (miListaTokenTemporal[puntero].estado == -4)
            {
                t = NuevoNodoExpresion(TipoExpresion.Identificador);
                t.lexema = miListaTokenTemporal[puntero].lexema;
                t.codigoP = "lod " + miListaTokenTemporal[puntero].lexema;
                //Crear metodos ObtenerNodoClase y ObtenerNodoVariable en Semantico
                t.soyValorTipo = ConversionTipoDatoTipoValorNodo(ts.TipoNodoVariable(ts.ObtenerNodoClase(claseActiva), metodoActivo, t.lexema));
                var valor = ts.ObtenerNodoVariable(t.lexema, metodoActivo, ts.ObtenerNodoClase(claseActiva));
                if (valor == null)
                {
                    //checar
                    //MessageBox.Show("Variable'" + t.lexema + "' no ha sido definida previamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Application.Exit();
                }
                else
                {
                    t.valorNodo = ts.ObtenerNodoVariable(t.lexema, metodoActivo, ts.ObtenerNodoClase(claseActiva)).Valor;
                }
                puntero++;
            }
            else if (miListaTokenTemporal[puntero].lexema.Equals("("))
            {
                puntero++;
                t = SimpleExpresion();
                puntero++;
            }
            return t;
        }
        public TipoValorNodo ConversionTipoDatoTipoValorNodo(TipoDato tipo)
        {
            switch (tipo)
            {
                case TipoDato.Int:
                    return TipoValorNodo.Entero;
                case TipoDato.Float:
                    return TipoValorNodo.Flotante;
                case TipoDato.Boolean:
                    return TipoValorNodo.Booleano;
                case TipoDato.String:
                    return TipoValorNodo.Cadena;
                case TipoDato.NADA:
                    return TipoValorNodo.Nada;
                default:
                    return TipoValorNodo.Nada;
            }
        }
        public Arboles NuevoNodoExpresion(TipoExpresion tipo)
        {
            Arboles t = new Arboles();
            t.ts = ts;
            t.claseActiva = this.claseActiva;
            t.metodoActivo = this.metodoActivo;
            t.soyExpresionTipo = tipo;
            t.soyTipoNodo = TipoNodoArbol.Expresion;
            t.soySentenciaTipo = TipoSentencia.Nada;
            t.soyValorTipo = TipoValorNodo.Nada;
            t.tipoValorHijoDerecho = TipoValorNodo.Nada;
            t.tipoValorHijoIzquierdo = TipoValorNodo.Nada;
            t.soyOperacion = Operaciones.Nada;
            return t;
        }

        public Arboles NuevoNodoSentencia(TipoSentencia tipoSentencia)
        {
            Arboles t = new Arboles();
            t.ts = ts;
            t.claseActiva = this.claseActiva;
            t.metodoActivo = this.metodoActivo;
            t.soyTipoNodo = TipoNodoArbol.Sentencia;
            t.soySentenciaTipo = tipoSentencia;
            t.soyValorTipo = TipoValorNodo.Nada;
            t.tipoValorHijoDerecho = TipoValorNodo.Nada;
            t.tipoValorHijoIzquierdo = TipoValorNodo.Nada;
            t.soyOperacion = Operaciones.Nada;
            t.soyExpresionTipo = TipoExpresion.Nada;

            return t;
        }
        #endregion




    }
}
