using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compi
{
	public enum Alcance {
		Public,
		Private,
		Protected
	}

	public class NodoClase
	{
		private string lexema;
		private string herencia;
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

		public string Herencia
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
	}
	class Semantico
	{
	}
}
