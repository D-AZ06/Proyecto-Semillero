using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    internal class Consulta
    {
        Conexion conexion = new Conexion(); // creamos una instancia de la clase Conexion para establecer la conexion a la base de datos
        DataSet dataset = new DataSet(); // (conjunto de datos) creamos la variable dt con tipo DataTable para almacenar los resultados de las consultas a la base de datos
        Boolean Estado_conexion = false; // creamos la variable Estado_conexion para verificar si la conexion a la base de datos se establecio correctamente

        public Boolean Iniciar_sesion(int idUsuario, string contraseñaUsuario)
        {
            SqlCommand consulta;//creamos un objeto de tipo SqlCommand para ejecutar la consulta SQL
            consulta = new SqlCommand("select idUsuario, contraseñaUsuario, rolUsuario from Usuario where idUsuario = @idUsuario and contraseñaUsuario = @contraseñaUsuario", conexion.Conectar());//establecemos la consulta SQL para verificar el usuario y la contraseña
            consulta.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta.Parameters.AddWithValue("@idUsuario", idUsuario);//agregamos el parametro idusuario a la consulta SQL
            consulta.Parameters.AddWithValue("@contraseñaUsuario", contraseñaUsuario);//agregamos el parametro passwordusuario a la consulta SQL


            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
                dataAdapter.Fill(dataset, "Usuario");//llenamos el DataSet con los datos obtenidos de la consulta SQL
                DataRow datarow;//creamos un objeto de tipo DataRow para almacenar una fila de datos del DataSet
                datarow = dataset.Tables["Usuario"].Rows[0];//obtenemos la primera fila de datos del DataSet// creamos una variable dr con tipo DataRow para almacenar la primera fila de los resultados de la consulta a la base de datos
                if (Convert.ToString(idUsuario) == datarow["idUsuario"].ToString() && contraseñaUsuario == datarow["contraseñaUsuario"].ToString() && "Administrador" == datarow["rolUsuario"].ToString()) // verificamos si el id_usuario y el password_usuario ingresados por el usuario coinciden con los resultados de la consulta a la base de datos
                {
                    MessageBox.Show("Bienvenido Administrador"); // si el id_usuario y el password_usuario ingresados por el usuario coinciden con los resultados de la consulta a la base de datos, se muestra un mensaje de bienvenida al usuario
                    FormAdmin frm = new FormAdmin(); // creamos una instancia del formulario FormAdmin para mostrarlo al usuario
                    frm.Show(); // mostramos el formulario FormAdmin al usuario
                    Estado_conexion = true; // si la consulta a la base de datos se ejecuto correctamente, se establece el estado de la conexion a true
                }
                else
                {
                    if (Convert.ToString(idUsuario) == datarow["idUsuario"].ToString() && contraseñaUsuario == datarow["contraseñaUsuario"].ToString() && "Lider" == datarow["rolUsuario"].ToString()) // verificamos si el id_usuario y el password_usuario ingresados por el usuario coinciden con los resultados de la consulta a la base de datos
                    {
                        MessageBox.Show("Bienvenido Lider");
                        Form_lider rfs = new Form_lider();
                        rfs.Show();
                        Estado_conexion = true;
                    }

                    else
                    {
                        if (Convert.ToString(idUsuario) == datarow["idUsuario"].ToString() && contraseñaUsuario == datarow["contraseñaUsuario"].ToString() && "Investigador" == datarow["rolUsuario"].ToString()) // verificamos si el id_usuario y el password_usuario ingresados por el usuario coinciden con los resultados de la consulta a la base de datos
                        {
                            MessageBox.Show("Bienvenido Lider");
                            Form_invest rf = new Form_invest();
                            rf.Show();
                            Estado_conexion = true;
                        }

                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                            
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta");// usuario o contraseña incorrectos, se muestra un mensaje de error al usuario
                // MessageBox.Show(ex.Message); // si ocurre un error al ejecutar la consulta a la base de datos, se muestra un mensaje de error
            }
            finally
            {
                conexion.cerrar(); // cerramos la conexion a la base de datos
            }
            return Estado_conexion; // retornamos el estado de la conexion a la base de datos (true si la consulta a la base de datos se ejecuto correctamente, false si no se ejecuto correctamente)
        }
    }
}
