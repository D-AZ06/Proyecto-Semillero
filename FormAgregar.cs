using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;


namespace Proyecto_Semillero
{
    public partial class FormAgregar : Form
    {
        Conexion conexion = new Conexion();

        public string tipo;

        public bool modoEdicion = false;
        public DataGridViewRow filaSeleccionada;

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

            else if (tipo == "Fase")
            {
                tabAgregar.SelectedTab = tabFases;
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
            else
            {
                MessageBox.Show("Selecciona primero una opción");
            }

            if (modoEdicion && filaSeleccionada != null)
            {
                if (tipo == "Usuario")
                {
                    txtIdUsuario.Enabled = false;
                    txtIdSemillero3.Enabled = false;
                    txtIdUsuario.Text = filaSeleccionada.Cells["idUsuario"].Value.ToString();
                    txtIdSemillero3.Text = filaSeleccionada.Cells["idSemillero"].Value.ToString();
                    txtContraseña.Text = filaSeleccionada.Cells["contraseñaUsuario"].Value.ToString();
                    txtNombre.Text = filaSeleccionada.Cells["nombresUsuario"].Value.ToString();
                    cboRol.Text = filaSeleccionada.Cells["rolUsuario"].Value.ToString();
                    txtTelefonoUsuario.Text = filaSeleccionada.Cells["telefonoUsuario"].Value.ToString();
                    txtCorreoUsuario.Text = filaSeleccionada.Cells["correoUsuario"].Value.ToString();
                    txtEdadUsuario.Text = filaSeleccionada.Cells["edadUsuario"].Value.ToString();
                    cboGeneroUsuario.Text = filaSeleccionada.Cells["generoUsuario"].Value.ToString();
                    cboEstado.Text = filaSeleccionada.Cells["estadoUsuario"].Value.ToString();

                    btnAgregarUsuario.Text = "Modificar"; // Cambia texto del botón para indicar que se está en modo edición
                }

                else if (tipo == "Semillero")
                {
                    txtIdSemillero.Enabled = false;
                    txtIdSemillero.Text = filaSeleccionada.Cells["idSemillero"].Value.ToString();
                    txtNombreSem.Text = filaSeleccionada.Cells["nombreSemillero"].Value.ToString();
                    txtLineaSem.Text = filaSeleccionada.Cells["lineaSemillero"].Value.ToString();
                    txtEnfoqueSem.Text = filaSeleccionada.Cells["enfoqueSemillero"].Value.ToString();
                    btnAgregarSem.Text = "Modificar";
                }
                else if (tipo == "Proyectos")
                {
                    txtProyecto.Enabled = false;
                    txtIdSemillero1.Enabled = false;
                    txtProyecto.Text = filaSeleccionada.Cells["idProyecto"].Value.ToString();
                    txtIdSemillero1.Text = filaSeleccionada.Cells["idSemillero"].Value.ToString();
                    txtTitulo.Text = filaSeleccionada.Cells["tituloProyecto"].Value.ToString();
                    txtObjetivo.Text = filaSeleccionada.Cells["objetivoProyecto"].Value.ToString();
                    txtDescripcion.Text = filaSeleccionada.Cells["descripcionProyecto"].Value.ToString();
                    txtFechaInicio.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaInicioProyecto"].Value).ToString("yyyy-MM-dd");
                    txtFechaFin.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaFinProyecto"].Value).ToString("yyyy-MM-dd");
                    btnAgregarProyec.Text = "Modificar";

                }
                else if (tipo == "Reportes")
                {
                    txtIdReporte.Enabled = false;
                    txtIdUsuario2.Enabled = false;
                    txtIdReporte.Text = filaSeleccionada.Cells["idReporte"].Value.ToString();
                    txtIdUsuario2.Text = filaSeleccionada.Cells["idUsuario"].Value.ToString();
                    txtFechaReporte.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaReporte"].Value).ToString("yyyy-MM-dd");
                    txtHoraReporte.Text = Convert.ToDateTime(filaSeleccionada.Cells["horaReporte"].Value).ToString("HH:mm:ss");
                    txtMotivo.Text = filaSeleccionada.Cells["motivoReporte"].Value.ToString();
                    btnAgregarReporte.Text = "Modificar";
                }
                else if (tipo == "Eventos")
                {
                    txtIdEvento.Enabled = false;
                    txtIdEvento.Text = filaSeleccionada.Cells["idEvento"].Value.ToString();
                    txtLugarEven.Text = filaSeleccionada.Cells["lugarEvento"].Value.ToString();
                    txtNombreEven.Text = filaSeleccionada.Cells["nombreEvento"].Value.ToString();
                    txtTipoEven.Text = filaSeleccionada.Cells["tipoEvento"].Value.ToString();
                    txtFechaEven.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaEvento"].Value).ToString("yyyy-MM-dd");
                    txtOrgEvento.Text = filaSeleccionada.Cells["organizadorEvento"].Value.ToString();
                    btnAgregarEvent.Text = "Modificar";
                }
                else if (tipo == "Patrocinadores")
                {
                    txtIdpatro.Enabled = false;
                    txtIdpatro.Text = filaSeleccionada.Cells["idPatrocinador"].Value.ToString();
                    txtNombrePatro.Text = filaSeleccionada.Cells["nombrePatrocinador"].Value.ToString();
                    txtTipoPatro.Text = filaSeleccionada.Cells["tipoPatrocinador"].Value.ToString();
                    txtTelefonoPatro.Text = filaSeleccionada.Cells["telefonoPatrocinador"].Value.ToString();
                    txtCorreoPatro.Text = filaSeleccionada.Cells["correoPatrocinador"].Value.ToString();
                    btnAgregarPatro.Text = "Modificar";
                }
                else if (tipo == "Actividad")
                {
                    txtIdAct.Enabled = false;
                    txtIdFase1.Enabled = false;

                    txtIdAct.Text = filaSeleccionada.Cells["idActividad"].Value.ToString();
                    txtIdFase1.Text = filaSeleccionada.Cells["idFase"].Value.ToString();
                    txtNombreAct.Text = filaSeleccionada.Cells["nombreActividad"].Value.ToString();
                    txtDuracionAct.Text = filaSeleccionada.Cells["duracionActividad"].Value.ToString();
                    txtFechaAct.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaActividad"].Value).ToString("yyyy-MM-dd");
                    btnAgregarAct.Text = "Modificar";
                }

                else if ((tipo == "Fase"))
                {
                    txtIdFase.Enabled = false;
                    txtProyecto1.Enabled = false;
                    txtIdFase.Text = filaSeleccionada.Cells["idFase"].Value.ToString();
                    txtProyecto1.Text = filaSeleccionada.Cells["idProyecto"].Value.ToString();
                    txtNombreFas.Text = filaSeleccionada.Cells["nombreFase"].Value.ToString();
                    txtDuracion.Text = filaSeleccionada.Cells["duracionFase"].Value.ToString();
                    btnAgregarFas.Text = "Modificar";
                }
            }
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
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

            // Validamos que el ID del usuario sea un número entero
            string rol = cboRol.Text;
            int? idSemillero = null;// Inicializamos idSemillero como null, ya que no es obligatorio para el rol de Administrador el ? permite que la variable pueda ser null, lo cual es útil para manejar el caso en el que el usuario sea un Administrador y no tenga un semillero asociado.

            if (rol != "Administrador")
            {
                if (txtIdSemillero3.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el ID del semillero");
                    return;
                }

                int idSem = int.Parse(txtIdSemillero3.Text);// Convertimos el texto del ID del semillero a un número entero para poder realizar la consulta a la base de datos y verificar si el semillero existe.

                // Validamos que el ID del semillero exista en la base de datos
                SqlCommand validar = new SqlCommand(
                    "select count(*) from Semillero where idSemillero = @idSemillero",
                    conexion.Conectar()
                );

                validar.Parameters.AddWithValue("@idSemillero", idSem);

                int existe = (int)validar.ExecuteScalar();// Ejecutamos la consulta y obtenemos el resultado, que es el número de registros que coinciden con el ID del semillero ingresado. Si el resultado es 0,
                                                          // significa que el semillero no existe en la base de datos, por lo que se muestra un mensaje de error al usuario y se cierra la conexión a la base de datos.

                if (existe == 0)
                {
                    MessageBox.Show("El semillero no existe");
                    conexion.cerrar();
                    return;
                }

                idSemillero = idSem;// Si el semillero existe, asignamos su ID a la variable idSemillero para que pueda ser utilizada posteriormente al insertar el nuevo usuario en la base de datos.
            }

            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text;
            string correo = txtCorreoUsuario.Text;
            string genero = cboGeneroUsuario.Text;
            string estado = cboEstado.Text;
            int idUsuario = int.Parse(txtIdUsuario.Text);
            long telefono = long.Parse(txtTelefonoUsuario.Text);
            int edad = int.Parse(txtEdadUsuario.Text);

            if (modoEdicion == true)
            {
                SqlCommand update;
                try
                {
                    update = new SqlCommand("UPDATE Usuario SET idSemillero = @idSemillero, contraseñaUsuario = @contraseñaUsuario, nombresUsuario = @nombresUsuario, rolUsuario = @rolUsuario, telefonoUsuario = @telefonoUsuario, correoUsuario = @correoUsuario, edadUsuario = @edadUsuario, generoUsuario = @generoUsuario, estadoUsuario = @estadoUsuario WHERE idUsuario = @idUsuario", conexion.Conectar());
                    update.Parameters.AddWithValue("@idUsuario", idUsuario);
                    update.Parameters.AddWithValue("@idSemillero", (object)idSemillero ?? DBNull.Value); // Si idSemillero es null, se asigna DBNull.Value para evitar errores en la consulta SQL
                    update.Parameters.AddWithValue("@contraseñaUsuario", contraseña);
                    update.Parameters.AddWithValue("@nombresUsuario", nombre);
                    update.Parameters.AddWithValue("@rolUsuario", rol);
                    update.Parameters.AddWithValue("@telefonoUsuario", telefono);
                    update.Parameters.AddWithValue("@correoUsuario", correo);
                    update.Parameters.AddWithValue("@edadUsuario", edad);
                    update.Parameters.AddWithValue("@generoUsuario", genero);
                    update.Parameters.AddWithValue("@estadoUsuario", estado);
                    update.ExecuteNonQuery();
                    MessageBox.Show("Usuario modificado correctamente");
                    conexion.cerrar();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
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
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
            if ((txtIdSemillero.Text == "") || (txtNombreSem.Text == "") || (txtLineaSem.Text == "") || (txtEnfoqueSem.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idSemillero = int.Parse(txtIdSemillero.Text);
                string nombreSemillero = txtNombreSem.Text;
                string lineaSemillero = txtLineaSem.Text;
                string enfoqueSemillero = txtEnfoqueSem.Text;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Semillero SET nombreSemillero = @nombreSemillero, lineaSemillero = @lineaSemillero, enfoqueSemillero = @enfoqueSemillero WHERE idSemillero = @idSemillero", conexion.Conectar());
                        update.Parameters.AddWithValue("@idSemillero", idSemillero);
                        update.Parameters.AddWithValue("@nombreSemillero", nombreSemillero);
                        update.Parameters.AddWithValue("@lineaSemillero", lineaSemillero);
                        update.Parameters.AddWithValue("@enfoqueSemillero", enfoqueSemillero);

                        update.ExecuteNonQuery();
                        MessageBox.Show("Semillero modificado correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAgregarEvent_Click(object sender, EventArgs e)
        {
            if ((txtIdEvento.Text == "") ||
                (txtLugarEven.Text == "") ||
                (txtNombreEven.Text == "") ||
                (txtTipoEven.Text == "") ||
                (txtFechaEven.Text == "") ||
                (txtOrgEvento.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idEvento = int.Parse(txtIdEvento.Text);
                string lugarEvento = txtLugarEven.Text;
                string nombreEvento = txtNombreEven.Text;
                string tipoEvento = txtTipoEven.Text;
                DateTime fechaEvento = DateTime.Parse(txtFechaEven.Text);
                string organizadorEvento = txtOrgEvento.Text;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Eventos SET lugarEvento = @lugarEvento, nombreEvento = @nombreEvento, tipoEvento = @tipoEvento, fechaEvento = @fechaEvento, organizadorEvento = @organizadorEvento WHERE idEvento = @idEvento", conexion.Conectar());
                        update.Parameters.AddWithValue("@idEvento", idEvento);
                        update.Parameters.AddWithValue("@lugarEvento", lugarEvento);
                        update.Parameters.AddWithValue("@nombreEvento", nombreEvento);
                        update.Parameters.AddWithValue("@tipoEvento", tipoEvento);
                        update.Parameters.AddWithValue("@fechaEvento", fechaEvento);
                        update.Parameters.AddWithValue("@organizadorEvento", organizadorEvento);

                        update.ExecuteNonQuery();
                        MessageBox.Show("Semillero modificado correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAgregarProyec_Click(object sender, EventArgs e)
        {
            if ((txtProyecto.Text == "") || (txtIdSemillero1.Text == "") || (txtTitulo.Text == "") || (txtObjetivo.Text == "") || (txtDescripcion.Text == "") || (txtFechaInicio.Text == "") || (txtFechaFin.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idProyecto = int.Parse(txtProyecto.Text);
                int idSemillero = int.Parse(txtIdSemillero1.Text);
                string tituloProyecto = txtTitulo.Text;
                string objetivoProyecto = txtObjetivo.Text;
                string descripcionProyecto = txtDescripcion.Text;
                DateTime fechaInicioProyecto = DateTime.Parse(txtFechaInicio.Text);
                DateTime fechaFinProyecto = DateTime.Parse(txtFechaFin.Text);

                int idSem = int.Parse(txtIdSemillero1.Text);

                SqlCommand validar = new SqlCommand(
                    "select count(*) from Semillero where idSemillero = @idSemillero",
                    conexion.Conectar()
                );

                validar.Parameters.AddWithValue("@idSemillero", idSem);

                int existe = (int)validar.ExecuteScalar();

                if (existe == 0)
                {
                    MessageBox.Show("el Semillero no existe");
                    conexion.cerrar();
                    return;
                }

                idSemillero = idSem;




                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Proyectos SET idSemillero = @idSemillero, tituloProyecto = @tituloProyecto, objetivoProyecto = @objetivoProyecto, descripcionProyecto = @descripcionProyecto, fechaInicioProyecto = @fechaInicioProyecto, fechaFinProyecto = @fechaFinProyecto WHERE idProyecto = @idProyecto", conexion.Conectar());
                        update.Parameters.AddWithValue("@idProyecto", idProyecto);
                        update.Parameters.AddWithValue("@idSemillero", idSemillero);
                        update.Parameters.AddWithValue("@tituloProyecto", tituloProyecto);
                        update.Parameters.AddWithValue("@objetivoProyecto", objetivoProyecto);
                        update.Parameters.AddWithValue("@descripcionProyecto", descripcionProyecto);
                        update.Parameters.AddWithValue("@fechaInicioProyecto", fechaInicioProyecto);
                        update.Parameters.AddWithValue("@fechaFinProyecto", fechaFinProyecto);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Proyecto modificado correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
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
                        MessageBox.Show("Evento guardado correctamente");
                        // cerrar conexión (como ya la tienes global)
                        conexion.cerrar();
                        // cerrar formulario
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnAgregarReporte_Click(object sender, EventArgs e)
        {
            if ((txtIdReporte.Text == "") || (txtIdUsuario2.Text == "") || (txtFechaReporte.Text == "") || (txtHoraReporte.Text == "") || (txtMotivo.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idReporte = int.Parse(txtIdReporte.Text);
                int idUsuario = int.Parse(txtIdUsuario2.Text);
                DateTime fechaReporte = DateTime.Parse(txtFechaReporte.Text);
                DateTime horaReporte = DateTime.Parse(txtHoraReporte.Text);
                string motivoReporte = (txtMotivo.Text);

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Reportes SET idUsuario = @idUsuario, fechaReporte = @fechaReporte, horaReporte = @horaReporte, motivoReporte = @motivoReporte WHERE idReporte = @idReporte", conexion.Conectar());
                        update.Parameters.AddWithValue("@idReporte", idReporte);
                        update.Parameters.AddWithValue("@idUsuario", idUsuario);
                        update.Parameters.AddWithValue("@fechaReporte", fechaReporte);
                        update.Parameters.AddWithValue("@horaReporte", horaReporte);
                        update.Parameters.AddWithValue("@motivoReporte", motivoReporte);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Reporte modificado correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    SqlCommand insert;
                    try
                    {
                        insert = new SqlCommand("INSERT INTO Reportes (idReporte, idUsuario, fechaReporte, horaReporte, motivoReporte) " +
                            "VALUES (@idReporte, @idUsuario, @fechaReporte, @horaReporte, @motivoReporte)",
                            conexion.Conectar()
                        );
                        insert.CommandType = CommandType.Text;
                        insert.Parameters.AddWithValue("@idReporte", idReporte);
                        insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                        insert.Parameters.AddWithValue("@fechaReporte", fechaReporte);
                        insert.Parameters.AddWithValue("@horaReporte", horaReporte);
                        insert.Parameters.AddWithValue("@motivoReporte", motivoReporte);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Reporte guardado correctamente");
                        // cerrar conexión 
                        conexion.cerrar();
                        // cerrar formulario
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
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

        private void btnAgregarPatro_Click(object sender, EventArgs e)
        {
            if ((txtIdpatro.Text == "") || (txtNombrePatro.Text == "") || (txtTipoPatro.Text == "") || (txtTelefonoPatro.Text == "") || (txtCorreoPatro.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idPatrocinador = int.Parse(txtIdpatro.Text);
                string nombrePatrocinador = txtNombrePatro.Text;
                string tipoPatrocinador = txtTipoPatro.Text;
                long telefonoPatrocinador = long.Parse(txtTelefonoPatro.Text);
                string correoPatrocinador = txtCorreoPatro.Text;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Patrocinadores SET nombrePatrocinador = @nombrePatrocinador, tipoPatrocinador = @tipoPatrocinador, telefonoPatrocinador = @telefonoPatrocinador, correoPatrocinador = @correoPatrocinador WHERE idPatrocinador = @idPatrocinador", conexion.Conectar());
                        update.Parameters.AddWithValue("@idPatrocinador", idPatrocinador);
                        update.Parameters.AddWithValue("@nombrePatrocinador", nombrePatrocinador);
                        update.Parameters.AddWithValue("@tipoPatrocinador", tipoPatrocinador);
                        update.Parameters.AddWithValue("@telefonoPatrocinador", telefonoPatrocinador);
                        update.Parameters.AddWithValue("@correoPatrocinador", correoPatrocinador);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Patrocinador modificado correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    SqlCommand insert;
                    try
                    {
                        insert = new SqlCommand("INSERT INTO Patrocinadores (idPatrocinador, nombrePatrocinador, tipoPatrocinador, telefonoPatrocinador, correoPatrocinador) " +
                            "VALUES (@idPatrocinador, @nombrePatrocinador, @tipoPatrocinador, @telefonoPatrocinador, @correoPatrocinador)",
                            conexion.Conectar()
                        );
                        insert.CommandType = CommandType.Text;
                        insert.Parameters.AddWithValue("@idPatrocinador", idPatrocinador);
                        insert.Parameters.AddWithValue("@nombrePatrocinador", nombrePatrocinador);
                        insert.Parameters.AddWithValue("@tipoPatrocinador", tipoPatrocinador);
                        insert.Parameters.AddWithValue("@telefonoPatrocinador", telefonoPatrocinador);
                        insert.Parameters.AddWithValue("@correoPatrocinador", correoPatrocinador);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Patrocinador guardado correctamente");
                        // cerrar conexión 
                        conexion.cerrar();
                        // cerrar formulario
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void tabFases_Click(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void label45_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarFas_Click(object sender, EventArgs e)
        {
            if ((txtIdFase.Text == "") || (txtProyecto1.Text == "") || (txtNombreFas.Text == "") || (txtNombreFas.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

            else
            {
                int idFase = int.Parse(txtIdFase.Text);
                int idProyecto = int.Parse(txtProyecto1.Text);
                string nombreFase = txtNombreFas.Text;
                string duracionFase = txtDuracion.Text;

                int idPro = int.Parse(txtProyecto1.Text);

                SqlCommand validar = new SqlCommand(
                    "select count(*) from Proyectos where idProyecto = @idProyecto",
                    conexion.Conectar()
                );

                validar.Parameters.AddWithValue("@idProyecto", idPro);

                int existe = (int)validar.ExecuteScalar();

                if (existe == 0)
                {
                    MessageBox.Show("El proyecto no existe");
                    conexion.cerrar();
                    return;
                }

                idProyecto = idPro;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Fase SET idProyecto = @idProyecto, nombreFase = @nombreFase, duracionFase = @duracionFase WHERE idFase = @idFase", conexion.Conectar());
                        update.Parameters.AddWithValue("@idFase", idFase);
                        update.Parameters.AddWithValue("@idProyecto", idProyecto);
                        update.Parameters.AddWithValue("@nombreFase", nombreFase);
                        update.Parameters.AddWithValue("@duracionFase", duracionFase);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Fase modificada correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        SqlCommand insert = new SqlCommand(
                            "INSERT INTO Fase (idFase, idProyecto, nombreFase, duracionFase) " +
                            "VALUES (@idFase, @idProyecto, @nombreFase, @duracionFase)",
                            conexion.Conectar()
                        );

                        insert.Parameters.AddWithValue("@idFase", idFase);
                        insert.Parameters.AddWithValue("@idProyecto", idProyecto);
                        insert.Parameters.AddWithValue("@nombreFase", nombreFase);
                        insert.Parameters.AddWithValue("@duracionFase", duracionFase);

                        insert.ExecuteNonQuery();

                        MessageBox.Show("Fase guardada correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }


            }
        }

        private void btnAgregarAct_Click(object sender, EventArgs e)
        {
            if ((txtIdAct.Text == "") || (txtIdFase1.Text == "") || (txtDuracionAct.Text == "") || (txtNombreAct.Text == "") || (txtFechaAct.Text == "") )
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

            else
            {
                int idActividad = int.Parse(txtIdAct.Text);
                int idFase = int.Parse(txtIdFase1.Text);
                string duracionAct = txtDuracionAct.Text;
                string nombreAct = txtNombreAct.Text;
                DateTime fechaAct = DateTime.Parse(txtFechaAct.Text);

                int idFas = int.Parse(txtIdFase1.Text);

                SqlCommand validar = new SqlCommand(
                    "select count(*) from Fase where idFase = @idFase",
                    conexion.Conectar()
                );

                validar.Parameters.AddWithValue("@idFase", idFas);

                int existe = (int)validar.ExecuteScalar();

                if (existe == 0)
                {
                    MessageBox.Show("La Actividad no existe");
                    conexion.cerrar();
                    return;
                }

                idFase = idFas;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Actividad SET idFase = @idFase, nombreActividad = @nombreActividad, duracionActividad = @duracionActividad, fechaActividad = @fechaActividad WHERE idActividad = @idActividad", conexion.Conectar());
                        update.Parameters.AddWithValue("@idActividad", idActividad);
                        update.Parameters.AddWithValue("@idFase", idFase);
                        update.Parameters.AddWithValue("@nombreActividad", nombreAct);
                        update.Parameters.AddWithValue("@duracionActividad", duracionAct);
                        update.Parameters.AddWithValue("@fechaActividad", fechaAct);

                        update.ExecuteNonQuery();

                        MessageBox.Show("Actividad modificada correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        SqlCommand insert = new SqlCommand(
                            "INSERT INTO Actividad (idActividad, idFase, nombreActividad, duracionActividad, fechaActividad) " +
                            "VALUES (@idActividad, @idFase, @nombreActividad, @duracionActividad, @fechaActividad)",
                            conexion.Conectar()
                        );

                        insert.Parameters.AddWithValue("@idActividad", idActividad);
                        insert.Parameters.AddWithValue("@idFase", idFase);
                        insert.Parameters.AddWithValue("@nombreActividad", nombreAct);
                        insert.Parameters.AddWithValue("@duracionActividad", duracionAct);
                        insert.Parameters.AddWithValue("@fechaActividad", fechaAct);

                        insert.ExecuteNonQuery();

                        MessageBox.Show("Actividad guardada correctamente");
                        conexion.cerrar();
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

            }
        }
    }
}
