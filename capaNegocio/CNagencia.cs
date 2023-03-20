using capaEntidad;
using System.Data;
using capaDatos;

namespace capaNegocio
{
    public class CNagencia
    {

        CDagenda persona= new CDagenda();


        public bool validarDatosEstudiante(CEagencia PerEnt)
        {
            bool resultado = true;

            if (PerEnt.nom == string.Empty)  // ""
            {
                MessageBox.Show("nombre Obligatoria");
                resultado = false;
            }

            if (PerEnt.Apellido == string.Empty)
            {
                MessageBox.Show("El Apellido es obligatorio");
                resultado = false;
            }

            /*if (PerEnt.nacimiento == string.Empty)
            {
                MessageBox.Show("Nacimiento es obligarotio");
                resultado = false;
            }*/

            if (PerEnt.dir == string.Empty)
            {
                MessageBox.Show("Nacimiento es obligarotio");
                resultado = false;
            }

            if (PerEnt.generoid == string.Empty)
            {
                MessageBox.Show("Genero no debe ser nulo");
                resultado = false;
            }
            if (PerEnt.generoid == string.Empty)
            {
                MessageBox.Show("Estado Civil no debe ser nulo");
                resultado = false;
            }
            if (PerEnt.movil == string.Empty)
            {
                MessageBox.Show("celular es obligarotio");
                resultado = false;
            }
            if (PerEnt.tell == string.Empty)
            {
                MessageBox.Show("tell es obligarotio");
                resultado = false;
            }

            if (PerEnt.correo == string.Empty)
            {
                MessageBox.Show("correo es obligarotio");
                resultado = false;
            }

            return resultado;
        }



        //crud 
        public DataTable NElistado()
        {
            return persona.Datos_Listar();
        }


        public void NE_insertar(CEagencia per)
        {
            persona.Datos_insertarPersona(per);

        }


        public void NE_eliminar(int id)
        {
            persona.Datos_Eliminar(id);
        }

        public void NE_actualizar(CEagencia per)
        {
           persona.Datos_editarPersona(per);
        }

    }
}