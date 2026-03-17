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
    internal class Conexion
    {
        SqlConnection con;

        public SqlConnection Conectar() // creamos el metodo Conectar para establecer la conexion a la base de datos
        {
            try // utilizamos un bloque try-catch para manejar cualquier error que pueda ocurrir al establecer la conexion
            {
                con = new SqlConnection("Data Source=DESKTOP-N1N64BR\\SQLEXPRESS;Initial Catalog=BD_proyectoSemillero;Integrated Security=True"); // establecemos la conexion a la base de datos utilizando la cadena de conexion
                con.Open(); // abrimos la conexion a la base de datos
            }
            catch (Exception e) // si ocurre un error al establecer la conexion, se muestra un mensaje de error
            {
                MessageBox.Show(e.Message); // mostramos el mensaje de error al usuario
            }
            return con;// retornamos la conexion establecida a la base de datos
        }

        public void cerrar() // creamos el metodo cerrar para cerrar la conexion a la base de datos
        {
            con.Close(); // cerramos la conexion a la base de datos

        }
    }
}
