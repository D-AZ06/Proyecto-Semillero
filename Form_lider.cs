using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Semillero
{
    public partial class Form_lider : Form
    {
        public int idSemillero; // creamos la variable idSemillero para almacenar el id del semillero al que pertenece el lider 
        Consulta Consulta = new Consulta(); // creamos un objeto de tipo Consulta para llamar a los métodos de la clase Consulta

        public Form_lider(int idSemillero)
        {
            InitializeComponent();
            this.idSemillero = idSemillero;
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

        private void btn_gestionar_usuarios_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            Consulta.GestionarUsuarios(idSemillero, dataGridView1);//llamamos al método GestionarUsuario de la clase Consulta, pasando el id del semillero y el DataGridView para mostrar los usuarios
        }
    }
}
