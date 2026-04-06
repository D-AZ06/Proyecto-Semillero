using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    public partial class Form_invest : Form
    {
        public int idSemillero; // creamos la variable idSemillero para almacenar el id del semillero al que pertenece el lider 
        Consulta Consulta = new Consulta(); // creamos un objeto de tipo Consulta para llamar a los métodos de la clase Consulta
        Conexion conexion = new Conexion(); // creamos un objeto de tipo Conexion para establecer la conexion a la base de datos

        string formularioActual = ""; // creamos la variable formularioActual para almacenar el nombre del formulario que se esta mostrando actualmente en el DataGridView

        public Form_invest(int idSemillero)
        {
            InitializeComponent();
            this.idSemillero = idSemillero;
        }

        private void Form_invest_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(80, 255, 255, 255);
            Panel2.BackColor = Color.FromArgb(80, 255, 255, 255);
            Panel3.BackColor = Color.FromArgb(80, 255, 255, 255);
            Panel4.BackColor = Color.FromArgb(80, 255, 255, 255);
        }
        private void btbsalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
            {
                Form1 salir = new Form1();//creamos un objeto de tipo Form1 para mostrar el formulario de inicio de sesión
                salir.Show();//mostramos el formulario de inicio de sesión
                this.Hide();//ocultamos el formulario actual (FormAdmin)
            }
        }

        private void btnconsultalp_Click(object sender, EventArgs e)
        {
            if ((cboConsultarParametro.SelectedIndex == 0) || txtParametro.Text == "")
            {
                MessageBox.Show("Seleccione un parámetro y escriba un valor.");
                return;
            }
            dataGridView1.DataSource = null;

            string columna = cboConsultarParametro.SelectedItem?.ToString();
            string valor = txtParametro.Text;

            DataTable resultados = ConsultarConParametro.ConsultarParametroSegunSemillero(formularioActual, columna, valor, idSemillero, conexion);

            dataGridView1.DataSource = resultados;

            if (formularioActual == "Usuario")
            {
                dataGridView1.Columns["contraseñaUsuario"].Visible = false;
                dataGridView1.Columns["telefonoUsuario"].Visible = false; // ocultamos la columna telefono usuario del DataGridView
                dataGridView1.Columns["correoUsuario"].Visible = false; // ocultamos la columna correo usuario del DataGridView
            }
        }

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los usuarios
            formularioActual = "Usuario"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Usuario", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los usuarios
            dataGridView1.Columns["contraseñaUsuario"].Visible = false; // ocultamos la columna contrasema usuario del DataGridView
            dataGridView1.Columns["telefonoUsuario"].Visible = false; // ocultamos la columna telefono usuario del DataGridView
            dataGridView1.Columns["correoUsuario"].Visible = false; // ocultamos la columna correo usuario del DataGridView
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Usuarios";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btnSemillero_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los semilleros
            formularioActual = "Semillero"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Semillero", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los semilleros
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Semilleros";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Proyectos"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Proyectos", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Proyectos";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btnFases_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Fase"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Fase", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Fases";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Actividad"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Actividad", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Actividad";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Eventos"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Eventos", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Eventos";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_gestionar_reportes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Reportes"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Reportes", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Reportes";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_patrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Patrocinadores"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Patrocinadores", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Patrocinadores";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btn_reunion_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "Reuniones"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Reuniones", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Reuniones";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btnProyectosEventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "ProyectosEventos"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("ProyectosEventos", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Proyectos y Eventos";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void btnEventoPatrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // limpiamos el DataGridView para mostrar los datos de los proyectos
            formularioActual = "EventoPatrocinadores"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("EventoPatrocinadores", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los proyectos
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_consultar.Text = "Consultar Evento y Patrocinadores";
            txtParametro.Text = ""; // limpiamos el TextBox txtParametro para que el usuario pueda escribir un nuevo valor de consulta
        }

        private void cboConsultarParametro_Click(object sender, EventArgs e)
        {
            if (formularioActual == "Usuario")
            {
                cboConsultarParametro.Items.Remove("contraseñaUsuario"); // eliminamos el parámetro contraseñaUsuario del ComboBox cboParametro, ya que no es un parámetro de consulta para los usuarios
                cboConsultarParametro.Items.Remove("telefonoUsuario"); // eliminamos el parámetro telefonoUsuario del ComboBox cboParametro, ya que no es un parámetro de consulta para los usuarios
                cboConsultarParametro.Items.Remove("correoUsuario"); // eliminamos el parámetro correoUsuario del ComboBox cboParametro, ya que no es un parámetro de consulta para los usuarios
            }
        }
    }
}
