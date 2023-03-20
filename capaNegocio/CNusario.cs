using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using capaDatos;

namespace capaNegocio
{
    public class CNusario
    {

        CDusuario usuario = new CDusuario();


        //validacion

        public bool validarUsuario(CEUsuario user)
        {
            bool respuesta = true;

            if(user.UsuarioE == string.Empty)
            {
                MessageBox.Show("Usuario Requerido");
                respuesta = false;
            }
            if (user.passE == string.Empty)
            {
                MessageBox.Show("Password Requerido");
                respuesta = false;
            }

            return respuesta;
        }


        public void NE_crearUusario(CEUsuario user)
        {
            usuario.Datos_insertarPersona(user);

        }

        public DataTable NEBuscarUsuario(CEUsuario US)
        {
            return usuario.Datos_Listar(US);
        }



    }
}
