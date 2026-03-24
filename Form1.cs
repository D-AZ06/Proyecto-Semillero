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
            panel1.BackColor = Color.FromArgb(20, 255, 255, 255);
            RedondearPanel(panel1, 25);
            txtcontraseña.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RedondearPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseAllFigures();
            panel.Region = new Region(path);
        }

        

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtcontraseña.Text == "" || txtId.Text == "") // verificamos si los campos de usuario y contraseña estan vacios
            {
                MessageBox.Show("Es obligatorio ingresar toda la información del login"); // si los campos de usuario y contraseña estan vacios, se muestra un mensaje de error al usuario
            }
            else
            {
                consulta.Iniciar_sesion(int.Parse(txtId.Text), txtcontraseña.Text); // si los campos de usuario y contraseña no estan vacios, se ejecuta el metodo Iniciar_sesion para verificar si el usuario y la contraseña ingresados por el usuario coinciden con los resultados de la consulta a la base de datos)
                this.Hide(); // ocultamos el formulario Form1 al usuario
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas salir del programa?", "salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
