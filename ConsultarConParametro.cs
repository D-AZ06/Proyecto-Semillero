using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    internal class ConsultarConParametro
    {
        public static void CargarParametros(string tipo, ComboBox cbo)
        {
            cbo.Items.Clear();

            if (tipo == "Usuario")
            {
                cbo.Items.AddRange(new string[] { "", "idUsuario", "contraseñaUsuario", "nombresUsuario", "rolUsuario", "telefonoUsuario", "correoUsuario", "edadUsuario", "generoUsuario", "estadoUsuario" });
            }
            else if (tipo == "Reuniones")
            {
                cbo.Items.AddRange(new string[] { "", "idReunion", "idUsuario", "horaReunion", "motivoReunion", "fechaReunion" });
            }
            else if (tipo == "Semillero")
            {
                cbo.Items.AddRange(new string[] { "", "idSemillero", "idUsuario", "nombreSemillero", "lineaSemillero", "enfoqueSemillero" });
            }
            else if (tipo == "Proyectos")
            {
                cbo.Items.AddRange(new string[] { "", "idProyecto", "idSemillero", "tituloProyecto", "objetivoProyecto", "descripcionProyecto", "fechaInicioProyecto", "fechaFinProyecto" });
            }
            else if (tipo == "Fase")
            {
                cbo.Items.AddRange(new string[] { "", "idFase", "idProyecto", "nombreFase", "duracionFase" });
            }
            else if (tipo == "Actividad")
            {
                cbo.Items.AddRange(new string[] { "", "idActividad", "idFase", "duracionActividad", "nombreActividad", "fechaEntrega" });
            }
            else if (tipo == "Eventos")
            {
                cbo.Items.AddRange(new string[] { "", "idEvento", "lugarEvento", "nombreEvento", "tipoEvento", "fechaEvento", "organizadorEvento" });
            }
            else if (tipo == "Patrocinadores")
            {
                cbo.Items.AddRange(new string[] { "", "idPatrocinador", "nombrePatrocinador", "tipoPatrocinador", "telefonoPatrocinador", "correoPatrocinador" });
            }
            else if (tipo == "Reportes")
            {
                cbo.Items.AddRange(new string[] { "", "idReporte", "idUsuario", "fechaReporte", "horaReporte", "motivoReporte" });
            }

            else if (tipo == "Reunion")
            {
                cbo.Items.AddRange(new string[] { "", "idReunion", "idUsuario", "tipoReunion", "motivoReunion", "horaReunion", "fechaReunion" });
            }
        }

        public static DataTable ConsultarParametro(string tabla, string columna, string valor, Conexion conexion)
        {
            DataTable datatable = new DataTable();

            try
            {
                SqlCommand consulta = new SqlCommand($"SELECT * FROM {tabla} WHERE {columna} LIKE '%' + @valor + '%'", conexion.Conectar());

                consulta.Parameters.AddWithValue("@valor", valor);

                SqlDataAdapter datadapter = new SqlDataAdapter(consulta);
                datadapter.Fill(datatable);

                conexion.cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message);
            }

            return datatable;
        }


        public static DataTable ConsultarParametroSegunSemillero(string tabla, string columna, string valor, int idSemillero, Conexion conexion)
        {
            DataTable datatable = new DataTable();
            SqlCommand consulta = new SqlCommand();

            if (tabla == "Usuario")
            {
                consulta = new SqlCommand(
                    $"SELECT * FROM Usuario WHERE {columna} LIKE '%' + @valor + '%' AND idSemillero = @idSemillero",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Semillero")
            {
                consulta = new SqlCommand(
                    $"select * from Semillero where {columna} LIKE '%' + @valor + '%' AND idSemillero = @idSemillero",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Proyectos")
            {
                consulta = new SqlCommand(
                    $"select * from Proyectos where {columna} LIKE '%' + @valor + '%' AND idSemillero = @idSemillero",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Fase")
            {
                consulta = new SqlCommand(
                    $"select * from Fase where {columna} LIKE '%' + @valor + '%' AND idProyecto in (select idProyecto from Proyectos where idSemillero = @idSemillero)", 
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Actividad")
            {
                consulta = new SqlCommand(
                    $"select * from Actividad where {columna} LIKE '%' + @valor + '%' AND idFase in (select idFase from Fase where idProyecto in (select idProyecto from Proyectos where idSemillero = @idSemillero))",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Eventos")
            {
                consulta = new SqlCommand(
                    $"select * from Eventos where {columna} LIKE '%' + @valor + '%' AND idEvento in (select idEvento from ProyectosEventos where idProyecto in(select idProyecto from Proyectos where idSemillero = @idSemillero)) ",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Reportes")
            {
                consulta = new SqlCommand(
                    $"select * from Reportes where {columna} LIKE '%' + @valor + '%' AND idUsuario in (select idUsuario from Usuario where idSemillero = @idSemillero)",
                    conexion.Conectar()
                    );
            }
            else if (tabla == "Patrocinadores")
            {
                consulta = new SqlCommand(
                  $"select * from Patrocinadores where {columna} LIKE '%' + @valor + '%' AND idPatrocinador in (" +
                  "select idPatrocinador from EventoPatrocinadores where idEvento in (" +
                  "select idEvento from ProyectosEventos where idProyecto in (" +
                  "select idProyecto from Proyectos where idSemillero = @idSemillero)))",
                  conexion.Conectar()
                  );
            }
            else if (tabla == "Reuniones")
            {
                consulta = new SqlCommand(
                    $"select * from Reuniones where {columna} LIKE '%' + @valor + '%' AND idUsuario in (" +
                    "select idUsuario from Usuario where idSemillero = @idSemillero)",
                    conexion.Conectar()
                    );
            }

            try
            {
                consulta.Parameters.AddWithValue("@valor", valor);
                consulta.Parameters.AddWithValue("@idSemillero", idSemillero);
                SqlDataAdapter datadapter = new SqlDataAdapter(consulta);
                datadapter.Fill(datatable);
                conexion.cerrar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta: " + ex.Message);
            }

            return datatable;
        }
    }
}
