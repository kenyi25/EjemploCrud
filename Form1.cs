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
            private UsuariosController UsuariosController = new UsuariosController();
            private int filaSeleccionada = -1;
            private string accion = "guardar";
            private bool modoEdicion = false;

            public txtFechaRegistro()
            {
                InitializeComponent();
                InicializarTablaUsuarios();
                MostrarListaUsuarios();
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
                tabla.Clear();
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
                CbEmpresa.SelectedIndex = -1; // Desseleccionar cualquier opción
                txtTelefono.Text = "";
                txtDirrecion.Text = "";
                FechaRegistro.Value = DateTime.Now; // Establecer la fecha actual
                txtCantidadFacturas.Text = "";
                txtNumeroUltimaFactura.Text = "";
                txtMontoUltimaFactura.Text = "";
            }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esEmpresa = false; // Valor predeterminado si no se selecciona nada en el ComboBox

                if (CbEmpresa.SelectedItem != null)
                {
                    esEmpresa = CbEmpresa.SelectedItem.ToString() == "Sí";
                }

                string rut = txtRut.Text;

                // Si estamos guardando un nuevo usuario, verificamos si el RUT ya existe en la tabla
                if (!modoEdicion)
                {
                    foreach (DataRow row in tabla.Rows)
                    {
                        if (row["Rut"].ToString() == rut)
                        {
                            MessageBox.Show("El RUT ya existe en la tabla. Ingrese un RUT diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return; // Salir del método sin guardar
                        }
                    }
                }

                Usuario usuario = new Usuario()
                {
                    Rut = rut,
                    Nombre = txtNombre.Text,
                    EsEmpresa = esEmpresa,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDirrecion.Text,
                    FechaRegistro = FechaRegistro.Value,
                    CantidadFacturas = int.Parse(txtCantidadFacturas.Text),
                    NumeroUltimaFactura = int.Parse(txtNumeroUltimaFactura.Text),
                    MontoUltimaFactura = int.Parse(txtMontoUltimaFactura.Text)
                };

                if (modoEdicion)
                {
                    // Aplicar los cambios en modo edición
                    UsuariosController.ActualizarUsuario(filaSeleccionada, usuario);
                    modoEdicion = false;

                    // Desbloquear campos
                    txtRut.Enabled = true;
                    txtCantidadFacturas.Enabled = true;
                    txtNumeroUltimaFactura.Enabled = true;
                    txtMontoUltimaFactura.Enabled = true;
                }
                else
                {
                    UsuariosController.GuardarUsuario(usuario);
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
                LimpiarFormularioUsuarios();
            }

            private void btnModificar_Click(object sender, EventArgs e)
            {
                DataGridViewRow fila = dgUsuarios.Rows[filaSeleccionada];

                // Cargar los datos del registro seleccionado en los controles de edición
                txtRut.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();

                if (fila.Cells[2].Value.ToString() == "Sí")
                {
                    CbEmpresa.SelectedIndex = 0; // Si es empresa, selecciona "Sí"
                }
                else
                {
                    CbEmpresa.SelectedIndex = 1; // Si no es empresa, selecciona "No"
                }

                txtTelefono.Text = fila.Cells[3].Value.ToString();
                txtDirrecion.Text = fila.Cells[4].Value.ToString();
                FechaRegistro.Value = DateTime.Parse(fila.Cells[5].Value.ToString());
                txtCantidadFacturas.Text = fila.Cells[6].Value.ToString();
                txtNumeroUltimaFactura.Text = fila.Cells[7].Value.ToString();
                txtMontoUltimaFactura.Text = fila.Cells[8].Value.ToString();

                modoEdicion = true;

                // Bloquear campos no deseados
                txtRut.Enabled = false;
                txtCantidadFacturas.Enabled = false;
                txtNumeroUltimaFactura.Enabled = false;
                txtMontoUltimaFactura.Enabled = false;

                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                btnGuardar.Enabled = true; // Habilitar el botón "Guardar Cambios"
            }

            private void btnLimpiar_Click(object sender, EventArgs e)
            {
                LimpiarFormularioUsuarios();
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                modoEdicion = false;
                btnGuardar.Enabled = true;
            }
        }
    }


