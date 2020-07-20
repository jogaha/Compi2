using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi
{
	public class Token
	{
		public int estado;
		public int linea;
		public string lexema;

		public Token(int estado, int linea, string lexema)
		{
			this.estado = estado;
			this.lexema = lexema;
			this.linea = linea;
		}
	}
	public class Lexico
	{

		public List<Token> ListaTokens;

        public int[,] MT = new int[,]
         {/*        0		1        2		 3      4      5      6      7      8      9 	  10      11      12      13      14       15      16      17      18      19      20      21      22      23      24      25      26      27      28       29		  30     */
		  /*  ||   0-9  ||	.	||  A-Z  ||  _  ||  "  ||  '  ||  &  ||  |  ||  !  ||  =  ||  <   ||  >   ||  %   ||  :   ||   #   ||  [   ||  ]   ||  (   ||  )   ||  {   ||  }   ||  ;   ||  ,   ||  *   ||  -   ||  +   ||  /   || LEOF ||  OC  ||  SPACE ||  ENTER   */
		  /*																																																														     */

/*	0	*/	  {		1	,    6   ,   7   ,   8   ,  10  ,  11  ,  14  ,  15  ,  16  ,  17  ,  18   ,  19   ,  20   , -20  ,   21   ,  -21   , -22   , -23  ,  -24  ,  -25   , -26  ,  -27   , -30   ,  22   ,  23   ,  24   ,  25   ,   0   , -407  ,    0    ,     0    },
/*	1	*/	  {		1   ,    3   ,   2   ,   2   ,   2  ,   2  ,   2  ,   2  ,   2  ,  -1  ,  -1   ,  -1   ,  -1   ,  -1  ,    2   ,    2   ,  -1   ,   2  ,   -1  ,   2    ,  -1  ,   -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,  -1   ,   2   ,   -1    ,    -1    },
/*	2	*/	  {		2   ,  -400  ,   2   ,   2   ,   2  ,   2  ,   2  ,   2  ,   2  , -400 , -400  , -400  , -400  , -400 ,    2   ,    2   , -400  ,   2  ,  -400 ,    2   , -400 ,  -400  , -400  , -400  , -400  , -400  , -400  , -400  ,   2   ,  -400   ,   -400   },
/*	3	*/	  {		5   ,  -401  ,   4   ,   4   ,   4  ,   4  ,   4  ,   4  ,   4  , -401 , -401  , -401  , -401  ,   4  ,    4   ,    4   , -401	,   4  ,  -401 ,    4   , -401 ,  -401  , -401  , -401  , -401  , -401  , -401  , -401  ,   4   ,  -401   ,   -401   },
/*	4	*/	  {		4   ,  -401  ,   4   ,   4   ,   4  ,   4  ,   4  ,   4  ,   4  , -401 , -401  , -401  , -401  ,   4  ,    4   ,    4   , -401  ,   4  ,  -401 ,    4   , -401 ,  -401  , -401  , -401  , -401  , -401  , -401  , -401  ,   4   ,  -401   ,   -401   },
/*	5	*/	  {		5   ,    4   ,   4   ,   4   ,   4  ,   4  ,   4  ,   4  ,   4  ,  -2  ,  -2   ,  -2   ,  -2   ,   4  ,    4   ,    4   ,  -2   ,   4  ,   -2  ,    4   ,  -2  ,   -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,  -2   ,   4   ,   -2    ,    -2    },
/*	6	*/	  {		5   ,   -3   ,  -3   ,  -3   ,  -3  ,  -3  ,  -3  ,  -3  ,  -3  ,  -3  ,  -3   ,  -3   ,  -3   ,  -3  ,   -3   ,   -3   ,  -3   ,  -3  ,   -3  ,   -3   ,  -3  ,   -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,  -3   ,   -3    ,    -3    },
/*	7	*/	  {		7   ,   -4   ,   7   ,   8   ,   9  ,   9  ,   9  ,   9  ,   9  ,  -4  ,  -4   ,  -4   ,  -4   ,  -4  ,    9   ,   -4   ,   9   ,  -4  ,   -4  ,   -4   ,   9  ,   -4   ,  -4   ,  -4   ,  -4   ,  -4   ,  -4   ,  -4   ,   9   ,   -4    ,    -4    },
/*	8	*/	  {		7   ,    9   ,   7   ,   9   ,   9  ,   9  ,   9  ,   9  ,   9  ,   9  ,   9   ,   9   ,   9   ,   9  ,    9   ,    9   ,   9   ,   9  ,    9  ,    9   ,   9  ,    9   ,   9   ,   9   ,   9   ,   9   ,   9   , -402  ,   9   ,  -402   ,   -402   },
/*	9	*/	  {		9   ,  -402  ,   9   ,   9   ,   9  ,   9  ,   9  ,   9  ,   9  , -402 , -402  , -402  , -402  ,   9  ,    9   ,  -402  , -402  , -402 ,  -402 ,  -402  , -402 ,  -402  , -402  , -402  , -402  , -402  , -402  , -402  ,   9   ,  -402   ,   -402   },
/*  10	*/	  {    10   ,   10   ,  10   ,  10   ,  -5  ,  10  ,  10  ,  10  ,  10  ,  10  ,  10   ,  10   ,  10   ,  10  ,   10   ,   10   ,  10   ,  10  ,   10  ,   10   ,  10  ,   10   ,  10   ,  10   ,  10   ,  10   ,  10   , -403  ,  10   ,   10    ,   -403   },
/*  11	*/	  {	   12	,   12   ,  12   ,  12   ,  12  ,  -6  ,  12  ,  12  ,  12  ,  12  ,  12   ,  12   ,  12   ,  12  ,   12   ,   12   ,  12   ,  12  ,   12  ,   12   ,  12  ,   12   ,  12   ,  12   ,  12   ,  12   ,  12   , -404  ,  12   ,   12    ,   -404   },
/*  12	*/	  {	   13	,   13   ,  13   ,  13   ,  13  ,  -6  ,  13  ,  13  ,  13  ,  13  ,  13   ,  13   ,  13   ,  13  ,   13   ,   13   ,  13   ,  13  ,   13  ,   13   ,  13  ,   13	,  13   ,  13   ,  13   ,  13   ,  13   , -404  ,  13   ,   13    ,   -404   },
/*  13  */	  {    13   ,   13   ,  13   ,  13   ,  13  ,  13  ,  13  ,  13  ,  13  ,  13  ,  13   ,  13   ,  13   ,  13  ,   13   ,   13   ,  13   ,  13  ,   13  ,   13   ,  13  ,   13   ,  13   ,  13   ,  13   ,  13   ,  13   , -404  ,  13   ,   13    ,   -404   },
/*	14	*/	  {	  -405	,  -405  , -405  , -405  , -405 , -405 ,  -7  , -405 , -405 , -405 , -405  , -405  , -405  , -405 ,  -405  , - 405  , -405  , -405 ,  -405 ,  -405  , -405 ,  -405  , -405  , -405  , -405  , -405  , -405  , -405  , -405  ,  -405   ,   -405   },
/*	15	*/	  {   -405  ,  -405  , -405  , -405  , -405 , -405 , -405 ,  -8  , -405 , -405 , -405  , -405  , -405  , -405 ,  -405  , - 405  , -405  , -405 ,  -405 ,  -405  , -405 ,  -405  , -405  , -405  , -405  , -405  , -405  , -405  , -405  ,  -405   ,   -405   },
/*	16	*/	  {   -405  ,  -405  , -405  , -405  , -405 , -405 , -405 , -405 ,  -9  , -405 , -405  , -405  , -405  , -405 ,  -405  , - 405  , -405  , -405 ,  -405 ,  -405  , -405 ,  -405  , -405  , -405  , -405  , -405  , -405  , -405  , -405  ,  -405   ,   -405   },
/*	17	*/	  {	  -10	,  -10   , -10   , -10   , -10  , -10  , -10  , -10  , -10  , -11  , -10   , -10   , -10   , -10  ,  -10   ,  -10   , -10   , -10  ,  -10  ,  -10   , -10  ,  -10   , -10   , -10   , -10   , -10   , -10   , -10   , -10   ,  -10    ,   -10    },
/*	18	*/	  {   -12	,  -12   , -12   , -12   , -12  , -12  , -12  , -12  , -12  , -13  , -14   , -12   , -12   , -12  ,  -12   ,  -12   , -12   , -12  ,  -12  ,  -12   , -12  ,  -12   , -12   , -12   , -12   , -12   , -12   , -12   , -12   ,  -12    ,   -12    },
/*	19	*/	  {	  -15	,  -15   , -15   , -15   , -15  , -15  , -15  , -15  , -15  , -16  , -15   , -17   , -15   , -15  ,  -15   ,  -15   , -15   , -15  ,  -15  ,  -15   , -15  ,  -15   , -15   , -15   , -15   , -15   , -15   , -15   , -15   ,  -15    ,	  -15	 },
/*	20	*/	  {	  -18	,  -18   , -18   , -18   , -18  , -18  , -18  , -18  , -18  , -19  , -18   , -18   , -18   , -18  ,  -18   ,  -18   , -18   , -18  ,  -18  ,  -18   , -18  ,  -18   , -18   , -18   , -18   , -18   , -18   , -18   , -18   ,  -18    ,   -18    },
/*	21	*/	  {   -28	,  -28   , -28   , -28   , -28  , -28  , -28  , -28  , -28  , -28  , -28   , -28   , -28   , -28  ,  -29   ,  -28   , -28   , -28  ,  -28  ,  -28   , -28  ,  -28   , -28   , -28   , -28   , -39   , -28   , -28   , -28   ,  -28    ,   -28    },
/*	22	*/	  {	  -31	,  -31   , -31   , -31   , -31  , -31  , -31  , -31  , -31  , -32  , -31   , -31   , -31   , -31  ,  -31   ,  -31   , -31   , -31  ,  -31  ,  -31   , -31  ,  -31   , -31   , -31   , -31   , -31   , -31   , -31   , -31   ,  -31    ,   -31    },
/*	23	*/	  {	  -33	,  -33   , -33   , -33   , -33  , -33  , -33  , -33  , -33  , -34  , -33   , -33   , -33   , -33  ,  -33   ,  -33   , -33   , -33  ,  -33  ,  -33   , -33  ,  -33   , -33   , -33   , -35   , -33   , -33   , -33   , -33   ,  -33    ,   -33    },
/*	24	*/	  {	  -36	,  -36   , -36   , -36   , -36  , -36  , -36  , -36  , -36  , -37  , -36   , -36   , -36   , -36  ,  -36   ,  -36   , -36   , -36  ,  -36  ,  -36   , -36  ,  -36   , -36   , -36   , -36   , -38   , -36   , -36   , -36   ,  -36    ,   -36    },
/*	25	*/	  {	  -39	,  -39   , -39   , -39   , -39  , -39  , -39  , -39  , -39  , -40  , -39   , -39   , -39   , -39  ,  -39   ,  -39   , -39   , -39  ,  -39  ,  -39   , -39  ,  -39   , -39   ,  26   , -39   , -39   ,  28   , -39   , -39   ,  -39    ,   -39    },
/*	26	*/	  {	   26	,   26   ,  26   ,  26   ,  26  ,  26  ,  26  ,  26  ,  26  ,  26  ,  26   ,  26   ,  26   ,  26  ,   26   ,   26   ,  26   ,  26  ,   26  ,   26   ,  26  ,   26   ,  26   ,  27   ,  26   ,  26   ,  26   , -406  ,  26   ,   26    ,    26    },
/*	27	*/	  {    26   ,   26   ,  26   ,  26   ,  26  ,  26  ,  26  ,  26  ,  26  ,  26  ,  26   ,  26   ,  26   ,  26  ,   26   ,   26   ,  26   ,  26  ,   26  ,   26   ,  26  ,   26   ,  26   ,  26   ,  26   ,  26   ,   0   , -406  ,  27   ,   26    ,    26    },
/*	28	*/	  {	   28	,   28   ,  28  ,   28   ,  28  ,  28  ,  28  ,  28  ,  28  ,  28  ,  28   ,  28   ,  28   ,  28  ,   28   ,   28   ,  28   ,  28  ,   28  ,   28   ,  28  ,   28   ,  28   ,  28   ,  28   ,  28   ,  28   ,   0   ,  28   ,   28    ,     0    },
			
			/*      0		1        2		 3      4      5      6      7      8      9 	  10      11      12      13      14       15      16      17      18      19      20      21      22      23      24      25      26      27      28       29		  30     */
		  /*  ||   0-9  ||	.	||  A-Z  ||  _  ||  "  ||  '  ||  &  ||  |  ||  !  ||  =  ||  <   ||  >   ||  %   ||  :   ||   #   ||  [   ||  ]   ||  (   ||  )   ||  {   ||  }   ||  ;   ||  ,   ||  *   ||  -   ||  +   ||  /   || LEOF ||  OC  ||  SPACE ||  ENTER   */

		 };

		public string[,] PalabrasReservadas = new string[,]
		{
			{"asm","-101"},         {"default","-111"},     {"for","-121"},         {"operator","-131"},        {"struc","-141"},       {"unsigned","-151"},        {"Iostream","-161"},
			{"auto","-102"},        {"delete","-112"},      {"friend","-122"},      {"private","-132"},         {"switch","-142"},      {"using","-152"},           {"Mathe","-162"},
			{"bool","-103"},        {"do","-113"},          {"goto","-123"},        {"protected","-133"},       {"template","-143"},    {"virtual","-153"},         {"endl","-163"},
			{"break","-104"},       {"double","-114"},      {"if","-124"},          {"public","-134"},          {"this","-144"},        {"void","-154"},            {"finally","-164"},
			{"case","-105"},        {"else","-115"},        {"inline","-125"},      {"register","-135"},        {"throw","-145"},       {"volatile","-155"},        {"cin","-165"},
			{"catch","-106"},       {"enum","-116"},        {"int","-126"},         {"return","-136"},          {"true","-146"},        {"while","-156"},
			{"char","-107"},        {"explicit","-117"},    {"long","-127"},        {"short","-137"},           {"try","-147"},         {"abstract","-157"},
			{"class","-108"},       {"extern","-118"},      {"mutable","-128"},     {"signed","-138"},          {"typedef","-148"},     {"cout","-158"},
			{"const","-109"},       {"false","-119"},       {"namespace","-129"},   {"sizeof","-139"},          {"typename","-149"},    {"include","-159"},
			{"continue","-110"},    {"float","-120"},       {"new","-130"},         {"static","-140"},          {"union","-150"},       {"string","-160"}
		};

		public string[,] Errores = new string[,]
		{
			{"Formato de numero entero invalido",       "-400"},
			{"Formato de numero decimal invalido",      "-401"},
			{"Formato de identificador invalido",       "-402"},
			{"Formato de cadena invalido",              "-403"},
			{"Formato de caracter invalido",            "-404"},
			{"Formato de operador invalido",			"-405"},
			{"Formato de comentario invalido",			"-406"},
			{"Simbolo desconocido",                     "-407"},
			{"Error sintactico, se esperaba un :",		"-450"},
		};

		int[] DelimitadorPalabra = new int[]
		{-400, -1, -401, -2, -3, -4, -402, -36, -33, -31, -28, -12, -15, -10, -39, -18};

		char SiguienteCaracter(string Texto, int index)
		{
			return Convert.ToChar(Texto.Substring(index, 1));
		}

		bool SeUsoDelimitadorPalabra(int estado)
		{
			for (int i = 0; i < DelimitadorPalabra.Length; i++)
			{
				if (estado == DelimitadorPalabra[i])
				{
					return true;
				}
			}
			return false;
		}
		public int linea;
		public List<Token> Ejecutar(string Texto)
		{
			linea = 1;
			ListaTokens = new List<Token>();

			int estado = 0; //fila
			int columna = 0;
			string lexema = "";
			char caracter;

			for (int i = 0; i < Texto.Length; i++)
			{

				#region Busqueda de Columna y Estado
				caracter = SiguienteCaracter(Texto, i);
				if (char.IsDigit(caracter))
				{
					columna = 0;
				}
				else if (char.IsLetter(caracter))
				{
					columna = 2;
				}
				else
				{

					switch (caracter)
					{
						case '.': columna = 1; break;
						case '_': columna = 3; break;
						case '"': columna = 4; break;
						case '\'': columna =5; break;
						case '&': columna = 6; break;
						case '|': columna = 7; break;
						case '!': columna = 8; break;
						case '=': columna = 9; break;
						case '<': columna = 10; break;
						case '>': columna = 11; break;
						case '%': columna = 12; break;
						case ':': columna = 13; break;
						case '#': columna = 14; break;
						case '[': columna = 15; break;
						case ']': columna = 16; break;
						case '(': columna = 17; break;
						case ')': columna = 18; break;
						case '{': columna = 19; break;
						case '}': columna = 20; break;
						case ';': columna = 21; break;
						case ',': columna = 22; break;
						case '*': columna = 23; break;
						case '-': columna = 24; break;
						case '+': columna = 25; break;
						case '/': columna = 26; break;
						case (char)165:columna = 27; break;//LEOF  (SIMBOLO UTILIZADO PARA RECONOCER EL FINAL DEL MENSAJE) ¥
						default: columna = 28; break;   // Otra Cosa
						case '\t': columna = 29; break;
						case ' ': columna = 29; break;	// Space
						case '\n': columna = 30; break;    // Enter
						case '\r': columna = 30; break;
					}
				}
				estado = MT[estado, columna];
				#endregion

				lexema += caracter;
				if (lexema == "\n")
				{
					linea++;
				}
				if (estado == 0)
				{
					lexema = "";
				}
				if (estado < 0)
				{
					if (SeUsoDelimitadorPalabra(estado))
					{
						lexema = lexema.Substring(0, lexema.Length - 1);
						i--;
					}
					if (estado <= -400)
					{
						//Se encontro error, se envia en la lista de tokens
						for (int k = 0; k < Errores.GetLength(0); k++)
						{
							if (estado == Convert.ToInt32(Errores[k, 1]))
							{
								lexema = Errores[k, 0];
							}
						}
					}
					else if (estado == -4)
					{
						// Aqui revisamos si el identificador es en realidad un 
						//identificador y si no es una palabra reservada
						for (int j = 0; j < PalabrasReservadas.GetLength(0); j++)
						{
							if (lexema == PalabrasReservadas[j, 0])
							{
								estado = Convert.ToInt32(PalabrasReservadas[j, 1]);
							}
						}
					}
					ListaTokens.Add(new Token(estado, linea, lexema));
					lexema = "";
					estado = 0;
				}
			}
			return ListaTokens;
		}
	}
}

	
