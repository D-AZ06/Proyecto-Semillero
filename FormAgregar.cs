using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_Semillero
{
    public partial class FormAgregar : Form
    {
        Conexion conexion = new Conexion();

        public string tipo;

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            tabAgregar.Appearance = TabAppearance.FlatButtons;
            tabAgregar.ItemSize = new Size(0, 1);
            tabAgregar.SizeMode = TabSizeMode.Fixed;
            tabAgregar.BackColor = Color.FromArgb(200, Color.White);


            if (tipo == "Usuario")
            {
                tabAgregar.SelectedTab = tabUsuario;
            }
            else if (tipo == "Semillero")
            {
                tabAgregar.SelectedTab = tabSemillero;
            }

            else if (tipo == "Proyectos")
            {
                tabAgregar.SelectedTab = tabProyectos;
            }

            else if (tipo == "Reportes")
            {
                tabAgregar.SelectedTab = tabReportes;
            }

            else if (tipo == "Actividad")
            {
                tabAgregar.SelectedTab = tabActividades;
            }
            else if (tipo == "Patrocinadores")
            {
                tabAgregar.SelectedTab = tabPatroc;
            }

            else if (tipo == "Eventos")
            {
                tabAgregar.SelectedTab = tabEventos;
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtIdUsuario.Text);
            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text;
            string rol = cboRol.Text;
            long telefono = long.Parse(txtTelefonoUsuario.Text);
            string correo = txtCorreoUsuario.Text;
            int edad = int.Parse(txtEdadUsuario.Text);
            string genero = cboGeneroUsuario.Text;
            string estado = cboEstado.Text;

            if ((txtIdUsuario.Text == "") || (txtContraseña.Text == "") || (txtNombre.Text == "") || (cboRol.SelectedIndex == 0) || (txtTelefonoUsuario.Text == "") || (txtCorreoUsuario.Text == "") || (txtEdadUsuario.Text == "") || (cboGeneroUsuario.Text == "") || (cboEstado.SelectedIndex == 0))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

            else
            {
                SqlCommand insert;

                try
                {
                    insert = new SqlCommand("INSERT INTO Usuario (idUsuario, contraseñaUsuario, nombresUsuario, rolUsuario, telefonoUsuario, correoUsuario, edadUsuario, generoUsuario, estadoUsuario) " +
                        "VALUES (@idUsuario, @contraseña, @nombre, @rol, @telefono, @correo, @edad, @genero, @estado)",
                        conexion.Conectar()
                    );

                    insert.CommandType = CommandType.Text;

                    insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                    insert.Parameters.AddWithValue("@contraseña", contraseña);
                    insert.Parameters.AddWithValue("@nombre", nombre);
                    insert.Parameters.AddWithValue("@rol", rol);
                    insert.Parameters.AddWithValue("@telefono", telefono);
                    insert.Parameters.AddWithValue("@correo", correo);
                    insert.Parameters.AddWithValue("@edad", edad);
                    insert.Parameters.AddWithValue("@genero", genero);
                    insert.Parameters.AddWithValue("@estado", estado);

                    insert.ExecuteNonQuery();

                    MessageBox.Show("Usuario guardado correctamente");

                    // cerrar conexión (como ya la tienes global)
                    conexion.cerrar();

                    // cerrar formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarSem_Click(object sender, EventArgs e)
        {
            int idSemillero = int.Parse(txtIdSemillero.Text);
            int idUsuario = int.Parse(txtIdUsuarioSem.Text);
            string nombreSemillero = txtNombreSem.Text;
            string lineaSemillero = txtLineaSem.Text;
            string enfoqueSemillero = txtEnfoqueSem.Text;

            if ((txtIdSemillero.Text == "") || (txtIdUsuarioSem.Text == "") || (txtNombreSem.Text == "") || (txtLineaSem.Text == "") || (txtEnfoqueSem.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                SqlCommand insert;
                try
                {
                    insert = new SqlCommand("INSERT INTO Semillero (idSemillero, idUsuario, nombreSemillero, lineaSemillero, enfoqueSemillero) " +
                        "VALUES (@idSemillero, @idUsuario, @nombreSemillero, @lineaSemillero, @enfoqueSemillero)",
                        conexion.Conectar()
                    );
                    insert.CommandType = CommandType.Text;
                    insert.Parameters.AddWithValue("@idSemillero", idSemillero);
                    insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                    insert.Parameters.AddWithValue("@nombreSemillero", nombreSemillero);
                    insert.Parameters.AddWithValue("@lineaSemillero", lineaSemillero);
                    insert.Parameters.AddWithValue("@enfoqueSemillero", enfoqueSemillero);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Semillero guardado correctamente");
                    // cerrar conexión (como ya la tienes global)
                    conexion.cerrar();
                    // cerrar formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregarEvent_Click(object sender, EventArgs e)
        {
            int idEvento = int.Parse(txtIdEvento.Text);
            string lugarEvento = txtLugarEven.Text;
            string nombreEvento = txtNombreEven.Text;
            string tipoEvento = txtTipoEven.Text;
            DateTime fechaEvento = DateTime.Parse(txtFechaEven.Text);
            string organizadorEvento = txtOrgEvento.Text;

            if ((txtIdEvento.Text == "") || (txtLugarEven.Text == "") || (txtNombreEven.Text == "") || (txtTipoEven.Text == "") || (txtFechaEven.Text == "") || (txtOrgEvento.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                SqlCommand insert;
                try
                {
                    insert = new SqlCommand("INSERT INTO Eventos (idEvento, lugarEvento, nombreEvento, tipoEvento, fechaEvento, organizadorEvento) " +
                        "VALUES (@idEvento, @lugarEvento, @nombreEvento, @tipoEvento, @fechaEvento, @organizadorEvento)",
                        conexion.Conectar()
                    );
                    insert.CommandType = CommandType.Text;
                    insert.Parameters.AddWithValue("@idEvento", idEvento);
                    insert.Parameters.AddWithValue("@lugarEvento", lugarEvento);
                    insert.Parameters.AddWithValue("@nombreEvento", nombreEvento);
                    insert.Parameters.AddWithValue("@tipoEvento", tipoEvento);
                    insert.Parameters.AddWithValue("@fechaEvento", fechaEvento);
                    insert.Parameters.AddWithValue("@organizadorEvento", organizadorEvento);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Evento guardado correctamente");
                    // cerrar conexión (como ya la tienes global)
                    conexion.cerrar();
                    // cerrar formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregarProyec_Click(object sender, EventArgs e)
        {
            int idProyecto = int.Parse(txtProyecto.Text);
            int idSemillero = int.Parse(txtIdSemillero1.Text);
            string tituloProyecto = txtTitulo.Text;
            string objetivoProyecto = txtObjetivo.Text;
            string descripcionProyecto = txtDescripcion.Text;
            DateTime fechaInicioProyecto = DateTime.Parse(txtFechaInicio.Text);
            DateTime fechaFinProyecto = DateTime.Parse(txtFechaFin.Text);

            if ((txtProyecto.Text == "") || (txtIdSemillero1.Text == "") || (txtTitulo.Text == "") || (txtObjetivo.Text == "") || (txtDescripcion.Text == "") || (txtFechaInicio.Text == "") || (txtFechaFin.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                SqlCommand insert;
                try
                {
                    insert = new SqlCommand("INSERT INTO Proyectos (idProyecto, idSemillero, tituloProyecto, objetivoProyecto, descripcionProyecto, fechaInicioProyecto, fechaFinProyecto) " +
                        "VALUES (@idProyecto, @idSemillero, @tituloProyecto, @objetivoProyecto, @descripcionProyecto, @fechaInicioProyecto, @fechaFinProyecto)",
                        conexion.Conectar()
                    );
                    insert.CommandType = CommandType.Text;
                    insert.Parameters.AddWithValue("@idProyecto", idProyecto);
                    insert.Parameters.AddWithValue("@idSemillero", idSemillero);
                    insert.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);
                    insert.Parameters.AddWithValue("@objetivoProyecto", objetivoProyecto);
                    insert.Parameters.AddWithValue("@descripcionProyecto", descripcionProyecto);
                    insert.Parameters.AddWithValue("@fechaInicioProyecto", fechaInicioProyecto);
                    insert.Parameters.AddWithValue("@fechaFinProyecto", fechaFinProyecto);
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Proyecto guardado correctamente");
                    // cerrar conexión (como ya la tienes global)
                    conexion.cerrar();
                    // cerrar formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            int idReporte = int.Parse(txtIdReporte.Text);
            DateTime fechaReporte = DateTime.Parse(txtFechaReporte.Text);
            DateTime horaReporte = DateTime.Parse(txtHoraReporte.Text);
            string motivoReporte = (txtMotivo.Text);

        }
    }
}
