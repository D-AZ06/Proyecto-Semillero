namespace Proyecto_Semillero
{
    partial class FormAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_eventos = new Guna.UI2.WinForms.Guna2Button();
            this.btn_proyecto = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_gestionar_reportes = new Guna.UI2.WinForms.Guna2Button();
            this.btn_semillero = new Guna.UI2.WinForms.Guna2Button();
            this.btn_gestionar_usuarios = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblGesSi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbsalir = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnModificar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_gestionar = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnconsultalp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnactulizar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtactualizarcon = new System.Windows.Forms.TextBox();
            this.txtactualizarid = new System.Windows.Forms.TextBox();
            this.btn_patrocinadores = new Guna.UI2.WinForms.Guna2Button();
            this.btn_actividades = new Guna.UI2.WinForms.Guna2Button();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel3.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BorderRadius = 20;
            this.Panel1.Controls.Add(this.btn_actividades);
            this.Panel1.Controls.Add(this.btn_patrocinadores);
            this.Panel1.Controls.Add(this.btn_eventos);
            this.Panel1.Controls.Add(this.btn_proyecto);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.btn_gestionar_reportes);
            this.Panel1.Controls.Add(this.btn_semillero);
            this.Panel1.Controls.Add(this.btn_gestionar_usuarios);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Location = new System.Drawing.Point(13, 75);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(257, 568);
            this.Panel1.TabIndex = 0;
            // 
            // btn_eventos
            // 
            this.btn_eventos.BackColor = System.Drawing.Color.Transparent;
            this.btn_eventos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eventos.BorderRadius = 15;
            this.btn_eventos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eventos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eventos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eventos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eventos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btn_eventos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eventos.ForeColor = System.Drawing.Color.White;
            this.btn_eventos.Location = new System.Drawing.Point(27, 299);
            this.btn_eventos.Name = "btn_eventos";
            this.btn_eventos.Size = new System.Drawing.Size(192, 34);
            this.btn_eventos.TabIndex = 8;
            this.btn_eventos.Text = "🎉 Eventos";
            this.btn_eventos.Click += new System.EventHandler(this.btn_eventos_Click);
            // 
            // btn_proyecto
            // 
            this.btn_proyecto.BackColor = System.Drawing.Color.Transparent;
            this.btn_proyecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_proyecto.BorderRadius = 15;
            this.btn_proyecto.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_proyecto.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_proyecto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_proyecto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_proyecto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(182)))), ((int)(((byte)(212)))));
            this.btn_proyecto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proyecto.ForeColor = System.Drawing.Color.White;
            this.btn_proyecto.Location = new System.Drawing.Point(27, 227);
            this.btn_proyecto.Name = "btn_proyecto";
            this.btn_proyecto.Size = new System.Drawing.Size(192, 34);
            this.btn_proyecto.TabIndex = 7;
            this.btn_proyecto.Text = "📁 Proyectos";
            this.btn_proyecto.Click += new System.EventHandler(this.btn_proyecto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "¿Qué desea gestionar hoy?";
            // 
            // btn_gestionar_reportes
            // 
            this.btn_gestionar_reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionar_reportes.BorderRadius = 15;
            this.btn_gestionar_reportes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionar_reportes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionar_reportes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionar_reportes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionar_reportes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btn_gestionar_reportes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionar_reportes.ForeColor = System.Drawing.Color.White;
            this.btn_gestionar_reportes.Location = new System.Drawing.Point(27, 371);
            this.btn_gestionar_reportes.Name = "btn_gestionar_reportes";
            this.btn_gestionar_reportes.Size = new System.Drawing.Size(192, 34);
            this.btn_gestionar_reportes.TabIndex = 4;
            this.btn_gestionar_reportes.Text = "📄 Reportes";
            this.btn_gestionar_reportes.Click += new System.EventHandler(this.btn_gestionar_reportes_Click);
            // 
            // btn_semillero
            // 
            this.btn_semillero.BackColor = System.Drawing.Color.Transparent;
            this.btn_semillero.BorderRadius = 15;
            this.btn_semillero.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_semillero.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_semillero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_semillero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_semillero.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(197)))), ((int)(((byte)(94)))));
            this.btn_semillero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semillero.ForeColor = System.Drawing.Color.White;
            this.btn_semillero.Location = new System.Drawing.Point(27, 156);
            this.btn_semillero.Name = "btn_semillero";
            this.btn_semillero.Size = new System.Drawing.Size(192, 34);
            this.btn_semillero.TabIndex = 3;
            this.btn_semillero.Text = "🌱 Semillero";
            this.btn_semillero.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btn_gestionar_usuarios
            // 
            this.btn_gestionar_usuarios.BackColor = System.Drawing.Color.Transparent;
            this.btn_gestionar_usuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gestionar_usuarios.BorderRadius = 15;
            this.btn_gestionar_usuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionar_usuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_gestionar_usuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_gestionar_usuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_gestionar_usuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(130)))), ((int)(((byte)(246)))));
            this.btn_gestionar_usuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gestionar_usuarios.ForeColor = System.Drawing.Color.White;
            this.btn_gestionar_usuarios.Location = new System.Drawing.Point(30, 85);
            this.btn_gestionar_usuarios.Name = "btn_gestionar_usuarios";
            this.btn_gestionar_usuarios.Size = new System.Drawing.Size(192, 34);
            this.btn_gestionar_usuarios.TabIndex = 2;
            this.btn_gestionar_usuarios.Text = "👤 Usuarios ";
            this.btn_gestionar_usuarios.Click += new System.EventHandler(this.btn_gestionar_usuarios_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido Administrador";
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.lblGesSi);
            this.Panel2.Controls.Add(this.pictureBox1);
            this.Panel2.Controls.Add(this.btbsalir);
            this.Panel2.Location = new System.Drawing.Point(-2, -8);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1111, 73);
            this.Panel2.TabIndex = 1;
            // 
            // lblGesSi
            // 
            this.lblGesSi.AutoSize = true;
            this.lblGesSi.BackColor = System.Drawing.Color.Transparent;
            this.lblGesSi.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGesSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGesSi.Location = new System.Drawing.Point(532, 24);
            this.lblGesSi.Name = "lblGesSi";
            this.lblGesSi.Size = new System.Drawing.Size(84, 33);
            this.lblGesSi.TabIndex = 9;
            this.lblGesSi.Text = "GesSi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Proyecto_Semillero.Properties.Resources.Sin_título__5_;
            this.pictureBox1.Location = new System.Drawing.Point(491, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btbsalir
            // 
            this.btbsalir.BackColor = System.Drawing.Color.Transparent;
            this.btbsalir.BorderRadius = 15;
            this.btbsalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btbsalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btbsalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btbsalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btbsalir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btbsalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbsalir.ForeColor = System.Drawing.Color.White;
            this.btbsalir.Location = new System.Drawing.Point(14, 26);
            this.btbsalir.Name = "btbsalir";
            this.btbsalir.Size = new System.Drawing.Size(112, 26);
            this.btbsalir.TabIndex = 9;
            this.btbsalir.Text = "◀️ Salir";
            this.btbsalir.Click += new System.EventHandler(this.btbsalir_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeight = 4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(113, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(546, 274);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView1.ThemeStyle.ReadOnly = false;
            this.dataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView1.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.btnModificar);
            this.Panel3.Controls.Add(this.btnRegistrar);
            this.Panel3.Controls.Add(this.lbl_gestionar);
            this.Panel3.Controls.Add(this.dataGridView1);
            this.Panel3.Location = new System.Drawing.Point(290, 75);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(803, 333);
            this.Panel3.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BorderRadius = 15;
            this.btnModificar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnModificar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnModificar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnModificar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(674, 92);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 34);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BorderRadius = 15;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(674, 42);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(97, 34);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lbl_gestionar
            // 
            this.lbl_gestionar.AutoSize = true;
            this.lbl_gestionar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gestionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gestionar.ForeColor = System.Drawing.Color.White;
            this.lbl_gestionar.Location = new System.Drawing.Point(349, 11);
            this.lbl_gestionar.Name = "lbl_gestionar";
            this.lbl_gestionar.Size = new System.Drawing.Size(61, 19);
            this.lbl_gestionar.TabIndex = 7;
            this.lbl_gestionar.Text = "Gestion";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.groupBox1);
            this.guna2Panel1.Controls.Add(this.groupBox3);
            this.guna2Panel1.Location = new System.Drawing.Point(290, 421);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(803, 222);
            this.guna2Panel1.TabIndex = 4;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnconsultalp);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(353, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 160);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar por parametros";
            // 
            // btnconsultalp
            // 
            this.btnconsultalp.Location = new System.Drawing.Point(38, 92);
            this.btnconsultalp.Name = "btnconsultalp";
            this.btnconsultalp.Size = new System.Drawing.Size(75, 23);
            this.btnconsultalp.TabIndex = 6;
            this.btnconsultalp.Text = "ConsultarP";
            this.btnconsultalp.UseVisualStyleBackColor = true;
            this.btnconsultalp.Click += new System.EventHandler(this.btnconsultalp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "idUsuario",
            "rolUsuario"});
            this.comboBox1.Location = new System.Drawing.Point(132, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecciona la opcion";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnactulizar);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtactualizarcon);
            this.groupBox3.Controls.Add(this.txtactualizarid);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(20, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 159);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actulización";
            // 
            // btnactulizar
            // 
            this.btnactulizar.Location = new System.Drawing.Point(42, 108);
            this.btnactulizar.Name = "btnactulizar";
            this.btnactulizar.Size = new System.Drawing.Size(75, 23);
            this.btnactulizar.TabIndex = 13;
            this.btnactulizar.Text = "Actualizar";
            this.btnactulizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(154, 108);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Contraseña";
            // 
            // txtactualizarcon
            // 
            this.txtactualizarcon.Location = new System.Drawing.Point(108, 66);
            this.txtactualizarcon.Name = "txtactualizarcon";
            this.txtactualizarcon.Size = new System.Drawing.Size(121, 20);
            this.txtactualizarcon.TabIndex = 14;
            // 
            // txtactualizarid
            // 
            this.txtactualizarid.Location = new System.Drawing.Point(108, 20);
            this.txtactualizarid.Name = "txtactualizarid";
            this.txtactualizarid.ReadOnly = true;
            this.txtactualizarid.Size = new System.Drawing.Size(121, 20);
            this.txtactualizarid.TabIndex = 12;
            // 
            // btn_patrocinadores
            // 
            this.btn_patrocinadores.BackColor = System.Drawing.Color.Transparent;
            this.btn_patrocinadores.BorderRadius = 15;
            this.btn_patrocinadores.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_patrocinadores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_patrocinadores.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_patrocinadores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_patrocinadores.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btn_patrocinadores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_patrocinadores.ForeColor = System.Drawing.Color.White;
            this.btn_patrocinadores.Location = new System.Drawing.Point(27, 440);
            this.btn_patrocinadores.Name = "btn_patrocinadores";
            this.btn_patrocinadores.Size = new System.Drawing.Size(192, 34);
            this.btn_patrocinadores.TabIndex = 9;
            this.btn_patrocinadores.Text = "🤝 Patrocinadores";
            this.btn_patrocinadores.Click += new System.EventHandler(this.btn_patrocinadores_Click);
            // 
            // btn_actividades
            // 
            this.btn_actividades.BackColor = System.Drawing.Color.Transparent;
            this.btn_actividades.BorderRadius = 15;
            this.btn_actividades.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_actividades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_actividades.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_actividades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_actividades.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.btn_actividades.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actividades.ForeColor = System.Drawing.Color.White;
            this.btn_actividades.Location = new System.Drawing.Point(27, 508);
            this.btn_actividades.Name = "btn_actividades";
            this.btn_actividades.Size = new System.Drawing.Size(192, 34);
            this.btn_actividades.TabIndex = 10;
            this.btn_actividades.Text = "🎯 Actividades";
            this.btn_actividades.Click += new System.EventHandler(this.btn_actividades_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Semillero.Properties.Resources._592593667718;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 687);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_gestionar_reportes;
        private Guna.UI2.WinForms.Guna2Button btn_semillero;
        private Guna.UI2.WinForms.Guna2Button btn_gestionar_usuarios;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Panel Panel3;
        private System.Windows.Forms.Label lbl_gestionar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_eventos;
        private Guna.UI2.WinForms.Guna2Button btn_proyecto;
        private Guna.UI2.WinForms.Guna2Button btbsalir;
        private System.Windows.Forms.Label lblGesSi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactulizar;
        private System.Windows.Forms.TextBox txtactualizarcon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtactualizarid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnconsultalp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRegistrar;
        private Guna.UI2.WinForms.Guna2Button btnModificar;
        private Guna.UI2.WinForms.Guna2Button btn_actividades;
        private Guna.UI2.WinForms.Guna2Button btn_patrocinadores;
    }
}