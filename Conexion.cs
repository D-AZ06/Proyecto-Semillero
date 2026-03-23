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
        SqlConnection conexion;

        public SqlConnection Conectar() // creamos el metodo Conectar para establecer la conexion a la base de datos
        {
         

            try // utilizamos un bloque try-catch para manejar cualquier error que pueda ocurrir al establecer la conexion
            {
                conexion = new SqlConnection("Data Source=DESKTOP-N1N64BR\\SQLEXPRESS;Initial Catalog=BD-ProyectoSemillero;Integrated Security=True"); // establecemos la conexion a la base de datos utilizando la cadena de conexion
                //conexion = new SqlConnection("Data Source=DESKTOP-N895SQ4\\SQLEXPRESS;Initial Catalog=BDProyectoSemillero;Integrated Security=True");
                conexion.Open(); // abrimos la conexion a la base de datos
            }
            catch (Exception e) // si ocurre un error al establecer la conexion, se muestra un mensaje de error
            {
                MessageBox.Show(e.Message); // mostramos el mensaje de error al usuario
            }
            return conexion;// retornamos la conexion establecida a la base de datos
        }

        public void cerrar() // creamos el metodo cerrar para cerrar la conexion a la base de datos
        {
            conexion.Close(); // cerramos la conexion a la base de datos

        }
    }
}
