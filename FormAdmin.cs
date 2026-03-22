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

        string formularioActual = ""; // variable para almacenar el nombre del formulario actual que se esta mostrando en el DataGridView
        ConsultarConParametro consultarConParametro = new ConsultarConParametro(); // creamos una instancia de la clase ConsultarConParametro para utilizar sus métodos de consulta con parámetros

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(20, 255, 255, 255);
            Panel2.BackColor = Color.FromArgb(20, 255, 255, 255);
            Panel3.BackColor = Color.FromArgb(20, 255, 255, 255);
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
            Gestionar("Reportes");
            formularioActual = "Reportes";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            Gestionar("Usuario");
            formularioActual = "Usuario";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Gestionar("Semillero");
            formularioActual = "Semillero";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            Gestionar("Proyectos");
            formularioActual = "Proyectos";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            Gestionar("Eventos");
            formularioActual = "Eventos";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void btn_patrocinadores_Click(object sender, EventArgs e)
        {
            Gestionar("Patrocinadores");
            formularioActual = "Patrocinadores";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
        }

        private void btn_actividades_Click(object sender, EventArgs e)
        {
            Gestionar("Actividad");
            formularioActual = "Actividad";
            ConsultarConParametro.CargarParametros(formularioActual, cboConsultarParametro);
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
            string columna = cboConsultarParametro.SelectedItem?.ToString();
            string valor = txtParametro.Text;

            if ((cboConsultarParametro.SelectedIndex == 0) || txtParametro.Text == "")
            {
                MessageBox.Show("Seleccione un parámetro y escriba un valor.");
                return;
            }

            DataTable resultados = ConsultarConParametro.ConsultarParametro(formularioActual, columna, valor, conexion);

            dataGridView1.DataSource = resultados;
         }
      

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar();
            frm.tipo = formularioActual; // asignamos el valor del formulario actual a la propiedad tipo del formulario FormAgregar para que sepa qué tipo de registro se va a agregar
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
