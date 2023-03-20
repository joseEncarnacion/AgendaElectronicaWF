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


      


        public void listarEstudiante()
        {
            DataTable dt = perNegocio.NElistado();
            //dataGV.DataSource = dt;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarEstudiante();
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
    }
}
