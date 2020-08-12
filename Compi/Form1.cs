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

        private void lbl_Sintactico_Click(object sender, EventArgs e)
        {

        }

        private void dgv_PreTabSim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}