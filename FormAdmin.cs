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

        private void btn_gestionar_reportes_Click(object sender, EventArgs e)
        {

        }

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            SqlCommand consulta2;
            consulta2 = new SqlCommand("select * from Usuario", conexion.Conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, "Usuario");//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = ("Usuario");//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SqlCommand consulta2;
            consulta2 = new SqlCommand("select * from Semillero", conexion.Conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, "Semillero");//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = ("Semillero");//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
            }
        }

        private void btn_proyecto_Click(object sender, EventArgs e)
        {
            SqlCommand consulta2;
            consulta2 = new SqlCommand("select * from Proyectos", conexion.Conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, "Proyectos");//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = ("Proyectos");//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
            }
        }

        private void btn_eventos_Click(object sender, EventArgs e)
        {
            SqlCommand consulta2;
            consulta2 = new SqlCommand("select * from Eventos", conexion.Conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            dataset.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(dataset, "Eventos");//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = ("Eventos");//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = dataset;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
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
            int filasReales = dataGridView1.Rows.Count - 1;
            int ultimaFila;

            if (filasReales <= 0)
            {
                MessageBox.Show("Para registrar usuarios primero debes habilitar el datagrid", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.CurrentRow == null) return;

            ultimaFila = dataGridView1.Rows.Count - 2;

            if (dataGridView1.CurrentRow.Index == ultimaFila)
            {
                bool tieneDatosVacios = false;

                foreach (DataGridViewCell cell in dataGridView1.CurrentRow.Cells)
                {
                    if (string.IsNullOrWhiteSpace(cell.Value?.ToString()))
                    {
                        tieneDatosVacios = true;
                    }
                }

                if (tieneDatosVacios)
                {
                    MessageBox.Show("Todos los campos son obligatorios", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //VALIDACIONES 
                    int idUsuario;
                    long telefonoUsuario;
                    int edadUsuario;

                    if (!int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out idUsuario))
                    {
                        MessageBox.Show("ID inválido");
                        return;
                    }

                    if (!long.TryParse(dataGridView1.CurrentRow.Cells[4].Value.ToString(), out telefonoUsuario))
                    {
                        MessageBox.Show("Teléfono inválido");
                        return;
                    }

                    if (!int.TryParse(dataGridView1.CurrentRow.Cells[6].Value.ToString(), out edadUsuario))
                    {
                        MessageBox.Show("Edad inválida");
                        return;
                    }

                    //DATOS
                    string contraseña = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    string rol = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    string nombre = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    string correo = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    string genero = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    string estado = dataGridView1.CurrentRow.Cells[8].Value.ToString();

                    //INSERTAR
                    insertarRegistro(idUsuario, contraseña, rol, nombre, telefonoUsuario, correo, edadUsuario, genero, estado);

                    dataGridView1.Focus();
                    dataGridView1.CurrentCell = dataGridView1.Rows[ultimaFila + 1].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Debes ubicarse en la última fila del datagrid", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
