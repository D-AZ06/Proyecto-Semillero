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
            else {
                MessageBox.Show("Selecciona primero una opción");
            }

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text.Trim() == "" ||
                txtContraseña.Text.Trim() == "" ||
                txtNombre.Text.Trim() == "" ||
                cboRol.Text == "" ||
                txtTelefonoUsuario.Text.Trim() == "" ||
                txtCorreoUsuario.Text.Trim() == "" ||
                txtEdadUsuario.Text.Trim() == "" ||
                cboGeneroUsuario.Text == "" ||
                cboEstado.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string rol = cboRol.Text;

            int? idSemillero = null;

            if (rol != "Administrador")
            {
                if (txtIdSemillero3.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el ID del semillero");
                    return;
                }

                if (!int.TryParse(txtIdSemillero3.Text, out int idSem))
                {
                    MessageBox.Show("ID Semillero inválido");
                    return;
                }

                idSemillero = idSem;

                if (rol != "Administrador")
                {
                    SqlCommand validar = new SqlCommand(
                        "SELECT COUNT(*) FROM Semillero WHERE idSemillero = @idSemillero",
                        conexion.Conectar()
                    );

                    validar.Parameters.AddWithValue("@idSemillero", idSemillero);

                    int cantidad = (int)validar.ExecuteScalar();

                    if (cantidad == 0)
                    {
                        MessageBox.Show("El ID del semillero no existe");
                        conexion.cerrar();
                        return;
                    }
                }
            }

            if (!int.TryParse(txtIdUsuario.Text, out int idUsuario))
            {
                MessageBox.Show("ID Usuario inválido");
                return;
            }

            if (!long.TryParse(txtTelefonoUsuario.Text, out long telefono))
            {
                MessageBox.Show("Teléfono inválido");
                return;
            }

            if (!int.TryParse(txtEdadUsuario.Text, out int edad))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreoUsuario.Text;
            string genero = cboGeneroUsuario.Text;
            string estado = cboEstado.Text;

            try
            {
                SqlCommand insert = new SqlCommand(
                    "INSERT INTO Usuario (idUsuario, idSemillero, contraseñaUsuario, nombresUsuario, rolUsuario, telefonoUsuario, correoUsuario, edadUsuario, generoUsuario, estadoUsuario) " +
                    "VALUES (@idUsuario, @idSemillero, @contraseña, @nombre, @rol, @telefono, @correo, @edad, @genero, @estado)",
                    conexion.Conectar()
                );

                insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                insert.Parameters.AddWithValue("@idSemillero", (object)idSemillero ?? DBNull.Value);
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
                conexion.cerrar();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
          
            string nombreSemillero = txtNombreSem.Text;
            string lineaSemillero = txtLineaSem.Text;
            string enfoqueSemillero = txtEnfoqueSem.Text;

            if ((txtIdSemillero.Text == "")  || (txtNombreSem.Text == "") || (txtLineaSem.Text == "") || (txtEnfoqueSem.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                SqlCommand insert;
                try
                {
                    insert = new SqlCommand("INSERT INTO Semillero (idSemillero,nombreSemillero, lineaSemillero, enfoqueSemillero) " +
                        "VALUES (@idSemillero, @nombreSemillero, @lineaSemillero, @enfoqueSemillero)",
                        conexion.Conectar()
                    );
                    insert.CommandType = CommandType.Text;
                    insert.Parameters.AddWithValue("@idSemillero", idSemillero);
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
                    // cerrar conexión 
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

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRol.Text == "Administrador")
            {
                txtIdSemillero3.Enabled = false;
                txtIdSemillero3.Text = "";
            }
            else
            {
                txtIdSemillero3.Enabled = true;
            }
        }
    }
}
