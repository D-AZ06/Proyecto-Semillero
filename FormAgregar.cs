using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Proyecto_Semillero
{
    public partial class FormAgregar : Form
    {
        Conexion conexion = new Conexion();

        public string tipo;

        public FormAgregar()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            int idUsuario = int.Parse(txtIdUsuario.Text);
            string contraseña = txtContraseña.Text;
            string nombre = txtNombre.Text;
            string rol = cboRol.Text;
            long telefono = long.Parse(txtTelefonoUsuario.Text);
            string correo = txtCorreoUsuario.Text;
            int edad = int.Parse(txtEdadUsuario.Text);
            string genero = cboGeneroUsuario.Text;
            string estado = cboEstado.Text;

            if ((txtIdUsuario.Text == "") || (txtContraseña.Text == "") || (txtNombre.Text == "") || (cboRol.SelectedIndex == 0) || (txtTelefonoUsuario.Text == "") || (txtCorreoUsuario.Text == "") || (txtEdadUsuario.Text == "") || (cboGeneroUsuario.Text == "") || (cboEstado.SelectedIndex == 0))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }

            else
            {
                SqlCommand insert;

                try
                {
                    insert = new SqlCommand("INSERT INTO Usuario (idUsuario, contraseñaUsuario, nombresUsuario, rolUsuario, telefonoUsuario, correoUsuario, edadUsuario, generoUsuario, estadoUsuario) " +
                        "VALUES (@idUsuario, @contraseña, @nombre, @rol, @telefono, @correo, @edad, @genero, @estado)",
                        conexion.Conectar()
                    );

                    insert.CommandType = CommandType.Text;

                    insert.Parameters.AddWithValue("@idUsuario", idUsuario);
                    insert.Parameters.AddWithValue("@contraseña", contraseña);
                    insert.Parameters.AddWithValue("@nombre", nombre);
                    insert.Parameters.AddWithValue("@rol", rol);
                    insert.Parameters.AddWithValue("@telefono", telefono);
                    insert.Parameters.AddWithValue("@correo", correo);
                    insert.Parameters.AddWithValue("@edad", edad);
                    insert.Parameters.AddWithValue("@genero", genero);
                    insert.Parameters.AddWithValue("@estado", estado);

                    insert.ExecuteNonQuery();

                    MessageBox.Show("Usuario guardado correctamente");

                    // cerrar conexión (como ya la tienes global)
                    conexion.cerrar();

                    // cerrar formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            if (tipo == "Usuario")
            {
                tabAgregar.SelectedTab = tabUsuario;
            }
             else if (tipo == "Semillero")
            {
                tabAgregar.SelectedTab = tabSemillero;
            }
        }
    }
}
