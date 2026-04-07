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

        public bool lider = false;

        public int idSemilleroLider;

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

            // Dependiendo del valor de la variable "tipo", se selecciona la pestaña correspondiente en el control tabAgregar para mostrar el formulario adecuado para agregar o modificar registros relacionados con ese tipo específico. Esto permite que el mismo formulario pueda ser utilizado para diferentes tipos de registros, mostrando solo los campos y controles relevantes para cada tipo, lo que mejora la usabilidad y organización del formulario.
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
            else if (tipo == "Reuniones")
            {
                tabAgregar.SelectedTab = tabReunion;
            }
            else if (tipo == "ProyectosEventos")
            {
                tabAgregar.SelectedTab = tabProyectosEventos;
            }
            else if (tipo == "EventoPatrocinadores")
            {
                tabAgregar.SelectedTab = tabEventoPatrocinadores;
            }

            else
            {
                MessageBox.Show("Selecciona primero una opción");
            }

            if (modoEdicion == false) // Si no estamos en modo edición, generamos un nuevo ID para el registro que se va a crear utilizando el método generadorID de la clase GenerarID. Este método toma como parámetros el nombre de la tabla, el nombre de la columna que representa el ID, un número inicial para generar el ID y la conexión a la base de datos. El ID generado se asigna al campo correspondiente en el formulario y se establece como de solo lectura para evitar que el usuario lo modifique, ya que los IDs deben ser únicos y generados automáticamente para garantizar la integridad de los datos en la base de datos.
            {
                if (tipo == "Usuario")
                {
                    txtIdUsuario.Text = GenerarID.generadorID("Usuario", "idUsuario", 10, conexion).ToString();
                    txtIdUsuario.ReadOnly = true;
                }
                else if (tipo == "Semillero")
                {
                    txtIdSemillero.Text = GenerarID.generadorID("Semillero", "idSemillero", 20, conexion).ToString();
                    txtIdSemillero.ReadOnly = true;
                }
                else if (tipo == "Proyectos")
                {
                    txtProyecto.Text = GenerarID.generadorID("Proyectos", "idProyecto", 30, conexion).ToString();
                    txtProyecto.ReadOnly = true;
                }
                else if (tipo == "Reportes")
                {
                    txtIdReporte.Text = GenerarID.generadorID("Reportes", "idReporte", 70, conexion).ToString();
                    txtIdReporte.ReadOnly = true;
                }
                else if (tipo == "Eventos")
                {
                    txtIdEvento.Text = GenerarID.generadorID("Eventos", "idEvento", 60, conexion).ToString();
                    txtIdEvento.ReadOnly = true;
                }
                else if (tipo == "Patrocinadores")
                {
                    txtIdpatro.Text = GenerarID.generadorID("Patrocinadores", "idPatrocinador", 80, conexion).ToString();
                    txtIdpatro.ReadOnly = true;
                }
                else if (tipo == "Actividad")
                {
                    txtIdAct.Text = GenerarID.generadorID("Actividad", "idActividad", 50, conexion).ToString();
                    txtIdAct.ReadOnly = true;
                }
                else if ((tipo == "Fase"))
                {
                    txtIdFase.Text = GenerarID.generadorID("Fase", "idFase", 40, conexion).ToString();
                    txtIdFase.ReadOnly = true;
                }
                else if (tipo == "Reuniones")
                {
                    txtIdReu.Text = GenerarID.generadorID("Reuniones", "idReunion", 90, conexion).ToString();
                    txtIdReu.ReadOnly = true;
                }
            }

            if (modoEdicion && filaSeleccionada != null)// Si estamos en modo edición y se ha seleccionado una fila de datos para modificar, se cargan los datos de esa fila en los campos correspondientes del formulario para que el usuario pueda ver y editar la información existente. Esto permite que el mismo formulario sea utilizado tanto para agregar nuevos registros como para modificar registros existentes, mejorando la eficiencia y usabilidad del sistema.
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
                    txtFechaAct.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaEntregaActividad"].Value).ToString("yyyy-MM-dd");
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

                else if (tipo == "Reuniones")
                {
                    txtIdReu.Enabled = false;
                    txtIdUsuario3.Enabled = false;
                    txtIdReu.Text = filaSeleccionada.Cells["idReunion"].Value.ToString();
                    txtIdUsuario3.Text = filaSeleccionada.Cells["idUsuario"].Value.ToString();
                    txtTipoReu.Text = filaSeleccionada.Cells["tipoReunion"].Value.ToString();
                    txtHoraReu.Text = filaSeleccionada.Cells["horaReunion"].Value.ToString();
                    txtMotivoReu.Text = filaSeleccionada.Cells["motivoReunion"].Value.ToString();
                    txtFechaReu.Text = Convert.ToDateTime(filaSeleccionada.Cells["fechaReunion"].Value).ToString("yyyy-MM-dd");
                    btnAgregarReu.Text = "Modificar";
                }

                else if (tipo == "ProyectosEventos")
                { 
                    txtIdEvento_PE.Enabled = false;
                    txtIdProyecto_PE.Enabled = false;
                    txtIdEvento_PE.Text = filaSeleccionada.Cells["idEvento"].Value.ToString();
                    txtIdProyecto_PE.Text = filaSeleccionada.Cells["idProyecto"].Value.ToString();
                    btnAgregarProyectosEventos.Text = "Modificar";
                }

                else if (tipo == "EventoPatrocinadores")
                {
                    txtIdPatro_EP.Enabled = false;
                    txtIdEvento_EP.Enabled = false;
                    txtIdPatro_EP.Text = filaSeleccionada.Cells["idPatrocinador"].Value.ToString();
                    txtIdEvento_EP.Text = filaSeleccionada.Cells["idEvento"].Value.ToString();
                    btnAgregarEventoPatro.Text = "Modificar";
                }
            }

            if (lider == true && modoEdicion == false) // permite al lider solo registrar cosas de su semillero
            {
                txtIdSemillero3.Text = idSemilleroLider.ToString();
                txtIdSemillero3.ReadOnly = true;
                cboRol.Items.Remove("Administrador");
                txtIdSemillero1.Text = idSemilleroLider.ToString();
                txtIdSemillero1.ReadOnly = true;
            }

            if (lider == true && modoEdicion == true) // permite al lider solo modificar cosas de su semillero
            {
                cboRol.Enabled = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRol.Text == "Administrador")// Si el rol seleccionado en el combo box cboRol es "Administrador", se deshabilita el campo txtIdSemillero3 y se borra su contenido, ya que los administradores no están asociados a ningún semillero. Esto garantiza que los usuarios con el rol de administrador no puedan ingresar un ID de semillero, lo que es coherente con la lógica del sistema y evita errores relacionados con la asociación de administradores a semilleros.
            {
                txtIdSemillero3.Enabled = false;
                txtIdSemillero3.Text = "";
            }
            else
            {
                txtIdSemillero3.Enabled = true;
            }
        }

        public bool ValidarFecha(Guna.UI2.WinForms.Guna2TextBox txt) // Este método se encarga de validar que la fecha ingresada en el campo txtFechaEven tenga un formato correcto (yyyy-MM-dd) y que no sea una fecha anterior a la fecha actual. Si la fecha es válida, el método devuelve true; de lo contrario, muestra un mensaje de error y devuelve false.
        {
            DateTime fechaIngresada;

            if (DateTime.TryParseExact(txt.Text, "yyyy-MM-dd",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaIngresada)) // Intentamos convertir el texto ingresado en el campo txtFechaEven a un objeto DateTime utilizando el formato "yyyy-MM-dd". Si la conversión es exitosa, se almacena la fecha resultante en la variable fechaIngresada y se continúa con la validación de la fecha. Si la conversión falla, se muestra un mensaje de error indicando que el formato es inválido y se devuelve false.
            {
                if (fechaIngresada < DateTime.Today) // Si la fecha ingresada es anterior a la fecha actual (DateTime.Today), se muestra un mensaje de error indicando que no se permiten fechas anteriores a hoy, se establece el foco en el campo txtFechaEven para que el usuario pueda corregir la fecha, y se devuelve false para indicar que la validación ha fallado. Esto garantiza que solo se puedan ingresar fechas válidas y futuras en el campo correspondiente.
                {
                    MessageBox.Show("No se permiten fechas anteriores a hoy.");
                    txt.Focus();
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Formato inválido. Use yyyy-MM-dd.");
                txt.Focus();
                return false;
            }
        }

        public bool ValidarIdUnico(string nombreTabla, string campoId, int id) // metodo para validar que no registre con ID repetido
        {
            try
            {
                //aqui se hace la consulta a la base de datos para verificar si el ID ya existe en la tabla correspondiente.
                SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM " + nombreTabla + " WHERE " + campoId + " = @id",
                    conexion.Conectar()
                );
                cmd.Parameters.AddWithValue("@id", id);// Agregamos el parámetro @id a la consulta SQL para filtrar los registros por el ID que se desea validar. Esto nos permitirá contar cuántos registros en la tabla correspondiente tienen el mismo ID que se está intentando registrar.

                int count = (int)cmd.ExecuteScalar();
                conexion.cerrar();

                if (count > 0)// Si el resultado de la consulta es mayor que 0, significa que ya existe un registro con el mismo ID en la tabla correspondiente. En este caso, se muestra un mensaje de error indicando que el ID ya existe y se devuelve false para indicar que la validación ha fallado, evitando que se intente guardar un registro con un ID duplicado en la base de datos.
                {
                    MessageBox.Show("El ID " + id + " ya existe en la tabla " + nombreTabla + ". Ingrese un ID diferente.");// Se muestra un mensaje de error indicando que el ID ya existe en la tabla correspondiente y se solicita al usuario que ingrese un ID diferente para evitar duplicados en la base de datos.
                    return false;
                }
                return true;// Si el resultado de la consulta es 0, significa que no existe ningún registro con el mismo ID en la tabla correspondiente. En este caso, se devuelve true para indicar que la validación ha sido exitosa y se puede proceder a guardar el nuevo registro con el ID ingresado.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar ID: " + ex.Message);
                return false;
            }
        }

        private void btnAgregarUsuario_Click_1(object sender, EventArgs e)
        {
            //se valida que los campos esten completos
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
            
            
            if (txtTelefonoUsuario.Text.Length != 10 || !txtTelefonoUsuario.Text.All(char.IsDigit))
            {
                MessageBox.Show("Teléfono inválido, debe contener 10 dígitos numéricos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correo = txtCorreoUsuario.Text;

            int arroba = correo.IndexOf("@");
            int punto = correo.LastIndexOf(".");

            if (arroba <= 0 || punto <= arroba + 1 || punto == correo.Length - 1)
            {
                MessageBox.Show("Correo inválido, formato valido: nombre@correo.com", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Validamos que el ID del usuario sea un número entero
            string rol = cboRol.Text;
            int idSemillero = 0; // inicializamos la variable idSemillero en 0 para que pueda ser utilizada posteriormente en el código, incluso si el rol del usuario es "Administrador" y no se requiere un ID de semillero. Esto nos permite evitar errores relacionados con variables no inicializadas y garantiza que el código funcione correctamente independientemente del rol seleccionado para el nuevo usuario.

            //si el rol del usuario no es "Administrador", se realiza una validación adicional para verificar que se haya ingresado un ID de semillero en el campo txtIdSemillero3. Si el campo está vacío, se muestra un mensaje de error indicando que se debe ingresar el ID del semillero, y se detiene la ejecución del método, evitando que se intente guardar un usuario sin un ID de semillero asociado. Esto garantiza que los usuarios que no son administradores estén correctamente asociados a un semillero en la base de datos.
            if (rol != "Administrador")
            {
                if (txtIdSemillero3.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el ID del semillero");
                    return;
                }

                int idSem = int.Parse(txtIdSemillero3.Text);// Convertimos el texto del ID del semillero a un número entero para poder realizar la consulta a la base de datos y verificar si el semillero existe.

                // Validamos que el ID del semillero exista en la base de datos
                SqlCommand validarSemillero = new SqlCommand(
                    "select count(*) from Semillero where idSemillero = @idSemillero",
                    conexion.Conectar()
                );

                validarSemillero.Parameters.AddWithValue("@idSemillero", idSem);

                int existeSemillero = (int)validarSemillero.ExecuteScalar();// Ejecutamos la consulta y obtenemos el resultado, que es el número de registros que coinciden con el ID del semillero ingresado. Si el resultado es 0,
                                                          // significa que el semillero no existe en la base de datos

                if (existeSemillero == 0)
                {
                    MessageBox.Show("El semillero no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    conexion.cerrar();
                    return;
                }

                idSemillero = idSem;// Si el semillero existe, asignamos su ID a la variable idSemillero para que pueda ser utilizada posteriormente al insertar el nuevo usuario en la base de datos.
            }

            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text;
            string genero = cboGeneroUsuario.Text;
            string estado = cboEstado.Text;
            int idUsuario = int.Parse(txtIdUsuario.Text);
            long telefono = long.Parse(txtTelefonoUsuario.Text);
            int edad = int.Parse(txtEdadUsuario.Text);

            if (rol != "Administrador") // Si el rol del usuario no es "Administrador", se realiza una validación adicional para verificar que exista al menos un líder registrado para el semillero al que se va a asociar el nuevo usuario. Esto se hace mediante una consulta a la base de datos que cuenta cuántos usuarios con el rol de "Lider" están asociados al mismo semillero. Si no hay ningún líder registrado para ese semillero y el nuevo usuario no tiene el rol de "Lider", se muestra un mensaje de error indicando que primero se debe registrar un líder para ese semillero, y se detiene la ejecución del método, evitando que se intente guardar un usuario sin un líder asociado.
            {
                SqlCommand validarLider = new SqlCommand(
                    "select count(*) from Usuario where idSemillero = @idSemillero and rolUsuario = 'Lider'",
                    conexion.Conectar() // Establecemos la conexión a la base de datos utilizando el método Conectar de la clase Conexion para ejecutar la consulta que valida si existe al menos un líder registrado para el semillero al que se va a asociar el nuevo usuario.
                );

                validarLider.Parameters.AddWithValue("@idSemillero", idSemillero); // Agregamos el parámetro @idSemillero a la consulta SQL para filtrar los usuarios por el ID del semillero al que se va a asociar el nuevo usuario. Esto nos permitirá contar cuántos usuarios con el rol de "Lider" están asociados a ese semillero específico.

                int cantidadLideres = (int)validarLider.ExecuteScalar(); // Ejecutamos la consulta y obtenemos el resultado, que es el número de usuarios con el rol de "Lider" que están asociados al mismo semillero. Si el resultado es 0, significa que no hay ningún líder registrado para ese semillero.

                if (cantidadLideres == 0 && rol != "Lider") // Si no hay ningún líder registrado para el semillero y el nuevo usuario no tiene el rol de "Lider", se muestra un mensaje de error indicando que primero se debe registrar un líder para ese semillero, y se detiene la ejecución del método, evitando que se intente guardar un usuario sin un líder asociado.
                {
                    MessageBox.Show("Debe registrar primero un líder para este semillero");
                    conexion.cerrar();
                    return;
                }
            }

            if (modoEdicion == false && !ValidarIdUnico("Usuario", "idUsuario", idUsuario)) // Validamos que el ID del usuario sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un usuario con un ID duplicado.
                return;

            if (modoEdicion == true)
            {
                SqlCommand update;  
                try
                {
                    update = new SqlCommand("UPDATE Usuario SET idSemillero = @idSemillero, contraseñaUsuario = @contraseñaUsuario, nombresUsuario = @nombresUsuario, rolUsuario = @rolUsuario, telefonoUsuario = @telefonoUsuario, correoUsuario = @correoUsuario, edadUsuario = @edadUsuario, generoUsuario = @generoUsuario, estadoUsuario = @estadoUsuario WHERE idUsuario = @idUsuario", conexion.Conectar());
                    update.Parameters.AddWithValue("@idUsuario", idUsuario);
                    if (rol == "Administrador") // Si el rol del usuario es "Administrador", no se asigna un ID de semillero, ya que los administradores no están asociados a ningún semillero. En este caso, se asigna un valor nulo a la columna idSemillero en la base de datos utilizando DBNull.Value, lo que indica que el usuario no tiene un semillero asociado. Esto permite manejar correctamente la inserción o actualización del usuario en la base de datos sin generar errores relacionados con valores nulos en la columna idSemillero.
                    {
                        update.Parameters.AddWithValue("@idSemillero", DBNull.Value);// Si el rol del usuario es "Administrador", asignamos un valor nulo a la columna idSemillero en la base de datos, ya que los administradores no están asociados a ningún semillero. Esto se hace utilizando DBNull.Value, que representa un valor nulo en la base de datos.
                    }
                    else
                    {
                        update.Parameters.AddWithValue("@idSemillero", idSemillero);
                    }
                    update.Parameters.AddWithValue("@contraseñaUsuario", contraseña);
                    update.Parameters.AddWithValue("@nombresUsuario", nombre);
                    update.Parameters.AddWithValue("@rolUsuario", rol);
                    update.Parameters.AddWithValue("@telefonoUsuario", telefono);
                    update.Parameters.AddWithValue("@correoUsuario", correo);
                    update.Parameters.AddWithValue("@edadUsuario", edad);
                    update.Parameters.AddWithValue("@generoUsuario", genero);
                    update.Parameters.AddWithValue("@estadoUsuario", estado);
                    update.ExecuteNonQuery();
                    MessageBox.Show($"Usuario modificado correctamente. Al correo suministrado {correo} le va a notificar la confirmación de la modificación de información de la cuenta del {rol}");
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
                    // Si el rol del usuario es "Administrador", no se asigna un ID de semillero, ya que los administradores no están asociados a ningún semillero. En este caso, se asigna un valor nulo a la columna idSemillero en la base de datos utilizando DBNull.Value, lo que indica que el usuario no tiene un semillero asociado. Esto permite manejar correctamente la inserción del nuevo usuario en la base de datos sin generar errores relacionados con valores nulos en la columna idSemillero.
                    SqlCommand insert = new SqlCommand(
                        "INSERT INTO Usuario (idUsuario, idSemillero, contraseñaUsuario, nombresUsuario, rolUsuario, telefonoUsuario, correoUsuario, edadUsuario, generoUsuario, estadoUsuario) " +
                        "VALUES (@idUsuario, @idSemillero, @contraseña, @nombre, @rol, @telefono, @correo, @edad, @genero, @estado)",
                        conexion.Conectar()
                    );

                    insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                    if (rol == "Administrador")
                    {
                        insert.Parameters.AddWithValue("@idSemillero", DBNull.Value);
                    }
                    else
                    {
                        insert.Parameters.AddWithValue("@idSemillero", idSemillero);
                    }
                    insert.Parameters.AddWithValue("@contraseña", contraseña);
                    insert.Parameters.AddWithValue("@nombre", nombre);
                    insert.Parameters.AddWithValue("@rol", rol);
                    insert.Parameters.AddWithValue("@telefono", telefono);
                    insert.Parameters.AddWithValue("@correo", correo);
                    insert.Parameters.AddWithValue("@edad", edad);
                    insert.Parameters.AddWithValue("@genero", genero);
                    insert.Parameters.AddWithValue("@estado", estado);

                    insert.ExecuteNonQuery();

                    MessageBox.Show($"Usuario guardado correctamente. Al correo suministrado {correo} le va a notificar la confirmación de la creación de la cuenta del {rol}");
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

                if (modoEdicion == false && !ValidarIdUnico("Semillero", "idSemillero", idSemillero)) // Validamos que el ID del semillero sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un semillero con un ID duplicado.
                    return;

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
                if (!ValidarFecha(txtFechaEven)) // Validamos la fecha del evento utilizando el método ValidarFecha. Si la fecha no es válida, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un evento con una fecha incorrecta.
                    return;

                int idEvento = int.Parse(txtIdEvento.Text);
                string lugarEvento = txtLugarEven.Text;
                string nombreEvento = txtNombreEven.Text;
                string tipoEvento = txtTipoEven.Text;
                DateTime fechaEvento = DateTime.Parse(txtFechaEven.Text);
                string organizadorEvento = txtOrgEvento.Text;

                if (modoEdicion == false && !ValidarIdUnico("Eventos", "idEvento", idEvento)) // Validamos que el ID del evento sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un evento con un ID duplicado.
                    return;

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
                        MessageBox.Show("Evento modificado correctamente. Se les notificará por medio del correo la modificación de la información del evento a todos los líderes e Investigadores que hacen parte del semillero del evento");
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
                        MessageBox.Show("Evento guardado correctamente. Se les notificará por medio del correo la creación del evento a todos los líderes e Investigadores que hacen parte del semillero del evento");
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

        private void btnAgregarProyec_Click(object sender, EventArgs e)
        {
            if ((txtProyecto.Text == "") || (txtIdSemillero1.Text == "") || (txtTitulo.Text == "") || (txtObjetivo.Text == "") || (txtDescripcion.Text == "") || (txtFechaInicio.Text == "") || (txtFechaFin.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                if (!ValidarFecha(txtFechaInicio) || !ValidarFecha(txtFechaFin)) // Validamos las fechas de inicio y fin del proyecto utilizando el método ValidarFecha. Si alguna de las fechas no es válida, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un proyecto con fechas incorrectas.
                    return;

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

                if (modoEdicion == false && !ValidarIdUnico("Proyectos", "idProyecto", idProyecto)) // Validamos que el ID del proyecto sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un proyecto con un ID duplicado.
                    return;

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
                        MessageBox.Show("Proyecto guardado correctamente");
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
                if (!ValidarFecha(txtFechaReporte)) // Validamos la fecha del reporte utilizando el método ValidarFecha. Si la fecha no es válida, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un reporte con una fecha incorrecta.
                    return;

                int idReporte = int.Parse(txtIdReporte.Text);
                int idUsuario = int.Parse(txtIdUsuario2.Text);
                DateTime fechaReporte = DateTime.Parse(txtFechaReporte.Text);
                DateTime horaReporte = DateTime.Parse(txtHoraReporte.Text);
                string motivoReporte = (txtMotivo.Text);

                if (modoEdicion == false && !ValidarIdUnico("Reportes", "idReporte", idReporte)) // Validamos que el ID del reporte sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un reporte con un ID duplicado.
                    return;

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

                if (modoEdicion == false && !ValidarIdUnico("Patrocinadores", "idPatrocinador", idPatrocinador)) // Validamos que el ID del patrocinador sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar un patrocinador con un ID duplicado.
                    return;

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

                if (lider == true)
                {
                    // Validar que el proyecto pertenece al semillero del líder
                    SqlCommand validarSemillero = new SqlCommand(
                        "SELECT COUNT(*) FROM Proyectos WHERE idProyecto = @idProyecto AND idSemillero = @idSemillero",
                        conexion.Conectar()
                    );

                    validarSemillero.Parameters.AddWithValue("@idProyecto", idProyecto);
                    validarSemillero.Parameters.AddWithValue("@idSemillero", idSemilleroLider);

                    int pertenece = (int)validarSemillero.ExecuteScalar();

                    if (pertenece == 0)
                    {
                        MessageBox.Show("El proyecto no corresponde al semillero del líder.");
                        conexion.cerrar();
                        return;
                    }
                }

                if (modoEdicion == false && !ValidarIdUnico("Fase", "idFase", idFase)) // Validamos que el ID de la fase sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar una fase con un ID duplicado.
                    return;

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
                if (!ValidarFecha(txtFechaAct)) // Validamos la fecha de la actividad utilizando el método ValidarFecha. Si la fecha no es válida, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar una actividad con una fecha incorrecta.
                    return;

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
                    MessageBox.Show("La fase no existe");
                    conexion.cerrar();
                    return;
                }

                idFase = idFas;

                if (lider == true)
                {
                    // Validar que la fase pertenece al proyecto del semillero del líder
                    SqlCommand validarSemillero = new SqlCommand(
                        "SELECT COUNT(*) FROM Fase, Proyectos WHERE Fase.idProyecto = Proyectos.idProyecto AND Fase.idFase = @idFase AND Proyectos.idSemillero = @idSemilleroLider",
                        conexion.Conectar()
                    );
                    validarSemillero.Parameters.AddWithValue("@idFase", idFase);
                    validarSemillero.Parameters.AddWithValue("@idSemillero", idSemilleroLider);

                    int pertenece = (int)validarSemillero.ExecuteScalar();

                    if (pertenece == 0)
                    {
                        MessageBox.Show("La fase no corresponde al semillero del líder.");
                        conexion.cerrar();
                        return;
                    }
                }

                if (modoEdicion == false && !ValidarIdUnico("Actividad", "idActividad", idActividad)) // Validamos que el ID de la actividad sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar una actividad con un ID duplicado.
                    return;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Actividad SET idFase = @idFase, nombreActividad = @nombreActividad, duracionActividad = @duracionActividad, fechaEntregaActividad = @fechaEntregaActividad WHERE idActividad = @idActividad", conexion.Conectar());
                        update.Parameters.AddWithValue("@idActividad", idActividad);
                        update.Parameters.AddWithValue("@idFase", idFase);
                        update.Parameters.AddWithValue("@nombreActividad", nombreAct);
                        update.Parameters.AddWithValue("@duracionActividad", duracionAct);
                        update.Parameters.AddWithValue("@fechaEntregaActividad", fechaAct);

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
                            "INSERT INTO Actividad (idActividad, idFase, nombreActividad, duracionActividad, fechaEntregaActividad) " +
                            "VALUES (@idActividad, @idFase, @nombreActividad, @duracionActividad, @fechaEntregaActividad)",
                            conexion.Conectar()
                        );
                        insert.Parameters.AddWithValue("@idActividad", idActividad);
                        insert.Parameters.AddWithValue("@idFase", idFase);
                        insert.Parameters.AddWithValue("@nombreActividad", nombreAct);
                        insert.Parameters.AddWithValue("@duracionActividad", duracionAct);
                        insert.Parameters.AddWithValue("@fechaEntregaActividad", fechaAct);

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

        private void txtAgregarReu_Click(object sender, EventArgs e)
        {
            if ((txtIdReu.Text == "") || (txtIdUsuario3.Text == "") || (txtTipoReu.Text == "") || (txtMotivoReu.Text == "") || (txtHoraReu.Text == "") || (txtFechaReu.Text == ""))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

            else
            {
                if (!ValidarFecha(txtFechaReu)) // Validamos la fecha de la reunión utilizando el método ValidarFecha. Si la fecha no es válida, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar una reunión con una fecha incorrecta.
                    return;

                int idReu = int.Parse(txtIdReu.Text);
                int idUsuario = int.Parse(txtIdUsuario3.Text);
                string tipoReu = txtTipoReu.Text;
                string motivoReu = txtMotivoReu.Text;
                string horaReu = txtHoraReu.Text;
                DateTime fechaReu = DateTime.Parse(txtFechaReu.Text);

                int idUsu = int.Parse(txtIdUsuario3.Text);

                SqlCommand validar = new SqlCommand(
                    "SELECT COUNT(*) FROM Usuario WHERE idUsuario = @idUsuario AND rolUsuario = 'Lider'",
                     conexion.Conectar()
                 );

                validar.Parameters.AddWithValue("@idUsuario", idUsuario);
                int existe = (int)validar.ExecuteScalar();

                if (existe == 0)
                {
                    MessageBox.Show("El Usuario no existe o no es un Lider.");
                    conexion.cerrar();
                    return;
                }

                idUsuario = idUsu;

                if (lider == true)
                {
                    SqlCommand validarSemillero = new SqlCommand(
                        "SELECT COUNT(*) FROM Usuario " +
                        "WHERE idUsuario = @idUsuario AND idSemillero = @idSemillero",
                        conexion.Conectar()
                    );

                    validarSemillero.Parameters.AddWithValue("@idUsuario", idUsuario);
                    validarSemillero.Parameters.AddWithValue("@idSemillero", idSemilleroLider);

                    int pertenece = (int)validarSemillero.ExecuteScalar();

                    if (pertenece == 0)
                    {
                        MessageBox.Show("El usuario de la reunión no corresponde al semillero del líder.");
                        conexion.cerrar();
                        return;
                    }
                }

                if (modoEdicion == false && !ValidarIdUnico("Reuniones", "idReunion", idReu)) // Validamos que el ID de la reunión sea único en la base de datos utilizando el método ValidarIdUnico. Si el ID ya existe, se muestra un mensaje de error y se detiene la ejecución del método, evitando que se intente guardar una reunión con un ID duplicado.
                    return;

                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE Reuniones SET idUsuario = @idUsuario, tipoReunion = @tipoReunion, horaReunion = @horaReunion, motivoReunion = @motivoReunion, fechaReunion = @fechaReunion WHERE idReunion = @idReunion", conexion.Conectar());
                        update.Parameters.AddWithValue("@idReunion", idReu);
                        update.Parameters.AddWithValue("@idUsuario", idUsuario);
                        update.Parameters.AddWithValue("@tipoReunion", tipoReu);
                        update.Parameters.AddWithValue("@horaReunion", horaReu);
                        update.Parameters.AddWithValue("@motivoReunion", motivoReu);
                        update.Parameters.AddWithValue("@fechaReunion", fechaReu);

                        update.ExecuteNonQuery();

                        MessageBox.Show("Reunión modificada correctamente. Se les notificará por medio del correo la modificación de la información del reunión a todos los líderes e Investigadores que hacen parte del semillero de la reunión");
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
                            "INSERT INTO Reuniones (idReunion, idUsuario, tipoReunion, horaReunion, motivoReunion, fechaReunion) " +
                            "VALUES (@idReunion, @idUsuario, @tipoReunion, @motivoReunion, @horaReunion, @fechaReunion)",
                            conexion.Conectar()
                        );
                        insert.Parameters.AddWithValue("@idReunion", idReu);
                        insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                        insert.Parameters.AddWithValue("@tipoReunion", tipoReu);
                        insert.Parameters.AddWithValue("@horaReunion", horaReu);
                        insert.Parameters.AddWithValue("@motivoReunion", motivoReu);
                        insert.Parameters.AddWithValue("@fechaReunion", fechaReu);

                        insert.ExecuteNonQuery();

                        MessageBox.Show("Reunión guardada correctamente. Se les notificará por medio del correo la creación de la reunión a todos los líderes e Investigadores que hacen parte del semillero de la reunión");
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

        private void btnAgregarEventoProyecto_Click(object sender, EventArgs e)
        {
            if (txtIdProyecto_PE.Text == "" || txtIdEvento_PE.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idEvento = int.Parse(txtIdEvento_PE.Text);
                int idProyecto = int.Parse(txtIdProyecto_PE.Text);

                int idEven = int.Parse(txtIdEvento_PE.Text);
                int idPro = int.Parse(txtIdProyecto_PE.Text);



                SqlCommand validarEvento = new SqlCommand(
                    "SELECT COUNT(*) FROM Eventos WHERE idEvento = @idEvento",
                     conexion.Conectar()
                 );

                validarEvento.Parameters.AddWithValue("@idEvento", idEven);
                int existeEvento = (int)validarEvento.ExecuteScalar();


                SqlCommand validarProyecto = new SqlCommand(
                    "SELECT COUNT(*) FROM Proyectos WHERE idProyecto = @idProyecto",
                     conexion.Conectar()
                 );

                validarProyecto.Parameters.AddWithValue("@idProyecto", idPro);
                int existeProyecto = (int)validarProyecto.ExecuteScalar();

                if (existeEvento == 0 || existeProyecto == 0)
                {
                    MessageBox.Show("El Evento o el Proyecto no existen.");
                    conexion.cerrar();
                    return;
                }

                idEvento = idEven;
                idProyecto = idPro;

                if (lider == true)
                {
                    SqlCommand validarSemillero = new SqlCommand(
                        "SELECT COUNT(*) FROM Proyectos " +
                        "WHERE idProyecto = @idProyecto AND idSemillero = @idSemillero",
                        conexion.Conectar()
                    );

                    validarSemillero.Parameters.AddWithValue("@idProyecto", idProyecto);
                    validarSemillero.Parameters.AddWithValue("@idSemillero", idSemilleroLider);

                    int pertenece = (int)validarSemillero.ExecuteScalar();

                    if (pertenece == 0)
                    {
                        MessageBox.Show("El proyecto no corresponde al semillero del líder.");
                        conexion.cerrar();
                        return;
                    }
                }


                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE ProyectosEventos SET idEvento = @idEvento, idProyecto = @idProyecto WHERE idEvento = @idEvento AND idProyecto = @idProyecto", conexion.Conectar());
                        update.Parameters.AddWithValue("@idEvento", idEvento);
                        update.Parameters.AddWithValue("@idProyecto", idProyecto);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Evento del Proyecto modificado correctamente");
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
                            "INSERT INTO ProyectosEventos (idEvento, idProyecto) " +
                            "VALUES (@idEvento, @idProyecto)",
                            conexion.Conectar()
                        );
                        insert.Parameters.AddWithValue("@idEvento", idEvento);
                        insert.Parameters.AddWithValue("@idProyecto", idProyecto);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Proyecto asignado a evento correctamente");
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

        private void btnAgregarEventoPatro_Click(object sender, EventArgs e)
        {
            if (txtIdEvento_EP.Text == "" || txtIdPatro_EP.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
            else
            {
                int idPatrocinador = int.Parse(txtIdPatro_EP.Text);
                int idEvento = int.Parse(txtIdEvento_EP.Text);

                int idPatro = int.Parse(txtIdPatro_EP.Text);
                int idEven = int.Parse(txtIdEvento_EP.Text);



                SqlCommand validarPatro = new SqlCommand(
                    "SELECT COUNT(*) FROM Patrocinadores WHERE idPatrocinador = @idPatrocinador",
                     conexion.Conectar()
                 );

              
                validarPatro.Parameters.AddWithValue("@idPatrocinador", idPatro);
                int existePatro = (int)validarPatro.ExecuteScalar();


                SqlCommand validarEvento = new SqlCommand(
                    "SELECT COUNT(*) FROM Eventos WHERE idEvento = @idEvento",
                     conexion.Conectar()
                 );

                validarEvento.Parameters.AddWithValue("@idEvento", idEven);
                int existeEvento = (int)validarEvento.ExecuteScalar();

                if (existePatro == 0 || existeEvento == 0)
                {
                    MessageBox.Show("El Patrocinador o el Evento no existen.");
                    conexion.cerrar();
                    return;
                }

                idEvento = idEven;
                idPatrocinador = idPatro;

                if (lider == true)
                {
                    SqlCommand validarSemillero = new SqlCommand(
                        "SELECT COUNT(*) " +
                        "FROM Eventos, ProyectosEventos, Proyectos " +
                        "WHERE Eventos.idEvento = ProyectosEventos.idEvento " +
                        "AND ProyectosEventos.idProyecto = Proyectos.idProyecto " +
                        "AND Eventos.idEvento = @idEvento " +
                        "AND Proyectos.idSemillero = @idSemillero",
                        conexion.Conectar()
                    );

                    validarSemillero.Parameters.AddWithValue("@idEvento", idEvento);
                    validarSemillero.Parameters.AddWithValue("@idSemillero", idSemilleroLider);

                    int pertenece = (int)validarSemillero.ExecuteScalar();

                    if (pertenece == 0)
                    {
                        MessageBox.Show("El evento no corresponde al semillero del líder.");
                        conexion.cerrar();
                        return;
                    }
                }


                if (modoEdicion == true)
                {
                    SqlCommand update;
                    try
                    {
                        update = new SqlCommand("UPDATE EventoPatrocinadores SET idPatrocinador = @idPatrocinador, idEvento = @idEvento WHERE idPatrocinador = @idPatrocinador AND idEvento = @idEvento", conexion.Conectar());
                        update.Parameters.AddWithValue("@idPatrocinador", idPatrocinador);
                        update.Parameters.AddWithValue("@idEvento", idEvento);
                        update.ExecuteNonQuery();
                        MessageBox.Show("Evento del Patrocinador modificado correctamente");
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
                            "INSERT INTO EventoPatrocinadores (idPatrocinador, idEvento) " +
                            "VALUES (@idPatrocinador, @idEvento)",
                            conexion.Conectar()
                        );
                        insert.Parameters.AddWithValue("@idPatrocinador", idPatrocinador);
                        insert.Parameters.AddWithValue("@idEvento", idEvento);
                        insert.ExecuteNonQuery();
                        MessageBox.Show("Patrocinador asignado a evento correctamente");
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
        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void SoloFechas(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }

        private void txtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdSemillero3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtTelefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtEdadUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdSemillero_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtLineaSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtEnfoqueSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtIdEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTipoEven_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtOrgEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdSemillero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtObjetivo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtIdFase_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtProyecto1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdFase1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdUsuario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtFechaEven_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtFechaInicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtFechaFin_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtFechaAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtFechaReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtHoraReporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtIdpatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTipoPatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtTelefonoPatro_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdReu_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdUsuario3_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtTipoReu_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txtHoraReu_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtFechaReu_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFechas(e);
        }

        private void txtIdUsuario2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIdEvento_PE_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdProyecto_PE_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdPatro_EP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtIdEvento_EP_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
