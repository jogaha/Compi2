namespace Compi
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Abir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lexicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sintacticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb_Texto = new System.Windows.Forms.RichTextBox();
            this.dgv_Lexico = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Sintactico = new System.Windows.Forms.DataGridView();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Lexico = new System.Windows.Forms.Label();
            this.lbl_Sintactico = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.dgv_PreTabSim = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sintactico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreTabSim)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.lexicoToolStripMenuItem,
            this.sintacticoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1549, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Abir,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsm_Abir
            // 
            this.tsm_Abir.Name = "tsm_Abir";
            this.tsm_Abir.Size = new System.Drawing.Size(169, 30);
            this.tsm_Abir.Text = "Abrir";
            this.tsm_Abir.Click += new System.EventHandler(this.tsm_Abir_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // lexicoToolStripMenuItem
            // 
            this.lexicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem});
            this.lexicoToolStripMenuItem.Name = "lexicoToolStripMenuItem";
            this.lexicoToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.lexicoToolStripMenuItem.Text = "Lexico";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.ejecutarToolStripMenuItem.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutar_lexico_tsmi_click);
            // 
            // sintacticoToolStripMenuItem
            // 
            this.sintacticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem1});
            this.sintacticoToolStripMenuItem.Name = "sintacticoToolStripMenuItem";
            this.sintacticoToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.sintacticoToolStripMenuItem.Text = "Sintactico";
            // 
            // ejecutarToolStripMenuItem1
            // 
            this.ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
            this.ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(169, 30);
            this.ejecutarToolStripMenuItem1.Text = "Ejecutar";
            this.ejecutarToolStripMenuItem1.Click += new System.EventHandler(this.ejecutar_sintactico_tsmi_click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salir_tsmi_click);
            // 
            // rtb_Texto
            // 
            this.rtb_Texto.AcceptsTab = true;
            this.rtb_Texto.Location = new System.Drawing.Point(16, 47);
            this.rtb_Texto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtb_Texto.Name = "rtb_Texto";
            this.rtb_Texto.Size = new System.Drawing.Size(601, 489);
            this.rtb_Texto.TabIndex = 1;
            this.rtb_Texto.Text = "";
            // 
            // dgv_Lexico
            // 
            this.dgv_Lexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Lexico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Estado,
            this.Lexema,
            this.Linea});
            this.dgv_Lexico.Location = new System.Drawing.Point(627, 76);
            this.dgv_Lexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Lexico.Name = "dgv_Lexico";
            this.dgv_Lexico.RowHeadersWidth = 51;
            this.dgv_Lexico.Size = new System.Drawing.Size(486, 328);
            this.dgv_Lexico.TabIndex = 2;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.MinimumWidth = 6;
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Width = 50;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.Width = 125;
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.MinimumWidth = 200;
            this.Lexema.Name = "Lexema";
            this.Lexema.Width = 200;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.MinimumWidth = 6;
            this.Linea.Name = "Linea";
            this.Linea.Width = 50;
            // 
            // dgv_Sintactico
            // 
            this.dgv_Sintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Sintactico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Error,
            this.Descripcion,
            this.errorLinea});
            this.dgv_Sintactico.Location = new System.Drawing.Point(631, 447);
            this.dgv_Sintactico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Sintactico.Name = "dgv_Sintactico";
            this.dgv_Sintactico.RowHeadersWidth = 51;
            this.dgv_Sintactico.Size = new System.Drawing.Size(591, 182);
            this.dgv_Sintactico.TabIndex = 3;
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.MinimumWidth = 6;
            this.Error.Name = "Error";
            this.Error.ReadOnly = true;
            this.Error.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 200;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // errorLinea
            // 
            this.errorLinea.HeaderText = "Linea";
            this.errorLinea.MinimumWidth = 6;
            this.errorLinea.Name = "errorLinea";
            this.errorLinea.ReadOnly = true;
            this.errorLinea.Width = 50;
            // 
            // lbl_Lexico
            // 
            this.lbl_Lexico.AutoSize = true;
            this.lbl_Lexico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lexico.Location = new System.Drawing.Point(627, 47);
            this.lbl_Lexico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Lexico.Name = "lbl_Lexico";
            this.lbl_Lexico.Size = new System.Drawing.Size(69, 25);
            this.lbl_Lexico.TabIndex = 4;
            this.lbl_Lexico.Text = "Lexico";
            // 
            // lbl_Sintactico
            // 
            this.lbl_Sintactico.AutoSize = true;
            this.lbl_Sintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sintactico.Location = new System.Drawing.Point(627, 421);
            this.lbl_Sintactico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Sintactico.Name = "lbl_Sintactico";
            this.lbl_Sintactico.Size = new System.Drawing.Size(175, 25);
            this.lbl_Sintactico.TabIndex = 5;
            this.lbl_Sintactico.Text = "Errores Sintacticos";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resultado.Location = new System.Drawing.Point(16, 559);
            this.lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(591, 70);
            this.lbl_Resultado.TabIndex = 6;
            this.lbl_Resultado.Visible = false;
            // 
            // dgv_PreTabSim
            // 
            this.dgv_PreTabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PreTabSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_PreTabSim.Location = new System.Drawing.Point(1150, 76);
            this.dgv_PreTabSim.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_PreTabSim.Name = "dgv_PreTabSim";
            this.dgv_PreTabSim.RowHeadersWidth = 51;
            this.dgv_PreTabSim.Size = new System.Drawing.Size(386, 245);
            this.dgv_PreTabSim.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Indice";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Simbolos";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 640);
            this.Controls.Add(this.dgv_PreTabSim);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Sintactico);
            this.Controls.Add(this.lbl_Lexico);
            this.Controls.Add(this.dgv_Sintactico);
            this.Controls.Add(this.dgv_Lexico);
            this.Controls.Add(this.rtb_Texto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Sintactico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PreTabSim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsm_Abir;
		private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem lexicoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sintacticoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem1;
		private System.Windows.Forms.RichTextBox rtb_Texto;
		private System.Windows.Forms.DataGridView dgv_Lexico;
		private System.Windows.Forms.DataGridView dgv_Sintactico;
		private System.Windows.Forms.Label lbl_Lexico;
		private System.Windows.Forms.Label lbl_Sintactico;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
		private System.Windows.Forms.Label lbl_Resultado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Token;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
		private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
		private System.Windows.Forms.DataGridViewTextBoxColumn Error;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn errorLinea;
        private System.Windows.Forms.DataGridView dgv_PreTabSim;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

