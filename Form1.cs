using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proyecto_Semillero
{
    public partial class Form1 : Form
    {
        Consulta consulta = new Consulta(); // creamos una instancia de la clase Consultas para ejecutar las consultas a la base de datos

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(20, 255, 255, 255);
  
            txtcontraseña.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "" || txtId.Text == "") // verificamos si los campos de usuario y contraseña estan vacios
            {
                MessageBox.Show("Es obligatorio ingresar toda la información del login"); // si los campos de usuario y contraseña estan vacios, se muestra un mensaje de error al usuario
            }
            else
            {
                if (consulta.Iniciar_sesion(int.Parse(txtId.Text), txtcontraseña.Text) == true) // si el metodo Iniciar_sesion retorna true, se muestra un mensaje de bienvenida al usuario
                {
                    this.Hide(); // ocultamos el formulario Form1 al usuario
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ':')
            {
                e.Handled = true;
            }
        }
    }
}
