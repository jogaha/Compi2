using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compi
{
	public partial class Form1 : Form
	{
		Lexico Lexico = new Lexico();
		Sintactico Sintactico = new Sintactico();
		List<Token> ListaTokens = new List<Token>();
		string claseSeleccionada;
		string metodoSeleccionado;
		int bandera;
		public Form1()
		{
			InitializeComponent();
		}

		

		private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog guardar = new SaveFileDialog();
			guardar.Filter = "Documento de texto|*.txt| Todos los archivos|*.*";
			guardar.Title = "Guardar";
			guardar.FileName = "Sin Tituo1";
			var resultado = guardar.ShowDialog();
			if (resultado == DialogResult.OK)
			{
				StreamWriter escribir = new StreamWriter(guardar.FileName);
				foreach (object line in rtb_Texto.Lines)
				{
					escribir.WriteLine(line);
				}
				escribir.Close();
			}

		}
		private void tsm_Abir_Click(object sender, EventArgs e)
		{
			OpenFileDialog abrir = new OpenFileDialog();
			abrir.Filter = "Documento de texto|*.txt| Todos los archivos|*.*";
			abrir.Title = "Abrir";
			abrir.FileName = "Sin Tituo1";
			var resultado = abrir.ShowDialog();
			if (resultado == DialogResult.OK)
			{
				StreamReader leer = new StreamReader(abrir.FileName);
				rtb_Texto.Text = leer.ReadToEnd();
				leer.Close();
			}
		}

		private void ejecutar_lexico_tsmi_click(object sender, EventArgs e)
		{
			dgv_Lexico.Rows.Clear();

			ListaTokens = Lexico.Ejecutar(rtb_Texto.Text + (char)165);
			foreach (var item in ListaTokens)
			{
				dgv_Lexico.Rows.Add(dgv_Lexico.RowCount, item.estado, item.lexema, item.linea);
			}
			dgv_Sintactico.Rows.Clear();
		}

		private void salir_tsmi_click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ejecutar_sintactico_tsmi_click(object sender, EventArgs e)
		{
			Sintactico.ts.tablaSimbolosClase.Clear();
			dgv_PreTabSim.Rows.Clear();
			ejecutar_lexico_tsmi_click(this, e);
			lbl_Resultado.Visible = true;
			string[] Resultado = Sintactico.Ejecutar(ListaTokens.Where(d=>d.estado>-400).ToList());
			lbl_Resultado.Text = Resultado[0];
			lbl_Resultado.BackColor = Resultado[1] == "ERROR" ? Color.Red : Color.Green;
            dgv_Sintactico.Rows.Clear();
            foreach (var item in Sintactico.ErroresSintacticos)
			{
				dgv_Sintactico.Rows.Add(item.tipo, item.Descripcion, item.linea.ToString());
			}
            Sintactico.ErroresSintacticos = new List<Error>();

			var listaClases = (from item in Sintactico.ts.tablaSimbolosClase select item.Value).ToList();
			string herencia = string.Empty;
			foreach(var item in listaClases)
            {
				if(item.Herencia != null)
                {
					herencia = item.Herencia.LexemaC;
				}
				dgv_PreTabSim.Rows.Add(item.LexemaC, herencia, item.RenglonDeDeclaracion);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
		private void dgv_PreTabSim_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			bandera = 0;
			dgv_TSA.Rows.Clear();
			dgv_TSM.Rows.Clear();
			claseSeleccionada = dgv_PreTabSim.CurrentCell.Value.ToString();

			var listaClases2 = (from x in Sintactico.ts.tablaSimbolosClase where x.Key.ToString().Equals(claseSeleccionada) select x.Value).FirstOrDefault();

			var listaAtributos = listaClases2.TSA.Values;
			var listaMetodos = listaClases2.TSM.Values;

			
			dgv_PreTabSim.Visible = false;
			dgv_TSA.Visible = true;
			dgv_TSM.Visible = true;
			lbl_Lexico.Visible = false;
			lbl_TSA.Visible = true;
			lbl_TSM.Visible = true;
			dgv_TSA.Width = 528;
			dgv_TSA.Height = 266;
			dgv_TSM.Size = new Size(528,266);
			dgv_TSA.Location = new Point(470,62);
			lbl_TSA.Location = new Point(470, 38);
			dgv_TSM.Location = new Point(1052,62);
			lbl_TSM.Location = new Point(1052, 38);

			foreach (var item in listaAtributos)
			{
				dgv_TSA.Rows.Add(item.MiTipo, item.MiAlcance, item.Lexema, item.Valor, item.RenglonDeclaracion);
			}

			foreach (var item in listaMetodos)
			{
				dgv_TSM.Rows.Add(item.MiRegreso, item.MiAlcance, item.Lexema, item.RenglonDeclaracion);
			}
		}


		private void dgv_TSM_CellContentDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			bandera = 1;
			dgv_TSV.Rows.Clear();
			metodoSeleccionado = dgv_TSM.CurrentCell.Value.ToString();

			var listaClases2 = (from x in Sintactico.tablaFinal.tablaSimbolosClase where x.Key.ToString().Equals(claseSeleccionada) select x.Value).FirstOrDefault();

			var listaMetodos = listaClases2.TSM;

			var listaMetodos2 = (from x in listaMetodos where x.Key.ToString().Equals(metodoSeleccionado) select x.Value).FirstOrDefault();

			var listaVariables = listaMetodos2.TSV.Values;

			dgv_TSA.Visible = false;
			dgv_TSM.Visible = false;
			lbl_TSA.Visible = false;
			lbl_TSM.Visible = false;
			lbl_TSV.Visible = true;
			lbl_TSV.Location = new Point(470, 38);
			dgv_TSV.Visible = true;
			dgv_TSV.Location = new Point(470, 62);
			dgv_TSV.Size = new Size(528, 266);

			foreach (var item in listaVariables)
			{
				dgv_TSV.Rows.Add(item.MiTipo, item.MiAlcance, item.Lexema, item.Valor, item.Linea);
			}
		}

		private void btn_Regresar_Click(object sender, EventArgs e)
		{
			if (bandera == 0)
			{
				dgv_PreTabSim.Visible = true;
				dgv_TSA.Visible = false;
				dgv_TSM.Visible = false;
				lbl_Lexico.Visible = true;
				lbl_TSA.Visible = false;
				lbl_TSM.Visible = false;
			}
			else if (bandera == 1)
			{
				dgv_TSV.Visible = false;
				dgv_TSA.Visible = true;
				dgv_TSM.Visible = true;
				lbl_TSV.Visible = false;
				lbl_TSA.Visible = true;
				lbl_TSM.Visible = true;
				bandera = 0;
			}
		}
	}
}