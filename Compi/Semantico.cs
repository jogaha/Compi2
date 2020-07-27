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
	}

	public class NodoClase
	{
		private string lexema;
		private NodoClase herencia;
		private int renglonDeclaracion;
		private int[] referencias;

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

		private Dictionary<object, NodoAtributo> TSA = new Dictionary<object, NodoAtributo>();
	}
	public class NodoAtributo
	{
		public string lexema;
		public Alcance miAlcance;
		public TipoDato miTipo;
		public string valor;
		public string memoria;
	}
	public class NodoMetodo
	{
		public string lexema;
		public Alcance miAlcance;
		public Regreso miRegreso;
		public Dictionary<object, NodoVariables> TablaSimbolosVariables =
			new Dictionary<object, NodoVariables>();
	}
	public class NodoVariables
	{
		public Alcance miAlcance;
		public string lexema;
		public TipoDato miTipo;
		public string valor;
		public TipoVariable tipoVariable;
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
