using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi
{
	public class TablaSimbolos
	{
		Dictionary<object, NodoClase> tablaSimbolosClase = new Dictionary<object, NodoClase>();

		public int sobrecargas = 0;
		public int numeroEtiqueta = 1;

		/// <summary>
		/// Insertar Nodos Clase en la TS de Clase
		/// </summary>
		/// <param name="miNodoClase">Objeto de tipo NodoClase</param>
		/// <returns>El estado de insertado o duplicado</returns>
		public Estado InsertarNodoClase(NodoClase miNodoClase)
		{
			if (!tablaSimbolosClase.ContainsKey(miNodoClase.Lexema))
			{
				tablaSimbolosClase.Add(miNodoClase.Lexema, miNodoClase);
				return Estado.Insertado;
			}
			else
			{
				return Estado.Duplicado;
			}

		}
		public bool ExisteClaseHeredada(string lexema)
		{
			if (tablaSimbolosClase.ContainsKey(lexema))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	public class NodoClase
	{
		private string lexema;
		private NodoClase herencia;
		private int renglonDeclaracion;
		private int[] referencias;

		#region Encapsulamiento NodoClase
		public string Lexema
		{
			get
			{
				return lexema;
			}

			set
			{
				lexema = value;
			}
		}

		public NodoClase Herencia
		{
			get
			{
				return herencia;
			}

			set
			{
				herencia = value;
			}
		}

		public int RenglonDeDeclaracion
		{
			get
			{
				return renglonDeclaracion;
			}

			set
			{
				renglonDeclaracion = value;
			}
		}

		public int[] Referencias
		{
			get
			{
				return referencias
					;
			}

			set
			{
				referencias = value;
			}
		}

		#endregion


		private Dictionary<object, NodoAtributo> TSA = new Dictionary<object, NodoAtributo>();
	}
	public class NodoAtributo
	{
		private string lexema;
		private Alcance miAlcance;
		private TipoDato miTipo;
		private string valor;
		private string memoria;

		#region Encapsulamiento NodoAtributo
		public string Lexema
		{
			get
			{
				return lexema;
			}

			set
			{
				lexema = value;
			}
		}
		public Alcance MiAlcance
		{
			get
			{
				return miAlcance;
			}

			set
			{
				miAlcance = value;
			}
		}
		public TipoDato MiTipo
		{
			get
			{
				return miTipo;
			}

			set
			{
				miTipo = value;
			}
		}
		public string Valor
		{
			get
			{
				return valor;
			}

			set
			{
				valor = value;
			}
		}
		public string Memoria
		{
			get
			{
				return memoria;
			}

			set
			{
				memoria = value;
			}
		}
		#endregion


	}
	public class NodoMetodo
	{
		private string lexema;
		private Alcance miAlcance;
		private Regreso miRegreso;

		#region Encapsulamiento NodoMetodo
		public string Lexema
		{
			get
			{
				return lexema;
			}

			set
			{
				lexema = value;
			}
		}
		public Alcance MiAlcance
		{
			get
			{
				return miAlcance;
			}

			set
			{
				miAlcance = value;
			}
		}
		public Regreso MiRegreso
		{
			get
			{
				return miRegreso;
			}

			set
			{
				miRegreso = value;
			}
		}

		#endregion

		public Dictionary<object, NodoVariables> TablaSimbolosVariables = new Dictionary<object, NodoVariables>();
	}
	public class NodoVariables
	{
		private Alcance miAlcance;
		private string lexema;
		private TipoDato miTipo;
		private string valor;
		private TipoVariable tipoVariable;

		#region Encapsulamiento NodoVariables
		
		public Alcance MiAlcance
		{
			get
			{
				return miAlcance;
			}

			set
			{
				miAlcance = value;
			}
		}
		public string Lexema
		{
			get
			{
				return lexema;
			}

			set
			{
				lexema = value;
			}


		}
		public TipoDato MiTipo
		{
			get
			{
				return miTipo;
			}

			set
			{
				miTipo = value;
			}


		}
		public string Valor
		{
			get
			{
				return valor;
			}

			set
			{
				valor = value;
			}


		}
		public TipoVariable TipoVariable
		{
			get
			{
				return TipoVariable;
			}

			set
			{
				tipoVariable = value;
			}


		}
		
		#endregion
	}

	#region Alcance, Tipo de Datos, Tipo Variables, Estados

	public enum Alcance
	{
		Public,
		Private,
		Protected
	}
	public enum TipoDato
	{
		Int,
		Float,
		String,
		Char,
		Boolean,
		NADA
	}
	public enum Estado
	{
		Insertado,
		Duplicado,
		DuplicadoVariableMetodo,
		DuplicadoAtributoConClase,
		DuplicadoMetodoConClase
	}
	public enum Regreso
	{
		Void,
		Int,
		String,
		Char,
		Boolean
	}
	public enum TipoVariable
	{
		Reference,
		Primitive
	}

	#endregion

}
