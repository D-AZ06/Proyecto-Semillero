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
            consulta2 = new SqlCommand("select * from Usuario", cn.conectar());//establecemos la consulta SQL para obtener todos los datos de la tabla Usuario
            consulta2.CommandType = CommandType.Text;//establecemos el tipo de comando como texto
            consulta2.ExecuteNonQuery();//ejecutamos la consulta SQL
            ds.Clear();//limpiamos el DataSet para evitar que se acumulen los datos obtenidos de la consulta SQL
            SqlDataAdapter da = new SqlDataAdapter(consulta2);//creamos un objeto de tipo SqlDataAdapter para ejecutar la consulta SQL y almacenar los datos obtenidos en el DataSet
            da.Fill(ds, "Usuario");//llenamos el DataSet con los datos obtenidos de la consulta SQL
            try
            {
                dataGridView1.DataMember = ("Usuario");//establecemos el miembro de datos del DataGridView para mostrar los datos de la tabla "Usuario" del DataSet
                dataGridView1.DataSource = ds;//establecemos la fuente de datos del DataGridView como el DataSet para mostrar los datos obtenidos de la consulta SQL
            }

            catch (Exception ex)//capturamos cualquier excepción que pueda ocurrir al mostrar los datos en el DataGridView y mostramos un mensaje de error
            {
                MessageBox.Show(ex.Message);//mostramos el mensaje de error de la excepción
            }
        }
    }
}
