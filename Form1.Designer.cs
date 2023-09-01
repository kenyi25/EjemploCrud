namespace EjemploCrud
{
	partial class txtFechaRegistro
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgUsuarios = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDirrecion = new System.Windows.Forms.TextBox();
            this.txtCantidadFacturas = new System.Windows.Forms.TextBox();
            this.txtNumeroUltimaFactura = new System.Windows.Forms.TextBox();
            this.txtMontoUltimaFactura = new System.Windows.Forms.TextBox();
            this.FechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.CbEmpresa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "EsEmpresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefono";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(354, 155);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(939, 461);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(354, 210);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(354, 266);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rut";
            // 
            // dgUsuarios
            // 
            this.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsuarios.Location = new System.Drawing.Point(462, 62);
            this.dgUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgUsuarios.Name = "dgUsuarios";
            this.dgUsuarios.RowHeadersWidth = 51;
            this.dgUsuarios.Size = new System.Drawing.Size(977, 360);
            this.dgUsuarios.TabIndex = 4;
            this.dgUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUsuarios_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "FechaRegistro";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "CantidadFacturas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 377);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "MontoUltimaFactura";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 335);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "NumeroUltimaFactura";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(189, 33);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(144, 22);
            this.txtRut.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(189, 157);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(144, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // txtDirrecion
            // 
            this.txtDirrecion.Location = new System.Drawing.Point(189, 196);
            this.txtDirrecion.Name = "txtDirrecion";
            this.txtDirrecion.Size = new System.Drawing.Size(144, 22);
            this.txtDirrecion.TabIndex = 12;
            // 
            // txtCantidadFacturas
            // 
            this.txtCantidadFacturas.Location = new System.Drawing.Point(189, 286);
            this.txtCantidadFacturas.Name = "txtCantidadFacturas";
            this.txtCantidadFacturas.Size = new System.Drawing.Size(144, 22);
            this.txtCantidadFacturas.TabIndex = 14;
            // 
            // txtNumeroUltimaFactura
            // 
            this.txtNumeroUltimaFactura.Location = new System.Drawing.Point(189, 332);
            this.txtNumeroUltimaFactura.Name = "txtNumeroUltimaFactura";
            this.txtNumeroUltimaFactura.Size = new System.Drawing.Size(144, 22);
            this.txtNumeroUltimaFactura.TabIndex = 15;
            // 
            // txtMontoUltimaFactura
            // 
            this.txtMontoUltimaFactura.Location = new System.Drawing.Point(189, 374);
            this.txtMontoUltimaFactura.Name = "txtMontoUltimaFactura";
            this.txtMontoUltimaFactura.Size = new System.Drawing.Size(144, 22);
            this.txtMontoUltimaFactura.TabIndex = 16;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.Location = new System.Drawing.Point(189, 246);
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.Size = new System.Drawing.Size(144, 22);
            this.FechaRegistro.TabIndex = 19;
            // 
            // CbEmpresa
            // 
            this.CbEmpresa.FormattingEnabled = true;
            this.CbEmpresa.Items.AddRange(new object[] {
            "si",
            "no"});
            this.CbEmpresa.Location = new System.Drawing.Point(189, 114);
            this.CbEmpresa.Name = "CbEmpresa";
            this.CbEmpresa.Size = new System.Drawing.Size(144, 24);
            this.CbEmpresa.TabIndex = 20;
            // 
            // txtFechaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 572);
            this.Controls.Add(this.CbEmpresa);
            this.Controls.Add(this.FechaRegistro);
            this.Controls.Add(this.txtMontoUltimaFactura);
            this.Controls.Add(this.txtNumeroUltimaFactura);
            this.Controls.Add(this.txtCantidadFacturas);
            this.Controls.Add(this.txtDirrecion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRut);
            this.Controls.Add(this.dgUsuarios);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "txtFechaRegistro";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dgUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDirrecion;
        private System.Windows.Forms.TextBox txtCantidadFacturas;
        private System.Windows.Forms.TextBox txtNumeroUltimaFactura;
        private System.Windows.Forms.TextBox txtMontoUltimaFactura;
        private System.Windows.Forms.DateTimePicker FechaRegistro;
        private System.Windows.Forms.ComboBox CbEmpresa;
    }
}

