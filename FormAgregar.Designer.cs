namespace Proyecto_Semillero
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabAgregar = new System.Windows.Forms.TabControl();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboGeneroUsuario = new System.Windows.Forms.ComboBox();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdadUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.tabSemillero = new System.Windows.Forms.TabPage();
            this.tabAgregar.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tabUsuario);
            this.tabAgregar.Controls.Add(this.tabSemillero);
            this.tabAgregar.Location = new System.Drawing.Point(12, 12);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.SelectedIndex = 0;
            this.tabAgregar.Size = new System.Drawing.Size(453, 426);
            this.tabAgregar.TabIndex = 0;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.cboEstado);
            this.tabUsuario.Controls.Add(this.label9);
            this.tabUsuario.Controls.Add(this.cboGeneroUsuario);
            this.tabUsuario.Controls.Add(this.cboRol);
            this.tabUsuario.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuario.Controls.Add(this.label8);
            this.tabUsuario.Controls.Add(this.label7);
            this.tabUsuario.Controls.Add(this.txtEdadUsuario);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Controls.Add(this.txtCorreoUsuario);
            this.tabUsuario.Controls.Add(this.label5);
            this.tabUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.tabUsuario.Controls.Add(this.label4);
            this.tabUsuario.Controls.Add(this.label3);
            this.tabUsuario.Controls.Add(this.txtNombre);
            this.tabUsuario.Controls.Add(this.label2);
            this.tabUsuario.Controls.Add(this.txtContraseña);
            this.tabUsuario.Controls.Add(this.label1);
            this.tabUsuario.Controls.Add(this.txtIdUsuario);
            this.tabUsuario.Location = new System.Drawing.Point(4, 25);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuario.Size = new System.Drawing.Size(445, 397);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuario";
            this.tabUsuario.UseVisualStyleBackColor = true;
            this.tabUsuario.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.Enabled = false;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(209, 259);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 24);
            this.cboEstado.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado";
            // 
            // cboGeneroUsuario
            // 
            this.cboGeneroUsuario.Enabled = false;
            this.cboGeneroUsuario.FormattingEnabled = true;
            this.cboGeneroUsuario.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.cboGeneroUsuario.Location = new System.Drawing.Point(209, 229);
            this.cboGeneroUsuario.Name = "cboGeneroUsuario";
            this.cboGeneroUsuario.Size = new System.Drawing.Size(121, 24);
            this.cboGeneroUsuario.TabIndex = 18;
            // 
            // cboRol
            // 
            this.cboRol.Enabled = false;
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Lider",
            "Investigador"});
            this.cboRol.Location = new System.Drawing.Point(209, 117);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(121, 24);
            this.cboRol.TabIndex = 17;
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(172, 291);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad";
            // 
            // txtEdadUsuario
            // 
            this.txtEdadUsuario.Location = new System.Drawing.Point(209, 201);
            this.txtEdadUsuario.Name = "txtEdadUsuario";
            this.txtEdadUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtEdadUsuario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "correo";
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(209, 173);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtCorreoUsuario.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "telefono";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(209, 145);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtTelefonoUsuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 89);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(209, 61);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 22);
            this.txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Usuario";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(209, 33);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // tabSemillero
            // 
            this.tabSemillero.Location = new System.Drawing.Point(4, 25);
            this.tabSemillero.Name = "tabSemillero";
            this.tabSemillero.Padding = new System.Windows.Forms.Padding(3);
            this.tabSemillero.Size = new System.Drawing.Size(445, 397);
            this.tabSemillero.TabIndex = 1;
            this.tabSemillero.Text = "Semillero";
            this.tabSemillero.UseVisualStyleBackColor = true;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.tabAgregar);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.tabAgregar.ResumeLayout(false);
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabAgregar;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.TabPage tabSemillero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdadUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.ComboBox cboGeneroUsuario;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label9;
    }
}