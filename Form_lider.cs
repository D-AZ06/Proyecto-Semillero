using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Proyecto_Semillero
{
    public partial class Form_lider : Form
    {
        public int idSemillero; // creamos la variable idSemillero para almacenar el id del semillero al que pertenece el lider 
        Consulta Consulta = new Consulta(); // creamos un objeto de tipo Consulta para llamar a los métodos de la clase Consulta
        Conexion conexion = new Conexion(); // creamos un objeto de tipo Conexion para establecer la conexion a la base de datos

        string formularioActual = ""; // creamos la variable formularioActual para almacenar el nombre del formulario que se esta mostrando actualmente en el DataGridView

        public Form_lider(int idSemillero)
        {
            InitializeComponent();
            this.idSemillero = idSemillero;
        }
        private void Form_lider_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(100, 15, 40, 70);
            Panel2.BackColor = Color.FromArgb(100, 15, 40, 70);
            Panel3.BackColor = Color.FromArgb(100, 15, 40, 70);
            Panel4.BackColor = Color.FromArgb(100, 15, 40, 70);

           

            if (formularioActual == "")
            {
                btnRegistrar.Enabled = false; // deshabilitamos el botón de consulta con parámetros si no se ha seleccionado un formulario para mostrar en el DataGridView
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;

            }
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

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Usuario"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Usuario", idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los usuarios
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Usuarios";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
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
        }

        private void btnSemillero_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Semillero"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Semillero", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Semillero";
            btnRegistrar.Enabled = false; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Proyectos"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Proyectos", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Proyectos";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btnFases_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Fase"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Fase", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Fases";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Actividad"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Actividad", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Actividades";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Eventos"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Eventos", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Eventos";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_gestionar_reportes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Reportes"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Reportes", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Reportes";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_patrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Patrocinadores"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Patrocinadores", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Patrocinadores";
            btnRegistrar.Enabled = false; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btn_reunion_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "Reuniones"; // asignamos el nombre del formulario que se esta mostrando actualmente en el DataGridView a la variable formularioActual
            Consulta.Gestionarlider("Reuniones", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro); // cargamos los parámetros de consulta para el formulario que se esta mostrando actualmente en el DataGridView en el ComboBox cboParametro
            lbl_gestionar.Text = "Gestionar Reuniones";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btnProyectosEventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "ProyectosEventos";
            Consulta.Gestionarlider("ProyectosEventos", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            lbl_gestionar.Text = "Gestionar Proyectos y Eventos";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btnEventoPatrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            formularioActual = "EventoPatrocinadores";
            Consulta.Gestionarlider("EventoPatrocinadores", idSemillero, dataGridView1);
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            lbl_gestionar.Text = "Gestionar Eventos y Patrocinadores";
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            txtParametro.Clear(); // limpiamos el TextBox de consulta con parámetros al seleccionar un formulario para mostrar en el DataGridView
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar();
            frm.tipo = formularioActual; // asignamos el valor del formulario actual a la propiedad tipo del formulario FormAgregar para que sepa qué tipo de registro se va a agregar
            frm.lider = true; // asignamos el valor true a la propiedad lider del formulario FormAgregar para que sepa que el usuario es un lider y pueda mostrar u ocultar campos según el tipo de usuario
            frm.idSemilleroLider = idSemillero; // asignamos el valor del id del semillero a la propiedad idSemillero del formulario FormAgregar para que sepa a qué semillero pertenece el registro que se va a agregar
            frm.ShowDialog();
            Consulta.Gestionarlider(formularioActual, idSemillero, dataGridView1); // actualizamos el DataGridView con los datos del formulario que se esta mostrando actualmente en el DataGridView después de agregar un nuevo registro
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro");
                return;
            }

            FormAgregar frm = new FormAgregar();
            frm.lider = true; // asignamos el valor true a la propiedad lider del formulario FormAgregar para que sepa que el usuario es un lider y pueda mostrar u ocultar campos según el tipo de usuario
            frm.tipo = formularioActual; // ya lo tienes
            frm.modoEdicion = true; // ACTIVAS MODO MODIFICAR
            frm.filaSeleccionada = dataGridView1.CurrentRow; // ENVÍAS LOS DATOS

            if (frm.ShowDialog() == DialogResult.OK) // refresca solo si se modificó
            {
                Consulta.Gestionarlider(formularioActual, idSemillero, dataGridView1); // actualizamos el DataGridView con los datos del formulario que se esta mostrando actualmente en el DataGridView después de agregar un nuevo registro
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    // 🔑 Obtén el valor de la primera celda (ID)
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    SqlCommand eliminar = new SqlCommand($"DELETE FROM {formularioActual} WHERE {dataGridView1.Columns[0].Name} = @Id", conexion.Conectar());

                    eliminar.CommandType = CommandType.Text;
                    eliminar.Parameters.AddWithValue("@Id", id);

                    if (MessageBox.Show($"¿Desea eliminar el registro con ID = {id}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        int filas = eliminar.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("El registro ha sido eliminado correctamente.");
                            Consulta.Gestionarlider(formularioActual, idSemillero, dataGridView1); // actualizamos el DataGridView con los datos del formulario que se esta mostrando actualmente en el DataGridView después de agregar un nuevo registro
                        }
                    
                        else
                        {
                            MessageBox.Show("No se encontró el registro a eliminar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

    }
}
