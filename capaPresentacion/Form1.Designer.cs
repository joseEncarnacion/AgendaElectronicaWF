namespace capaPresentacion
{
    partial class Form1
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
            this.btn_regresarP1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txtCalve = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_newUusario = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Crear = new System.Windows.Forms.Button();
            this.btn_NavLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelRegistro.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_regresarP1
            // 
            this.btn_regresarP1.Location = new System.Drawing.Point(123, 485);
            this.btn_regresarP1.Name = "btn_regresarP1";
            this.btn_regresarP1.Size = new System.Drawing.Size(191, 46);
            this.btn_regresarP1.TabIndex = 1;
            this.btn_regresarP1.Text = "Registrar un contacto";
            this.btn_regresarP1.UseVisualStyleBackColor = true;
            this.btn_regresarP1.Click += new System.EventHandler(this.btn_regresarP1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.panelRegistro);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 553);
            this.panel1.TabIndex = 2;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrarse.Location = new System.Drawing.Point(199, 224);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(126, 29);
            this.btnRegistrarse.TabIndex = 5;
            this.btnRegistrarse.Text = "Registrarme";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.BackColor = System.Drawing.Color.LightGreen;
            this.btn_ingresar.Location = new System.Drawing.Point(60, 224);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(133, 29);
            this.btn_ingresar.TabIndex = 4;
            this.btn_ingresar.Text = "Entrar";
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // txtCalve
            // 
            this.txtCalve.Location = new System.Drawing.Point(60, 163);
            this.txtCalve.Name = "txtCalve";
            this.txtCalve.Size = new System.Drawing.Size(265, 27);
            this.txtCalve.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(60, 79);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(265, 27);
            this.txtUsuario.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clave";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuario.Location = new System.Drawing.Point(60, 46);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(86, 30);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            this.Usuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Usuario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_ingresar);
            this.panel2.Controls.Add(this.btnRegistrarse);
            this.panel2.Controls.Add(this.txtCalve);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Location = new System.Drawing.Point(277, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 346);
            this.panel2.TabIndex = 6;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.panel3);
            this.panelRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRegistro.Location = new System.Drawing.Point(0, 0);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(1082, 553);
            this.panelRegistro.TabIndex = 7;
            this.panelRegistro.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aqua;
            this.panel3.Controls.Add(this.btn_NavLogin);
            this.panel3.Controls.Add(this.btn_Crear);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNewPass);
            this.panel3.Controls.Add(this.txt_newUusario);
            this.panel3.Location = new System.Drawing.Point(362, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 366);
            this.panel3.TabIndex = 0;
            // 
            // txt_newUusario
            // 
            this.txt_newUusario.Location = new System.Drawing.Point(47, 112);
            this.txt_newUusario.Name = "txt_newUusario";
            this.txt_newUusario.Size = new System.Drawing.Size(274, 27);
            this.txt_newUusario.TabIndex = 0;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(47, 227);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(274, 27);
            this.txtNewPass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(47, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Usario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contraseña";
            // 
            // btn_Crear
            // 
            this.btn_Crear.BackColor = System.Drawing.Color.Gold;
            this.btn_Crear.Location = new System.Drawing.Point(47, 290);
            this.btn_Crear.Name = "btn_Crear";
            this.btn_Crear.Size = new System.Drawing.Size(130, 38);
            this.btn_Crear.TabIndex = 4;
            this.btn_Crear.Text = "Crear Usuario";
            this.btn_Crear.UseVisualStyleBackColor = false;
            this.btn_Crear.Click += new System.EventHandler(this.btn_Crear_Click);
            // 
            // btn_NavLogin
            // 
            this.btn_NavLogin.BackColor = System.Drawing.Color.LightGreen;
            this.btn_NavLogin.Location = new System.Drawing.Point(196, 290);
            this.btn_NavLogin.Name = "btn_NavLogin";
            this.btn_NavLogin.Size = new System.Drawing.Size(125, 38);
            this.btn_NavLogin.TabIndex = 5;
            this.btn_NavLogin.Text = "Ir a Log in";
            this.btn_NavLogin.UseVisualStyleBackColor = false;
            this.btn_NavLogin.Click += new System.EventHandler(this.btn_NavLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_regresarP1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelRegistro.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_regresarP1;
        private Panel panel1;
        private Label Usuario;
        private Button btnRegistrarse;
        private Button btn_ingresar;
        private TextBox txtCalve;
        private TextBox txtUsuario;
        private Label label1;
        private Panel panel2;
        private Panel panelRegistro;
        private Panel panel3;
        private Button btn_NavLogin;
        private Button btn_Crear;
        private Label label3;
        private Label label2;
        private TextBox txtNewPass;
        private TextBox txt_newUusario;
    }
}