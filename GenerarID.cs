using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Semillero
{
    internal class GenerarID
    {
        public static int generadorID(string tabla, string columnaId, int prefijo, Conexion conexion) // Metodo para generar un ID consecutivo con prefijo específico
        {
            int ultimoID = 0; // Variable para almacenar el último ID obtenido de la base de datos

            SqlCommand cmd = new SqlCommand(
                $"SELECT MAX({columnaId}) FROM {tabla}",
                conexion.Conectar()
            ); // Consulta SQL para obtener el máximo ID de la tabla especificada

            object resultado = cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene el resultado (máximo ID)
            conexion.cerrar(); // Cierra la conexión a la base de datos

            if (resultado != DBNull.Value) // Verifica si el resultado no es nulo
            {
                ultimoID = Convert.ToInt32(resultado); // Convierte el resultado a entero y lo asigna a la variable ultimoID
            }

            if (ultimoID == 0) // Si no hay registros en la tabla, se inicia el ID con el prefijo seguido de "1"
            {
                return Convert.ToInt32(prefijo.ToString() + "1"); // Ejemplo: Si el prefijo es 10, el primer ID generado será 101
            }

            string idTexto = ultimoID.ToString(); // Convierte el último ID a texto para manipularlo
            string prefijoTexto = prefijo.ToString();  // Convierte el prefijo a texto para compararlo con el ID obtenido

            string consecutivoTexto = idTexto.Substring(prefijoTexto.Length); // Extrae la parte del ID que corresponde al número consecutivo, eliminando el prefijo. Por ejemplo, si el último ID es "1010" y el prefijo es "10", se extrae "10"
            int consecutivo = Convert.ToInt32(consecutivoTexto) + 1;  // Convierte el número consecutivo a entero, le suma 1 para obtener el siguiente número en la secuencia. En el ejemplo, "10" se convierte a 10 y se incrementa a 11

            string nuevoID = prefijoTexto + consecutivo.ToString(); // Combina el prefijo con el nuevo número consecutivo para formar el nuevo ID. En el ejemplo, se combina "10" con "11" para obtener "1011"

            return Convert.ToInt32(nuevoID); // Convierte el nuevo ID a entero y lo devuelve como resultado del método. En el ejemplo, "1011" se convierte a 1011
        }
    }
}
