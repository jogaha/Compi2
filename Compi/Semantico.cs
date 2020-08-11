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

		#region Metodos TS Clase
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
		#endregion

		#region Metodos TS Atributo
		internal Estado InsertarNodoAtributo(NodoAtributo nodo, NodoClase nodoClaseActiva)
		{
			if (nodoClaseActiva.Lexema != nodo.Lexema)
			{
				if (!nodoClaseActiva.TSA.ContainsKey(nodo.Lexema))
				{
					nodoClaseActiva.TSA.Add(nodo.Lexema, nodo);
					return Estado.Insertado;
				}
				else
				{
					//Mandar error atributo duplicado
					return Estado.Duplicado;
				}
			}
			else
			{
				return Estado.DuplicadoAtributoConClase;
				//Mandar error de nombre del atributo igual al nombre de su clase
			}
		}
		#endregion

		#region Metodos TS Metodos
		public Tuple<Estado,string> InsertarNodoMetodo(NodoMetodo nodo, List<NodoVariables> misParametros, NodoClase nodoClaseActiva)
		{
			if (nodoClaseActiva.Lexema != nodo.Lexema)
			{
				//Checar que no existe un nombre de atributo igual al nombre del metodo

				if (!nodoClaseActiva.TSM.ContainsKey(nodo.Lexema))
				{
					if (misParametros != null)
					{
						//Checar que el nombre del parametro no exista
						foreach (var item in misParametros)
						{
							int iguales = 0;
							foreach (var parametro in misParametros)
							{
								if (parametro.Lexema == item.Lexema)
								{
									iguales++;
									if (iguales > 1)
									{
										return Tuple.Create(Estado.DuplicadoVariableMetodo, nodo.Lexema);
									}
								}
							}
							nodo.TSV.Add(item.Lexema, item);
						}
						nodoClaseActiva.TSM.Add(nodo.Lexema, nodo);
						return Tuple.Create(Estado.Insertado, nodo.Lexema);
					}
					return Tuple.Create(Estado.Insertado, nodo.Lexema);
				}
				else
				{
					// sobrecarga de metodos
					List<NodoVariables> listaParametros = ObtenerParametrosMetodo(nodo.Lexema, nodoClaseActiva,true);
					if (listaParametros.Count != misParametros.Count)
					{
						if (misParametros.Count != 0)
						{
							//Checar que el nombre del parametro no exista
							foreach (var item in misParametros)
							{
								int iguales = 0;
								foreach (var parametro in misParametros)
								{
									if (parametro.Lexema == item.Lexema)
									{
										iguales++;
										if (iguales > 1)
										{
											return Tuple.Create(Estado.DuplicadoVariableMetodo, "null");
										}
									}
								}
								nodo.TSV.Add(item.Lexema, item);
							}
							Random randomNumber = new Random();
							string nombreMetodo = nodo.Lexema + "@" + randomNumber.Next(10000, 99999);
							nodo.Lexema = nombreMetodo;
							nodoClaseActiva.TSM.Add(nombreMetodo, nodo);
							return Tuple.Create(Estado.Insertado, nombreMetodo);
						}
						else
						{
							if (listaParametros.Count == 0)
							{
								return Tuple.Create(Estado.DuplicadoVariableMetodo, "null");
							}
							else
							{
								Random randomNum = new Random();
								string nombreM = nodo.Lexema + "@" + randomNum.Next(10000, 99999);
								nodo.Lexema = nombreM;
								nodoClaseActiva.TSM.Add(nombreM, nodo);
								return Tuple.Create(Estado.Insertado, nombreM);
							}
						}
					}
					Boolean duplicado = true;
					for (int i = 0; i < misParametros.Count; i++)
					{
						if (misParametros[i].Lexema != listaParametros[i].Lexema || misParametros[i].MiTipo != listaParametros[i].MiTipo)
						{
							duplicado = false;
						}
					}
					if (duplicado)
					{
						return Tuple.Create(Estado.Duplicado, "null");
					}
					if (misParametros != null)
					{
						//Checa que el nombre del parametro no exite
						foreach (var item in misParametros)
						{
							int iguales = 0;
							foreach (var parametro in misParametros)
							{
								if (parametro.Lexema == item.Lexema)
								{
									iguales++;
									if (iguales > 1)
									{
										return Tuple.Create(Estado.DuplicadoVariableMetodo, "null");
									}
								}
							}
							nodo.TSV.Add(item.Lexema, item);
						}
					}
					sobrecargas++;
					string nombre = nodo.Lexema + "@" + sobrecargas;
					nodo.Lexema = nombre;
					nodoClaseActiva.TSM.Add(nombre, nodo);
					return Tuple.Create(Estado.Insertado, nombre);
				}
			}
			else
			{
				return Tuple.Create(Estado.DuplicadoMetodoConClase, nodo.Lexema);
			}
		}

		public List<NodoMetodo> ObtenerParametrosMetodos(string lexema, NodoClase nodoClaseActiva)
		{
			var non = nodoClaseActiva.TSM.Values;
			List<NodoMetodo> listaMetodos = new List<NodoMetodo>();
			foreach (var metodo in non)
			{
				if (metodo.Lexema.Length >= lexema.Length)
				{
					if (metodo.Lexema.Substring(0, lexema.Length) == lexema)
					{
						listaMetodos.Add(metodo);
					}
				}
			}
			return listaMetodos;
		}

		public Estado verificarAtributoAsignacion(List<NodoAtributo> misAtributos, string lexema)
		{
			foreach (var item in misAtributos)
			{
				if (item.Lexema == lexema)
				{
					return Estado.Duplicado;
				}
			}
			return Estado.NoDeclarado;
		}


		public List<NodoVariables> ObtenerParametrosMetodo(string lexema, NodoClase nodoClaseActiva, Boolean soloArgumentos)
		{
			var non = nodoClaseActiva.TSM.Values;
			foreach (var metodo in non)
			{
				if (metodo.Lexema == lexema)
				{
					List<NodoVariables> listaV = new List<NodoVariables>();
					foreach (var variable in metodo.TSV.Values)
					{
						if (soloArgumentos)
						{
							listaV.Add(variable);
						}
						else
						{
							listaV.Add(variable);
						}
					}
					return listaV;
				}
			}
			return null;
		}
		#endregion

		#region Metodos TS Variables
		public Estado InsertarNodoVariable(NodoVariables nodo, NodoClase nodoClaseActiva, string nombreMetodoActivo)
		{
			if (nodoClaseActiva.TSM.ContainsKey(nombreMetodoActivo))
			{
				var metodos = nodoClaseActiva.TSM;
				NodoMetodo nodoMetodo = new NodoMetodo();
				foreach (var metodo in metodos)
				{
					if (metodo.Key.ToString() == nombreMetodoActivo)
					{
						nodoMetodo = metodo.Value;
					}
				}

				if (!nodoMetodo.TSV.ContainsKey(nodo.Lexema))
				{
					nodoMetodo.TSV.Add(nodo.Lexema, nodo);
					return Estado.Insertado;
				}
				else
				{
					//se manda el error para el atributo duplicado
					return Estado.Duplicado;
				}
			}
			else
			{
				//error de atributo duplicado con clase
				return Estado.DuplicadoAtributoConClase;
			}
		}

		public Boolean ExisteNodoVariable(NodoClase nodoClaseActiva, string nombreMetodo, string lexema)
		{
			List<NodoVariables> listaVariables = ObtenerParametrosMetodo(nombreMetodo, nodoClaseActiva, false);
			foreach (var variable in listaVariables)
			{
				if (variable.Lexema == lexema)
				{
					return true;
				}
			}
			return false;
		}

		public Boolean InvocacionValida(NodoClase nodoClaseActiva, string metodoActual, string metodoInvocado, List<string> listaParametros)
		{
			List<NodoMetodo> listaMetodos = ObtenerParametrosMetodos(metodoInvocado, nodoClaseActiva);
			List<NodoVariables> listaVariables = ObtenerParametrosMetodo(metodoInvocado, nodoClaseActiva, true);
			if (listaMetodos.Count == 1)
			{
				if (listaVariables.Count != listaParametros.Count)
				{
					return false;
				}
				for (int i = 0; i < listaParametros.Count; i++)
				{
					if (listaParametros[i] == "STRING.")
					{
						if (TipoDato.String != listaVariables[i].MiTipo)
						{
							return false;
						}
						continue;
					}
					if (TipoNodoVariable(nodoClaseActiva, metodoActual, listaParametros[i]) == TipoDato.Float && (listaVariables[i].MiTipo == TipoDato.Float))
					{
						continue;
					}
					if (TipoNodoVariable(nodoClaseActiva, metodoActual, listaParametros[i]) != listaVariables[i].MiTipo)
					{
						return false;
					}
				}
				return true;
			}
			else
			{
				foreach (var metodo in listaMetodos)
				{
					if (metodo.TSV.Count != listaParametros.Count)
					{
						continue;
					}
					else if ((metodo.TSV.Count == 0 && listaParametros.Count == 0))
					{
						return true;
					}
					List<NodoVariables> listaVariables2 = ObtenerParametrosMetodo(metodo.Lexema, nodoClaseActiva, true);
					Boolean salto = false;
					for (int i = 0; i < listaParametros.Count; i++)
					{
						TipoDato dato = stringTipoDato(listaParametros[i]);
						if (dato != listaVariables2[i].MiTipo && (dato == TipoDato.Float))
						{
							if (!(listaParametros[i] == "STRING." && listaVariables2[i].MiTipo == TipoDato.String))
							{
								salto = true;

							}
						}
						if (i == listaParametros.Count - 1 && salto == false)
						{
							return true;
						}

					}
					if (salto)
					{
						continue;
						salto = false;
					}
				}
				return false;
			}
		}

		public TipoDato stringTipoDato(string tipo)
		{
			if (tipo.Substring(0,1) == "\"\"")
			{
				return TipoDato.String;
			}
			int n;
			bool IsNumeric = int.TryParse(tipo, out n);

			if (IsNumeric)
			{
				return TipoDato.Int;
			}
			else
			{
				Double num = 0;
				bool isDouble = false;
				isDouble = Double.TryParse(tipo, out num);
				if (isDouble)
				{
					return TipoDato.Float;
				}
			}
			return TipoDato.NADA;
		}

		public TipoDato TipoNodoVariable(NodoClase nodoClaseActiva, string nombreMetodo, string lexico)
		{
			List<NodoVariables> listaVariables = ObtenerParametrosMetodo(nombreMetodo, nodoClaseActiva, false);
			foreach (var variable in listaVariables)
			{
				int n;
				bool isNumeric = int.TryParse(lexico, out n);

				if (isNumeric)
				{
					return TipoDato.Int;
				}
				else
				{
					Double num = 0;
					bool isDouble = false;
					isDouble = Double.TryParse(lexico, out num);
					if (isDouble)
					{
						return TipoDato.Float;

					}
				}

				if (variable.Lexema == lexico)
				{
					return variable.MiTipo;
				}
			}
			return TipoDato.NADA;
		}

		public void buscarAtributo(NodoClase claseActiva, string lexema, string expresion)
		{
			foreach (var item in claseActiva.TSA.Values)
			{
				if (item.Lexema == lexema)
				{
					item.Valor = expresion;
				}
			}
			
		}

		#endregion
	}

	#region Nodos
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


		public Dictionary<object, NodoAtributo> TSA = new Dictionary<object, NodoAtributo>();
		public Dictionary<object, NodoMetodo> TSM = new Dictionary<object, NodoMetodo>();
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

		public Dictionary<object, NodoVariables> TSV = new Dictionary<object, NodoVariables>();
	}
	public class NodoVariables
	{
		private Alcance miAlcance;
		private string lexema;
		private TipoDato miTipo;
		private string valor;

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
		#endregion
	}

	#endregion

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
		DuplicadoMetodoConClase,
		NoDeclarado
	}
	public enum Regreso
	{
		Void,
		Int,
		Float,
		String,
		Char,
		Bool
	}

	#endregion

}
