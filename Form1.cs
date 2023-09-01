using EjemploCrud.Controladores;
using EjemploCrud.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EjemploCrud
{
    public partial class txtFechaRegistro : Form
    {
        private DataTable tabla;
        UsuariosController UsuariosController = new UsuariosController();
        int filaSeleccionada;
        string accion = "guardar";

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

        private void InicializarTablaUsuarios()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Rut");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("EsEmpresa");
            tabla.Columns.Add("Telefono");
            tabla.Columns.Add("Direccion");
            tabla.Columns.Add("FechaRegistro");
            tabla.Columns.Add("CantidadFacturas");
            tabla.Columns.Add("NumeroUltimaFactura");
            tabla.Columns.Add("MontoUltimaFactura");

            dgUsuarios.DataSource = tabla;
        }

        private void MostrarListaUsuarios()
        {
            InicializarTablaUsuarios();

            List<Usuario> usuarios = UsuariosController.ObtenerListaUsuarios();

            if (usuarios != null)
            {
                foreach (var usuario in usuarios)
                {
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

        private void LimpiarFormularioUsuarios()
        {
            txtRut.Text = "";
            txtNombre.Text = "";
            CbEmpresa.Text = "";
            txtTelefono.Text = "";
            txtDirrecion.Text = "";
            FechaRegistro.Text = "";
            txtCantidadFacturas.Text = "";
            txtNumeroUltimaFactura.Text = "";
            txtMontoUltimaFactura.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario()
                {
                    Rut = txtRut.Text,
                    Nombre = txtNombre.Text,
                    EsEmpresa = CbEmpresa.SelectedItem.ToString() == "Sí", // Convierte a booleano
                    Telefono = txtTelefono.Text,
                    Direccion = txtDirrecion.Text,
                    FechaRegistro = DateTime.Parse(FechaRegistro.Text),
                    CantidadFacturas = int.Parse(txtCantidadFacturas.Text),
                    NumeroUltimaFactura = int.Parse(txtNumeroUltimaFactura.Text),
                    MontoUltimaFactura = int.Parse(txtMontoUltimaFactura.Text)
                };

                if (accion == "guardar")
                {
                    UsuariosController.GuardarUsuario(usuario);
                }
                else if (accion == "editar")
                {
                    UsuariosController.ActualizarUsuario(filaSeleccionada, usuario);
                    accion = "guardar";
                }

                MostrarListaUsuarios();
                LimpiarFormularioUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filaSeleccionada = e.RowIndex;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UsuariosController.EliminarUsuario(filaSeleccionada);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            MostrarListaUsuarios();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgUsuarios.Rows[filaSeleccionada];

            txtRut.Text = fila.Cells[0].Value.ToString();
            txtNombre.Text = fila.Cells[1].Value.ToString();
            CbEmpresa.Text = fila.Cells[2].Value.ToString();
            txtTelefono.Text = fila.Cells[3].Value.ToString();
            txtDirrecion.Text = fila.Cells[4].Value.ToString();
            FechaRegistro.Text = fila.Cells[5].Value.ToString();
            txtCantidadFacturas.Text = fila.Cells[6].Value.ToString();
            txtNumeroUltimaFactura.Text = fila.Cells[7].Value.ToString();
            txtMontoUltimaFactura.Text = fila.Cells[8].Value.ToString();

            accion = "editar";

            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormularioUsuarios();
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            accion = "guardar";
        }
    }
}
