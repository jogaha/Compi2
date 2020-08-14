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
    }
}
//        public Arboles SecuenciaSentencias()
//        {
//            Arboles t = Sentencia();
//            puntero++;
//            while (puntero < miListaTokenTemporal.Count - 1)
//            {
//                t = insertarNodo(t, Sentencia());
//                puntero++;
//            }
//            return t;
//        }

//		private Arboles Sentencia()
//		{
//            Arboles nodoRaiz = new NodoArbol();
//            bool secuencia = true;
//            switch (miListaTokenTemporal[puntero].estado)
//            {
//                case -124:
//                    nodoRaiz = SentenciaIf();
//                    break;

//                case -121:
//                    nodoRaiz = SenteciaFor();
//                    break;

//                case -158:
//                    nodoRaiz = SentenciaWrite(true);
//                    break;
//            }
//        }
//        if (puntero)
//	{

//	}
//	}
//}
