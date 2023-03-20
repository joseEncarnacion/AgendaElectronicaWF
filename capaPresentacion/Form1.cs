using capaEntidad;
using capaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        CNusario usuarioNeg = new CNusario();
        CEUsuario UsuarioEntidad = new CEUsuario();
        Pantalla1 p1 = new Pantalla1();

        public void login()
        {
            bool respuesta;
            DataTable dt;
            string userAuth;
            string passAuth;

            UsuarioEntidad.UsuarioE = txtUsuario.Text;
            UsuarioEntidad.passE = txtCalve.Text;

            respuesta =usuarioNeg.validarUsuario(UsuarioEntidad);

            if(respuesta == false) {

                return;
            }

             dt= usuarioNeg.NEBuscarUsuario(UsuarioEntidad);

            //dataGridView1.DataSource = dt;

            if(dt.Rows.Count == 0 ) 
            {
                MessageBox.Show("ususario no existe");
                txtCalve.Text = string.Empty;
                return; 
            
            }
            else
            {
            userAuth = dt.Rows[0]["Usuario"].ToString();
            passAuth = dt.Rows[0]["pass"].ToString();

            if(txtUsuario.Text == userAuth && txtCalve.Text == passAuth)
            {

                    p1.Show();
                    this.Hide();
               
            
             }
            }




        }

        public void Limpiar()
        {
            txtNewPass.Text = string.Empty;
            txt_newUusario.Text = string.Empty;
        }

        public void RegistrarUsuario()
        {
            bool respuesta;

            UsuarioEntidad.UsuarioE = txt_newUusario.Text;
            UsuarioEntidad.passE = txtNewPass.Text;

            respuesta = usuarioNeg.validarUsuario(UsuarioEntidad);

            if (respuesta == false)
            {

                return;
            }

            usuarioNeg.NE_crearUusario(UsuarioEntidad);
            MessageBox.Show("Usuario creado satisfactorio");

            Limpiar();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_regresarP1_Click(object sender, EventArgs e)
        {
            Pantalla1 p1 = new Pantalla1();
            p1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            
        }

        private void btn_NavLogin_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }
    }
}
