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

namespace Proyecto_Semillero
{
    public partial class FormAdmin : Form
    {
        Conexion conexion = new Conexion(); // creamos una instancia de la clase Conexion para establecer la conexion a la base de datos
        DataSet dataset = new DataSet(); // (conjunto de datos) creamos la variable dt con tipo DataTable para almacenar los resultados de las consultas a la base de datos

        string formularioActual = ""; // variable para almacenar el nombre del formulario actual que se esta mostrando en el DataGridView

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

        }

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            Gestionar("Usuario");
            formularioActual = "Usuario";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Gestionar("Semillero");
            formularioActual = "Semillero";
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            Gestionar("Proyectos");
            formularioActual = "Proyectos";
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            Gestionar("Eventos");
            formularioActual = "Eventos";
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

        private void btnconsultalp_Click(object sender, EventArgs e)
        {
            buscar_usuario(comboBox1.SelectedItem.ToString(), textBox1.Text);
        }

        public void buscar_usuario(string criterio, string valor)
        {
            SqlCommand consulta = new SqlCommand();//creamos un objeto de tipo SqlCommand para ejecutar la consulta SQL

            if (criterio == "idUsuario")
            {
                consulta = new SqlCommand("select * from Usuario where idUsuario = @valor", conexion.Conectar());//establecemos la consulta SQL para buscar por idUsuario
                consulta.CommandType = CommandType.Text;
            }
            else
            {
                consulta = new SqlCommand("select * from Usuario where rolUsuario  LIKE '%' + @valor + '%'", conexion.Conectar());//establecemos la consulta SQL para buscar por tipoUsuario utilizando el operador LIKE para permitir búsquedas parciales
                consulta.CommandType = CommandType.Text;
            }

            consulta.Parameters.AddWithValue("@valor", valor);//agregamos el parametro valor a la consulta SQL
            consulta.ExecuteNonQuery();
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, "Usuario");//llenamos el DataSet con los datos obtenidos de la consulta SQL

            try
            {
                dataGridView1.DataMember = "Usuario";//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }
            catch (Exception e)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(e.Message);//mostramos el mensaje de error de la excepción
            }




        }
        public void insertarRegistro(int idUsuario, string contraseñaUsuario, string rolUsuario, string nombresUsuario  ,long telefonoUsuario, string correoUsuario, int edadUsuario, string generoUsuario, string estadoUsuario)
        {
            try
            {
                SqlCommand insert = new SqlCommand(
                    "INSERT INTO Usuario (idUsuario, contraseñaUsuario, rolUsuario, nombresUsuario, telefonoUsuario, correoUsuario, edadUsuario, generoUsuario, estadoUsuario) " +
                    "VALUES (@idUsuario, @contraseñaUsuario, @rolUsuario, @nombresUsuario, @telefonoUsuario, @correoUsuario, @edadUsuario, @generoUsuario, @estadoUsuario)",
                    conexion.Conectar()
                );

                insert.CommandType = CommandType.Text;

                insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                insert.Parameters.AddWithValue("@contraseñaUsuario", contraseñaUsuario);
                insert.Parameters.AddWithValue("@rolUsuario", rolUsuario);
                insert.Parameters.AddWithValue("@nombresUsuario", nombresUsuario);
                insert.Parameters.AddWithValue("@telefonoUsuario", telefonoUsuario);
                insert.Parameters.AddWithValue("@correoUsuario", correoUsuario);
                insert.Parameters.AddWithValue("@edadUsuario", edadUsuario);
                insert.Parameters.AddWithValue("@generoUsuario", generoUsuario);
                insert.Parameters.AddWithValue("@estadoUsuario", estadoUsuario);

                insert.ExecuteNonQuery();

                MessageBox.Show("Registro insertado correctamente", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexion.cerrar();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FormAgregar frm = new FormAgregar();
            frm.tipo = formularioActual; // asignamos el valor del formulario actual a la propiedad tipo del formulario FormAgregar para que sepa qué tipo de registro se va a agregar
            frm.ShowDialog();
        }
    }
}
