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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
			this.LexemaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Herencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RenglonDeDeclaracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_TSA = new System.Windows.Forms.DataGridView();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Alcance = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LexemaA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RenglonDeDeclaracionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_TSM = new System.Windows.Forms.DataGridView();
			this.Regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlcanceM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LexemaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RenglonDeDeclaracionM = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_TSV = new System.Windows.Forms.DataGridView();
			this.lbl_TSA = new System.Windows.Forms.Label();
			this.lbl_TSM = new System.Windows.Forms.Label();
			this.lbl_TSV = new System.Windows.Forms.Label();
			this.btn_Regresar = new System.Windows.Forms.Button();
			this.TipoV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AlcanceV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LexemaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ValorV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LineaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Sintactico)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_PreTabSim)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSV)).BeginInit();
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
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(1589, 28);
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
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// tsm_Abir
			// 
			this.tsm_Abir.Name = "tsm_Abir";
			this.tsm_Abir.Size = new System.Drawing.Size(137, 24);
			this.tsm_Abir.Text = "Abrir";
			this.tsm_Abir.Click += new System.EventHandler(this.tsm_Abir_Click);
			// 
			// guardarToolStripMenuItem
			// 
			this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
			this.guardarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.guardarToolStripMenuItem.Text = "Guardar";
			this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// lexicoToolStripMenuItem
			// 
			this.lexicoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem});
			this.lexicoToolStripMenuItem.Name = "lexicoToolStripMenuItem";
			this.lexicoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
			this.lexicoToolStripMenuItem.Text = "Lexico";
			// 
			// ejecutarToolStripMenuItem
			// 
			this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
			this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
			this.ejecutarToolStripMenuItem.Text = "Ejecutar";
			this.ejecutarToolStripMenuItem.Click += new System.EventHandler(this.ejecutar_lexico_tsmi_click);
			// 
			// sintacticoToolStripMenuItem
			// 
			this.sintacticoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejecutarToolStripMenuItem1});
			this.sintacticoToolStripMenuItem.Name = "sintacticoToolStripMenuItem";
			this.sintacticoToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
			this.sintacticoToolStripMenuItem.Text = "Sintactico";
			// 
			// ejecutarToolStripMenuItem1
			// 
			this.ejecutarToolStripMenuItem1.Name = "ejecutarToolStripMenuItem1";
			this.ejecutarToolStripMenuItem1.Size = new System.Drawing.Size(137, 24);
			this.ejecutarToolStripMenuItem1.Text = "Ejecutar";
			this.ejecutarToolStripMenuItem1.Click += new System.EventHandler(this.ejecutar_sintactico_tsmi_click);
			// 
			// salirToolStripMenuItem1
			// 
			this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
			this.salirToolStripMenuItem1.Size = new System.Drawing.Size(52, 24);
			this.salirToolStripMenuItem1.Text = "Salir";
			this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salir_tsmi_click);
			// 
			// rtb_Texto
			// 
			this.rtb_Texto.AcceptsTab = true;
			this.rtb_Texto.Location = new System.Drawing.Point(12, 38);
			this.rtb_Texto.Name = "rtb_Texto";
			this.rtb_Texto.Size = new System.Drawing.Size(452, 398);
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
			this.dgv_Lexico.Location = new System.Drawing.Point(470, 62);
			this.dgv_Lexico.Name = "dgv_Lexico";
			this.dgv_Lexico.RowHeadersWidth = 51;
			this.dgv_Lexico.Size = new System.Drawing.Size(364, 266);
			this.dgv_Lexico.TabIndex = 2;
			this.dgv_Lexico.Visible = false;
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
			this.dgv_Sintactico.Location = new System.Drawing.Point(473, 363);
			this.dgv_Sintactico.Name = "dgv_Sintactico";
			this.dgv_Sintactico.RowHeadersWidth = 51;
			this.dgv_Sintactico.Size = new System.Drawing.Size(453, 148);
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
			this.Descripcion.Width = 300;
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
			this.lbl_Lexico.Location = new System.Drawing.Point(470, 38);
			this.lbl_Lexico.Name = "lbl_Lexico";
			this.lbl_Lexico.Size = new System.Drawing.Size(86, 20);
			this.lbl_Lexico.TabIndex = 4;
			this.lbl_Lexico.Text = "TS CLASE";
			// 
			// lbl_Sintactico
			// 
			this.lbl_Sintactico.AutoSize = true;
			this.lbl_Sintactico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Sintactico.Location = new System.Drawing.Point(470, 342);
			this.lbl_Sintactico.Name = "lbl_Sintactico";
			this.lbl_Sintactico.Size = new System.Drawing.Size(61, 20);
			this.lbl_Sintactico.TabIndex = 5;
			this.lbl_Sintactico.Text = "Errores";
			// 
			// lbl_Resultado
			// 
			this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Resultado.Location = new System.Drawing.Point(12, 454);
			this.lbl_Resultado.Name = "lbl_Resultado";
			this.lbl_Resultado.Size = new System.Drawing.Size(443, 57);
			this.lbl_Resultado.TabIndex = 6;
			this.lbl_Resultado.Visible = false;
			// 
			// dgv_PreTabSim
			// 
			this.dgv_PreTabSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_PreTabSim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LexemaC,
            this.Herencia,
            this.RenglonDeDeclaracion});
			this.dgv_PreTabSim.Location = new System.Drawing.Point(469, 62);
			this.dgv_PreTabSim.Name = "dgv_PreTabSim";
			this.dgv_PreTabSim.RowHeadersWidth = 51;
			this.dgv_PreTabSim.Size = new System.Drawing.Size(431, 266);
			this.dgv_PreTabSim.TabIndex = 7;
			this.dgv_PreTabSim.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PreTabSim_CellContentDoubleClick);
			// 
			// LexemaC
			// 
			this.LexemaC.HeaderText = "LexemaC";
			this.LexemaC.MinimumWidth = 6;
			this.LexemaC.Name = "LexemaC";
			this.LexemaC.Width = 125;
			// 
			// Herencia
			// 
			this.Herencia.HeaderText = "Herencia";
			this.Herencia.MinimumWidth = 6;
			this.Herencia.Name = "Herencia";
			this.Herencia.Width = 125;
			// 
			// RenglonDeDeclaracion
			// 
			this.RenglonDeDeclaracion.HeaderText = "RenglonDeDeclaracion";
			this.RenglonDeDeclaracion.MinimumWidth = 6;
			this.RenglonDeDeclaracion.Name = "RenglonDeDeclaracion";
			this.RenglonDeDeclaracion.ReadOnly = true;
			this.RenglonDeDeclaracion.Width = 125;
			// 
			// dgv_TSA
			// 
			this.dgv_TSA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_TSA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Alcance,
            this.LexemaA,
            this.Valor,
            this.RenglonDeDeclaracionA});
			this.dgv_TSA.Location = new System.Drawing.Point(955, 363);
			this.dgv_TSA.Name = "dgv_TSA";
			this.dgv_TSA.Size = new System.Drawing.Size(99, 77);
			this.dgv_TSA.TabIndex = 8;
			this.dgv_TSA.Visible = false;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			// 
			// Alcance
			// 
			this.Alcance.HeaderText = "Alcance";
			this.Alcance.Name = "Alcance";
			// 
			// LexemaA
			// 
			this.LexemaA.HeaderText = "LexemaA";
			this.LexemaA.Name = "LexemaA";
			// 
			// Valor
			// 
			this.Valor.HeaderText = "Valor";
			this.Valor.Name = "Valor";
			// 
			// RenglonDeDeclaracionA
			// 
			this.RenglonDeDeclaracionA.HeaderText = "RenglonDeDeclaracionA";
			this.RenglonDeDeclaracionA.Name = "RenglonDeDeclaracionA";
			// 
			// dgv_TSM
			// 
			this.dgv_TSM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_TSM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Regreso,
            this.AlcanceM,
            this.LexemaM,
            this.RenglonDeDeclaracionM});
			this.dgv_TSM.Location = new System.Drawing.Point(1124, 363);
			this.dgv_TSM.Name = "dgv_TSM";
			this.dgv_TSM.Size = new System.Drawing.Size(96, 77);
			this.dgv_TSM.TabIndex = 9;
			this.dgv_TSM.Visible = false;
			this.dgv_TSM.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TSM_CellContentDoubleClick_1);
			// 
			// Regreso
			// 
			this.Regreso.HeaderText = "Regreso";
			this.Regreso.Name = "Regreso";
			// 
			// AlcanceM
			// 
			this.AlcanceM.HeaderText = "AlcanceM";
			this.AlcanceM.Name = "AlcanceM";
			// 
			// LexemaM
			// 
			this.LexemaM.HeaderText = "LexemaM";
			this.LexemaM.Name = "LexemaM";
			// 
			// RenglonDeDeclaracionM
			// 
			this.RenglonDeDeclaracionM.HeaderText = "RenglonDeDeclaracionM";
			this.RenglonDeDeclaracionM.Name = "RenglonDeDeclaracionM";
			// 
			// dgv_TSV
			// 
			this.dgv_TSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_TSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoV,
            this.AlcanceV,
            this.LexemaV,
            this.ValorV,
            this.LineaV});
			this.dgv_TSV.Location = new System.Drawing.Point(1279, 363);
			this.dgv_TSV.Name = "dgv_TSV";
			this.dgv_TSV.Size = new System.Drawing.Size(96, 77);
			this.dgv_TSV.TabIndex = 10;
			this.dgv_TSV.Visible = false;
			// 
			// lbl_TSA
			// 
			this.lbl_TSA.AutoSize = true;
			this.lbl_TSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_TSA.Location = new System.Drawing.Point(985, 454);
			this.lbl_TSA.Name = "lbl_TSA";
			this.lbl_TSA.Size = new System.Drawing.Size(125, 20);
			this.lbl_TSA.TabIndex = 11;
			this.lbl_TSA.Text = "TS ATRIBUTOS";
			this.lbl_TSA.Visible = false;
			// 
			// lbl_TSM
			// 
			this.lbl_TSM.AutoSize = true;
			this.lbl_TSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_TSM.Location = new System.Drawing.Point(1145, 454);
			this.lbl_TSM.Name = "lbl_TSM";
			this.lbl_TSM.Size = new System.Drawing.Size(113, 20);
			this.lbl_TSM.TabIndex = 12;
			this.lbl_TSM.Text = "TS METODOS";
			this.lbl_TSM.Visible = false;
			// 
			// lbl_TSV
			// 
			this.lbl_TSV.AutoSize = true;
			this.lbl_TSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lbl_TSV.Location = new System.Drawing.Point(1314, 454);
			this.lbl_TSV.Name = "lbl_TSV";
			this.lbl_TSV.Size = new System.Drawing.Size(125, 20);
			this.lbl_TSV.TabIndex = 13;
			this.lbl_TSV.Text = "TS VARIABLES";
			this.lbl_TSV.Visible = false;
			// 
			// btn_Regresar
			// 
			this.btn_Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Regresar.BackgroundImage")));
			this.btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_Regresar.Location = new System.Drawing.Point(804, 34);
			this.btn_Regresar.Name = "btn_Regresar";
			this.btn_Regresar.Size = new System.Drawing.Size(30, 27);
			this.btn_Regresar.TabIndex = 14;
			this.btn_Regresar.UseVisualStyleBackColor = true;
			this.btn_Regresar.Click += new System.EventHandler(this.btn_Regresar_Click);
			// 
			// TipoV
			// 
			this.TipoV.HeaderText = "TipoV";
			this.TipoV.Name = "TipoV";
			// 
			// AlcanceV
			// 
			this.AlcanceV.HeaderText = "AlcanceV";
			this.AlcanceV.Name = "AlcanceV";
			// 
			// LexemaV
			// 
			this.LexemaV.HeaderText = "LexemaV";
			this.LexemaV.Name = "LexemaV";
			// 
			// ValorV
			// 
			this.ValorV.HeaderText = "ValorV";
			this.ValorV.Name = "ValorV";
			// 
			// LineaV
			// 
			this.LineaV.HeaderText = "LineaV";
			this.LineaV.Name = "LineaV";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1589, 520);
			this.Controls.Add(this.btn_Regresar);
			this.Controls.Add(this.lbl_TSV);
			this.Controls.Add(this.lbl_TSM);
			this.Controls.Add(this.lbl_TSA);
			this.Controls.Add(this.dgv_TSV);
			this.Controls.Add(this.dgv_TSM);
			this.Controls.Add(this.dgv_TSA);
			this.Controls.Add(this.dgv_PreTabSim);
			this.Controls.Add(this.lbl_Resultado);
			this.Controls.Add(this.lbl_Sintactico);
			this.Controls.Add(this.lbl_Lexico);
			this.Controls.Add(this.dgv_Sintactico);
			this.Controls.Add(this.dgv_Lexico);
			this.Controls.Add(this.rtb_Texto);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Lexico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Sintactico)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_PreTabSim)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgv_TSV)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_PreTabSim;
		private System.Windows.Forms.DataGridViewTextBoxColumn Error;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
		private System.Windows.Forms.DataGridViewTextBoxColumn errorLinea;
		private System.Windows.Forms.DataGridView dgv_TSA;
		private System.Windows.Forms.DataGridView dgv_TSM;
		private System.Windows.Forms.DataGridView dgv_TSV;
		private System.Windows.Forms.Label lbl_TSA;
		private System.Windows.Forms.Label lbl_TSM;
		private System.Windows.Forms.Label lbl_TSV;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Alcance;
		private System.Windows.Forms.DataGridViewTextBoxColumn LexemaA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		private System.Windows.Forms.DataGridViewTextBoxColumn RenglonDeDeclaracionA;
		private System.Windows.Forms.DataGridViewTextBoxColumn Regreso;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlcanceM;
		private System.Windows.Forms.DataGridViewTextBoxColumn LexemaM;
		private System.Windows.Forms.DataGridViewTextBoxColumn RenglonDeDeclaracionM;
		private System.Windows.Forms.DataGridViewTextBoxColumn LexemaC;
		private System.Windows.Forms.DataGridViewTextBoxColumn Herencia;
		private System.Windows.Forms.DataGridViewTextBoxColumn RenglonDeDeclaracion;
		private System.Windows.Forms.Button btn_Regresar;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoV;
		private System.Windows.Forms.DataGridViewTextBoxColumn AlcanceV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LexemaV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ValorV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LineaV;
	}
}

