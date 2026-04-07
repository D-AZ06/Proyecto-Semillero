using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Semillero
{
    public partial class FormAdmin : Form
    {
        Conexion conexion = new Conexion(); // creamos una instancia de la clase Conexion para establecer la conexion a la base de datos
        DataSet dataset = new DataSet(); // (conjunto de datos) creamos la variable dt con tipo DataTable para almacenar los resultados de las consultas a la base de datos
        ConsultarConParametro consultarConParametro = new ConsultarConParametro(); // creamos una instancia de la clase ConsultarConParametro para utilizar sus métodos de consulta con parámetros

        string formularioActual = ""; // variable para almacenar el nombre del formulario actual que se esta mostrando en el DataGridView

        public FormAdmin()
        {
            InitializeComponent();

            if (formularioActual == "")
            {
                btnRegistrar.Enabled = false; // deshabilitamos el botón de consulta con parámetros si no se ha seleccionado un formulario para mostrar en el DataGridView
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(20, 255, 255, 255);
            Panel2.BackColor = Color.FromArgb(20, 255, 255, 255);
            Panel3.BackColor = Color.FromArgb(20, 255, 255, 255);

            dataGridView1.ColumnHeadersVisible = true;
        }

        public void Gestionar(string tabla)
        {
            SqlCommand consulta2;
            consulta2 = new SqlCommand($"select * from {tabla}", conexion.Conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
                                                     //consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, tabla);//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = tabla;//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
            }
        }

        private void btn_gestionar_reportes_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Reportes");
            formularioActual = "Reportes";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = false; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Reportes";
            txtParametro.Clear(); // Limpiar el TextBox de parámetros al cambiar de formulario
        }

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Usuario");
            formularioActual = "Usuario";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Usuarios";
            txtParametro.Clear();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Semillero");
            formularioActual = "Semillero";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Semilleros";
            txtParametro.Clear();
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Proyectos");
            formularioActual = "Proyectos";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Proyectos";
            txtParametro.Clear();
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Eventos");
            formularioActual = "Eventos";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Eventos";
            txtParametro.Clear();
        }

        private void btn_patrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Patrocinadores");
            formularioActual = "Patrocinadores";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Patrocinadores";
            txtParametro.Clear();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Fase");
            formularioActual = "Fase";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Fases";
            txtParametro.Clear();
        }

        private void btn_act_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Actividad");
            formularioActual = "Actividad";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Actividades";
            txtParametro.Clear();
        }
        private void btn_reunion_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("Reuniones");
            formularioActual = "Reuniones";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Reuniones";
            txtParametro.Clear();
        }
        private void btnProyectosEventos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("ProyectosEventos");
            formularioActual = "ProyectosEventos";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = false;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Proyectos y Eventos";
            txtParametro.Clear();
        }

        private void btnEventoPatrocinadores_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Gestionar("EventoPatrocinadores");
            formularioActual = "EventoPatrocinadores";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
            btnRegistrar.Enabled = true; // habilitamos el botón de consulta con parámetros si se ha seleccionado un formulario para mostrar en el DataGridView
            btnModificar.Enabled = false;
            btnEliminar.Enabled = true;
            lbl_gestionar.Text = "Gestionar Eventos y Patrocinadores";
            txtParametro.Clear();
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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(20, 255, 255, 255);
        }
        private void btnconsultalp_Click_1(object sender, EventArgs e)
        {
            if ((cboConsultarParametro.SelectedIndex == 0) || txtParametro.Text == "")
            {
                MessageBox.Show("Seleccione un parámetro y escriba un valor.");
                return;
            }
            dataGridView1.DataSource = null;

            string columna = cboConsultarParametro.SelectedItem?.ToString();
            string valor = txtParametro.Text;

            DataTable resultados = ConsultarConParametro.ConsultarParametro(formularioActual, columna, valor, conexion);

            dataGridView1.DataSource = resultados;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar();
            frm.tipo = formularioActual; // asignamos el valor del formulario actual a la propiedad tipo del formulario FormAgregar para que sepa qué tipo de registro se va a agregar
            frm.ShowDialog();
            Gestionar(formularioActual);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro");
                return;
            }

            FormAgregar frm = new FormAgregar();

            frm.tipo = formularioActual; // ya lo tienes
            frm.modoEdicion = true; // Activa el modo de modificar
            frm.filaSeleccionada = dataGridView1.CurrentRow; // Manda los datos 

            if (frm.ShowDialog() == DialogResult.OK) // refresca solo si se modificó
            {
                Gestionar(formularioActual);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada en el DataGridView antes de intentar eliminar
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {// Obtener el ID del registro a eliminar desde la primera celda de la fila seleccionada
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);// Asumimos que la primera columna del DataGridView contiene el ID del registro

                    SqlCommand eliminar = new SqlCommand($"DELETE FROM {formularioActual} WHERE {dataGridView1.Columns[0].Name} = @Id", conexion.Conectar());// Creamos un comando SQL para eliminar el registro seleccionado de la tabla correspondiente al formulario actual, utilizando un parámetro para evitar inyecciones SQL
                    eliminar.CommandType = CommandType.Text;// Establecemos el tipo de comando como texto
                    eliminar.Parameters.AddWithValue("@Id", id);// Agregamos el valor del ID como parámetro al comando SQL

                    // Mostrar un mensaje de confirmación antes de eliminar el registro
                    if (MessageBox.Show($"¿Desea eliminar el registro con ID = {id}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
                    {
                        int filas = eliminar.ExecuteNonQuery();// Ejecutamos el comando SQL para eliminar el registro y obtenemos el número de filas afectadas

                        if (filas > 0)// Si se eliminó al menos una fila, mostramos un mensaje de éxito y refrescamos el DataGridView
                        {
                            MessageBox.Show("El registro ha sido eliminado correctamente.");// Mostramos un mensaje de éxito al usuario
                            Gestionar(formularioActual); // refresca el DataGridView
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
