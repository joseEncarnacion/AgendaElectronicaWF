namespace capaPresentacion
{
    partial class Pantalla1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla1));
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.textMovil = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btn_ver = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.Cbox_genero = new System.Windows.Forms.ComboBox();
            this.cbox_Ecivil = new System.Windows.Forms.ComboBox();
            this.panel_verRegistro = new System.Windows.Forms.Panel();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.ver = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_AgendarContacto = new System.Windows.Forms.Button();
            this.dataGRegistro = new System.Windows.Forms.DataGridView();
            this.idPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dirreccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.textNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel_verRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(158, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 630);
            this.label1.TabIndex = 0;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNombre.Location = new System.Drawing.Point(416, 96);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(262, 34);
            this.textNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha de Nacimiento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Direccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Genero";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Movil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 452);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Correo Electronico";
            // 
            // textApellidos
            // 
            this.textApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textApellidos.Location = new System.Drawing.Point(416, 136);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(262, 34);
            this.textApellidos.TabIndex = 11;
            // 
            // textDireccion
            // 
            this.textDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDireccion.Location = new System.Drawing.Point(416, 224);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(262, 34);
            this.textDireccion.TabIndex = 13;
            // 
            // textMovil
            // 
            this.textMovil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textMovil.Location = new System.Drawing.Point(416, 350);
            this.textMovil.Name = "textMovil";
            this.textMovil.Size = new System.Drawing.Size(262, 34);
            this.textMovil.TabIndex = 16;
            // 
            // textTelefono
            // 
            this.textTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTelefono.Location = new System.Drawing.Point(416, 394);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(262, 34);
            this.textTelefono.TabIndex = 17;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(416, 442);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(262, 34);
            this.textEmail.TabIndex = 18;
            // 
            // btn_ver
            // 
            this.btn_ver.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ver.Location = new System.Drawing.Point(189, 560);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(198, 55);
            this.btn_ver.TabIndex = 19;
            this.btn_ver.Text = "Ver Registro";
            this.btn_ver.UseVisualStyleBackColor = false;
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_registrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_registrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrar.Location = new System.Drawing.Point(416, 560);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(138, 55);
            this.btn_registrar.TabIndex = 20;
            this.btn_registrar.Text = "Guardar ";
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(560, 560);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 55);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Cbox_genero
            // 
            this.Cbox_genero.FormattingEnabled = true;
            this.Cbox_genero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.Cbox_genero.Location = new System.Drawing.Point(416, 277);
            this.Cbox_genero.Name = "Cbox_genero";
            this.Cbox_genero.Size = new System.Drawing.Size(262, 28);
            this.Cbox_genero.TabIndex = 22;
            // 
            // cbox_Ecivil
            // 
            this.cbox_Ecivil.FormattingEnabled = true;
            this.cbox_Ecivil.Items.AddRange(new object[] {
            "Soltero/a",
            "casado/a",
            "divorciado/a",
            "viudo/a"});
            this.cbox_Ecivil.Location = new System.Drawing.Point(416, 317);
            this.cbox_Ecivil.Name = "cbox_Ecivil";
            this.cbox_Ecivil.Size = new System.Drawing.Size(262, 28);
            this.cbox_Ecivil.TabIndex = 23;
            // 
            // panel_verRegistro
            // 
            this.panel_verRegistro.BackColor = System.Drawing.Color.Teal;
            this.panel_verRegistro.Controls.Add(this.btn_Salir);
            this.panel_verRegistro.Controls.Add(this.ver);
            this.panel_verRegistro.Controls.Add(this.textBox1);
            this.panel_verRegistro.Controls.Add(this.btn_AgendarContacto);
            this.panel_verRegistro.Controls.Add(this.dataGRegistro);
            this.panel_verRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_verRegistro.Location = new System.Drawing.Point(0, 0);
            this.panel_verRegistro.Name = "panel_verRegistro";
            this.panel_verRegistro.Size = new System.Drawing.Size(1006, 753);
            this.panel_verRegistro.TabIndex = 24;
            this.panel_verRegistro.Visible = false;
            this.panel_verRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_verRegistro_Paint);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(764, 23);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(149, 41);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Log out";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(515, 134);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(193, 29);
            this.ver.TabIndex = 4;
            this.ver.Text = "ver";
            this.ver.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(230, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 3;
            // 
            // btn_AgendarContacto
            // 
            this.btn_AgendarContacto.BackColor = System.Drawing.Color.LightGreen;
            this.btn_AgendarContacto.Location = new System.Drawing.Point(113, 635);
            this.btn_AgendarContacto.Name = "btn_AgendarContacto";
            this.btn_AgendarContacto.Size = new System.Drawing.Size(164, 41);
            this.btn_AgendarContacto.TabIndex = 1;
            this.btn_AgendarContacto.Text = "Agendar Nuevo";
            this.btn_AgendarContacto.UseVisualStyleBackColor = false;
            this.btn_AgendarContacto.Click += new System.EventHandler(this.btn_AgendarContacto_Click);
            // 
            // dataGRegistro
            // 
            this.dataGRegistro.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersona,
            this.nombre,
            this.apellido,
            this.nacimiento,
            this.dirreccion,
            this.genero,
            this.estadoCivil,
            this.movil,
            this.tell,
            this.correo,
            this.eliminar,
            this.editar});
            this.dataGRegistro.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dataGRegistro.Location = new System.Drawing.Point(12, 191);
            this.dataGRegistro.Name = "dataGRegistro";
            this.dataGRegistro.RowHeadersWidth = 51;
            this.dataGRegistro.RowTemplate.Height = 29;
            this.dataGRegistro.Size = new System.Drawing.Size(982, 398);
            this.dataGRegistro.TabIndex = 0;
            this.dataGRegistro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGRegistro_CellContentClick);
            // 
            // idPersona
            // 
            this.idPersona.DataPropertyName = "idPersona";
            this.idPersona.HeaderText = "codigo";
            this.idPersona.MinimumWidth = 6;
            this.idPersona.Name = "idPersona";
            this.idPersona.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "Apellidos";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.Width = 125;
            // 
            // nacimiento
            // 
            this.nacimiento.DataPropertyName = "nacimiento";
            this.nacimiento.HeaderText = "Fecha Nacimiento";
            this.nacimiento.MinimumWidth = 6;
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Width = 125;
            // 
            // dirreccion
            // 
            this.dirreccion.DataPropertyName = "dirreccion";
            this.dirreccion.HeaderText = "Direccion";
            this.dirreccion.MinimumWidth = 6;
            this.dirreccion.Name = "dirreccion";
            this.dirreccion.Width = 125;
            // 
            // genero
            // 
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "Genero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.Width = 125;
            // 
            // estadoCivil
            // 
            this.estadoCivil.DataPropertyName = "estadoCivil";
            this.estadoCivil.HeaderText = "Estado Civil";
            this.estadoCivil.MinimumWidth = 6;
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Width = 125;
            // 
            // movil
            // 
            this.movil.DataPropertyName = "movil";
            this.movil.HeaderText = "Movil";
            this.movil.MinimumWidth = 6;
            this.movil.Name = "movil";
            this.movil.Width = 125;
            // 
            // tell
            // 
            this.tell.DataPropertyName = "tell";
            this.tell.HeaderText = "Telefono";
            this.tell.MinimumWidth = 6;
            this.tell.Name = "tell";
            this.tell.Width = 125;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "Email";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.Width = 125;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "Eliminar";
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.MinimumWidth = 6;
            this.eliminar.Name = "eliminar";
            this.eliminar.Width = 125;
            // 
            // editar
            // 
            this.editar.HeaderText = "Editar";
            this.editar.Image = ((System.Drawing.Image)(resources.GetObject("editar.Image")));
            this.editar.MinimumWidth = 6;
            this.editar.Name = "editar";
            this.editar.Width = 125;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.Color.Black;
            this.btn_Editar.Location = new System.Drawing.Point(416, 517);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(270, 37);
            this.btn_Editar.TabIndex = 25;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Visible = false;
            // 
            // textNacimiento
            // 
            this.textNacimiento.Location = new System.Drawing.Point(416, 186);
            this.textNacimiento.Name = "textNacimiento";
            this.textNacimiento.Size = new System.Drawing.Size(262, 27);
            this.textNacimiento.TabIndex = 26;
            // 
            // Pantalla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1006, 753);
            this.Controls.Add(this.textNacimiento);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.panel_verRegistro);
            this.Controls.Add(this.cbox_Ecivil);
            this.Controls.Add(this.Cbox_genero);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textMovil);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "Pantalla1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.panel_verRegistro.ResumeLayout(false);
            this.panel_verRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textApellidos;
        private TextBox textDireccion;
        private TextBox textMovil;
        private TextBox textTelefono;
        private TextBox textEmail;
        private Button btn_ver;
        private Button btn_registrar;
        private Button btnLimpiar;
        private ComboBox Cbox_genero;
        private ComboBox cbox_Ecivil;
        private Panel panel_verRegistro;
        private DataGridView dataGRegistro;
        private Button ver;
        private TextBox textBox1;
        private Button btn_AgendarContacto;
        private DataGridViewTextBoxColumn idPersona;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nacimiento;
        private DataGridViewTextBoxColumn dirreccion;
        private DataGridViewTextBoxColumn genero;
        private DataGridViewTextBoxColumn estadoCivil;
        private DataGridViewTextBoxColumn movil;
        private DataGridViewTextBoxColumn tell;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewImageColumn eliminar;
        private DataGridViewImageColumn editar;
        private Button btn_Editar;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker textNacimiento;
        private Button btn_Salir;
    }
}