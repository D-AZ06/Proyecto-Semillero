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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabActividades = new System.Windows.Forms.TabPage();
            this.tabPatroc = new System.Windows.Forms.TabPage();
            this.tabReportes = new System.Windows.Forms.TabPage();
            this.tabProyectos = new System.Windows.Forms.TabPage();
            this.tabEventos = new System.Windows.Forms.TabPage();
            this.tabSemillero = new System.Windows.Forms.TabPage();
            this.tabUsuario = new System.Windows.Forms.TabPage();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEdadUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.cboGeneroUsuario = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.tabAgregar = new System.Windows.Forms.TabControl();
            this.lblsemillero = new System.Windows.Forms.Label();
            this.lbleventos = new System.Windows.Forms.Label();
            this.lblproyecto = new System.Windows.Forms.Label();
            this.lblreporte = new System.Windows.Forms.Label();
            this.lblpatroc = new System.Windows.Forms.Label();
            this.lblactividades = new System.Windows.Forms.Label();
            this.tabActividades.SuspendLayout();
            this.tabPatroc.SuspendLayout();
            this.tabReportes.SuspendLayout();
            this.tabProyectos.SuspendLayout();
            this.tabEventos.SuspendLayout();
            this.tabSemillero.SuspendLayout();
            this.tabUsuario.SuspendLayout();
            this.tabAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(344, 379);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 32);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabActividades
            // 
            this.tabActividades.Controls.Add(this.lblactividades);
            this.tabActividades.Location = new System.Drawing.Point(4, 22);
            this.tabActividades.Margin = new System.Windows.Forms.Padding(2);
            this.tabActividades.Name = "tabActividades";
            this.tabActividades.Padding = new System.Windows.Forms.Padding(2);
            this.tabActividades.Size = new System.Drawing.Size(386, 338);
            this.tabActividades.TabIndex = 6;
            this.tabActividades.Text = "Actividades";
            this.tabActividades.UseVisualStyleBackColor = true;
            // 
            // tabPatroc
            // 
            this.tabPatroc.Controls.Add(this.lblpatroc);
            this.tabPatroc.Location = new System.Drawing.Point(4, 22);
            this.tabPatroc.Margin = new System.Windows.Forms.Padding(2);
            this.tabPatroc.Name = "tabPatroc";
            this.tabPatroc.Padding = new System.Windows.Forms.Padding(2);
            this.tabPatroc.Size = new System.Drawing.Size(386, 338);
            this.tabPatroc.TabIndex = 5;
            this.tabPatroc.Text = "Patrocinadores";
            this.tabPatroc.UseVisualStyleBackColor = true;
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.lblreporte);
            this.tabReportes.Location = new System.Drawing.Point(4, 22);
            this.tabReportes.Margin = new System.Windows.Forms.Padding(2);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.Padding = new System.Windows.Forms.Padding(2);
            this.tabReportes.Size = new System.Drawing.Size(386, 338);
            this.tabReportes.TabIndex = 4;
            this.tabReportes.Text = "Reportes";
            this.tabReportes.UseVisualStyleBackColor = true;
            // 
            // tabProyectos
            // 
            this.tabProyectos.Controls.Add(this.lblproyecto);
            this.tabProyectos.Location = new System.Drawing.Point(4, 22);
            this.tabProyectos.Margin = new System.Windows.Forms.Padding(2);
            this.tabProyectos.Name = "tabProyectos";
            this.tabProyectos.Padding = new System.Windows.Forms.Padding(2);
            this.tabProyectos.Size = new System.Drawing.Size(386, 338);
            this.tabProyectos.TabIndex = 3;
            this.tabProyectos.Text = "Proyectos";
            this.tabProyectos.UseVisualStyleBackColor = true;
            // 
            // tabEventos
            // 
            this.tabEventos.Controls.Add(this.lbleventos);
            this.tabEventos.Location = new System.Drawing.Point(4, 22);
            this.tabEventos.Margin = new System.Windows.Forms.Padding(2);
            this.tabEventos.Name = "tabEventos";
            this.tabEventos.Padding = new System.Windows.Forms.Padding(2);
            this.tabEventos.Size = new System.Drawing.Size(386, 338);
            this.tabEventos.TabIndex = 2;
            this.tabEventos.Text = "Eventos";
            this.tabEventos.UseVisualStyleBackColor = true;
            // 
            // tabSemillero
            // 
            this.tabSemillero.Controls.Add(this.lblsemillero);
            this.tabSemillero.Location = new System.Drawing.Point(4, 22);
            this.tabSemillero.Margin = new System.Windows.Forms.Padding(2);
            this.tabSemillero.Name = "tabSemillero";
            this.tabSemillero.Padding = new System.Windows.Forms.Padding(2);
            this.tabSemillero.Size = new System.Drawing.Size(386, 338);
            this.tabSemillero.TabIndex = 1;
            this.tabSemillero.Text = "Semillero";
            this.tabSemillero.UseVisualStyleBackColor = true;
            // 
            // tabUsuario
            // 
            this.tabUsuario.Controls.Add(this.btnModificarUsuario);
            this.tabUsuario.Controls.Add(this.label10);
            this.tabUsuario.Controls.Add(this.cboEstado);
            this.tabUsuario.Controls.Add(this.label9);
            this.tabUsuario.Controls.Add(this.cboGeneroUsuario);
            this.tabUsuario.Controls.Add(this.cboRol);
            this.tabUsuario.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuario.Controls.Add(this.label8);
            this.tabUsuario.Controls.Add(this.label7);
            this.tabUsuario.Controls.Add(this.txtEdadUsuario);
            this.tabUsuario.Controls.Add(this.txtCorreoUsuario);
            this.tabUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.tabUsuario.Controls.Add(this.txtNombre);
            this.tabUsuario.Controls.Add(this.txtContraseña);
            this.tabUsuario.Controls.Add(this.txtIdUsuario);
            this.tabUsuario.Controls.Add(this.label6);
            this.tabUsuario.Controls.Add(this.label5);
            this.tabUsuario.Controls.Add(this.label4);
            this.tabUsuario.Controls.Add(this.label3);
            this.tabUsuario.Controls.Add(this.label2);
            this.tabUsuario.Controls.Add(this.label1);
            this.tabUsuario.Location = new System.Drawing.Point(4, 22);
            this.tabUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tabUsuario.Name = "tabUsuario";
            this.tabUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.tabUsuario.Size = new System.Drawing.Size(386, 338);
            this.tabUsuario.TabIndex = 0;
            this.tabUsuario.Text = "Usuario";
            this.tabUsuario.UseVisualStyleBackColor = true;
            this.tabUsuario.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(156, 59);
            this.txtIdUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtIdUsuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(156, 82);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(76, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 105);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rol";
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(156, 150);
            this.txtTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtTelefonoUsuario.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "telefono";
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(156, 173);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtCorreoUsuario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "correo";
            // 
            // txtEdadUsuario
            // 
            this.txtEdadUsuario.Location = new System.Drawing.Point(156, 196);
            this.txtEdadUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtEdadUsuario.Name = "txtEdadUsuario";
            this.txtEdadUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtEdadUsuario.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 221);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "genero";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(190, 283);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(56, 25);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // cboRol
            // 
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Lider",
            "Investigador"});
            this.cboRol.Location = new System.Drawing.Point(156, 128);
            this.cboRol.Margin = new System.Windows.Forms.Padding(2);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(92, 21);
            this.cboRol.TabIndex = 17;
            // 
            // cboGeneroUsuario
            // 
            this.cboGeneroUsuario.FormattingEnabled = true;
            this.cboGeneroUsuario.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Femenino"});
            this.cboGeneroUsuario.Location = new System.Drawing.Point(156, 219);
            this.cboGeneroUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cboGeneroUsuario.Name = "cboGeneroUsuario";
            this.cboGeneroUsuario.Size = new System.Drawing.Size(92, 21);
            this.cboGeneroUsuario.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Estado";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(156, 243);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(92, 21);
            this.cboEstado.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Usuario";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(79, 283);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(56, 25);
            this.btnModificarUsuario.TabIndex = 22;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // tabAgregar
            // 
            this.tabAgregar.Controls.Add(this.tabUsuario);
            this.tabAgregar.Controls.Add(this.tabSemillero);
            this.tabAgregar.Controls.Add(this.tabEventos);
            this.tabAgregar.Controls.Add(this.tabProyectos);
            this.tabAgregar.Controls.Add(this.tabReportes);
            this.tabAgregar.Controls.Add(this.tabPatroc);
            this.tabAgregar.Controls.Add(this.tabActividades);
            this.tabAgregar.Location = new System.Drawing.Point(6, 11);
            this.tabAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.tabAgregar.Name = "tabAgregar";
            this.tabAgregar.SelectedIndex = 0;
            this.tabAgregar.Size = new System.Drawing.Size(394, 364);
            this.tabAgregar.TabIndex = 0;
            // 
            // lblsemillero
            // 
            this.lblsemillero.AutoSize = true;
            this.lblsemillero.Location = new System.Drawing.Point(145, 16);
            this.lblsemillero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsemillero.Name = "lblsemillero";
            this.lblsemillero.Size = new System.Drawing.Size(49, 13);
            this.lblsemillero.TabIndex = 22;
            this.lblsemillero.Text = "Semillero";
            // 
            // lbleventos
            // 
            this.lbleventos.AutoSize = true;
            this.lbleventos.Location = new System.Drawing.Point(145, 18);
            this.lbleventos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbleventos.Name = "lbleventos";
            this.lbleventos.Size = new System.Drawing.Size(46, 13);
            this.lbleventos.TabIndex = 22;
            this.lbleventos.Text = "Eventos";
            // 
            // lblproyecto
            // 
            this.lblproyecto.AutoSize = true;
            this.lblproyecto.Location = new System.Drawing.Point(155, 31);
            this.lblproyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblproyecto.Name = "lblproyecto";
            this.lblproyecto.Size = new System.Drawing.Size(54, 13);
            this.lblproyecto.TabIndex = 22;
            this.lblproyecto.Text = "Proyectos";
            // 
            // lblreporte
            // 
            this.lblreporte.AutoSize = true;
            this.lblreporte.Location = new System.Drawing.Point(154, 20);
            this.lblreporte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreporte.Name = "lblreporte";
            this.lblreporte.Size = new System.Drawing.Size(50, 13);
            this.lblreporte.TabIndex = 22;
            this.lblreporte.Text = "Reportes";
            // 
            // lblpatroc
            // 
            this.lblpatroc.AutoSize = true;
            this.lblpatroc.Location = new System.Drawing.Point(141, 13);
            this.lblpatroc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpatroc.Name = "lblpatroc";
            this.lblpatroc.Size = new System.Drawing.Size(78, 13);
            this.lblpatroc.TabIndex = 22;
            this.lblpatroc.Text = "Patrocinadores";
            // 
            // lblactividades
            // 
            this.lblactividades.AutoSize = true;
            this.lblactividades.Location = new System.Drawing.Point(143, 20);
            this.lblactividades.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblactividades.Name = "lblactividades";
            this.lblactividades.Size = new System.Drawing.Size(62, 13);
            this.lblactividades.TabIndex = 22;
            this.lblactividades.Text = "Actividades";
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 420);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabAgregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            this.Load += new System.EventHandler(this.FormAgregar_Load);
            this.tabActividades.ResumeLayout(false);
            this.tabActividades.PerformLayout();
            this.tabPatroc.ResumeLayout(false);
            this.tabPatroc.PerformLayout();
            this.tabReportes.ResumeLayout(false);
            this.tabReportes.PerformLayout();
            this.tabProyectos.ResumeLayout(false);
            this.tabProyectos.PerformLayout();
            this.tabEventos.ResumeLayout(false);
            this.tabEventos.PerformLayout();
            this.tabSemillero.ResumeLayout(false);
            this.tabSemillero.PerformLayout();
            this.tabUsuario.ResumeLayout(false);
            this.tabUsuario.PerformLayout();
            this.tabAgregar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TabPage tabActividades;
        private System.Windows.Forms.TabPage tabPatroc;
        private System.Windows.Forms.TabPage tabReportes;
        private System.Windows.Forms.TabPage tabProyectos;
        private System.Windows.Forms.TabPage tabEventos;
        private System.Windows.Forms.TabPage tabSemillero;
        private System.Windows.Forms.TabPage tabUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGeneroUsuario;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdadUsuario;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabAgregar;
        private System.Windows.Forms.Label lblactividades;
        private System.Windows.Forms.Label lblpatroc;
        private System.Windows.Forms.Label lblreporte;
        private System.Windows.Forms.Label lblproyecto;
        private System.Windows.Forms.Label lbleventos;
        private System.Windows.Forms.Label lblsemillero;
    }
}