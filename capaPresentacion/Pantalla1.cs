using capaEntidad;
using capaNegocio;
using System.Data;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Pantalla1 : Form
    {
        //variables
       // Form1 formvistaRegistro;
        CEagencia entidadPersona = new CEagencia(); 
        CNagencia negPersona = new CNagencia();
        bool existe = false;
        string id = string.Empty;
        

        public Pantalla1()
        {
            InitializeComponent();
            //formvistaRegistro = new Form1();    
        }


        void limpiar()
        {
            textNombre.Text = string.Empty;
            textApellidos.Text = string.Empty;
            textDireccion.Text = string.Empty;  
            Cbox_genero.Text = string.Empty;
            cbox_Ecivil.Text = string.Empty;
            textMovil.Text = string.Empty;
            textTelefono.Text = string.Empty;   
            textEmail.Text = string.Empty;  

        }


        public void listarDatos()
        {
            DataTable dt = negPersona.NElistado();
            dataGRegistro.DataSource = dt;

        }


        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            // this.Hide();
            // formvistaRegistro.ShowDialog();

            panel_verRegistro.Visible = true;
            textNacimiento.Visible = false;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {


                bool respuesta;
           
            
                entidadPersona.nom = textNombre.Text;
                entidadPersona.Apellido = textApellidos.Text;
                entidadPersona.nacimiento = textNacimiento.Value.ToString();
                entidadPersona.dir = textDireccion.Text;
                entidadPersona.generoid = Cbox_genero.TabIndex.ToString();
                entidadPersona.estadoCivil = cbox_Ecivil.TabIndex.ToString();
                entidadPersona.movil = textMovil.Text;
                entidadPersona.tell = textTelefono.Text;
                entidadPersona.correo = textEmail.Text;

                respuesta = negPersona.validarDatosEstudiante(entidadPersona);

                if (respuesta == false)
                {
                    return;
                }

            if (!existe)
            {



                negPersona.NE_insertar(entidadPersona);
                MessageBox.Show("Registrado Satisfactorio");
            }
            else if (existe)
            {
                entidadPersona.idPersona = Convert.ToInt32(id);

                negPersona.NE_actualizar(entidadPersona);
                    MessageBox.Show("Editado Satisfactorio");
                
            }
            
            

            limpiar();
        }

        private void btn_AgendarContacto_Click(object sender, EventArgs e)
        {
            existe = false;
            panel_verRegistro.Visible= false;
            textNacimiento.Visible = true;
        }

        private void panel_verRegistro_Paint(object sender, PaintEventArgs e)
        {
            listarDatos();
        }

        private void dataGRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGRegistro.Rows[e.RowIndex].Cells["eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(dataGRegistro.Rows[e.RowIndex].Cells["idPersona"].Value.ToString());

                negPersona.NE_eliminar(eliminar);

                listarDatos();
            }
            else if (dataGRegistro.Rows[e.RowIndex].Cells["editar"].Selected)
            {
                panel_verRegistro.Visible = false;
                existe = true;
                id = dataGRegistro.Rows[e.RowIndex].Cells["idPersona"].Value.ToString();

                textNombre.Text = dataGRegistro.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textApellidos.Text = dataGRegistro.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
                textNacimiento.Text = dataGRegistro.Rows[e.RowIndex].Cells["nacimiento"].Value.ToString();
                textDireccion.Text = dataGRegistro.Rows[e.RowIndex].Cells["dirreccion"].Value.ToString();
                Cbox_genero.Text = dataGRegistro.Rows[e.RowIndex].Cells["genero"].Value.ToString();
                cbox_Ecivil.Text = dataGRegistro.Rows[e.RowIndex].Cells["estadoCivil"].Value.ToString();
                textMovil.Text = dataGRegistro.Rows[e.RowIndex].Cells["Movil"].Value.ToString();
                textTelefono.Text = dataGRegistro.Rows[e.RowIndex].Cells["tell"].Value.ToString();
                textEmail.Text = dataGRegistro.Rows[e.RowIndex].Cells["correo"].Value.ToString();

            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Form1 logins = new Form1();
            logins.Show();
            this.Close();
        }
    }
}