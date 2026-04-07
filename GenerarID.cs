using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    internal class GenerarID
    {
        public static int generadorID(string tabla, string columnaId, int prefijo, Conexion conexion) // Metodo para generar un ID único basado en el último ID de la tabla, con un prefijo específico
        {
            try
            {
                // Esta consulta obtiene el valor máximo de la columna ID en la tabla especificada, lo que representa el último ID generado
                SqlCommand cmd = new SqlCommand(
                    $"SELECT MAX({columnaId}) FROM {tabla}",
                    conexion.Conectar()
                );

                object resultado = cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene el resultado (el último ID)
                conexion.cerrar(); // Cierra la conexión a la base de datos

                string prefijoTexto = prefijo.ToString(); // Convierte el prefijo a texto para colocar con el nuevo ID


                if (resultado == DBNull.Value || resultado == null) // Si no hay registros en la tabla, se inicia el ID con el prefijo seguido de "1"
                {
                    return Convert.ToInt32(prefijoTexto + "1");
                }

                int ultimoID = Convert.ToInt32(resultado); // Convierte el resultado a un entero para manipularlo y generar el nuevo ID
                string idTexto = ultimoID.ToString(); // Convierte el último ID a texto para extraer el consecutivo

                string consecutivoTexto = idTexto.Substring(prefijoTexto.Length); // Extrae la parte del ID que representa el número consecutivo, eliminando el prefijo
                int consecutivo = Convert.ToInt32(consecutivoTexto) + 1; // Incrementa el número consecutivo para generar el nuevo ID

                string nuevoID = prefijoTexto + consecutivo.ToString(); // Combina el prefijo con el nuevo número consecutivo para formar el nuevo ID completo
                return Convert.ToInt32(nuevoID); // Devuelve el nuevo ID generado como un entero, listo para ser utilizado en la inserción de un nuevo registro en la base de datos
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Error al generar el ID: " + ex.Message); // Muestra un mensaje de error si ocurre una excepción durante la generación del ID
                return 0; // Devuelve 0 en caso de error, lo que indica que no se pudo generar un ID válido
            }
        }
    }
}
