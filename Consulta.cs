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
            consulta = new SqlCommand("select idUsuario, contraseñaUsuario, rolUsuario, idSemillero, estadoUsuario from Usuario where idUsuario = @idUsuario and contraseñaUsuario = @contraseñaUsuario", conexion.Conectar());//establecemos la consulta SQL para verificar el usuario y la contraseña
            consulta.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta.Parameters.AddWithValue("@idUsuario", idUsuario);//agregamos el parametro idusuario a la consulta SQL
            consulta.Parameters.AddWithValue("@contraseñaUsuario", contraseñaUsuario);//agregamos el parametro passwordusuario a la consulta SQL

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
                if (dataset.Tables.Contains("Usuario")) dataset.Tables["Usuario"].Clear(); // si el DataSet ya contiene una tabla con el nombre "Usuario", se limpia esa tabla para evitar que se acumulen los datos de consultas anteriores
                dataAdapter.Fill(dataset, "Usuario");//llenamos el DataSet con los datos obtenidos de la consulta SQL

                if (dataset.Tables["Usuario"].Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    return false;
                }

                DataRow datarow;//creamos un objeto de tipo DataRow para almacenar una fila de datos del DataSet
                datarow = dataset.Tables["Usuario"].Rows[0];//obtenemos la primera fila de datos del DataSet// creamos una variable dr con tipo DataRow para almacenar la primera fila de los resultados de la consulta a la base de datos
                int idSemillero = datarow["idSemillero"] == DBNull.Value ? 0 : Convert.ToInt32(datarow["idSemillero"]); // obtenemos el valor del campo idSemillero de la fila de datos obtenida de la consulta SQL y lo convertimos a un entero para almacenarlo en la variable semilleroId, si el valor es nulo se asigna 0
                string rol = datarow["rolUsuario"].ToString(); // obtenemos el valor del campo rolUsuario de la fila de datos obtenida de la consulta SQL y lo convertimos a una cadena para almacenarlo en la variable rol

                string estado = datarow["estadoUsuario"].ToString(); // obtenemos el valor del campo estadoUsuario de la fila de datos obtenida de la consulta SQL y lo convertimos a una cadena para almacenarlo en la variable estado

                if (estado == "Inactivo")
                {
                    MessageBox.Show("El usuario se encuentra inactivo. Por favor, contacte al administrador.");
                    return false;
                }

                MessageBox.Show($"Bienvenido {rol}");

                // Lógica de apertura de formularios según rol
                if (rol == "Administrador")
                {
                    new FormAdministrador().Show();
                }
                else if (rol == "Lider")
                {
                    new Form_lider(idSemillero).Show();
                }
                else if (rol == "Investigador")
                {
                    new Form_invest(idSemillero).Show();
                }

                Estado_conexion = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // si ocurre un error al ejecutar la consulta a la base de datos, se muestra un mensaje de error
            }
            finally
            {
                conexion.cerrar(); // cerramos la conexion a la base de datos
            }
            return Estado_conexion; // retornamos el estado de la conexion a la base de datos (true si la consulta a la base de datos se ejecuto correctamente, false si no se ejecuto correctamente)
        }




        // -------------------------------------------------------------------------------------------------------------
        // Metodo para mostrar en el datagrid los datos según al semillero que pertenezcan los investigadores y lideres
        // -------------------------------------------------------------------------------------------------------------
        public void Gestionarlider(string tipo, int idSemillero, DataGridView dataGridView) // creamos el metodo GestionarUsuarios para mostrar en el datagrid los datos de los usuarios según al semillero que pertenezcan los investigadores y lideres
        {
            // dependiendo del tipo de datos que se quiera mostrar en el datagrid, se ejecuta una consulta SQL diferente para obtener los datos correspondientes a ese tipo, filtrados por el idSemillero para mostrar solo los datos relacionados con ese semillero específico
            SqlCommand consulta; // creamos un objeto de tipo Sql
            consulta = new SqlCommand();
            if (tipo == "Usuario")
            {
                consulta = new SqlCommand(
                    "select * from Usuario where idSemillero = @idSemillero",
                    conexion.Conectar()
                );
            }
            else if (tipo == "Semillero")
            {
                consulta = new SqlCommand(
                    "select * from Semillero where idSemillero = @idSemillero",
                    conexion.Conectar()
                );
            }
            else if (tipo == "Proyectos")
            {
                consulta = new SqlCommand(
                    "select * from Proyectos where idSemillero = @idSemillero",
                    conexion.Conectar()
                );
            }
            else if (tipo == "Fase")
            {
                consulta = new SqlCommand(
                    "select * from Fase where idProyecto in (select idProyecto from Proyectos where idSemillero = @idSemillero)",
                    conexion.Conectar()
                );
            }
            else if (tipo == "Actividad")
            {
                consulta = new SqlCommand(
                    "select * from Actividad where idFase in (select idFase from Fase where idProyecto in (select idProyecto from Proyectos where idSemillero = @idSemillero))",
                    conexion.Conectar()
                );
            }
            else if (tipo == "Eventos")
            {
                consulta = new SqlCommand(
                    "select * from Eventos where idEvento in (select idEvento from ProyectosEventos where idProyecto in(select idProyecto from Proyectos where idSemillero = @idSemillero)) ",
                    conexion.Conectar()
                    );
            }
            else if (tipo == "Reportes")
            {
                consulta = new SqlCommand(
                    "select * from Reportes where idUsuario in (select idUsuario from Usuario where idSemillero = @idSemillero)",
                    conexion.Conectar()
                    );
            }
            else if (tipo == "Patrocinadores")
            {
                consulta = new SqlCommand(
                  "select * from Patrocinadores where idPatrocinador in (" +
                  "select idPatrocinador from EventoPatrocinadores where idEvento in (" +
                  "select idEvento from ProyectosEventos where idProyecto in (" +
                  "select idProyecto from Proyectos where idSemillero = @idSemillero)))",
                  conexion.Conectar()
                  );
            }
            else if (tipo == "Reuniones")
            {
                consulta = new SqlCommand(
                    "select * from Reuniones where idUsuario in (" +
                    "select idUsuario from Usuario where idSemillero = @idSemillero)",
                    conexion.Conectar()
                    );
            }
            else if (tipo == "ProyectosEventos")
            {
                consulta = new SqlCommand(
                    "select * from ProyectosEventos where idProyecto in (" +
                    "select idProyecto from Proyectos where idSemillero = @idSemillero)",
                    conexion.Conectar()
                    );
            }
            else if (tipo == "EventoPatrocinadores")
            {
                consulta = new SqlCommand(
                    "select * from EventoPatrocinadores where idEvento in (" +
                    "select idEvento from ProyectosEventos where idProyecto in (" +
                    "select idProyecto from Proyectos where idSemillero = @idSemillero))",
                    conexion.Conectar()
                    );
            }

            consulta.CommandType = CommandType.Text;// establecemos el tipo de comando como texto
            consulta.Parameters.Add("@idSemillero", SqlDbType.Int).Value = idSemillero;// agregamos el parametro idSemillero a la consulta SQL para filtrar los datos por el semillero específico

            dataset.Clear();

            SqlDataAdapter da = new SqlDataAdapter(consulta);
            da.Fill(dataset, tipo); // llenamos el DataSet con los datos obtenidos de la consulta SQL, utilizando el nombre del tipo como nombre de la tabla en el DataSet

            try
            {// asignamos el DataSet como fuente de datos del DataGridView y especificamos el nombre de la tabla a mostrar en el DataGridView utilizando el nombre del tipo
                dataGridView.DataSource = dataset;
                dataGridView.DataMember = tipo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

      
    }
}