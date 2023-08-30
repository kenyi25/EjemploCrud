using EjemploCrud.Controladores;
using EjemploCrud.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploCrud
{
	public partial class txtFechaRegistro : Form
	{
		private DataTable tabla; 
		UsuariosController UsuariosController = new UsuariosController(); //se instancia objeto para llamar a acciones crud del controller
		int filaSeleccionada;
		string accion = "guardar"; //la opción por defecto al pulsar el botón guardar, si se está editando, debe cambiar a editar
        private txtFechaRegistro txtFechaxRegistro;

        public static string text { get; private set; }

        //punto de partida de la app, mostramos lista usuarios (util si se tuviera datos por defecto, o desde una bd)
        public txtFechaRegistro()
		{
			InitializeComponent();
			try
			{
				MostrarListaUsuarios();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//asigna nombres de columna a cada row del datagrid y ubica dichos nombres como cabecera
		private void InicializarTablaUsuarios()
		{
			tabla = new DataTable();
			tabla.Columns.Add("Rut");
			tabla.Columns.Add("Nombre");
			tabla.Columns.Add("EsEmpresa");
			tabla.Columns.Add("Telefono");
			tabla.Columns.Add("FechaRegistro");
			tabla.Columns.Add("CantidadFacturas");
			tabla.Columns.Add("NumeroUltimaFactura");
			tabla.Columns.Add("MontoUltimaFactura");

			dgUsuarios.DataSource = tabla; //dgUsuarios = datagrid usuarios
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		//pobla el datagrid con los datos de la lista de usuarios
		private void MostrarListaUsuarios()
		{
			InicializarTablaUsuarios();

			List<Usuario> usuarios = UsuariosController.ObtenerListaUsuarios();

			if (usuarios != null)
			{
				foreach (var usuario in usuarios)
				{
					//si usuarios no es nulo, se le asigna a cada fila el valor de la propiedad que le corresponde.
					//el nombre del row debe coincidir con el de inicializarTablaUsuarios()
					DataRow row = tabla.NewRow();
					row["Rut"] = usuario.Rut;
                    row["Nombre"] = usuario.Nombre;
                    row["EsEmpresa"] = usuario.EsEmpresa;
                    row["Telefono"] = usuario.Telefono;
                    row["Direccion"] = usuario.Direccion;
                    row["FechaRegistro"] = usuario.FechaRegistro;
                    row["CantidadFacturas"] = usuario.CantidadFacturas;
                    row["NumeroUltimaFactura"] = usuario.NumeroUltimaFactura;
                    row["MontoUltimaFactura"] = usuario.MontoUltimaFactura;

					tabla.Rows.Add(row);
				}
			}
		}

        private txtFechaRegistro GetTxtFechaRegistro(txtFechaRegistro txtFechaRegistro)
        {
            return txtFechaRegistro;
        }

        private void btnGuardar_Click(object sender, EventArgs e, txtFechaRegistro txtFechaRegistro)
        {
            btnGuardar_Click(sender, e, txtFechaRegistro, txtEsEmpresa);
        }

        private void btnGuardar_Click(object sender, EventArgs e, txtFechaRegistro txtFechaRegistro, TextBox txtEsEmpresa)
        {
            btnGuardar_Click(sender, e, txtFechaRegistro, txtEsEmpresa, txtMontoUltimaFactura);
        }

        //guarda/edita usuario
        private void btnGuardar_Click(object sender, EventArgs e, txtFechaRegistro txtFechaRegistro, TextBox txtEsEmpresa, TextBox txtMontoUltimaFactura)
		{
			try
			{



                Usuario usuario = new Usuario()
                {
                    Rut = txtNombre.Text,
                    Nombre = txtNombre.Text,
                    EsEmpresa = bool.Parse(txtEsEmpresa.Text),
                    Telefono = txtTelefono.Text,
                    Direccion = txtDirrecion.Text,
                    FechaRegistro = DateTime.Parse(FechaRegistro.Text),
                    CantidadFacturas = int.Parse(txtCantidadFacturas.Text),
                    NumeroUltimaFactura = int.Parse(txtNumeroUltimaFactura.Text),
                    MontoUltimaFactura = (int)double.Parse(txtMontoUltimaFactura.Text),
                };





                //la variable accion está por defecto en 'guardar' 
                if (accion == "guardar")
				{
					UsuariosController.GuardarUsuario(usuario);
				}
				else if (accion == "editar") //cuando se quiere editar, la acción debería estar en 'editar' ver función btnModificar_Click()
				{
					UsuariosController.ActualizarUsuario(filaSeleccionada, usuario);
					accion = "guardar";
				}

				MostrarListaUsuarios();
				LimpiarFormularioUsuarios(txtFechaRegistro);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//hace lo que su nombre dice
		private void LimpiarFormularioUsuarios(txtFechaRegistro txtFechaRegistro)
		{
			txtRut.Text = "";
			txtNombre.Text = "";
			txtEsEmpresa.Text = "";
			txtTelefono.Text = "";
			txtDirrecion.Text = "";
            txtFechaRegistro.Text = "";
			txtCantidadFacturas.Text = "";
			txtNumeroUltimaFactura.Text = "";
			txtMontoUltimaFactura.Text = "";
			


		}


		//detecta cuando se le hace click a una celda el datagrid y guarda el indice correspondiente al registro seleccionado
		private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) 
		{
			filaSeleccionada = e.RowIndex;
			btnEliminar.Enabled = true;
			btnModificar.Enabled = true;
		}

		//el boton eliminar llama a la funcion eliminar del controlador
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			UsuariosController.EliminarUsuario(filaSeleccionada);
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
			MostrarListaUsuarios();
		}


		//		Envía datos de la fila elegida al formulario para su edición

		private void btnModificar_Click(object sender, EventArgs e)
		{

			DataGridViewRow fila = dgUsuarios.Rows[filaSeleccionada];


			txtRut.Text = fila.Cells[0].Value.ToString();
			txtNombre.Text = fila.Cells[1].Value.ToString();
			txtEsEmpresa.Text = fila.Cells[2].Value.ToString();
			txtTelefono.Text = fila.Cells[3].Value.ToString();
			txtDirrecion.Text = fila.Cells[4].Value.ToString();
			txtFechaRegistro.text = fila.Cells[5].Value.ToString();
            txtCantidadFacturas.Text = fila.Cells[6].Value.ToString();
			txtMontoUltimaFactura.Text = fila.Cells[7].Value.ToString();

            accion = "editar";

			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
		}

		//limpia todos los campos y vuelve algunas cosas a su estado inicial
		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarFormularioUsuarios(txtFechaxRegistro);
			btnEliminar.Enabled = false;
			btnModificar.Enabled = false;
			accion = "guardar";
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
